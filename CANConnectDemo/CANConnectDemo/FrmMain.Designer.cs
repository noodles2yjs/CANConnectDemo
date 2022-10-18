
namespace CANConnectDemo
{
    partial class FrmMain
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmMain));
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.系统标定ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.修改密码ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.退出ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.其他ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.系统标定ToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.menuSysStandard = new System.Windows.Forms.ToolStripMenuItem();
            this.程序下载ToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.statusStrip1 = new System.Windows.Forms.StatusStrip();
            this.toolStripStatusLabel1 = new System.Windows.Forms.ToolStripStatusLabel();
            this.panel1 = new System.Windows.Forms.Panel();
            this.菜单1ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.菜单2ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.菜单1ToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.菜单2ToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.menuStrip1.SuspendLayout();
            this.statusStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.系统标定ToolStripMenuItem,
            this.系统标定ToolStripMenuItem1,
            this.toolStripMenuItem1,
            this.menuSysStandard,
            this.程序下载ToolStripMenuItem1});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(1333, 25);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // 系统标定ToolStripMenuItem
            // 
            this.系统标定ToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.修改密码ToolStripMenuItem,
            this.退出ToolStripMenuItem,
            this.toolStripSeparator1,
            this.其他ToolStripMenuItem});
            this.系统标定ToolStripMenuItem.Name = "系统标定ToolStripMenuItem";
            this.系统标定ToolStripMenuItem.Size = new System.Drawing.Size(59, 21);
            this.系统标定ToolStripMenuItem.Text = "系统(&S)";
            // 
            // 修改密码ToolStripMenuItem
            // 
            this.修改密码ToolStripMenuItem.Image = ((System.Drawing.Image)(resources.GetObject("修改密码ToolStripMenuItem.Image")));
            this.修改密码ToolStripMenuItem.Name = "修改密码ToolStripMenuItem";
            this.修改密码ToolStripMenuItem.Size = new System.Drawing.Size(124, 22);
            this.修改密码ToolStripMenuItem.Text = "修改密码";
            // 
            // 退出ToolStripMenuItem
            // 
            this.退出ToolStripMenuItem.Image = ((System.Drawing.Image)(resources.GetObject("退出ToolStripMenuItem.Image")));
            this.退出ToolStripMenuItem.Name = "退出ToolStripMenuItem";
            this.退出ToolStripMenuItem.Size = new System.Drawing.Size(124, 22);
            this.退出ToolStripMenuItem.Text = "退出";
            // 
            // toolStripSeparator1
            // 
            this.toolStripSeparator1.Name = "toolStripSeparator1";
            this.toolStripSeparator1.Size = new System.Drawing.Size(121, 6);
            // 
            // 其他ToolStripMenuItem
            // 
            this.其他ToolStripMenuItem.Name = "其他ToolStripMenuItem";
            this.其他ToolStripMenuItem.Size = new System.Drawing.Size(124, 22);
            this.其他ToolStripMenuItem.Text = "其他";
            // 
            // 系统标定ToolStripMenuItem1
            // 
            this.系统标定ToolStripMenuItem1.Name = "系统标定ToolStripMenuItem1";
            this.系统标定ToolStripMenuItem1.Size = new System.Drawing.Size(88, 21);
            this.系统标定ToolStripMenuItem1.Text = "系统监控(&M)";
            this.系统标定ToolStripMenuItem1.Click += new System.EventHandler(this.系统标定ToolStripMenuItem1_Click);
            // 
            // menuSysStandard
            // 
            this.menuSysStandard.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.菜单1ToolStripMenuItem,
            this.菜单2ToolStripMenuItem});
            this.menuSysStandard.Name = "menuSysStandard";
            this.menuSysStandard.Size = new System.Drawing.Size(83, 21);
            this.menuSysStandard.Text = "程序标定(&S)";
            this.menuSysStandard.Click += new System.EventHandler(this.menuSysStandard_Click);
            // 
            // 程序下载ToolStripMenuItem1
            // 
            this.程序下载ToolStripMenuItem1.Name = "程序下载ToolStripMenuItem1";
            this.程序下载ToolStripMenuItem1.Size = new System.Drawing.Size(85, 21);
            this.程序下载ToolStripMenuItem1.Text = "程序下载(&D)";
            // 
            // statusStrip1
            // 
            this.statusStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripStatusLabel1});
            this.statusStrip1.Location = new System.Drawing.Point(0, 691);
            this.statusStrip1.Name = "statusStrip1";
            this.statusStrip1.Size = new System.Drawing.Size(1333, 22);
            this.statusStrip1.TabIndex = 3;
            this.statusStrip1.Text = "statusStrip1";
            // 
            // toolStripStatusLabel1
            // 
            this.toolStripStatusLabel1.Name = "toolStripStatusLabel1";
            this.toolStripStatusLabel1.Size = new System.Drawing.Size(88, 17);
            this.toolStripStatusLabel1.Text = "当前版本号:1.0";
            // 
            // panel1
            // 
            this.panel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel1.Location = new System.Drawing.Point(0, 25);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1333, 666);
            this.panel1.TabIndex = 4;
            // 
            // 菜单1ToolStripMenuItem
            // 
            this.菜单1ToolStripMenuItem.Name = "菜单1ToolStripMenuItem";
            this.菜单1ToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.菜单1ToolStripMenuItem.Text = "菜单1";
            // 
            // 菜单2ToolStripMenuItem
            // 
            this.菜单2ToolStripMenuItem.Name = "菜单2ToolStripMenuItem";
            this.菜单2ToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.菜单2ToolStripMenuItem.Text = "菜单2";
            // 
            // toolStripMenuItem1
            // 
            this.toolStripMenuItem1.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.菜单1ToolStripMenuItem1});
            this.toolStripMenuItem1.Name = "toolStripMenuItem1";
            this.toolStripMenuItem1.Size = new System.Drawing.Size(136, 21);
            this.toolStripMenuItem1.Text = "toolStripMenuItem1";
            // 
            // 菜单1ToolStripMenuItem1
            // 
            this.菜单1ToolStripMenuItem1.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.菜单2ToolStripMenuItem1});
            this.菜单1ToolStripMenuItem1.Name = "菜单1ToolStripMenuItem1";
            this.菜单1ToolStripMenuItem1.Size = new System.Drawing.Size(180, 22);
            this.菜单1ToolStripMenuItem1.Text = "菜单1";
            // 
            // 菜单2ToolStripMenuItem1
            // 
            this.菜单2ToolStripMenuItem1.Name = "菜单2ToolStripMenuItem1";
            this.菜单2ToolStripMenuItem1.Size = new System.Drawing.Size(180, 22);
            this.菜单2ToolStripMenuItem1.Text = "菜单2";
            // 
            // FrmMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(96F, 96F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Dpi;
            this.ClientSize = new System.Drawing.Size(1333, 713);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.statusStrip1);
            this.Controls.Add(this.menuStrip1);
            this.Font = new System.Drawing.Font("宋体", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MainMenuStrip = this.menuStrip1;
            this.Margin = new System.Windows.Forms.Padding(5);
            this.Name = "FrmMain";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.statusStrip1.ResumeLayout(false);
            this.statusStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem 系统标定ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem 系统标定ToolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem menuSysStandard;
        private System.Windows.Forms.ToolStripMenuItem 修改密码ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem 退出ToolStripMenuItem;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator1;
        private System.Windows.Forms.ToolStripMenuItem 其他ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem 程序下载ToolStripMenuItem1;
        private System.Windows.Forms.StatusStrip statusStrip1;
        private System.Windows.Forms.ToolStripStatusLabel toolStripStatusLabel1;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.ToolStripMenuItem 菜单1ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem 菜单2ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem toolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem 菜单1ToolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem 菜单2ToolStripMenuItem1;
    }
}