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
    public partial class SystemStandard2 : Form
    {
        public SystemStandard2()
        {
            InitializeComponent();
            InitDataGridView();
        }

        private void InitDataGridView()
        {
            
            for (int i = 0; i < 13; i++)
            {
                var random = new Random();
                int index = this.dataGridView1.Rows.Add(); // 向集合添加新行,返回新行的索引
                for (int j = 0; j < 12; j++)
                {
                    
                    this.dataGridView1.Rows[index].Cells[j].Value = random.NextDouble();
                }
               

                
            }
        }
    }
}
