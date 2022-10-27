
namespace CANConnectDemo
{
    partial class FrmShowCurveTempProtection
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea1 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Legend legend1 = new System.Windows.Forms.DataVisualization.Charting.Legend();
            System.Windows.Forms.DataVisualization.Charting.Series series1 = new System.Windows.Forms.DataVisualization.Charting.Series();
            this.chart1TempProtection = new System.Windows.Forms.DataVisualization.Charting.Chart();
            ((System.ComponentModel.ISupportInitialize)(this.chart1TempProtection)).BeginInit();
            this.SuspendLayout();
            // 
            // chart1TempProtection
            // 
            chartArea1.AxisX.IntervalAutoMode = System.Windows.Forms.DataVisualization.Charting.IntervalAutoMode.VariableCount;
            chartArea1.AxisX.IsLabelAutoFit = false;
            chartArea1.AxisX.LabelStyle.IsStaggered = true;
            chartArea1.Name = "ChartArea1";
            this.chart1TempProtection.ChartAreas.Add(chartArea1);
            legend1.Name = "Legend1";
            this.chart1TempProtection.Legends.Add(legend1);
            this.chart1TempProtection.Location = new System.Drawing.Point(178, 72);
            this.chart1TempProtection.Name = "chart1TempProtection";
            series1.ChartArea = "ChartArea1";
            series1.Legend = "Legend1";
            series1.Name = "Series1";
            this.chart1TempProtection.Series.Add(series1);
            this.chart1TempProtection.Size = new System.Drawing.Size(711, 300);
            this.chart1TempProtection.TabIndex = 0;
            this.chart1TempProtection.Text = "chart1";
            // 
            // FrmShowCurveTempProtection
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(96F, 96F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Dpi;
            this.ClientSize = new System.Drawing.Size(1034, 529);
            this.Controls.Add(this.chart1TempProtection);
            this.Font = new System.Drawing.Font("宋体", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.Name = "FrmShowCurveTempProtection";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "FrmShowCurveTempProtection";
            ((System.ComponentModel.ISupportInitialize)(this.chart1TempProtection)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataVisualization.Charting.Chart chart1TempProtection;
    }
}