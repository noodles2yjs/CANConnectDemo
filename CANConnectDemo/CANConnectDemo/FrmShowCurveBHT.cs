using Models;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Windows.Forms.DataVisualization.Charting;

namespace CANConnectDemo
{
    public partial class FrmShowCurveBHT : Form
    {


        List<DataGridViewRow>datas=   new List<DataGridViewRow>();
        List<string> cols=new  List<string>();
        public FrmShowCurveBHT(List<DataGridViewRow> data, List<string> data1)
        {
            datas = data;
            cols = data1;
            InitializeComponent();
            Inint();
           // MessageBox.Show(datas.Count.ToString());
        }
        /// <summary>
        /// 初始化Chart
        /// </summary>
        private void Inint()
        {

            // set up chart
          
            chart1.Series.Clear();

            for (int i = 1; i <= datas.Count; i++)
            {
                var series = chart1.Series.Add("series" + i);
                series.ChartType = SeriesChartType.Line;
                
            }

            // fill in all the values from the dgv to chart 

            for (int i = 0; i < datas.Count; i++)
            {
                chart1.Series[i].XAxisType = AxisType.Primary;
               // chart1.ChartAreas[0].AxisX.;
                for (int j = 1; j < cols.Count; j++)
                {
                   //  Console.WriteLine(datas[i].Cells[j].Value);
                    chart1.Series[i].Points.AddXY(cols[j], double.Parse(datas[i].Cells[j].Value.ToString()));
                }
            }
           
        }
       

    }



}
