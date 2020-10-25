namespace barCodeScanner
{
    partial class cw_Form
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(cw_Form));
            this.cw_picBox = new System.Windows.Forms.PictureBox();
            this.cw_txtBox = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.cw_picBox)).BeginInit();
            this.SuspendLayout();
            // 
            // cw_picBox
            // 
            this.cw_picBox.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.cw_picBox.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.cw_picBox.Location = new System.Drawing.Point(-3, 0);
            this.cw_picBox.Name = "cw_picBox";
            this.cw_picBox.Size = new System.Drawing.Size(335, 260);
            this.cw_picBox.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.cw_picBox.TabIndex = 0;
            this.cw_picBox.TabStop = false;
            this.cw_picBox.Click += new System.EventHandler(this.cw_picBox_Click);
            // 
            // cw_txtBox
            // 
            this.cw_txtBox.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.cw_txtBox.CausesValidation = false;
            this.cw_txtBox.Font = new System.Drawing.Font("Consolas", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cw_txtBox.Location = new System.Drawing.Point(-3, 266);
            this.cw_txtBox.Multiline = true;
            this.cw_txtBox.Name = "cw_txtBox";
            this.cw_txtBox.Size = new System.Drawing.Size(345, 172);
            this.cw_txtBox.TabIndex = 1;
            this.cw_txtBox.Text = "> 点击上方区域打开二维码图片文件...";
            // 
            // cw_Form
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(342, 443);
            this.Controls.Add(this.cw_txtBox);
            this.Controls.Add(this.cw_picBox);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "cw_Form";
            this.ShowInTaskbar = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "CodeScanner V0.1";
            ((System.ComponentModel.ISupportInitialize)(this.cw_picBox)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox cw_picBox;
        private System.Windows.Forms.TextBox cw_txtBox;
    }
}

