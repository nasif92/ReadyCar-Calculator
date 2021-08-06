using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;
using DevExpress.XtraEditors;
using DevExpress.XtraCharts;
using System.Collections;

namespace ReadyCarCalculate
{
    public partial class ChartsForm : Form
    {
        private OuterForm OuterForm;
        public ChartsForm(OuterForm outerForm)
        {
            InitializeComponent();
            this.OuterForm = outerForm;
            // histogram 1
            double[] sampleData = new double[500];
            Random rnd = new Random();
            int[] test = { 1, 2, 3, 4, 5, 6, 6, 7, 8, 9, 9 };

            for (int i = 0; i < sampleData.Length; i++)
                sampleData[i] = rnd.NextDouble() * 100.0;

            Series series = new Series();
            series.DataSource = sampleData;
            chartControlhistogram.Series.Add(series);
            var diagram = (XYDiagram)chartControlhistogram.Diagram;
            diagram.EnableAxisXZooming = true;
            diagram.EnableAxisYZooming = true;
            diagram.EnableAxisXScrolling = true;
            diagram.EnableAxisYScrolling = true;
            var scaleOptions = diagram.AxisX.NumericScaleOptions;
            scaleOptions.AggregateFunction = AggregateFunction.Histogram;
            scaleOptions.ScaleMode = ScaleMode.Interval;


        }

        private void ChartsForm_Load(object sender, EventArgs e)
        {
           // the first pie chart
            Series piechartSeries = new Series("SAMPLE DATA", ViewType.Pie);
            piechartSeries.DataSource = DataPoint.GetDataPoints();
            piechartSeries.ArgumentDataMember = "Argument";
            piechartSeries.ValueDataMembers.AddRange(new string[] { "Value" });
            chartControlPie.Series.Add(piechartSeries);
           
            piechartSeries.LegendTextPattern = "{A}";
            chartControlPie.Legend.Visibility = DevExpress.Utils.DefaultBoolean.True;

            // test data
            /*
            double[] sampleData = new double[500];
            Random rnd = new Random();
            int start = 5;
            int end = 10;
            int[] values = { 1,2,3,4,5};
            int[] test = { 1, 2, 3, 4, 5 ,6,6,7,8,9,9};
            for (int i = 0; i < sampleData.Length; i++)
                sampleData[i] = rnd.NextDouble() * 100.0;

            var histogram = new Series("Sample values 1", ViewType.Bar);
            var histogram2 = new Series("Sample values 2", ViewType.Bar);
            histogram2.DataSource = values;

            // piechart 2
            // Create a list.
            ArrayList listDataSource = new ArrayList();

            // Populate the list with records.
            listDataSource.Add(new Record(1, "Jane", 19));
            listDataSource.Add(new Record(2, "Joe", 30));
            listDataSource.Add(new Record(3, "Bill", 15));
            listDataSource.Add(new Record(4, "Michael", 42));

            // Bind the chart to the list.
            ChartControl myChart = PieChartCostReportCategory;
            myChart.DataSource = listDataSource;

            // Create a series, and add it to the chart.
            Series series1 = new Series("My Series", ViewType.Pie);
            myChart.Series.Add(series1);

            // Adjust the series data members.
            series1.ArgumentDataMember = "name";
            series1.ValueDataMembers.AddRange(new string[] { "age" });

            // Access the view-type-specific options of the series.
           // ((PieSeriesView)series1.View).ColorEach = true;
            series1.LegendPointOptions.Pattern = "{A}";
            */
        }
        private void ShowChartPreview(ChartControl chart)
        {
            // Check whether the ChartControl can be previewed.
            if (!chart.IsPrintingAvailable)
            {
                MessageBox.Show("The 'DevExpress.XtraPrinting.v7.2.dll' is not found", "Error");
                return;
            }
            // Open the Preview window.
            chart.ShowPrintPreview();
        }

        private void PrintChart(ChartControl chart)
        {
            // Check whether the ChartControl can be printed.
            if (!chart.IsPrintingAvailable)
            {
                MessageBox.Show("The 'DevExpress.XtraPrinting.v7.2.dll' is not found", "Error");
                return;
            }
            // Print.
            chart.Print();
        }


        private void chartControlhistogram_DoubleClick(object sender, EventArgs e)
        {
            ChartControl chart = sender as ChartControl;
            ShowChartPreview(chart);
        }
    }

    internal class Record
    {
        int id, age;
        string name;
        public Record(int id, string name, int age)
        {
            this.id = id;
            this.name = name;
            this.age = age;
        }
        public int ID
        {
            get { return id; }
            set { id = value; }
        }
        public string Name
        {
            get { return name; }
            set { name = value; }
        }
        public int Age
        {
            get { return age; }
            set { age = value; }
        }
    }

    public class DataPoint
    {
        public string Argument { get; set; }
        public double Value { get; set; }

        public static List<DataPoint> GetDataPoints()
        {
            return new List<DataPoint> {
                    new DataPoint { Argument = "Russia",    Value = 17.0752},
                    new DataPoint { Argument = "Canada",    Value = 9.98467},
                    new DataPoint { Argument = "USA",       Value = 9.63142},
                    new DataPoint { Argument = "China",     Value = 9.59696},
                    new DataPoint { Argument = "Brazil",    Value = 8.511965},
                    new DataPoint { Argument = "Australia", Value = 7.68685},
                    new DataPoint { Argument = "India",     Value = 3.28759},
                    new DataPoint { Argument = "Others",    Value = 81.2}
                };
        }
    }
}