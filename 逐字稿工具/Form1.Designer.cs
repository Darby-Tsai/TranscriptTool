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
            this.tb_mp3FilePath = new System.Windows.Forms.TextBox();
            this.lb_mp3File = new System.Windows.Forms.Label();
            this.btn_chooseMp3File = new System.Windows.Forms.Button();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.btn_chooseMp3File);
            this.groupBox1.Controls.Add(this.lb_mp3File);
            this.groupBox1.Controls.Add(this.tb_mp3FilePath);
            this.groupBox1.Location = new System.Drawing.Point(13, 13);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(322, 127);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "聲音檔控制";
            // 
            // tb_mp3FilePath
            // 
            this.tb_mp3FilePath.Location = new System.Drawing.Point(84, 21);
            this.tb_mp3FilePath.Name = "tb_mp3FilePath";
            this.tb_mp3FilePath.Size = new System.Drawing.Size(121, 22);
            this.tb_mp3FilePath.TabIndex = 0;
            // 
            // lb_mp3File
            // 
            this.lb_mp3File.AutoSize = true;
            this.lb_mp3File.Font = new System.Drawing.Font("新細明體", 12F);
            this.lb_mp3File.Location = new System.Drawing.Point(6, 24);
            this.lb_mp3File.Name = "lb_mp3File";
            this.lb_mp3File.Size = new System.Drawing.Size(72, 16);
            this.lb_mp3File.TabIndex = 1;
            this.lb_mp3File.Text = "錄音檔：";
            // 
            // btn_chooseMp3File
            // 
            this.btn_chooseMp3File.Location = new System.Drawing.Point(211, 21);
            this.btn_chooseMp3File.Name = "btn_chooseMp3File";
            this.btn_chooseMp3File.Size = new System.Drawing.Size(101, 22);
            this.btn_chooseMp3File.TabIndex = 2;
            this.btn_chooseMp3File.Text = "選擇";
            this.btn_chooseMp3File.UseVisualStyleBackColor = true;
            // 
            // FormMain
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            this.ClientSize = new System.Drawing.Size(343, 498);
            this.Controls.Add(this.groupBox1);
            this.MaximizeBox = false;
            this.Name = "FormMain";
            this.Text = "逐字稿工具";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label lb_mp3File;
        private System.Windows.Forms.TextBox tb_mp3FilePath;
        private System.Windows.Forms.Button btn_chooseMp3File;
    }
}

