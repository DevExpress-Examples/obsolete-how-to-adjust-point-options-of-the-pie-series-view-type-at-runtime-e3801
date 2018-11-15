<!-- default file list -->
*Files to look at*:

* [Form1.cs](./CS/XtraChart_PointOptions/Form1.cs) (VB: [Form1.vb](./VB/XtraChart_PointOptions/Form1.vb))
<!-- default file list end -->
# OBSOLETE -  How to adjust  point options of the Pie series view type at runtime


<p>The following example demonstrates how to specify the appearance of series labels in the Pie chart using its point options.</p>
<p><strong>NOTE</strong>: Starting from v2014 vol 1, text pattern properties (<a href="https://documentation.devexpress.com/#CoreLibraries/DevExpressXtraChartsAxisLabel_TextPatterntopic">AxisLabel.TextPattern</a>, <a href="https://documentation.devexpress.com/#CoreLibraries/DevExpressXtraChartsSeriesLabelBase_TextPatterntopic">SeriesLabelBase.TextPattern</a>, <a href="https://documentation.devexpress.com/#CoreLibraries/DevExpressXtraChartsSeriesBase_LegendTextPatterntopic">SeriesBase.LegendTextPattern</a>) have been introduced instead of point options. <br />Text pattern properties simplify text customization of series labels, axis labels and legend items (when the <a href="https://documentation.devexpress.com/#CoreLibraries/DevExpressXtraChartsSeriesViewColorEachSupportBase_ColorEachtopic">SeriesViewColorEachSupportBase.ColorEach </a> mode is enabled)</p>


<h3>Description</h3>

<p>To accomplish this at runtime, it is necessary to handle the <strong>Form.Load</strong> event and then transform series labels of the <a href="http://documentation.devexpress.com/#XtraCharts/clsDevExpressXtraChartsSeriestopic"><u>Series</u></a> object to the corresponding labels of the <a href="http://documentation.devexpress.com/#XtraCharts/clsDevExpressXtraChartsPieSeriesLabeltopic"><u>PieSeriesLabel</u></a> object.</p>
<p>And finally, get access to the point view and point value numeric options via the <a href="http://documentation.devexpress.com/#XtraCharts/DevExpressXtraChartsPointOptions_PointViewtopic"><u>PointOptions.PointView</u></a> and <a href="http://documentation.devexpress.com/#XtraCharts/DevExpressXtraChartsPointOptions_ValueNumericOptionstopic"><u>PointOptions.ValueNumericOptions</u></a> properties correspondingly.</p>

<br/>


