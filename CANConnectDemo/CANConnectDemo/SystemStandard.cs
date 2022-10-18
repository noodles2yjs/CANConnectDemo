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
    public partial class SystemStandard : Form
    {
        public SystemStandard()
        {
            InitializeComponent();
        }

       
      
        /// <summary>
        /// 显示曲线打开另一个窗口
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnShowCurve_Click(object sender, EventArgs e)
        {
            new FrmShowingCurve().Show();
            this.Hide();
        }
    }
}
