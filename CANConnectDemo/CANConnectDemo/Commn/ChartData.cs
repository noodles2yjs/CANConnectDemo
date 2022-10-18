using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CANConnectDemo
{
    /// <summary>
    /// Chart 实体类
    /// </summary>
   public class ChartData
    {
        public ChartData()
        {
            
        }
        public ChartData(string text,double value)
        {
            this.Text = text;
            this.Value = value;
        }

        // 显示的文本
        public string Text { get; set; }
        // 显示的数值
        public double Value { get; set; }
    }
}
