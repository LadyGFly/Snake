namespace Snake
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
        /// 设计器支持所需的方法 - 不要
        /// 使用代码编辑器修改此方法的内容。
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.Go = new System.Windows.Forms.Button();
            this.head1 = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.head1)).BeginInit();
            this.SuspendLayout();
            // 
            // Go
            // 
            this.Go.Font = new System.Drawing.Font("宋体", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.Go.Image = ((System.Drawing.Image)(resources.GetObject("Go.Image")));
            this.Go.Location = new System.Drawing.Point(356, 161);
            this.Go.Name = "Go";
            this.Go.Size = new System.Drawing.Size(200, 206);
            this.Go.TabIndex = 1;
            this.Go.Text = "\r\n\r\n\r\n\r\n\r\n开始";
            this.Go.UseVisualStyleBackColor = true;
            this.Go.Click += new System.EventHandler(this.Go_Click);
            // 
            // head1
            // 
            this.head1.Image = ((System.Drawing.Image)(resources.GetObject("head1.Image")));
            this.head1.Location = new System.Drawing.Point(622, 237);
            this.head1.Name = "head1";
            this.head1.Size = new System.Drawing.Size(49, 52);
            this.head1.TabIndex = 2;
            this.head1.TabStop = false;
            this.head1.Click += new System.EventHandler(this.head1_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(906, 555);
            this.Controls.Add(this.head1);
            this.Controls.Add(this.Go);
            this.KeyPreview = true;
            this.Name = "Form1";
            this.Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)(this.head1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button Go;
        private System.Windows.Forms.PictureBox head1;

    }
}

