Imports Microsoft.VisualBasic
Imports System
Imports System.Windows.Forms
Imports DevExpress.XtraCharts

Namespace XtraChart_PointOptions
	Partial Public Class Form1
		Inherits Form
		Public Sub New()
			InitializeComponent()
		End Sub

		Private Sub Form1_Load(ByVal sender As Object, ByVal e As EventArgs) Handles MyBase.Load
			' Create an empty chart.
			Dim pieChart As New ChartControl()

			' Create a pie series.
			Dim series1 As New Series("A Pie Series", ViewType.Pie)

			' Populate the series with points.
			series1.Points.Add(New SeriesPoint("Russia", 17.0752))
			series1.Points.Add(New SeriesPoint("Canada", 9.98467))
			series1.Points.Add(New SeriesPoint("USA", 9.63142))
			series1.Points.Add(New SeriesPoint("China", 9.59696))
			series1.Points.Add(New SeriesPoint("Brazil", 8.511965))
			series1.Points.Add(New SeriesPoint("Australia", 7.68685))
			series1.Points.Add(New SeriesPoint("India", 3.28759))
			series1.Points.Add(New SeriesPoint("Others", 81.2))

			' Add the series to the chart.
			pieChart.Series.Add(series1)

			' Adjust the text pattern of the series label.
			Dim label As PieSeriesLabel = CType(series1.Label, PieSeriesLabel)
			label.TextPattern = "{A}: {VP:P0}"

			' Detect overlapping of series labels.
			label.ResolveOverlappingMode = ResolveOverlappingMode.Default

			' Add the chart to the form.
			pieChart.Dock = DockStyle.Fill
			Me.Controls.Add(pieChart)
		End Sub
	End Class
End Namespace
