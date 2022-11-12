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
        #region 属性字段
        private Dictionary<string, string[,]> dicDgvs;

        #endregion
        public SystemStandard()
        {
            InitializeComponent();
            // InitDataGridView();
           // InitDgvBHT(this.dataGridViewBHT);

            InitDgvBHT();
        }

        #region 随机种子
        public int Seed()
        {
            return Guid.NewGuid().ToString().GetHashCode();
        }
        #endregion

        #region BHTTestDemo Code

        /// <summary>
        /// 一维数组转二维数组
        /// </summary>
        /// <typeparam name="T"></typeparam>
        /// <param name="vec">一维数组</param>
        /// <param name="row">二维数组的行数</param>
        /// <returns></returns>
        static T[,] Row2ArrT<T>(T[] vec, int row)
        {
            if (vec.Length % row != 0) return null;
            int col = vec.Length / row;
            T[,] ret = new T[row, col];
            for (int i = 0; i < vec.Length; i++)
            {
                ret[i / col, i % col] = vec[i];
            }
            return ret;
        }

        /// <summary>
        /// 矩阵转置
        /// </summary>
        /// <typeparam name="T"></typeparam>
        /// <param name="arr1">待转置的数组</param>
        public static T[,] CTL<T>(T[,] arr1)
        {
            //执行换行 // 3行3列
            // 计算 Matrix 的行与列  不会
            int row = arr1.GetLength(0);
            int col = arr1.GetLength(1);
            int trow = col;
            int tcol = row;

            T[,] arr2 = new T[trow, tcol];
            for (int i = 0; i < trow; i++)
            {
                for (int j = 0; j < tcol; j++)
                {
                    arr2[i, j] = arr1[j, i]; // 转置
                }
            }

            return arr2;
        }

        private Bitmap bitmap;
        private void iSave()
        {
            Microsoft.Office.Interop.Excel._Application app = new Microsoft.Office.Interop.Excel.Application();
            Microsoft.Office.Interop.Excel._Workbook workbook = app.Workbooks.Add(Type.Missing);
            Microsoft.Office.Interop.Excel._Worksheet worksheet = null;

            app.Visible = true;
            worksheet = workbook.Sheets["sheet1"];
            worksheet = workbook.ActiveSheet;
            worksheet.Name = "Exported from GridView";

            for (int i = 1; i < dgv_BHT.Columns.Count + 1; i++)
            {
                worksheet.Cells[1, i] = dgv_BHT.Columns[i - 1].HeaderText;
            }

            for (int i = 0; i < dgv_BHT.Rows.Count; i++)
            {
                for (int j = 0; j < dgv_BHT.Columns.Count; j++)
                {
                    worksheet.Cells[i + 2, j + 1] = dgv_BHT.Rows[i].Cells[j].Value.ToString();
                }
            }

        }


        #endregion

        #region 不同表格的初始化

        private void InitDgvBHT(DataGridView dataGridView)
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


        #endregion

        #region Tab 切换

        private void tabControl1_SelectedIndexChanged(object sender, EventArgs e)
        {

            //if (tabControl1.SelectedTab == )
            //{
            //    //InitDgvPID(this.dataGridViewPID);
            //    //InitDgvTempProtection(this.dataGridViewTempProtection);

            //}
        }


        #endregion


        /// <summary>
        /// 刷新BHP的数据
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        //private void btnReload_Click(object sender, EventArgs e)
        //{
        //    this.dataGridViewBHT.DataSource = null;
        //    InitDgvBHT(this.dataGridViewBHT);

        //}

        /// <summary>
        /// 刷新数据
        /// </summary>
        /// <param name="dataGridView"></param>
        private void ReloadData(DataGridView  dgv) // 这里需要传一个委托
        {
            dgv.DataSource = null;
        }

        /// <summary>
        /// 显示BHT曲线
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        //private void btnShowBHPCurve_Click(object sender, EventArgs e)
        //{
        //    List<DataGridViewRow> gdrs = new List<DataGridViewRow>();

        //    List<string> cols = new List<string>();
        //    for (int i = 0; i < this.dataGridViewBHT.Columns.Count; i++)
        //    {
        //        cols.Add(this.dataGridViewBHT.Columns[i].HeaderText);
        //    }
        //    for (int i = 0; i < this.dataGridViewBHT.Rows.Count; i++)
        //    {
        //        gdrs.Add(this.dataGridViewBHT.Rows[i]);
        //    }
        //    new FrmShowCurveBHT(gdrs, cols).Show();
        //}

        /// <summary>
        /// 显示PId曲线
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        //private void btnShowPID_Click(object sender, EventArgs e)
        //{

        //    List<DataGridViewRow> gdrs = new List<DataGridViewRow>();

        //    List<string> cols = new List<string>();
        //    for (int i = 0; i < this.dataGridViewPID.Columns.Count; i++)
        //    {
        //        cols.Add(this.dataGridViewPID.Columns[i].HeaderText);
        //    }
        //    for (int i = 0; i < this.dataGridViewBHT.Rows.Count; i++)
        //    {
        //        gdrs.Add(this.dataGridViewPID.Rows[i]);
        //    }
        //    new FrmShowCurvePId(gdrs, cols).Show();
        //}

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
        private void dgv_BHT_KeyPress(object sender, KeyPressEventArgs e)
        {

            if (e.KeyChar == 22)
            {
                PasteData();
            }
        }

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
            selectedRowIndex = this.dgv_BHT.CurrentRow.Index;
            selectedColIndex = this.dgv_BHT.CurrentCell.ColumnIndex;
            if (selectedRowIndex + rownum > dgv_BHT.RowCount || selectedColIndex + colnum > dgv_BHT.ColumnCount)
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
                    this.dgv_BHT.Rows[i].Cells[j].Value = temp[i - selectedRowIndex][j - selectedColIndex];
                }
            }
        }


        #endregion

        private void btn_Print_Click(object sender, EventArgs e)
        {
            var height = dgv_BHT.Height;
            dgv_BHT.Height = dgv_BHT.RowCount * dgv_BHT.RowTemplate.Height * 2;
            bitmap = new Bitmap(dgv_BHT.Width, dgv_BHT.Height);
            dgv_BHT.DrawToBitmap(bitmap, new Rectangle(0, 0, dgv_BHT.Width, dgv_BHT.Height));

            printPreviewDialog1.PrintPreviewControl.Zoom = 1;
            printPreviewDialog1.ShowDialog();
            dgv_BHT.Height = height;
        }

        private void printDocument1_PrintPage(object sender, System.Drawing.Printing.PrintPageEventArgs e)
        {
            e.Graphics.DrawImage(bitmap, 0, 0);
        }

        private void btn_Save_Click(object sender, EventArgs e)
        {
            iSave();
        }

        #region 初始化BHT

        private void InitDgvBHT()
        {  // 一维数组转化为二维数组  一列一列的转化
            // 发过来的数据为 一维数组,
            List<string> data = new List<string>(); // 接收数据的容器
            List<string> dataZoneData = new List<string>(); // 接收数据的容器

            int dgvCols = 13;
            int dgvRows = 12;

            int dataZoneLength = dgvCols - 1;
            // 数据
            int dataCols = dgvRows - 2;
            int dataRows = dgvCols - 1;
            int dataCount = dataCols * dataRows;


            // Initialize  DataZone 
            for (int i = 0; i < dataZoneLength; i++)
            {
                Random random = new Random(Seed());
                dataZoneData.Add(random.NextDouble().ToString("0.00"));
            }

            // initialize dataDoubles (模拟接收一维数组数据)
            for (int i = 0; i < dataCount; i++)
            {
                Random random = new Random(Seed());
                var nextDouble = random.NextDouble().ToString("0.00");
                data.Add(nextDouble);
            }

            // 将一维数组转化为二维数组 
            var dataArray = data.ToArray();
            int irows = dataRows; 
            // 为后面的显示曲线提供数据 按照车速(一个series)显示曲线 
            var c = Row2ArrT(dataArray, irows);
            // 添加到字典里 // 暂时采用这种方式 
            dicDgvs.Add(this.dgv_BHT.Name,c);

            // 二维数组转置
            var tc = CTL(c);
            var tcRow = tc.GetLength(0); // 获得行数
            var tcCol = tc.GetLength(1);// 获得列数

            // int icols = dataArray.Length / irows;
            //Console.WriteLine("一维数组(传过来的数据):");
            //foreach (var item in dataArray)
            //{
            //    Console.Write(item + "\t");
            //}

            //Console.WriteLine();
            //Console.WriteLine("============ Dividing line ============");


            // 
            //Console.WriteLine("c 二维数组:");
            //for (int i = 0; i < c.GetLength(0); i++)
            //{
            //    for (int j = 0; j < c.GetLength(1); j++)
            //    {
            //        Console.Write(c[i, j] + "\t");
            //    }

            //    Console.WriteLine();
            //}

            //Console.WriteLine("============ Dividing line ============");
            //Console.WriteLine("转置后的二维数组:");
            //for (int i = 0; i < tc.GetLength(0); i++)
            //{
            //    for (int j = 0; j < tc.GetLength(1); j++)
            //    {
            //        Console.Write(tc[i, j] + "\t");
            //    }

            //    Console.WriteLine();
            //}


            // Fill  data to   dataGridView1BHT

            //  int tcRow = tc.GetLength(0);

            int flag = 0; // 死区这一行
            for (int i = 0; i < dgvRows; i++)
            {  // 行填充
                Random random = new Random(Seed());

                // Add New row to  dataGridView1BHT
                if (i == 1)
                {
                    flag = 1; //扭矩 
                }

                if (i == 2)
                {
                    flag = 2;  // 其他行
                }
                var index = this.dgv_BHT.Rows.Add();
                for (int j = 0; j < dgvCols; j++)
                {
                    // 列填充 
                    if (flag == 0)
                    { // 死区
                        if (j == 0)
                        {
                            this.dgv_BHT.Rows[index].Cells[j].Value = "死区";
                            continue;
                        }
                        else
                        {
                            this.dgv_BHT.Rows[index].Cells[j].Value = dataZoneData[j - 1];
                            continue;
                        }


                    }

                    else if (flag == 1)
                    {
                        if (j == 0)
                        {
                            this.dgv_BHT.Rows[index].Cells[j].Value = "扭矩";
                            continue;
                        }
                        else
                        {
                            this.dgv_BHT.Rows[index].Cells[j].Value = $"Tout{j}";
                            continue;
                        }


                    }
                    else
                    {
                        // 填充转置后的二维数组  
                        //  this.dataGridView1BHT.Rows[index].Cells[j].Value = random.NextDouble();

                        if (j == 0)
                        {
                            this.dgv_BHT.Rows[index].Cells[j].Value = 0;
                        }
                        else
                        {

                            this.dgv_BHT.Rows[index].Cells[j].Value = tc[i - 2, j - 1];
                        }

                    }

                }
            }

            // 清除默认选中
            this.dgv_BHT.ClearSelection();
            // this.dataGridView1BHT.ClearSelection();
        }

        #endregion

        private void btnReload_Click(object sender, EventArgs e)
        {
            ReloadData(this.dgv_BHT);
            InitDgvBHT();
        }

        private void btn_Clear_Click(object sender, EventArgs e)
        {
            this.dgv_BHT.Rows.Clear();
        }

        private void btn_ShowBHTCurve_Click(object sender, EventArgs e)
        {
          
            var colNames = new List<string>();

            // dgv 列的数据
            for (int i = 0; i < this.dgv_BHT.ColumnCount; i++)
            {
                colNames.Add(this.dgv_BHT.Columns[i].HeaderText);
            }
            // 行的数据 二维数组
            var D2Data = dicDgvs[this.dgv_BHT.Name];


            for (int i = 0; i < D2Data.GetLength(0) ;i++)
            {
                
            }
        }
    }
}
