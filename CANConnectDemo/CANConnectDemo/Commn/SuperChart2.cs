using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms.DataVisualization.Charting;

namespace CANConnectDemo
{
    /// <summary>
    /// 高级Chart设置类
    /// </summary>
    public class SuperChart2
    {
        public Chart _Chart { get; set; }

        public SuperChart2(Chart chart)
        {
            this._Chart = chart;
        }
        /// <summary>
        /// 绘制Chart的通用方法
        /// <seealso cref="https://blog.csdn.net/metal1/article/details/51874169"/>
        /// </summary>
        public void ShowChart(SeriesChartType chartType,List<ChartData> dataList)
        {
            // 清除所有图表序列
            this._Chart.Series.Clear();
            // 创建一个图表序列对象
            Series series = new Series();
            series.ChartType = chartType;
            this._Chart.Series.Add(series);

            // 设置当前图表序列对象的各种属性值

            for (int i = 0; i < dataList.Count; i++)
            {
                // 获取数据对象的两个值
                string text = dataList[i].Text;
                double value = dataList[i].Value;

                // 使用x和y的值将DataPoint对象添加进去
                series.Points.AddXY(text, value);

                // 设置数据点显示内容
                series.Points[i].LabelToolTip = value.ToString(); // 鼠标放在标签上的提示
                series.Points[i].ToolTip = value.ToString(); // 鼠标放在图形上的提示

                // 更具图形的样式设置显示的形式和内容
                if (chartType == SeriesChartType.Pie)  // 饼图
                {
                    series.Points[i].Label = "#AXISLABEL(#PERCENT)"; // X轴百分比
                    series["PieLabelStyle"] = "Outside"; //在外侧显示Lable
                    // series["PieLabelStyle"] = "Inside";
                    series["PieLineColor"] = "Black";//绘制连线
                }
                else if (chartType == SeriesChartType.Doughnut) // 圆环图
                {
                    series.Points[i].Label = "#AXISLABEL   (#PERCENT)";
                    series["PieLabelStyle"] = "Inside";
                }
                else
                {
                    // 其他图形,显示百分比或数值

                    series.Points[i].Label = "(#PERCENT)";
                }

                if (chartType != SeriesChartType.Pie)
                {

                    series.Points[i].AxisLabel = string.Format("{0} {1}", text, value);
                }
                

            }
            // 设置图表绘图区域的x和y的坐标值 (Y:表示具体要显示的数值之间的间隔)

            this._Chart.ChartAreas[0].AxisY.Interval = 10;
            this._Chart.ChartAreas[0].AxisX.Interval = 1;

        }

    }
}
