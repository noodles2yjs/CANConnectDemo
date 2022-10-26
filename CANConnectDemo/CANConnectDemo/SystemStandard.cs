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
    public partial class SystemStandard : Form
    {
        public SystemStandard()
        {
            InitializeComponent();
            // InitDataGridView();
            InitDgvBHT(this.dataGridViewBHT);
        }

        /// <summary>
        /// 一行一行添加 使用 dataGridViewBHT.Rows.Add() 添加
        /// </summary>
    /*    private void InitDataGridView()
        {
            // 原始一个个添加
            int n = 1000;
            for (int i = 0; i < 13; i++)
            {
                n += 1;
                var random = new Random();
                int index = this.dataGridViewBHT.Rows.Add(); // 向集合添加新行,返回新行的索引
                for (int j = 0; j < 13; j++)
                {
                    if (j == 0)
                    {

                        this.dataGridViewBHT.Rows[index].Cells[j].Value = n;

                    }
                    this.dataGridViewBHT.Rows[index].Cells[j].Value = random.NextDouble();
                }

            }

            // 通过对象添加
            *//*    {
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
                }*//*
        }
*/
       
        private void InitDgvBHT( DataGridView dataGridView)
        {
            //dataGridView2.AutoGenerateColumns = true;
            var StandardBasicHelpTableModels = new List<StandardBasicHelpTableModel>();
            //这个就是 通过随机数,添加到对象,对象绑定
            int n = 1000; 
            for (int i = 0; i < 3; i++)
            {
                n += 1;
               // int seekSeek = unchecked((int)DateTime.Now.Ticks); // 随机种子 这个不太靠谱
                //string guid = System.Guid.NewGuid().ToString();
                // 使用Guid作为随机种子
                var guid = Guid.NewGuid().ToString();
                var random = new Random(guid.GetHashCode());
                var StandardPIDModel = new StandardBasicHelpTableModel
                {
                    Id = n,
                   VehicleSpeed = random.NextDouble(),
                   Prop00 = random.NextDouble(),
                   Prop05 = random.NextDouble(),
                   Prop10 = random.NextDouble(),
                   Prop20 = random.NextDouble(),
                   Prop30 = random.NextDouble(),
                   Prop40 = random.NextDouble(),
                   Prop50 = random.NextDouble(),
                   Prop60 = random.NextDouble(),
                   Prop70 = random.NextDouble(),
                   Prop80 = random.NextDouble(),
                   Prop90 = random.NextDouble(),
                   Prop100 = random.NextDouble(),

                };

                StandardBasicHelpTableModels.Add(StandardPIDModel);
            }


            //bindingSource1.DataSource = standardPidModels;
            dataGridView.DataSource = StandardBasicHelpTableModels;
        }

        private void InitDgvPID(DataGridView dataGridView)
        {
            //dataGridView2.AutoGenerateColumns = true;
            var StandardPIDModels = new List<StandardPIDModel>();
            //这个就是 通过随机数,添加到对象,对象绑定
            int n = 1000;
            for (int i = 0; i < 3; i++)
            {
                n += 1;
                // int seekSeek = unchecked((int)DateTime.Now.Ticks); // 随机种子 这个不太靠谱
                //string guid = System.Guid.NewGuid().ToString();
                // 使用Guid作为随机种子
                var guid = Guid.NewGuid().ToString();
                var random = new Random(guid.GetHashCode());
                var StandardPIDModel = new StandardPIDModel
                {
                    Id = n,
                    VhicleSpeed = random.NextDouble(),
                    KP = random.NextDouble(),
                    KI = random.NextDouble(),
                    KD = random.NextDouble(),
                    DZ = random.NextDouble(),
                    Max = random.NextDouble(),
                    PCJ = random.NextDouble(),
                    PCK = random.NextDouble(),
                    PCI = random.NextDouble(),
                    PFJ = random.NextDouble(),
                    PFK = random.NextDouble(),
                    PFI = random.NextDouble(),

                };

                StandardPIDModels.Add(StandardPIDModel);
            }


            //bindingSource1.DataSource = standardPidModels;
            dataGridView.DataSource = StandardPIDModels;
        }
        private void InitDgvTempProtection(DataGridView dataGridView)
        {
            //dataGridView2.AutoGenerateColumns = true;
            var StandardTempProtectionModels = new List<StandardTempProtectionModel>();
            //这个就是 通过随机数,添加到对象,对象绑定
            int n = 1000;
            for (int i = 0; i < 3; i++)
            {
                n += 1;
                // int seekSeek = unchecked((int)DateTime.Now.Ticks); // 随机种子 这个不太靠谱
                //string guid = System.Guid.NewGuid().ToString();
                // 使用Guid作为随机种子
                var guid = Guid.NewGuid().ToString();
                var random = new Random(guid.GetHashCode());
                var StandardTempProtectionModel = new StandardTempProtectionModel
                {
                    Id = n,
                    CutInTemp = random.NextDouble(),
                    CutInTime = random.NextDouble(),
                    Slope = random.NextDouble(),
                    WeakeningRatio = random.NextDouble(),
                    RecoverTime1 = random.NextDouble(),
                    RecoverTime2 = random.NextDouble(),
                    RecoverTemp = random.NextDouble(),
                };

                StandardTempProtectionModels.Add(StandardTempProtectionModel);
            }


            //bindingSource1.DataSource = standardPidModels;
            dataGridView.DataSource = StandardTempProtectionModels;
        }

        private void tabControl1_SelectedIndexChanged(object sender, EventArgs e)
        {

            if (tabControl1.SelectedTab == tabPID )
            {
                InitDgvPID(this.dataGridViewPID);
                InitDgvTempProtection(this.dataGridViewTempProtection);
            }
        }

       
        /// <summary>
        /// 刷新BHP的数据
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnReload_Click(object sender, EventArgs e)
        {
            this.dataGridViewBHT.DataSource = null;
            InitDgvBHT(this.dataGridViewBHT);

        }

        /// <summary>
        /// 刷新数据
        /// </summary>
        /// <param name="dataGridView"></param>
        private void ReloadData(DataGridView  dataGridView) // 这里需要传一个委托
        {
            dataGridView.DataSource = null;
        }

        /// <summary>
        /// 显示BHT曲线
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnShowBHPCurve_Click(object sender, EventArgs e)
        {
            List<DataGridViewRow> gdrs = new List<DataGridViewRow>();

            List<string> cols = new List<string>();
            for (int i = 0; i < this.dataGridViewBHT.Columns.Count; i++)
            {
                cols.Add(this.dataGridViewBHT.Columns[i].HeaderText);
            }
            for (int i = 0; i < this.dataGridViewBHT.Rows.Count; i++)
            {
                gdrs.Add(this.dataGridViewBHT.Rows[i]);
            }
            new FrmShowCurveBHT(gdrs, cols).Show();
        }
    }
}
