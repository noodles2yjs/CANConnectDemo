using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace LearningDemo
{
    public partial class BHTTestDemo : Form
    {
        public BHTTestDemo()
        {
            InitializeComponent();
            InitDgvBHT();
        }

        public int Seed()
        {
            return Guid.NewGuid().ToString().GetHashCode();
        }
       
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
        private void button1Print_Click(object sender, EventArgs e)
        {
            var height = dataGridView1BHT.Height;
            dataGridView1BHT.Height = dataGridView1BHT.RowCount * dataGridView1BHT.RowTemplate.Height * 2;
            bitmap = new Bitmap(dataGridView1BHT.Width, dataGridView1BHT.Height);
            dataGridView1BHT.DrawToBitmap(bitmap, new Rectangle(0, 0, dataGridView1BHT.Width, dataGridView1BHT.Height));

            printPreviewDialog1.PrintPreviewControl.Zoom = 1;
            printPreviewDialog1.ShowDialog();
            dataGridView1BHT.Height = height;
        }
        private void printDocument1_PrintPage(object sender, System.Drawing.Printing.PrintPageEventArgs e)
        {
            e.Graphics.DrawImage(bitmap,0,0);
        }

        private void iSave()
        {
            Microsoft.Office.Interop.Excel._Application app = new Microsoft.Office.Interop.Excel.Application();
            Microsoft.Office.Interop.Excel._Workbook workbook = app.Workbooks.Add(Type.Missing);
            Microsoft.Office.Interop.Excel._Worksheet worksheet = null;

            app.Visible = true;
            worksheet = workbook.Sheets["sheet1"];
            worksheet = workbook.ActiveSheet;
            worksheet.Name = "Exported from GridView";

            for (int i = 1; i < dataGridView1BHT.Columns.Count + 1; i++)
            {
                worksheet.Cells[1, i] = dataGridView1BHT.Columns[i - 1].HeaderText;
            }

            for (int i = 0; i < dataGridView1BHT.Rows.Count - 1; i++)
            {
                for (int j = 0; j < dataGridView1BHT.Columns.Count; j++)
                {
                    worksheet.Cells[i + 2, j + 1] = dataGridView1BHT.Rows[i].Cells[j].Value.ToString();
                }
            }

        }

        private void button2Save_Click(object sender, EventArgs e)
        {
            iSave();
        }

        private void InitDgvBHT()
        {  // 一维数组转化为二维数组  一列一列的转化
            // 发过来的数据为 一维数组,
            List<string> data = new List<string>(); // 接收数据的容器
            List<string> dataZoneData = new List<string>(); // 接收数据的容器


            int dgvCols = 13;
            int dgvRows = 5;

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
            int irows = dataRows; // 
            var c = Row2ArrT(dataArray, irows);

            // 二维数组转置
            var tc = CTL(c);
            var tcRow = tc.GetLength(0);
            var tcCol = tc.GetLength(1);

           // int icols = dataArray.Length / irows;
            Console.WriteLine("一维数组(传过来的数据):");
            foreach (var item in dataArray)
            {
                Console.Write(item + "\t");
            }

            Console.WriteLine();
            Console.WriteLine("============ Dividing line ============");

            // 
            Console.WriteLine("c 二维数组:");
            for (int i = 0; i < c.GetLength(0); i++)
            {
                for (int j = 0; j < c.GetLength(1); j++)
                {
                    Console.Write(c[i, j] + "\t");
                }

                Console.WriteLine();
            }
            Console.WriteLine("============ Dividing line ============");
            Console.WriteLine("转置后的二维数组:");
            for (int i = 0; i < tc.GetLength(0); i++)
            {
                for (int j = 0; j < tc.GetLength(1); j++)
                {
                    Console.Write(tc[i, j] + "\t");
                }

                Console.WriteLine();
            }


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
                var index = this.dataGridView1BHT.Rows.Add();
                for (int j = 0; j < dgvCols; j++)
                {
                    // 列填充 
                    if (flag == 0)
                    { // 死区
                        if (j == 0)
                        {
                            this.dataGridView1BHT.Rows[index].Cells[j].Value = "死区";
                            continue;
                        }
                        else
                        {
                            this.dataGridView1BHT.Rows[index].Cells[j].Value = dataZoneData[j - 1];
                            continue;
                        }


                    }

                    else if (flag == 1)
                    {
                        if (j == 0)
                        {
                            this.dataGridView1BHT.Rows[index].Cells[j].Value = "扭矩";
                            continue;
                        }
                        else
                        {
                            this.dataGridView1BHT.Rows[index].Cells[j].Value = $"Tout{j}";
                            continue;
                        }


                    }
                    else
                    {
                        // 填充转置后的二维数组  
                        //  this.dataGridView1BHT.Rows[index].Cells[j].Value = random.NextDouble();

                        if (j == 0)
                        {
                            this.dataGridView1BHT.Rows[index].Cells[j].Value = 0;
                        }
                        else
                        {

                           this.dataGridView1BHT.Rows[index].Cells[j].Value = tc[i-2,j-1];
                        }

                    }

                }
            }

            // 清除默认选中
            this.dataGridView1BHT.ClearSelection();
            // this.dataGridView1BHT.ClearSelection();
        }
    }
}
