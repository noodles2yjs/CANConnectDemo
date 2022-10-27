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
    public partial class FrmShowCurvePId : Form
    {
        private List<DataGridViewRow> _dgvrs;
        private List<string> _cols;

      //  private Chart chartPId;
        public FrmShowCurvePId( List<DataGridViewRow> dgvrs,List<string> cols)
        {
            this._cols = cols;
            this._dgvrs = dgvrs;
            InitializeComponent();
            InitChart1PId();
        }

        /// <summary>
        /// 初始化Chart1PId
        /// </summary>
        private void InitChart1PId()
        {
            // Set up Chart1PId
           
            this.chart1PId.Series.Clear();
            int n = 0;
            foreach (var dgvr in this._dgvrs)
            {
                n++;
                var series = chart1PId.Series.Add("series" + n);
                series.ChartType = SeriesChartType.Line;
            }

            // Fill in all values from the dgv to the chart ChartPId
            for (int i = 0; i < this._dgvrs.Count; i++)
            {
                chart1PId.Series[i].XAxisType = AxisType.Primary;

                for (int j = 1; j < this._cols.Count; j++)
                {
                    chart1PId.Series[i].Points.AddXY(this._cols[j], Convert.ToDouble(this._dgvrs[i].Cells[j].Value));
                }
            }

           
        }

      

    }
}
