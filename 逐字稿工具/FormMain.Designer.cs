namespace 逐字稿工具
{
    partial class FormMain
    {
        /// <summary>
        /// 設計工具所需的變數。
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// 清除任何使用中的資源。
        /// </summary>
        /// <param name="disposing">如果應該處置受控資源則為 true，否則為 false。</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form 設計工具產生的程式碼

        /// <summary>
        /// 此為設計工具支援所需的方法 - 請勿使用程式碼編輯器修改
        /// 這個方法的內容。
        /// </summary>
        private void InitializeComponent()
        {
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.btn_RollBack = new System.Windows.Forms.Button();
            this.btn_Stop = new System.Windows.Forms.Button();
            this.btn_Play = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.trackBar_Volume = new System.Windows.Forms.TrackBar();
            this.btn_ChooseMp3File = new System.Windows.Forms.Button();
            this.lb_Mp3File = new System.Windows.Forms.Label();
            this.tb_Mp3FilePath = new System.Windows.Forms.TextBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.btn_RemoveRow = new System.Windows.Forms.Button();
            this.btn_InsertNewRow = new System.Windows.Forms.Button();
            this.btn_InsertTimestamp = new System.Windows.Forms.Button();
            this.tb_desc = new System.Windows.Forms.TextBox();
            this.btn_UpdateRow = new System.Windows.Forms.Button();
            this.btn_ChooseTxtFile = new System.Windows.Forms.Button();
            this.tb_TXTFilePath = new System.Windows.Forms.TextBox();
            this.lb_TXTFile = new System.Windows.Forms.Label();
            this.dgv_txts = new System.Windows.Forms.DataGridView();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.trackBar_Volume)).BeginInit();
            this.groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_txts)).BeginInit();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.btn_RollBack);
            this.groupBox1.Controls.Add(this.btn_Stop);
            this.groupBox1.Controls.Add(this.btn_Play);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.trackBar_Volume);
            this.groupBox1.Controls.Add(this.btn_ChooseMp3File);
            this.groupBox1.Controls.Add(this.lb_Mp3File);
            this.groupBox1.Controls.Add(this.tb_Mp3FilePath);
            this.groupBox1.Location = new System.Drawing.Point(13, 13);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(322, 180);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "聲音檔控制";
            // 
            // btn_RollBack
            // 
            this.btn_RollBack.Location = new System.Drawing.Point(222, 75);
            this.btn_RollBack.Name = "btn_RollBack";
            this.btn_RollBack.Size = new System.Drawing.Size(90, 40);
            this.btn_RollBack.TabIndex = 7;
            this.btn_RollBack.Text = "倒帶5秒(F3)";
            this.btn_RollBack.UseVisualStyleBackColor = true;
            this.btn_RollBack.Click += new System.EventHandler(this.OnButtonRollBackClick);
            // 
            // btn_Stop
            // 
            this.btn_Stop.Location = new System.Drawing.Point(115, 75);
            this.btn_Stop.Name = "btn_Stop";
            this.btn_Stop.Size = new System.Drawing.Size(90, 40);
            this.btn_Stop.TabIndex = 6;
            this.btn_Stop.Text = "停止(F2)";
            this.btn_Stop.UseVisualStyleBackColor = true;
            this.btn_Stop.Click += new System.EventHandler(this.OnButtonStopClick);
            // 
            // btn_Play
            // 
            this.btn_Play.Location = new System.Drawing.Point(9, 75);
            this.btn_Play.Name = "btn_Play";
            this.btn_Play.Size = new System.Drawing.Size(90, 40);
            this.btn_Play.TabIndex = 5;
            this.btn_Play.Text = "播放(F1)";
            this.btn_Play.UseVisualStyleBackColor = true;
            this.btn_Play.Click += new System.EventHandler(this.OnButtonPlayClick);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("新細明體", 12F);
            this.label1.Location = new System.Drawing.Point(6, 132);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(56, 16);
            this.label1.TabIndex = 4;
            this.label1.Text = "音量：";
            // 
            // trackBar_Volume
            // 
            this.trackBar_Volume.Location = new System.Drawing.Point(84, 121);
            this.trackBar_Volume.Maximum = 100;
            this.trackBar_Volume.Name = "trackBar_Volume";
            this.trackBar_Volume.Size = new System.Drawing.Size(228, 45);
            this.trackBar_Volume.TabIndex = 3;
            this.trackBar_Volume.TickStyle = System.Windows.Forms.TickStyle.Both;
            this.trackBar_Volume.ValueChanged += new System.EventHandler(this.TrackBar_Volume_ValueChanged);
            // 
            // btn_ChooseMp3File
            // 
            this.btn_ChooseMp3File.Location = new System.Drawing.Point(211, 21);
            this.btn_ChooseMp3File.Name = "btn_ChooseMp3File";
            this.btn_ChooseMp3File.Size = new System.Drawing.Size(101, 27);
            this.btn_ChooseMp3File.TabIndex = 2;
            this.btn_ChooseMp3File.Text = "選擇";
            this.btn_ChooseMp3File.UseVisualStyleBackColor = true;
            this.btn_ChooseMp3File.Click += new System.EventHandler(this.Btn_chooseMp3File_Click);
            // 
            // lb_Mp3File
            // 
            this.lb_Mp3File.AutoSize = true;
            this.lb_Mp3File.Font = new System.Drawing.Font("新細明體", 12F);
            this.lb_Mp3File.Location = new System.Drawing.Point(6, 27);
            this.lb_Mp3File.Name = "lb_Mp3File";
            this.lb_Mp3File.Size = new System.Drawing.Size(72, 16);
            this.lb_Mp3File.TabIndex = 1;
            this.lb_Mp3File.Text = "錄音檔：";
            // 
            // tb_Mp3FilePath
            // 
            this.tb_Mp3FilePath.Enabled = false;
            this.tb_Mp3FilePath.Font = new System.Drawing.Font("新細明體", 12F);
            this.tb_Mp3FilePath.Location = new System.Drawing.Point(84, 21);
            this.tb_Mp3FilePath.Name = "tb_Mp3FilePath";
            this.tb_Mp3FilePath.Size = new System.Drawing.Size(121, 27);
            this.tb_Mp3FilePath.TabIndex = 0;
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.btn_RemoveRow);
            this.groupBox2.Controls.Add(this.btn_InsertNewRow);
            this.groupBox2.Controls.Add(this.btn_InsertTimestamp);
            this.groupBox2.Controls.Add(this.tb_desc);
            this.groupBox2.Controls.Add(this.btn_UpdateRow);
            this.groupBox2.Controls.Add(this.btn_ChooseTxtFile);
            this.groupBox2.Controls.Add(this.tb_TXTFilePath);
            this.groupBox2.Controls.Add(this.lb_TXTFile);
            this.groupBox2.Location = new System.Drawing.Point(341, 13);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(322, 180);
            this.groupBox2.TabIndex = 1;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "逐字稿輔助";
            // 
            // btn_RemoveRow
            // 
            this.btn_RemoveRow.Location = new System.Drawing.Point(222, 54);
            this.btn_RemoveRow.Name = "btn_RemoveRow";
            this.btn_RemoveRow.Size = new System.Drawing.Size(90, 40);
            this.btn_RemoveRow.TabIndex = 17;
            this.btn_RemoveRow.Text = "移除選擇(F6)";
            this.btn_RemoveRow.UseVisualStyleBackColor = true;
            this.btn_RemoveRow.Click += new System.EventHandler(this.Btn_RemoveRow_Click);
            // 
            // btn_InsertNewRow
            // 
            this.btn_InsertNewRow.Location = new System.Drawing.Point(115, 54);
            this.btn_InsertNewRow.Name = "btn_InsertNewRow";
            this.btn_InsertNewRow.Size = new System.Drawing.Size(90, 40);
            this.btn_InsertNewRow.TabIndex = 16;
            this.btn_InsertNewRow.Text = "插入新行(F5)";
            this.btn_InsertNewRow.UseVisualStyleBackColor = true;
            this.btn_InsertNewRow.Click += new System.EventHandler(this.Btn_InsertNewRow_Click);
            // 
            // btn_InsertTimestamp
            // 
            this.btn_InsertTimestamp.Location = new System.Drawing.Point(9, 54);
            this.btn_InsertTimestamp.Name = "btn_InsertTimestamp";
            this.btn_InsertTimestamp.Size = new System.Drawing.Size(90, 40);
            this.btn_InsertTimestamp.TabIndex = 15;
            this.btn_InsertTimestamp.Text = "標記時間(F4)";
            this.btn_InsertTimestamp.UseVisualStyleBackColor = true;
            this.btn_InsertTimestamp.Click += new System.EventHandler(this.Btn_InsertTimestamp_Click);
            // 
            // tb_desc
            // 
            this.tb_desc.Font = new System.Drawing.Font("新細明體", 12F);
            this.tb_desc.Location = new System.Drawing.Point(9, 146);
            this.tb_desc.Name = "tb_desc";
            this.tb_desc.Size = new System.Drawing.Size(222, 27);
            this.tb_desc.TabIndex = 14;
            // 
            // btn_UpdateRow
            // 
            this.btn_UpdateRow.Location = new System.Drawing.Point(237, 146);
            this.btn_UpdateRow.Name = "btn_UpdateRow";
            this.btn_UpdateRow.Size = new System.Drawing.Size(75, 27);
            this.btn_UpdateRow.TabIndex = 13;
            this.btn_UpdateRow.Text = "更新(F7)";
            this.btn_UpdateRow.UseVisualStyleBackColor = true;
            this.btn_UpdateRow.Click += new System.EventHandler(this.Btn_UpdateRow_Click);
            // 
            // btn_ChooseTxtFile
            // 
            this.btn_ChooseTxtFile.Location = new System.Drawing.Point(211, 21);
            this.btn_ChooseTxtFile.Name = "btn_ChooseTxtFile";
            this.btn_ChooseTxtFile.Size = new System.Drawing.Size(101, 27);
            this.btn_ChooseTxtFile.TabIndex = 10;
            this.btn_ChooseTxtFile.Text = "選擇";
            this.btn_ChooseTxtFile.UseVisualStyleBackColor = true;
            this.btn_ChooseTxtFile.Click += new System.EventHandler(this.Btn_chooseTxtFile_Click);
            // 
            // tb_TXTFilePath
            // 
            this.tb_TXTFilePath.Enabled = false;
            this.tb_TXTFilePath.Font = new System.Drawing.Font("新細明體", 12F);
            this.tb_TXTFilePath.Location = new System.Drawing.Point(84, 21);
            this.tb_TXTFilePath.Name = "tb_TXTFilePath";
            this.tb_TXTFilePath.Size = new System.Drawing.Size(121, 27);
            this.tb_TXTFilePath.TabIndex = 8;
            // 
            // lb_TXTFile
            // 
            this.lb_TXTFile.AutoSize = true;
            this.lb_TXTFile.Font = new System.Drawing.Font("新細明體", 12F);
            this.lb_TXTFile.Location = new System.Drawing.Point(6, 27);
            this.lb_TXTFile.Name = "lb_TXTFile";
            this.lb_TXTFile.Size = new System.Drawing.Size(72, 16);
            this.lb_TXTFile.TabIndex = 9;
            this.lb_TXTFile.Text = "文字檔：";
            // 
            // dgv_txts
            // 
            this.dgv_txts.AllowUserToAddRows = false;
            this.dgv_txts.AllowUserToDeleteRows = false;
            this.dgv_txts.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dgv_txts.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.DisplayedCellsExceptHeader;
            this.dgv_txts.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgv_txts.Location = new System.Drawing.Point(13, 199);
            this.dgv_txts.MultiSelect = false;
            this.dgv_txts.Name = "dgv_txts";
            this.dgv_txts.ReadOnly = true;
            this.dgv_txts.RowHeadersVisible = false;
            this.dgv_txts.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.AutoSizeToAllHeaders;
            this.dgv_txts.RowTemplate.Height = 24;
            this.dgv_txts.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgv_txts.Size = new System.Drawing.Size(650, 417);
            this.dgv_txts.TabIndex = 2;
            this.dgv_txts.SelectionChanged += new System.EventHandler(this.Dgv_txts_SelectionChanged);
            // 
            // FormMain
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            this.ClientSize = new System.Drawing.Size(681, 628);
            this.Controls.Add(this.dgv_txts);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Name = "FormMain";
            this.Text = "逐字稿工具";
            this.Load += new System.EventHandler(this.FormMain_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.trackBar_Volume)).EndInit();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_txts)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label lb_Mp3File;
        private System.Windows.Forms.TextBox tb_Mp3FilePath;
        private System.Windows.Forms.Button btn_ChooseMp3File;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TrackBar trackBar_Volume;
        private System.Windows.Forms.Button btn_Play;
        private System.Windows.Forms.Button btn_Stop;
        private System.Windows.Forms.Button btn_RollBack;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Button btn_ChooseTxtFile;
        private System.Windows.Forms.TextBox tb_TXTFilePath;
        private System.Windows.Forms.Label lb_TXTFile;
        private System.Windows.Forms.Button btn_UpdateRow;
        private System.Windows.Forms.TextBox tb_desc;
        private System.Windows.Forms.Button btn_InsertTimestamp;
        private System.Windows.Forms.Button btn_InsertNewRow;
        private System.Windows.Forms.DataGridView dgv_txts;
        private System.Windows.Forms.Button btn_RemoveRow;
    }
}

