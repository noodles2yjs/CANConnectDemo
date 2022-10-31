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
        //private void InitDgvBHT()
        //{
        //    List<double> dataDoubles = new List<double>(); // 接收数据的容器
        //    List<double> dataZoneData = new List<double>(); // 接收数据的容器

        //    int dataZoneLength = 13;
        //    int cols = 13;
        //    int rows = 5;
        //    int dataCount = cols * rows;


        //    // Initialize  DataZone 
        //    for (int i = 0; i < dataZoneLength; i++)
        //    {
        //        Random random = new Random(Seed());
        //        dataZoneData.Add(random.NextDouble());
        //    }

        //    // initialize dataDoubles
        //    for (int i = 0; i < dataCount; i++)
        //    {
        //        Random random = new Random(Seed());
        //        var nextDouble = random.NextDouble();
        //        dataDoubles.Add(nextDouble);
        //    }

        //    // 将一维数组转化为二维数组 


        //    // Fill data to   dataGridView1BHT
        //    int flag = 0; // 死区这一行
        //    for (int i = 0; i < rows; i++)
        //    {  // 行填充
        //        Random random = new Random(Seed());

        //        // Add New row to  dataGridView1BHT
        //        if (i == 1)
        //        {
        //            flag = 1; //扭矩 
        //        }

        //        if (i == 2)
        //        {
        //            flag = 2;
        //        }
        //        var index = this.dataGridView1BHT.Rows.Add();
        //        for (int j = 0; j < cols; j++)
        //        {
        //            // 列填充 
        //            if (flag == 0)
        //            { // 死区
        //                if (j == 0)
        //                {
        //                    this.dataGridView1BHT.Rows[index].Cells[j].Value = "死区";
        //                }
        //                else
        //                {
        //                    this.dataGridView1BHT.Rows[index].Cells[j].Value = random.NextDouble();
        //                }


        //            }

        //            else if (flag == 1)
        //            {
        //                if (j == 0)
        //                {
        //                    this.dataGridView1BHT.Rows[index].Cells[j].Value = "扭矩";
        //                }
        //                else
        //                {
        //                    this.dataGridView1BHT.Rows[index].Cells[j].Value = $"Tout{j}";
        //                }


        //            }
        //            else
        //            { this.dataGridView1BHT.Rows[index].Cells[j].Value = random.NextDouble(); }

        //        }
        //    }
        //}

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
        {
            // 发过来的数据为 一维数组,
            List<double> dataDoubles = new List<double>(); // 接收数据的容器
            List<double> dataZoneData = new List<double>(); // 接收数据的容器

           
            int cols = 13;
            int rows = 5;

            int dataZoneLength = cols - 1;
            // 数据
            int dataCols = cols - 1;
            int dataRows = rows - 2;
            int dataCount = dataCols * dataRows;


            // Initialize  DataZone 
            for (int i = 0; i < dataZoneLength; i++)
            {
                Random random = new Random(Seed());
                dataZoneData.Add(random.NextDouble());
            }

            // initialize dataDoubles (模拟接收一维数组数据)
            for (int i = 0; i < dataCount; i++)
            {
                Random random = new Random(Seed());
                var nextDouble = random.NextDouble();
                dataDoubles.Add(nextDouble);
            }

            // 将一维数组转化为二维数组 
            var dataArray = dataDoubles.ToArray();
            var c = Row2ArrT(dataArray, 3);

            // Fill data to   dataGridView1BHT
            int flag = 0; // 死区这一行
            for (int i = 0; i < rows; i++)
            {  // 行填充
                Random random = new Random(Seed());

                // Add New row to  dataGridView1BHT
                if (i == 1)
                {
                    flag = 1; //扭矩 
                }

                if (i == 2)
                {
                    flag = 2;
                }
                var index = this.dataGridView1BHT.Rows.Add();
                for (int j = 0; j < cols; j++)
                {
                    // 列填充 
                    if (flag == 0)
                    { // 死区
                        if (j == 0)
                        {
                            this.dataGridView1BHT.Rows[index].Cells[j].Value = "死区";
                        }
                        else
                        {
                            this.dataGridView1BHT.Rows[index].Cells[j].Value = dataZoneData[j - 1];
                        }


                    }

                    else if (flag == 1)
                    {
                        if (j == 0)
                        {
                            this.dataGridView1BHT.Rows[index].Cells[j].Value = "扭矩";
                        }
                        else
                        {
                            this.dataGridView1BHT.Rows[index].Cells[j].Value = $"Tout{j}";
                        }


                    }
                    else
                    {
                        // 填充二维数组  
                        this.dataGridView1BHT.Rows[index].Cells[j].Value = random.NextDouble();

                        if (j == 0)
                        {
                            this.dataGridView1BHT.Rows[index].Cells[j].Value = 0;
                        }
                        else
                        {

                            this.dataGridView1BHT.Rows[index].Cells[j].Value = c[i - 2, j - 1];
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
