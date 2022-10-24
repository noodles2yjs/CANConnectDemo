using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml.Schema;
using Models;

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
            // 原始一个个添加
            int n = 1000;
            for (int i = 0; i < 13; i++)
            {
                n += 1;
                var random = new Random();
                int index = this.dataGridView1.Rows.Add(); // 向集合添加新行,返回新行的索引
                for (int j = 0; j < 13; j++)
                {
                    if (j == 0)
                    {

                        this.dataGridView1.Rows[index].Cells[j].Value = n;

                    }
                    this.dataGridView1.Rows[index].Cells[j].Value = random.NextDouble();
                }

            }

            // 通过对象添加
            /*    {
                    var standardPidModels = new List<StandardPIDModel>();

                    int n = 1000;
                    for (int i = 0; i < 10; i++)
                    {
                        n += 1;
                        var random = new Random();
                        var standardPidModel = new StandardPIDModel
                        {
                            DZ = random.NextDouble(),
                            Id = n,
                            KD = random.NextDouble(),
                            KI = random.NextDouble(),
                            KP = random.NextDouble(),
                            Max = random.NextDouble(),
                            PCI = random.NextDouble(),
                            PCJ = random.NextDouble(),
                            PFI = random.NextDouble(),
                            PCK = random.NextDouble(),
                            PFJ = random.NextDouble(),
                            PFK = random.NextDouble(),
                            VhicleSpeed = random.NextDouble(),

                        };

                        standardPidModels.Add(standardPidModel);
                    }

                    this.dataGridView1.DataSource = standardPidModels;
                }*/
        }

       
        private void InitializeDataGridView( DataGridView dataGridView)
        {
            //dataGridView2.AutoGenerateColumns = true;
            var standardPidModels = new List<StandardPIDModel>();
            //这个就是 通过随机数,添加到对象,对象绑定
            int n = 1000; 
            for (int i = 0; i < 2; i++)
            {
                n += 1;
                var random = new Random();
                var standardPidModel = new StandardPIDModel
                {
                    DZ = random.NextDouble(),
                    Id = n,
                    KD = random.NextDouble(),
                    KI = random.NextDouble(),
                    KP = random.NextDouble(),
                    Max = random.NextDouble(),
                    PCI = random.NextDouble(),
                    PCJ = random.NextDouble(),
                    PFI = random.NextDouble(),
                    PCK = random.NextDouble(),
                    PFJ = random.NextDouble(),
                    PFK = random.NextDouble(),
                    VhicleSpeed = random.NextDouble(),

                };

                standardPidModels.Add(standardPidModel);
            }


            //bindingSource1.DataSource = standardPidModels;
            dataGridView.DataSource = standardPidModels;
        }

        private void tabControl1_SelectedIndexChanged(object sender, EventArgs e)
        {

            if (tabControl1.SelectedTab == tabPage2)
            {
                InitializeDataGridView(this.dataGridView2);
            }
            if (tabControl1.SelectedTab == tabPID )
            {
                InitializeDataGridView(this.dataGridView3);
            }
        }

        /// <summary>
        /// 显示曲线
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnShowCurve_Click(object sender, EventArgs e)
        {
            //var frmShowCurve2 = new FrmShowCurve2 {Owner = this};
            //frmShowCurve2.Show();
            // new FrmShowCurve2().Show(this); 另一个窗口无法获取到 放弃
            // var systemS= new SystemStandard2();
            // systemStandard2 = this;
            List<DataGridViewRow> gdrs = new List<DataGridViewRow>();

             List<string> cols=new List<string>();
          for (int i = 0; i < dataGridView2.Columns.Count; i++)
          {
              cols.Add(dataGridView2.Columns[i].HeaderText);
          }
          for (int i = 0; i < dataGridView2.Rows.Count; i++)
          {
              gdrs.Add(dataGridView2.Rows[i]);
          }
            new FrmShowCurve2(gdrs,cols).Show();
        }

        private void dataGridView1_DataBindingComplete(object sender, DataGridViewBindingCompleteEventArgs e)
        {

        }

        private void tabPage1_Click(object sender, EventArgs e)
        {

        }

        private void SystemStandard2_Load(object sender, EventArgs e)
        {

        }
    }
}
