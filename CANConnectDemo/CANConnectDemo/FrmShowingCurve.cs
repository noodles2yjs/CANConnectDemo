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
    public partial class FrmShowingCurve : Form
    {
        public FrmShowingCurve()
        {
            InitializeComponent();
            // 初始化自定义Chart对象
            superChart1 =new SuperChart(this.chart1);
            superChart2 =new SuperChart(this.chart1);
            superChart3 =new SuperChart(this.chart1);
            Init();
            this.superChart1.ShowChart(SeriesChartType.Line, dataList1);
            this.superChart2.ShowChart(SeriesChartType.Line, dataList2);
            this.superChart3.ShowChart(SeriesChartType.Line, dataList3);

        }
        private SuperChart superChart1 = null;
        private SuperChart superChart2 = null;
        private SuperChart superChart3 = null;
        private List<ChartData> dataList1 = new List<ChartData>();//用来保存数据的集合
        private List<ChartData> dataList2 = new List<ChartData>();//用来保存数据的集合
        private List<ChartData> dataList3 = new List<ChartData>();//用来保存数据的集合
        private void Init()
        {
            //创建一个随机数用来生成数据
            
            //Random random = new Random();
            //dataList1.Add(new ChartData("北京", random.Next(100)));
            //dataList1.Add(new ChartData("上海", random.Next(100)));
            //dataList1.Add(new ChartData("天津", random.Next(100)));
            //dataList1.Add(new ChartData("深圳", random.Next(100)));
            //dataList1.Add(new ChartData("南京", random.Next(100)));

            /// 将dataGridView2的数据显示在图表里
          dataList1.Add(
              new ChartData()
              
              );


        }
    }
}
