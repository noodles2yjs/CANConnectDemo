
namespace CANConnectDemo
{
    partial class FrmLogin
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmLogin));
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.lblTop = new System.Windows.Forms.Label();
            this.tbxLogin = new System.Windows.Forms.TextBox();
            this.lblLogPwd = new System.Windows.Forms.Label();
            this.tbxLogPwd = new System.Windows.Forms.TextBox();
            this.lblLogUser = new System.Windows.Forms.Label();
            this.btnLogIn = new System.Windows.Forms.Button();
            this.btnExit = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(143, 102);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(244, 269);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            // 
            // lblTop
            // 
            this.lblTop.AutoSize = true;
            this.lblTop.Font = new System.Drawing.Font("宋体", 21.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.lblTop.Location = new System.Drawing.Point(342, 40);
            this.lblTop.Name = "lblTop";
            this.lblTop.Size = new System.Drawing.Size(232, 29);
            this.lblTop.TabIndex = 1;
            this.lblTop.Text = "欢迎登录XXX系统";
            // 
            // tbxLogin
            // 
            this.tbxLogin.Location = new System.Drawing.Point(575, 168);
            this.tbxLogin.Name = "tbxLogin";
            this.tbxLogin.Size = new System.Drawing.Size(198, 29);
            this.tbxLogin.TabIndex = 0;
            // 
            // lblLogPwd
            // 
            this.lblLogPwd.AutoSize = true;
            this.lblLogPwd.Location = new System.Drawing.Point(464, 234);
            this.lblLogPwd.Name = "lblLogPwd";
            this.lblLogPwd.Size = new System.Drawing.Size(85, 19);
            this.lblLogPwd.TabIndex = 1;
            this.lblLogPwd.Text = "登录密码";
            // 
            // tbxLogPwd
            // 
            this.tbxLogPwd.Location = new System.Drawing.Point(575, 229);
            this.tbxLogPwd.Name = "tbxLogPwd";
            this.tbxLogPwd.Size = new System.Drawing.Size(198, 29);
            this.tbxLogPwd.TabIndex = 1;
            this.tbxLogPwd.UseSystemPasswordChar = true;
            // 
            // lblLogUser
            // 
            this.lblLogUser.AutoSize = true;
            this.lblLogUser.Location = new System.Drawing.Point(463, 178);
            this.lblLogUser.Name = "lblLogUser";
            this.lblLogUser.Size = new System.Drawing.Size(85, 19);
            this.lblLogUser.TabIndex = 1;
            this.lblLogUser.Text = "登录账号";
            // 
            // btnLogIn
            // 
            this.btnLogIn.AutoSize = true;
            this.btnLogIn.Image = ((System.Drawing.Image)(resources.GetObject("btnLogIn.Image")));
            this.btnLogIn.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnLogIn.Location = new System.Drawing.Point(482, 311);
            this.btnLogIn.Name = "btnLogIn";
            this.btnLogIn.Size = new System.Drawing.Size(75, 29);
            this.btnLogIn.TabIndex = 2;
            this.btnLogIn.Text = "登录";
            this.btnLogIn.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnLogIn.UseVisualStyleBackColor = true;
            this.btnLogIn.Click += new System.EventHandler(this.btnLogIn_Click);
            // 
            // btnExit
            // 
            this.btnExit.AutoSize = true;
            this.btnExit.Image = ((System.Drawing.Image)(resources.GetObject("btnExit.Image")));
            this.btnExit.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnExit.Location = new System.Drawing.Point(619, 311);
            this.btnExit.Name = "btnExit";
            this.btnExit.Size = new System.Drawing.Size(75, 29);
            this.btnExit.TabIndex = 3;
            this.btnExit.Text = "退出";
            this.btnExit.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnExit.UseVisualStyleBackColor = true;
            this.btnExit.Click += new System.EventHandler(this.btnExit_Click);
            // 
            // button1
            // 
            this.button1.AutoSize = true;
            this.button1.Image = ((System.Drawing.Image)(resources.GetObject("button1.Image")));
            this.button1.Location = new System.Drawing.Point(830, 12);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 29);
            this.button1.TabIndex = 4;
            this.button1.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // FrmLogin
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(96F, 96F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Dpi;
            this.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.ClientSize = new System.Drawing.Size(917, 564);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.btnExit);
            this.Controls.Add(this.btnLogIn);
            this.Controls.Add(this.tbxLogPwd);
            this.Controls.Add(this.tbxLogin);
            this.Controls.Add(this.lblLogUser);
            this.Controls.Add(this.lblLogPwd);
            this.Controls.Add(this.lblTop);
            this.Controls.Add(this.pictureBox1);
            this.Font = new System.Drawing.Font("宋体", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(3, 5, 3, 5);
            this.Name = "FrmLogin";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Main";
            this.Load += new System.EventHandler(this.FrmMain_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label lblTop;
        private System.Windows.Forms.TextBox tbxLogin;
        private System.Windows.Forms.Label lblLogPwd;
        private System.Windows.Forms.TextBox tbxLogPwd;
        private System.Windows.Forms.Label lblLogUser;
        private System.Windows.Forms.Button btnLogIn;
        private System.Windows.Forms.Button btnExit;
        private System.Windows.Forms.Button button1;
    }
}

