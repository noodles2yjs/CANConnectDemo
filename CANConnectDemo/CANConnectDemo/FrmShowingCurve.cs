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
            superChart =new SuperChart(this.chart1);
            Init();
            this.superChart.ShowChart(SeriesChartType.Line, dataList);

        }
        private List<ChartData> dataList = new List<ChartData>();//用来保存数据的集合
        private SuperChart superChart = null;
        private void Init()
        {
            //创建一个随机数用来生成数据
            Random random = new Random();
            dataList.Add(new ChartData("北京", random.Next(100)));
            dataList.Add(new ChartData("上海", random.Next(100)));
            dataList.Add(new ChartData("天津", random.Next(100)));
            dataList.Add(new ChartData("深圳", random.Next(100)));
            dataList.Add(new ChartData("南京", random.Next(100)));
        }
    }
}
