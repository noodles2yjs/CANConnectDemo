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
    public partial class FrmShowCurveTest : Form
    {
        #region 字段属性

        public string[,] Data { get; set; }
        public List<string> ColName { get; set; }

        #endregion

        //public FrmShowCurveTest()
        //{
        //    InitializeComponent();
        //}

        public FrmShowCurveTest(List<string> colName,string[,] data)
        {
            InitializeComponent();
            Data = data;
            ColName = colName;
            Init();
        }

        private void Init()
        {
            // set up chart
         /*   chartArea1.AxisX.IsLabelAutoFit = false;
            chartArea1.AxisX.LabelStyle.IsStaggered = true;
            chartArea1.IsSameFontSizeForAllAxes = true;*/

            chart1.Series.Clear();

            var dataCount = Data.GetLength(0);
            for (int i = 0; i < dataCount; i++)
            {
                var series = chart1.Series.Add("series" + i);
                series.ChartType = SeriesChartType.Line;
            }

            for (int i = 0; i < dataCount; i++)
            {
                chart1.Series[i].XAxisType = AxisType.Primary;
                for (int j = 0; j < ColName.Count; j++)
                {
                    chart1.Series[i].Points.AddXY(ColName[j], double.Parse(Data[i,j]));
                }
            }
        }
    }
}
