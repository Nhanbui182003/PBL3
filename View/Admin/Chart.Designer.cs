namespace PBL3.View.Admin
{
    partial class Chart
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
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea2 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Legend legend2 = new System.Windows.Forms.DataVisualization.Charting.Legend();
            System.Windows.Forms.DataVisualization.Charting.Series series2 = new System.Windows.Forms.DataVisualization.Charting.Series();
            this.LbTK = new System.Windows.Forms.Label();
            this.renevueChart = new System.Windows.Forms.DataVisualization.Charting.Chart();
            ((System.ComponentModel.ISupportInitialize)(this.renevueChart)).BeginInit();
            this.SuspendLayout();
            // 
            // LbTK
            // 
            this.LbTK.AutoSize = true;
            this.LbTK.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LbTK.Location = new System.Drawing.Point(189, 36);
            this.LbTK.Name = "LbTK";
            this.LbTK.Size = new System.Drawing.Size(384, 24);
            this.LbTK.TabIndex = 3;
            this.LbTK.Text = "BIỂU ĐỒ THỐNG KÊ DOANH THU NĂM ";
            // 
            // renevueChart
            // 
            chartArea2.Name = "ChartArea1";
            this.renevueChart.ChartAreas.Add(chartArea2);
            legend2.Name = "Legend1";
            this.renevueChart.Legends.Add(legend2);
            this.renevueChart.Location = new System.Drawing.Point(12, 102);
            this.renevueChart.Name = "renevueChart";
            series2.ChartArea = "ChartArea1";
            series2.Legend = "Legend1";
            series2.Name = "Series1";
            this.renevueChart.Series.Add(series2);
            this.renevueChart.Size = new System.Drawing.Size(776, 300);
            this.renevueChart.TabIndex = 4;
            this.renevueChart.Text = "chart1";
            // 
            // Chart
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.renevueChart);
            this.Controls.Add(this.LbTK);
            this.Name = "Chart";
            this.Text = "BIỂU ĐỒ THỐNG KÊ DOANH THU";
            ((System.ComponentModel.ISupportInitialize)(this.renevueChart)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label LbTK;
        private System.Windows.Forms.DataVisualization.Charting.Chart renevueChart;
    }
}