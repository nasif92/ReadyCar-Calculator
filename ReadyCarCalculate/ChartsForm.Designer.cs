namespace ReadyCarCalculate
{
    partial class ChartsForm
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
            DevExpress.XtraCharts.Series series1 = new DevExpress.XtraCharts.Series();
            DevExpress.XtraCharts.PieSeriesView pieSeriesView1 = new DevExpress.XtraCharts.PieSeriesView();
            this.chartControl1 = new DevExpress.XtraCharts.ChartControl();
            this.chartControlPie = new DevExpress.XtraCharts.ChartControl();
            this.chartControl2 = new DevExpress.XtraCharts.ChartControl();
            ((System.ComponentModel.ISupportInitialize)(this.chartControl1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.chartControlPie)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(series1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(pieSeriesView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.chartControl2)).BeginInit();
            this.SuspendLayout();
            // 
            // chartControl1
            // 
            this.chartControl1.Legend.Name = "Default Legend";
            this.chartControl1.Location = new System.Drawing.Point(115, 12);
            this.chartControl1.Name = "chartControl1";
            this.chartControl1.SeriesSerializable = new DevExpress.XtraCharts.Series[0];
            this.chartControl1.Size = new System.Drawing.Size(461, 414);
            this.chartControl1.TabIndex = 0;
            // 
            // chartControlPie
            // 
            this.chartControlPie.Legend.Name = "Default Legend";
            this.chartControlPie.Location = new System.Drawing.Point(630, 98);
            this.chartControlPie.Name = "chartControlPie";
            series1.Name = "Customers";
            series1.View = pieSeriesView1;
            this.chartControlPie.SeriesSerializable = new DevExpress.XtraCharts.Series[] {
        series1};
            this.chartControlPie.Size = new System.Drawing.Size(431, 312);
            this.chartControlPie.TabIndex = 1;
            // 
            // chartControl2
            // 
            this.chartControl2.Legend.Name = "Default Legend";
            this.chartControl2.Location = new System.Drawing.Point(425, 450);
            this.chartControl2.Name = "chartControl2";
            this.chartControl2.SeriesSerializable = new DevExpress.XtraCharts.Series[0];
            this.chartControl2.Size = new System.Drawing.Size(461, 414);
            this.chartControl2.TabIndex = 2;
            // 
            // ChartsForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1251, 683);
            this.Controls.Add(this.chartControl2);
            this.Controls.Add(this.chartControlPie);
            this.Controls.Add(this.chartControl1);
            this.Name = "ChartsForm";
            this.Text = "ChartsForm";
            this.Load += new System.EventHandler(this.ChartsForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.chartControl1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(pieSeriesView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(series1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.chartControlPie)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.chartControl2)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private DevExpress.XtraCharts.ChartControl chartControl1;
        private DevExpress.XtraCharts.ChartControl chartControlPie;
        private DevExpress.XtraCharts.ChartControl chartControl2;
    }
}