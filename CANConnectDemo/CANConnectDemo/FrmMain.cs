using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CANConnectDemo
{
    public partial class FrmMain : Form
    {
        public FrmMain()
        {
            InitializeComponent();
            //SetTitleCenter();
        }

        /// <summary>
        /// 设置标题居中
        ///<see cref="https://www.cnblogs.com/19930521zhang/p/14296342.html"/>  
        /// </summary>
        private void SetTitleCenter()
        {
            string titleMsg = "Main Interface";
            Graphics g = this.CreateGraphics();
            Double startingPoint = (this.Width / 2) - (g.MeasureString(titleMsg, this.Font).Width / 2);
            Double widthOfASpace = g.MeasureString(" ", this.Font).Width;
            String tmp = " ";
            Double tmpWidth = 0;

            while ((tmpWidth + widthOfASpace) < startingPoint)
            {
                tmp += " ";
                tmpWidth += widthOfASpace;
            }

            this.Text = tmp + titleMsg;
        }

        private void 系统标定ToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            ClosePreForm();
            OpenForm(new SystemMonitor());
        }

        private void ClosePreForm()
        {
            // 首先判断当前容器中是否已经存在其他窗体
            foreach (var item in this.panel1.Controls)
            {
                if (item is Form f)
                {
                    f.Close();
                }
            }

        }

        private void OpenForm(Form newForm)
        {
            newForm.TopLevel = false; // 将子窗体设置成非顶级控件
            newForm.WindowState = FormWindowState.Maximized;
            newForm.FormBorderStyle = FormBorderStyle.None;
            newForm.Parent = this.panel1;
            newForm.Show();
        }

        private void menuSysStandard_Click(object sender, EventArgs e)
        {
            ClosePreForm();
            OpenForm(new SystemStandard2());
            
            //ClosePreForm();
            //OpenForm(new SystemStandard());
          

        }
    }
}
