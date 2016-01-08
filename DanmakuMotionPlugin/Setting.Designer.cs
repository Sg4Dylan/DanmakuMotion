namespace DanmakuMotionPlugin
{
    partial class Setting
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
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.導入預設文件IToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.導出預設文件OToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.重置設定檔RToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.關於AToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.幫助HToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.關於AToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.導入預設文件IToolStripMenuItem,
            this.導出預設文件OToolStripMenuItem,
            this.重置設定檔RToolStripMenuItem,
            this.關於AToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(382, 24);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // 導入預設文件IToolStripMenuItem
            // 
            this.導入預設文件IToolStripMenuItem.Name = "導入預設文件IToolStripMenuItem";
            this.導入預設文件IToolStripMenuItem.Size = new System.Drawing.Size(102, 20);
            this.導入預設文件IToolStripMenuItem.Text = "導入預設文件(&I)";
            this.導入預設文件IToolStripMenuItem.Click += new System.EventHandler(this.導入預設文件IToolStripMenuItem_Click);
            // 
            // 導出預設文件OToolStripMenuItem
            // 
            this.導出預設文件OToolStripMenuItem.Name = "導出預設文件OToolStripMenuItem";
            this.導出預設文件OToolStripMenuItem.Size = new System.Drawing.Size(108, 20);
            this.導出預設文件OToolStripMenuItem.Text = "導出預設文件(&O)";
            this.導出預設文件OToolStripMenuItem.Click += new System.EventHandler(this.導出預設文件OToolStripMenuItem_Click);
            // 
            // 重置設定檔RToolStripMenuItem
            // 
            this.重置設定檔RToolStripMenuItem.Name = "重置設定檔RToolStripMenuItem";
            this.重置設定檔RToolStripMenuItem.Size = new System.Drawing.Size(94, 20);
            this.重置設定檔RToolStripMenuItem.Text = "重置設定檔(&R)";
            // 
            // 關於AToolStripMenuItem
            // 
            this.關於AToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.幫助HToolStripMenuItem,
            this.關於AToolStripMenuItem1});
            this.關於AToolStripMenuItem.Name = "關於AToolStripMenuItem";
            this.關於AToolStripMenuItem.Size = new System.Drawing.Size(59, 20);
            this.關於AToolStripMenuItem.Text = "幫助(&H)";
            // 
            // 幫助HToolStripMenuItem
            // 
            this.幫助HToolStripMenuItem.Name = "幫助HToolStripMenuItem";
            this.幫助HToolStripMenuItem.Size = new System.Drawing.Size(152, 22);
            this.幫助HToolStripMenuItem.Text = "幫助(&H)";
            this.幫助HToolStripMenuItem.Click += new System.EventHandler(this.幫助HToolStripMenuItem_Click);
            // 
            // 關於AToolStripMenuItem1
            // 
            this.關於AToolStripMenuItem1.Name = "關於AToolStripMenuItem1";
            this.關於AToolStripMenuItem1.Size = new System.Drawing.Size(152, 22);
            this.關於AToolStripMenuItem1.Text = "關於(&A)";
            this.關於AToolStripMenuItem1.Click += new System.EventHandler(this.關於AToolStripMenuItem1_Click);
            // 
            // Setting
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(382, 206);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "Setting";
            this.Text = "DanmakuMotion - 設定";
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem 導入預設文件IToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem 導出預設文件OToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem 重置設定檔RToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem 關於AToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem 幫助HToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem 關於AToolStripMenuItem1;
    }
}

