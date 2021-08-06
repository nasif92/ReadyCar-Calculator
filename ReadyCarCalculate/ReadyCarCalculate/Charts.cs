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
using DevExpress.XtraCharts;

namespace ReadyCarCalculate
{
    public partial class Charts : DevExpress.XtraEditors.XtraForm
    {
        private OuterForm OuterForm;
        public Charts(OuterForm outer)
        {
            InitializeComponent();
            this.OuterForm = outer;
        }


        private void Charts_Load(object sender, EventArgs e)
        {
            chartControlPie.Titles.Add(new ChartTitle() { Text = "Customers added" });
            var piechartSeries = new Series("SAMPLE DATA", ViewType.Pie);
            piechartSeries.DataSource = DataPoints.GetDataPoints();
            piechartSeries.ArgumentDataMember = "Argument";
            piechartSeries.ValueDataMembers.AddRange(new string[] { "Value" });
            chartControlPie.Series.Add(piechartSeries);
            // Format the series legend items.
            piechartSeries.LegendTextPattern = "{A}";
            chartControlPie.Legend.Visibility = DevExpress.Utils.DefaultBoolean.True;

            /*customers.Points.AddRange(
                new SeriesPoint("Bran", 25),
                new SeriesPoint("Kirvy",25),
                new SeriesPoint("Whis", 25)
                // and another points.
            );*/
            // The Points collection provides  Add...Point methods 
            // that allow you to add series points for different view types.
            //customers.Points.AddPoint("Bob", 22);
            //customers.Points.AddBubblePoint("Chill", 2, 1.0);

            double[] sampleData = new double[500];
            Random rnd = new Random();
            int start = 5;
            int end = 10;
            int[] values = { 1, 2, 3, 4, 5 };
            int[] test = { 1, 2, 3, 4, 5, 6, 6, 7, 8, 9, 9 };
            for (int i = 0; i < sampleData.Length; i++)
                sampleData[i] = rnd.NextDouble() * 100.0;

            var histogram = new Series("Sample values 1", ViewType.Bar);
            //var histogram2 = new Series("Sample values 2", ViewType.Bar);
            //chartControl1.Titles.Add(new ChartTitle() { Text = "Customers added" });

            histogram.DataSource = test;
            //histogram2.DataSource = values;

            // histogram 2


            //histogram.ArgumentDataMember = "Data types";
            chartControl1.Series.Add(histogram);
            // chartControl1.Series.Add(histogram2);

            //var diagram = (XYDiagram)chartControl1.Diagram;
           // chartControl2.Series.Add(piechartSeries);
            //chartControl2.Series.Add(histogram2);

            //XYDiagram diagram2 = chartControl2.Diagram as XYDiagram;
            //var scaleOptions = diagram2.AxisX.NumericScaleOptions;
            //diagram2.AxisX.NumericScaleOptions.IntervalOptions.DivisionMode = IntervalDivisionMode.Count;
            //diagram2.AxisX.NumericScaleOptions.IntervalOptions.Count = 5;
            //...
            // diagram.AxisX.NumericScaleOptions.IntervalOptions.DivisionMode = IntervalDivisionMode.Count;
            //  diagram.AxisX.NumericScaleOptions.IntervalOptions.Count = 3;
            // scaleOptions.AggregateFunction = AggregateFunction.Histogram;

            //scaleOptions.ScaleMode = ScaleMode.Manual;
            /*

            scaleOptions.IntervalOptions.Pattern = "{1} - {5}";
            */
            // var barchart = new Series("")
        }
    }
    public class DataPoints
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