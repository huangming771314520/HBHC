﻿namespace FtpFileUpload
{
    partial class FileUpload
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FileUpload));
            this.label1 = new System.Windows.Forms.Label();
            this.lst_filelist = new System.Windows.Forms.ListBox();
            this.prs_bar = new System.Windows.Forms.ProgressBar();
            this.上传进度 = new System.Windows.Forms.Label();
            this.BtnChooseFile = new System.Windows.Forms.Button();
            this.Btn_UploadFile = new System.Windows.Forms.Button();
            this.lblFigureNumber = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("微软雅黑", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label1.Location = new System.Drawing.Point(112, 53);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(68, 17);
            this.label1.TabIndex = 2;
            this.label1.Text = "图纸路径：";
            // 
            // lst_filelist
            // 
            this.lst_filelist.FormattingEnabled = true;
            this.lst_filelist.ItemHeight = 12;
            this.lst_filelist.Location = new System.Drawing.Point(183, 53);
            this.lst_filelist.Name = "lst_filelist";
            this.lst_filelist.Size = new System.Drawing.Size(384, 136);
            this.lst_filelist.TabIndex = 3;
            // 
            // prs_bar
            // 
            this.prs_bar.Location = new System.Drawing.Point(183, 208);
            this.prs_bar.Name = "prs_bar";
            this.prs_bar.Size = new System.Drawing.Size(384, 23);
            this.prs_bar.Step = 1;
            this.prs_bar.TabIndex = 5;
            // 
            // 上传进度
            // 
            this.上传进度.AutoSize = true;
            this.上传进度.Font = new System.Drawing.Font("微软雅黑", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.上传进度.Location = new System.Drawing.Point(112, 208);
            this.上传进度.Name = "上传进度";
            this.上传进度.Size = new System.Drawing.Size(68, 17);
            this.上传进度.TabIndex = 2;
            this.上传进度.Text = "上传进度：";
            // 
            // BtnChooseFile
            // 
            this.BtnChooseFile.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(121)))), ((int)(((byte)(184)))), ((int)(((byte)(255)))));
            this.BtnChooseFile.FlatAppearance.BorderSize = 0;
            this.BtnChooseFile.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(85)))), ((int)(((byte)(166)))), ((int)(((byte)(255)))));
            this.BtnChooseFile.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(121)))), ((int)(((byte)(184)))), ((int)(((byte)(255)))));
            this.BtnChooseFile.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BtnChooseFile.Font = new System.Drawing.Font("微软雅黑", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.BtnChooseFile.ForeColor = System.Drawing.Color.White;
            this.BtnChooseFile.Location = new System.Drawing.Point(592, 53);
            this.BtnChooseFile.Margin = new System.Windows.Forms.Padding(0);
            this.BtnChooseFile.Name = "BtnChooseFile";
            this.BtnChooseFile.Size = new System.Drawing.Size(84, 30);
            this.BtnChooseFile.TabIndex = 12;
            this.BtnChooseFile.Text = "选择图纸";
            this.BtnChooseFile.UseVisualStyleBackColor = false;
            this.BtnChooseFile.Click += new System.EventHandler(this.BtnChooseFile_Click);
            // 
            // Btn_UploadFile
            // 
            this.Btn_UploadFile.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(121)))), ((int)(((byte)(184)))), ((int)(((byte)(255)))));
            this.Btn_UploadFile.FlatAppearance.BorderSize = 0;
            this.Btn_UploadFile.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(85)))), ((int)(((byte)(166)))), ((int)(((byte)(255)))));
            this.Btn_UploadFile.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(121)))), ((int)(((byte)(184)))), ((int)(((byte)(255)))));
            this.Btn_UploadFile.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Btn_UploadFile.Font = new System.Drawing.Font("微软雅黑", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.Btn_UploadFile.ForeColor = System.Drawing.Color.White;
            this.Btn_UploadFile.Location = new System.Drawing.Point(183, 250);
            this.Btn_UploadFile.Margin = new System.Windows.Forms.Padding(0);
            this.Btn_UploadFile.Name = "Btn_UploadFile";
            this.Btn_UploadFile.Size = new System.Drawing.Size(84, 30);
            this.Btn_UploadFile.TabIndex = 12;
            this.Btn_UploadFile.Text = "上传";
            this.Btn_UploadFile.UseVisualStyleBackColor = false;
            this.Btn_UploadFile.Click += new System.EventHandler(this.Btn_UploadFile_Click);
            // 
            // lblFigureNumber
            // 
            this.lblFigureNumber.AutoSize = true;
            this.lblFigureNumber.Font = new System.Drawing.Font("微软雅黑", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.lblFigureNumber.Location = new System.Drawing.Point(135, 18);
            this.lblFigureNumber.Name = "lblFigureNumber";
            this.lblFigureNumber.Size = new System.Drawing.Size(44, 17);
            this.lblFigureNumber.TabIndex = 13;
            this.lblFigureNumber.Text = "图号：";
            // 
            // FileUpload
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(787, 298);
            this.Controls.Add(this.lblFigureNumber);
            this.Controls.Add(this.Btn_UploadFile);
            this.Controls.Add(this.BtnChooseFile);
            this.Controls.Add(this.prs_bar);
            this.Controls.Add(this.lst_filelist);
            this.Controls.Add(this.上传进度);
            this.Controls.Add(this.label1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "FileUpload";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "工艺图纸上传";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ListBox lst_filelist;
        private System.Windows.Forms.ProgressBar prs_bar;
        private System.Windows.Forms.Label 上传进度;
        private System.Windows.Forms.Button BtnChooseFile;
        private System.Windows.Forms.Button Btn_UploadFile;
        private System.Windows.Forms.Label lblFigureNumber;
    }
}
