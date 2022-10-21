using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using Models;

namespace CANConnectDemo
{
    public partial class FrmLogin : Form
    {
        public FrmLogin()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void FrmMain_Load(object sender, EventArgs e)
        {

        }

        private void btnLogIn_Click(object sender, EventArgs e)
        {
            List<LogUser> logUsers = new List<LogUser>()
            {
                new LogUser(){Id=1001,Name = "Volta",Pwd = "111111"},
                new LogUser(){Id=1002,Name = "David",Pwd = "111111"},
                new LogUser(){Id=1003,Name = "Peter",Pwd = "111111"},
            };

            if (tbxLogin.Text.Equals(string.Empty) || tbxLogPwd.Text.Equals(string.Empty))
            {
                MessageBox.Show("请输入账户ID和密码","提示信息",MessageBoxButtons.OK,MessageBoxIcon.Information);
                return;
            }

            try
            {
                foreach (var user in logUsers)
                {
                    if (tbxLogin.Text.Equals(user.Id.ToString()) && tbxLogPwd.Text.Equals(user.Pwd) )
                    {
                        //MessageBox.Show("账户名或者密码不对,请重新输入", "提示信息", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        //return;

                        new FrmMain().Show();
                        this.Hide();
                        return;
                    }
                }

            }
            catch (Exception exception)
            {
                Console.WriteLine(exception);
                throw;
            }

            MessageBox.Show("账户名或者密码不对,请重新输入", "提示信息", MessageBoxButtons.OK, MessageBoxIcon.Error);
            tbxLogin.Text = "";
            tbxLogPwd.Text = "";

        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void tbxLogin_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyValue == 13)
            {
                tbxLogPwd.Focus();
                tbxLogPwd.SelectAll();
            }
        }

        private void tbxLogPwd_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyValue == 13)
            {
                btnLogIn_Click(null,null);
            }
        }
    }
}
