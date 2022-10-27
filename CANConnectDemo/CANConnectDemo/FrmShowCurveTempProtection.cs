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
    public partial class FrmShowCurveTempProtection : Form
    {
        private List<DataGridViewRow> _dgvrs;
        private List<string> _cols;
        public FrmShowCurveTempProtection( List<DataGridViewRow> dgvrs,List<string> cols)
        {
            this._dgvrs = dgvrs;
            this._cols = cols;
            InitializeComponent();
            Initchart1TempProtection();
        }

        private void Initchart1TempProtection()
        {
            // Set up chart1TempProtection

            this.chart1TempProtection.Series.Clear();
            int n = 0;
            foreach (var dgvr in this._dgvrs)
            {
                n++;
                var series = chart1TempProtection.Series.Add("series" + n);
                series.ChartType = SeriesChartType.Line;
            }

            // Fill in all values from the dgv to the chart ChartPId
            for (int i = 0; i < this._dgvrs.Count; i++)
            {
                chart1TempProtection.Series[i].XAxisType = AxisType.Primary;

                for (int j = 1; j < this._cols.Count; j++)
                {
                    chart1TempProtection.Series[i].Points.AddXY(this._cols[j], Convert.ToDouble(this._dgvrs[i].Cells[j].Value));
                }
            }


        }
    }
}
