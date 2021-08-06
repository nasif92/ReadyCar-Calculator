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
            DevExpress.DataAccess.Excel.FieldInfo fieldInfo4 = new DevExpress.DataAccess.Excel.FieldInfo();
            DevExpress.DataAccess.Excel.FieldInfo fieldInfo5 = new DevExpress.DataAccess.Excel.FieldInfo();
            DevExpress.DataAccess.Excel.FieldInfo fieldInfo6 = new DevExpress.DataAccess.Excel.FieldInfo();
            DevExpress.DataAccess.Excel.CsvSourceOptions csvSourceOptions2 = new DevExpress.DataAccess.Excel.CsvSourceOptions();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ChartsForm));
            DevExpress.XtraCharts.ChartTitle chartTitle4 = new DevExpress.XtraCharts.ChartTitle();
            DevExpress.XtraCharts.ChartTitle chartTitle5 = new DevExpress.XtraCharts.ChartTitle();
            DevExpress.XtraCharts.XYDiagram xyDiagram2 = new DevExpress.XtraCharts.XYDiagram();
            DevExpress.XtraCharts.Series series2 = new DevExpress.XtraCharts.Series();
            DevExpress.XtraCharts.PieSeriesView pieSeriesView2 = new DevExpress.XtraCharts.PieSeriesView();
            DevExpress.XtraCharts.ChartTitle chartTitle6 = new DevExpress.XtraCharts.ChartTitle();
            this.excelDataSource1 = new DevExpress.DataAccess.Excel.ExcelDataSource();
            this.xtraScrollableControl1 = new DevExpress.XtraEditors.XtraScrollableControl();
            this.PieChartCostReportCategory = new DevExpress.XtraCharts.ChartControl();
            this.chartControlPie = new DevExpress.XtraCharts.ChartControl();
            this.chartControlhistogram = new DevExpress.XtraCharts.ChartControl();
            this.PieChartCostResourceType = new DevExpress.XtraCharts.ChartControl();
            this.xtraScrollableControl1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.PieChartCostReportCategory)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.chartControlPie)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.chartControlhistogram)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.PieChartCostResourceType)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(xyDiagram2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(series2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(pieSeriesView2)).BeginInit();
            this.SuspendLayout();
            // 
            // excelDataSource1
            // 
            this.excelDataSource1.FileName = "E:\\nasif\\ContractReqExtraction\\Tool\\trunk\\ContractExtraction\\ContractExtraction\\b" +
    "in\\Debug\\predefined_data_values\\resources.csv";
            this.excelDataSource1.Name = "excelDataSource1";
            this.excelDataSource1.ResultSchemaSerializable = "PFZpZXc+PEZpZWxkIE5hbWU9IlJlc291cmNlIFR5cGUiIFR5cGU9IlN0cmluZyIgLz48RmllbGQgTmFtZ" +
    "T0iQXZlcmFnZSBSYXRlICgkKSIgVHlwZT0iRG91YmxlIiAvPjwvVmlldz4=";
            fieldInfo4.Name = "Resource Type";
            fieldInfo4.Type = typeof(string);
            fieldInfo5.Name = "Average Rate ($)";
            fieldInfo5.Type = typeof(double);
            fieldInfo6.Name = "Note";
            fieldInfo6.Selected = false;
            fieldInfo6.Type = typeof(string);
            this.excelDataSource1.Schema.AddRange(new DevExpress.DataAccess.Excel.FieldInfo[] {
            fieldInfo4,
            fieldInfo5,
            fieldInfo6});
            csvSourceOptions2.Culture = new System.Globalization.CultureInfo("");
            csvSourceOptions2.DetectNewlineType = true;
            csvSourceOptions2.DetectValueSeparator = true;
            csvSourceOptions2.Encoding = ((System.Text.Encoding)(resources.GetObject("csvSourceOptions2.Encoding")));
            this.excelDataSource1.SourceOptions = csvSourceOptions2;
            // 
            // xtraScrollableControl1
            // 
            this.xtraScrollableControl1.Controls.Add(this.PieChartCostReportCategory);
            this.xtraScrollableControl1.Controls.Add(this.chartControlPie);
            this.xtraScrollableControl1.Controls.Add(this.chartControlhistogram);
            this.xtraScrollableControl1.Controls.Add(this.PieChartCostResourceType);
            this.xtraScrollableControl1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.xtraScrollableControl1.Location = new System.Drawing.Point(0, 0);
            this.xtraScrollableControl1.Name = "xtraScrollableControl1";
            this.xtraScrollableControl1.Size = new System.Drawing.Size(1430, 683);
            this.xtraScrollableControl1.TabIndex = 2;
            // 
            // PieChartCostReportCategory
            // 
            this.PieChartCostReportCategory.Legend.Name = "Default Legend";
            this.PieChartCostReportCategory.Location = new System.Drawing.Point(783, 495);
            this.PieChartCostReportCategory.Name = "PieChartCostReportCategory";
            this.PieChartCostReportCategory.SeriesSerializable = new DevExpress.XtraCharts.Series[0];
            this.PieChartCostReportCategory.Size = new System.Drawing.Size(647, 390);
            this.PieChartCostReportCategory.TabIndex = 5;
            // 
            // chartControlPie
            // 
            this.chartControlPie.Legend.Name = "Default Legend";
            this.chartControlPie.Location = new System.Drawing.Point(783, 12);
            this.chartControlPie.Name = "chartControlPie";
            this.chartControlPie.SeriesSerializable = new DevExpress.XtraCharts.Series[0];
            this.chartControlPie.Size = new System.Drawing.Size(596, 435);
            this.chartControlPie.TabIndex = 4;
            chartTitle4.Text = "Pie chart";
            this.chartControlPie.Titles.AddRange(new DevExpress.XtraCharts.ChartTitle[] {
            chartTitle4});
            // 
            // chartControlhistogram
            // 
            this.chartControlhistogram.Legend.Name = "Default Legend";
            this.chartControlhistogram.Location = new System.Drawing.Point(24, 12);
            this.chartControlhistogram.Name = "chartControlhistogram";
            this.chartControlhistogram.SeriesSerializable = new DevExpress.XtraCharts.Series[0];
            this.chartControlhistogram.Size = new System.Drawing.Size(686, 435);
            this.chartControlhistogram.TabIndex = 3;
            chartTitle5.Text = "Sample Data";
            this.chartControlhistogram.Titles.AddRange(new DevExpress.XtraCharts.ChartTitle[] {
            chartTitle5});
            this.chartControlhistogram.DoubleClick += new System.EventHandler(this.chartControlhistogram_DoubleClick);
            // 
            // PieChartCostResourceType
            // 
            this.PieChartCostResourceType.DataSource = this.excelDataSource1;
            xyDiagram2.AxisX.VisibleInPanesSerializable = "-1";
            xyDiagram2.AxisY.VisibleInPanesSerializable = "-1";
            this.PieChartCostResourceType.Diagram = xyDiagram2;
            this.PieChartCostResourceType.Legend.Name = "Default Legend";
            this.PieChartCostResourceType.Location = new System.Drawing.Point(55, 495);
            this.PieChartCostResourceType.Name = "PieChartCostResourceType";
            this.PieChartCostResourceType.SeriesDataMember = "Resource Type";
            series2.DataSource = this.excelDataSource1;
            series2.Name = "Series 1";
            series2.View = pieSeriesView2;
            this.PieChartCostResourceType.SeriesSerializable = new DevExpress.XtraCharts.Series[] {
        series2};
            this.PieChartCostResourceType.SeriesTemplate.ArgumentDataMember = "Resource Type";
            this.PieChartCostResourceType.SeriesTemplate.SeriesDataMember = "Resource Type";
            this.PieChartCostResourceType.SeriesTemplate.ValueDataMembersSerializable = "Average Rate ($)";
            this.PieChartCostResourceType.Size = new System.Drawing.Size(638, 408);
            this.PieChartCostResourceType.TabIndex = 2;
            chartTitle6.Text = "Resources";
            this.PieChartCostResourceType.Titles.AddRange(new DevExpress.XtraCharts.ChartTitle[] {
            chartTitle6});
            this.PieChartCostResourceType.DoubleClick += new System.EventHandler(this.chartControlhistogram_DoubleClick);
            // 
            // ChartsForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1430, 683);
            this.Controls.Add(this.xtraScrollableControl1);
            this.Name = "ChartsForm";
            this.Text = "ChartsForm";
            this.Load += new System.EventHandler(this.ChartsForm_Load);
            this.xtraScrollableControl1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.PieChartCostReportCategory)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.chartControlPie)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.chartControlhistogram)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(xyDiagram2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(pieSeriesView2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(series2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.PieChartCostResourceType)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private DevExpress.DataAccess.Excel.ExcelDataSource excelDataSource1;
        private DevExpress.XtraEditors.XtraScrollableControl xtraScrollableControl1;
        private DevExpress.XtraCharts.ChartControl PieChartCostResourceType;
        private DevExpress.XtraCharts.ChartControl chartControlhistogram;
        private DevExpress.XtraCharts.ChartControl chartControlPie;
        private DevExpress.XtraCharts.ChartControl PieChartCostReportCategory;
    }
}