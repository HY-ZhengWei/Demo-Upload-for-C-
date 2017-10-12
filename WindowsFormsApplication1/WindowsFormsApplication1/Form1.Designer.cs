namespace WindowsFormsApplication1
{
    partial class Form1
    {
        /// <summary>
        /// 必需的设计器变量。
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// 清理所有正在使用的资源。
        /// </summary>
        /// <param name="disposing">如果应释放托管资源，为 true；否则为 false。</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows 窗体设计器生成的代码

        /// <summary>
        /// 设计器支持所需的方法 - 不要修改
        /// 使用代码编辑器修改此方法的内容。
        /// </summary>
        private void InitializeComponent()
        {
            this.openFileDialog1 = new System.Windows.Forms.OpenFileDialog();
            this.selectUploadFile = new System.Windows.Forms.Button();
            this.upload = new System.Windows.Forms.Button();
            this.showFile = new System.Windows.Forms.TextBox();
            this.uploadProgress = new System.Windows.Forms.ProgressBar();
            this.uploadAddress = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.dataPacketSize = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // openFileDialog1
            // 
            this.openFileDialog1.FileOk += new System.ComponentModel.CancelEventHandler(this.openFileDialog1_FileOk);
            // 
            // selectUploadFile
            // 
            this.selectUploadFile.Location = new System.Drawing.Point(12, 28);
            this.selectUploadFile.Name = "selectUploadFile";
            this.selectUploadFile.Size = new System.Drawing.Size(76, 23);
            this.selectUploadFile.TabIndex = 0;
            this.selectUploadFile.Text = "选择文件";
            this.selectUploadFile.UseVisualStyleBackColor = true;
            this.selectUploadFile.Click += new System.EventHandler(this.selectUploadFile_Click);
            // 
            // upload
            // 
            this.upload.Enabled = false;
            this.upload.Location = new System.Drawing.Point(12, 142);
            this.upload.Name = "upload";
            this.upload.Size = new System.Drawing.Size(76, 23);
            this.upload.TabIndex = 1;
            this.upload.Text = "开始上传";
            this.upload.UseVisualStyleBackColor = true;
            this.upload.Click += new System.EventHandler(this.upload_Click);
            // 
            // showFile
            // 
            this.showFile.Location = new System.Drawing.Point(94, 28);
            this.showFile.Name = "showFile";
            this.showFile.ReadOnly = true;
            this.showFile.Size = new System.Drawing.Size(623, 21);
            this.showFile.TabIndex = 2;
            // 
            // uploadProgress
            // 
            this.uploadProgress.Location = new System.Drawing.Point(94, 142);
            this.uploadProgress.Name = "uploadProgress";
            this.uploadProgress.Size = new System.Drawing.Size(623, 23);
            this.uploadProgress.TabIndex = 3;
            // 
            // uploadAddress
            // 
            this.uploadAddress.Location = new System.Drawing.Point(94, 69);
            this.uploadAddress.Name = "uploadAddress";
            this.uploadAddress.Size = new System.Drawing.Size(623, 21);
            this.uploadAddress.TabIndex = 4;
            this.uploadAddress.Text = "http://127.0.0.1:80/xx/hoto";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(24, 72);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(53, 12);
            this.label1.TabIndex = 5;
            this.label1.Text = "上传地址";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(24, 108);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(53, 12);
            this.label2.TabIndex = 6;
            this.label2.Text = "分包大小";
            // 
            // dataPacketSize
            // 
            this.dataPacketSize.Location = new System.Drawing.Point(94, 105);
            this.dataPacketSize.Name = "dataPacketSize";
            this.dataPacketSize.Size = new System.Drawing.Size(623, 21);
            this.dataPacketSize.TabIndex = 7;
            this.dataPacketSize.Text = "100";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(695, 110);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(17, 12);
            this.label3.TabIndex = 8;
            this.label3.Text = "KB";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(735, 195);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.dataPacketSize);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.uploadAddress);
            this.Controls.Add(this.uploadProgress);
            this.Controls.Add(this.showFile);
            this.Controls.Add(this.upload);
            this.Controls.Add(this.selectUploadFile);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "断点续传的上传演示";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.OpenFileDialog openFileDialog1;
        private System.Windows.Forms.Button selectUploadFile;
        private System.Windows.Forms.Button upload;
        private System.Windows.Forms.TextBox showFile;
        private System.Windows.Forms.ProgressBar uploadProgress;
        private System.Windows.Forms.TextBox uploadAddress;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox dataPacketSize;
        private System.Windows.Forms.Label label3;
    }
}

