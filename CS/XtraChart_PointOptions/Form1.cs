using System;
using System.Windows.Forms;
using DevExpress.XtraCharts;

namespace XtraChart_PointOptions {
    public partial class Form1 : Form {
        public Form1() {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e) {
            // Create an empty chart.
            ChartControl pieChart = new ChartControl();

            // Create a pie series.
            Series series1 = new Series("A Pie Series", ViewType.Pie);

            // Populate the series with points.
            series1.Points.Add(new SeriesPoint("Russia", 17.0752));
            series1.Points.Add(new SeriesPoint("Canada", 9.98467));
            series1.Points.Add(new SeriesPoint("USA", 9.63142));
            series1.Points.Add(new SeriesPoint("China", 9.59696));
            series1.Points.Add(new SeriesPoint("Brazil", 8.511965));
            series1.Points.Add(new SeriesPoint("Australia", 7.68685));
            series1.Points.Add(new SeriesPoint("India", 3.28759));
            series1.Points.Add(new SeriesPoint("Others", 81.2));

            // Add the series to the chart.
            pieChart.Series.Add(series1);

            // Adjust the text pattern of the series label.
            PieSeriesLabel label = (PieSeriesLabel)series1.Label;
            label.TextPattern = "{A}: {VP:P0}";

            // Detect overlapping of series labels.
            label.ResolveOverlappingMode = ResolveOverlappingMode.Default;

            // Add the chart to the form.
            pieChart.Dock = DockStyle.Fill;
            this.Controls.Add(pieChart);
        }
    }
}
