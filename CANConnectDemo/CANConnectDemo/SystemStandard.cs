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

        /// <summary>
        /// 显示PId曲线
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnShowPID_Click(object sender, EventArgs e)
        {

            List<DataGridViewRow> gdrs = new List<DataGridViewRow>();

            List<string> cols = new List<string>();
            for (int i = 0; i < this.dataGridViewPID.Columns.Count; i++)
            {
                cols.Add(this.dataGridViewPID.Columns[i].HeaderText);
            }
            for (int i = 0; i < this.dataGridViewBHT.Rows.Count; i++)
            {
                gdrs.Add(this.dataGridViewPID.Rows[i]);
            }
            new FrmShowCurvePId(gdrs, cols).Show();
        }

        /// <summary>
        /// 显示温度保护曲线
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnShowTempProtection_Click(object sender, EventArgs e)
        {
            List<DataGridViewRow> gdrs = new List<DataGridViewRow>();

            List<string> cols = new List<string>();
            for (int i = 0; i < this.dataGridViewTempProtection.Columns.Count; i++)
            {
                cols.Add(this.dataGridViewTempProtection.Columns[i].HeaderText);
            }
            for (int i = 0; i < this.dataGridViewTempProtection.Rows.Count; i++)
            {
                gdrs.Add(this.dataGridViewTempProtection.Rows[i]);
            }
            new FrmShowCurveTempProtection(gdrs,cols).Show();
        }

        private void btnPIdReload_Click(object sender, EventArgs e)
        {
            ReloadData(this.dataGridViewPID);
            InitDgvPID(this.dataGridViewPID);
        }

        private void btnReloadTempProtection_Click(object sender, EventArgs e)
        {
            ReloadData(this.dataGridViewTempProtection);
            InitDgvTempProtection(this.dataGridViewTempProtection);
        }

        #region 从Excel中复制粘贴到Datagirdview

        //private void dataGridView1_KeyPress_1(object sender, KeyPressEventArgs e)
        //{
        //    if (e.KeyChar == 22)
        //    {
        //        PasteData();
        //    }
        //}

        private void PasteData()
        {
            string clipboardText = Clipboard.GetText(); //获取剪贴板中的内容
            if (string.IsNullOrEmpty(clipboardText))
            {
                return;
            }
            int colnum = 0;
            int rownum = 0;
            for (int i = 0; i < clipboardText.Length; i++)
            {
                if (clipboardText.Substring(i, 1) == "\t")
                {
                    colnum++;
                }
                if (clipboardText.Substring(i, 1) == "\n")
                {
                    rownum++;
                }
            }
            colnum = colnum / rownum + 1;
            int selectedRowIndex, selectedColIndex;
            selectedRowIndex = this.dataGridViewBHT.CurrentRow.Index;
            selectedColIndex = this.dataGridViewBHT.CurrentCell.ColumnIndex;
            if (selectedRowIndex + rownum > dataGridViewBHT.RowCount || selectedColIndex + colnum > dataGridViewBHT.ColumnCount)
            {
                MessageBox.Show("粘贴区域大小不一致","提示信息");
                return;
            }

            // 定义一个二维数组
            String[][] temp = new String[rownum][];
            for (int i = 0; i < rownum; i++)
            {
                temp[i] = new String[colnum];
            }


            int m = 0, n = 0, len = 0;
            while (len != clipboardText.Length)
            {
                String str = clipboardText.Substring(len, 1);
                if (str == "\t")
                {
                    n++;
                }
                else if (str == "\n")
                {
                    m++;
                    n = 0;
                }
                else
                {
                    temp[m][n] += str;
                }
                len++;
            }
            for (int i = selectedRowIndex; i < selectedRowIndex + rownum; i++)
            {
                for (int j = selectedColIndex; j < selectedColIndex + colnum; j++)
                {
                    this.dataGridViewBHT.Rows[i].Cells[j].Value = temp[i - selectedRowIndex][j - selectedColIndex];
                }
            }
        }


        #endregion

        private void dataGridViewBHT_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == 22)
            {
                PasteData();
            }
        }
    }
}
