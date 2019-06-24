using NAudio.Wave;
using NHotkey;
using NHotkey.WindowsForms;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace 逐字稿工具
{
    public partial class FormMain : Form
    {
        private List<Description> descriptions = new List<Description>();
        private WaveOutEvent outputDevice;
        private AudioFileReader audioFile;
        int lastViewIdx = 0;


        public enum Behavior
        {
            播放,
            停止,
            倒退,
            標記時間,
            插入新行,
            移除,
            更新
        }
        public class Description
        {
            public string 時間 { get; set; }
            public string 內容 { get; set; }
            public override string ToString()
            {
                return $"{時間}=>{內容}";
            }
        }
        public FormMain()
        {
            InitializeComponent();
            this.FormClosing += (s, a) => { outputDevice?.Stop(); };
        }
        private void FormMain_Load(object sender, EventArgs e)
        {
            RegisterHotkey();
        }
        #region Hotkey

        private void RegisterHotkey()
        {
            HotkeyManager.Current.AddOrReplace(Behavior.播放.ToString(), Keys.Control | Keys.F1, ActionControl);
            HotkeyManager.Current.AddOrReplace(Behavior.停止.ToString(), Keys.Control | Keys.F2, ActionControl);
            HotkeyManager.Current.AddOrReplace(Behavior.倒退.ToString(), Keys.Control | Keys.F3, ActionControl);
            HotkeyManager.Current.AddOrReplace(Behavior.標記時間.ToString(), Keys.Control | Keys.F4, ActionControl);
            HotkeyManager.Current.AddOrReplace(Behavior.插入新行.ToString(), Keys.Control | Keys.F5, ActionControl);
            HotkeyManager.Current.AddOrReplace(Behavior.移除.ToString(), Keys.Control | Keys.F6, ActionControl);
            HotkeyManager.Current.AddOrReplace(Behavior.更新.ToString(), Keys.Control | Keys.F7, ActionControl);
        }
        private void ActionControl(object sender, HotkeyEventArgs e)
        {
            try
            {
                switch (e.Name)
                {
                    case "播放":
                        btn_Play.PerformClick();
                        break;
                    case "停止":
                        btn_Stop.PerformClick();
                        break;
                    case "倒退":
                        btn_RollBack.PerformClick();
                        break;
                    case "標記時間":
                        btn_InsertTimestamp.PerformClick();
                        break;
                    case "插入新行":
                        btn_InsertNewRow.PerformClick();
                        break;
                    case "移除":
                        btn_RemoveRow.PerformClick();
                        break;
                    case "更新":
                        btn_UpdateRow.PerformClick();
                        break;
                }
            }
            catch (Exception ex)
            {

            }
            e.Handled = true;
        }
        #endregion
        #region NAudio
        private void OnButtonPlayClick(object sender, EventArgs args)
        {
            try
            {
                if (!CheckAudioLoaded())
                {
                    return;
                }
                if (outputDevice == null)
                {
                    if (!string.IsNullOrEmpty(tb_Mp3FilePath.Text))
                    {
                        audioFile = new AudioFileReader(tb_Mp3FilePath.Text);
                        if (outputDevice == null)
                        {
                            outputDevice = new WaveOutEvent();
                            outputDevice.PlaybackStopped += OnPlaybackStopped;
                        }
                        outputDevice.Init(audioFile);
                    }
                }
                outputDevice?.Play();
            }
            catch (Exception ex)
            {

            }
        }
        private void OnButtonStopClick(object sender, EventArgs args)
        {
            if (!CheckAudioLoaded())
            {
                return;
            }
            outputDevice?.Stop();
        }
        private void OnButtonRollBackClick(object sender, EventArgs args)
        {
            if (!CheckAudioLoaded())
            {
                return;
            }
            long position = (long)outputDevice?.GetPosition();
            var rollbackSecondsOffset = outputDevice.OutputWaveFormat.AverageBytesPerSecond * 5;
            audioFile.Position = position - rollbackSecondsOffset > 0 ? position - rollbackSecondsOffset : 0;
        }
        private void OnPlaybackStopped(object sender, StoppedEventArgs args)
        {
            outputDevice.Dispose();
            outputDevice = null;
            audioFile.Dispose();
            audioFile = null;
        }
        #endregion
        #region UI Events

        #region 音訊檔區塊

        private void Btn_chooseMp3File_Click(object sender, EventArgs e)
        {
            try
            {
                OpenFileDialog dialog = new OpenFileDialog();
                dialog.Multiselect = false;
                dialog.Title = "請選擇檔案";
                dialog.Filter = "MP3檔案(*.mp3)|*.mp3";
                if (dialog.ShowDialog() == System.Windows.Forms.DialogResult.OK)
                {
                    tb_Mp3FilePath.Text = dialog.FileName;
                    audioFile = new AudioFileReader(dialog.FileName);
                    if (outputDevice == null)
                    {
                        outputDevice = new WaveOutEvent();
                        outputDevice.PlaybackStopped += OnPlaybackStopped;
                    }
                    outputDevice.Init(audioFile);
                }
                else
                {

                }
            }
            catch (Exception ex)
            {

            }
        }
        private void TrackBar_Volume_ValueChanged(object sender, EventArgs e)
        {
            if (trackBar_Volume.Value != 0 && !CheckAudioLoaded())
            {
                trackBar_Volume.Value = 0;
                return;
            }
            outputDevice.Volume = trackBar_Volume.Value / 100f;
        }
        #endregion
        #region 逐字稿編輯區塊
        private void Btn_chooseTxtFile_Click(object sender, EventArgs e)
        {
            try
            {
                OpenFileDialog dialog = new OpenFileDialog();
                dialog.Multiselect = false;
                dialog.Title = "請選擇檔案";
                dialog.Filter = "txt檔案(*.txt)|*.txt";
                if (dialog.ShowDialog() == System.Windows.Forms.DialogResult.OK)
                {
                    tb_TXTFilePath.Text = dialog.FileName;

                    LoadFromTxt();
                }
                else
                {

                }
            }
            catch (Exception ex)
            {

            }
        }

        private void Btn_InsertTimestamp_Click(object sender, EventArgs e)
        {
            try
            {
                var idx = dgv_txts.SelectedRows[0].Index;
                var item = descriptions[idx];
                lastViewIdx = idx + 1 < descriptions.Count ? ++idx : idx;// 切換下一句
                TimeSpan t = TimeSpan.FromSeconds(audioFile.Position / outputDevice.OutputWaveFormat.AverageBytesPerSecond);
                item.時間 = $"{t.Hours}時{t.Minutes}分{t.Seconds}秒";

                SaveToTxt();
                RefreshUI();
            }
            catch (Exception ex)
            {

            }
        }

        private void Btn_InsertNewRow_Click(object sender, EventArgs e)
        {
            try
            {
                var idx = dgv_txts.SelectedRows[0].Index;
                lastViewIdx = idx;
                TimeSpan t = TimeSpan.FromSeconds(audioFile.Position / outputDevice.OutputWaveFormat.AverageBytesPerSecond);

                Description desc = new Description()
                {
                    時間 = $"{t.Hours}時{t.Minutes}分{t.Seconds}秒",
                    內容 = tb_desc.Text.Trim()
                };
                descriptions.Insert(idx, desc);
                tb_desc.Text = string.Empty;

                SaveToTxt();
                RefreshUI();
            }
            catch (Exception ex)
            {

            }
        }
        private void Btn_RemoveRow_Click(object sender, EventArgs e)
        {
            try
            {
                var idx = dgv_txts.SelectedRows[0].Index;
                lastViewIdx = idx;
                descriptions.RemoveAt(idx);

                SaveToTxt();
                RefreshUI();
            }
            catch (Exception ex)
            {

            }
        }
        private void Dgv_txts_SelectionChanged(object sender, EventArgs e)
        {
            try
            {
                var idx = dgv_txts.SelectedRows[0].Index;
                tb_desc.Text = descriptions[idx].ToString();
            }
            catch (Exception ex)
            {

            }
        }

        private void Btn_UpdateRow_Click(object sender, EventArgs e)
        {
            try
            {
                var idx = dgv_txts.SelectedRows[0].Index;
                var item = descriptions[idx];
                lastViewIdx = idx + 1 < descriptions.Count ? ++idx : idx;// 切換下一句
                var split = tb_desc.Text.Split(new string[] { "=>" }, StringSplitOptions.None);
                if (split.Count() == 2)
                {
                    item.內容 = split[1];
                }
                else
                {
                    item.內容 = tb_desc.Text;
                }

                SaveToTxt();
                RefreshUI();
            }
            catch (Exception ex)
            {

            }
        }
        #endregion
        #endregion
        #region Common

        /// <summary>
        /// 檢查是否讀檔案
        /// </summary>
        /// <returns></returns>
        private bool CheckAudioLoaded()
        {
            if (audioFile == null)
            {
                MessageBox.Show("請選擇音訊檔");
                btn_ChooseMp3File.PerformClick();
                return false;
            }
            return true;
        }
        private void RefreshUI()
        {
            var bindingList = new BindingList<Description>(descriptions);
            var source = new BindingSource(bindingList, null);
            dgv_txts.DataSource = source;

            if (lastViewIdx > 0)
            {
                dgv_txts.Rows[lastViewIdx].Selected = true;
                dgv_txts.FirstDisplayedScrollingRowIndex = lastViewIdx;
            }
        }
        private void SaveToTxt()
        {
            try
            {
                var descs = descriptions.Select(x => x.ToString()).ToArray();
                System.IO.File.WriteAllLines(tb_TXTFilePath.Text, descs);
            }
            catch (Exception ex)
            {

            }
        }
        private void LoadFromTxt()
        {

            try
            {
                List<string> lines = System.IO.File.ReadAllLines(tb_TXTFilePath.Text).ToList();
                descriptions = new List<Description>();
                foreach (var s in lines)
                {
                    var split = s.Split(new string[] { "=>" }, StringSplitOptions.None);
                    if (split.Count() == 2)
                    {
                        descriptions.Add(new Description() { 時間 = split[0], 內容 = split[1] });
                    }
                    else
                    {
                        descriptions.Add(new Description() { 時間 = "", 內容 = s });
                    }
                }
                RefreshUI();
            }
            catch (Exception ex)
            {

            }
        }
        #endregion
        #region 寫入Log
        /// 
        ///message:紀錄文字
        ///
        public static void LogWrite(string message, bool showMessageBox = false)
        {
            string FilePath = System.Environment.CurrentDirectory;
            //從config檔抓取LogDir參數的值 
            string fileName = FilePath + string.Format("\\Logs\\{0:yyyy-MM-dd}.txt", DateTime.Now);
            //設定檔案名稱,格式為西元年-月-日.txt  
            FileInfo fileInfo = new FileInfo(fileName);
            if (fileInfo.Directory.Exists == false)
            {
                fileInfo.Directory.Create();
                //若無此檔案則新增
            }
            string writeString = string.Format("{0:yyyy/MM/dd HH:mm:ss.fff} {1}", DateTime.Now, message) + Environment.NewLine;
            File.AppendAllText(fileName, writeString, Encoding.Unicode);

        }
        #endregion
    }
}
