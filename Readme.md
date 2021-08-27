<!-- default badges list -->
![](https://img.shields.io/endpoint?url=https://codecentral.devexpress.com/api/v1/VersionRange/134061491/14.1.3%2B)
[![](https://img.shields.io/badge/Open_in_DevExpress_Support_Center-FF7200?style=flat-square&logo=DevExpress&logoColor=white)](https://supportcenter.devexpress.com/ticket/details/E3801)
[![](https://img.shields.io/badge/📖_How_to_use_DevExpress_Examples-e9f6fc?style=flat-square)](https://docs.devexpress.com/GeneralInformation/403183)
<!-- default badges end -->
<!-- default file list -->
*Files to look at*:

* [Form1.cs](./CS/XtraChart_PointOptions/Form1.cs) (VB: [Form1.vb](./VB/XtraChart_PointOptions/Form1.vb))
<!-- default file list end -->
# OBSOLETE -  How to adjust  point options of the Pie series view type at runtime
<!-- run online -->
**[[Run Online]](https://codecentral.devexpress.com/e3801)**
<!-- run online end -->


<p>The following example demonstrates how to specify the appearance of series labels in the Pie chart using its point options.</p>
<p><strong>NOTE</strong>: Starting from v2014 vol 1, text pattern properties (<a href="https://documentation.devexpress.com/#CoreLibraries/DevExpressXtraChartsAxisLabel_TextPatterntopic">AxisLabel.TextPattern</a>, <a href="https://documentation.devexpress.com/#CoreLibraries/DevExpressXtraChartsSeriesLabelBase_TextPatterntopic">SeriesLabelBase.TextPattern</a>, <a href="https://documentation.devexpress.com/#CoreLibraries/DevExpressXtraChartsSeriesBase_LegendTextPatterntopic">SeriesBase.LegendTextPattern</a>) have been introduced instead of point options. <br />Text pattern properties simplify text customization of series labels, axis labels and legend items (when the <a href="https://documentation.devexpress.com/#CoreLibraries/DevExpressXtraChartsSeriesViewColorEachSupportBase_ColorEachtopic">SeriesViewColorEachSupportBase.ColorEach </a> mode is enabled)</p>


<h3>Description</h3>

<p>To accomplish this at runtime, it is necessary to handle the<strong> Form.Load</strong> event and then transform series labels of the <a href="https://documentation.devexpress.com/#CoreLibraries/clsDevExpressXtraChartsSeriestopic">Series</a>&nbsp;object to the corresponding labels of the <a href="https://documentation.devexpress.com/#CoreLibraries/clsDevExpressXtraChartsPieSeriesLabeltopic">PieSeriesLabel</a>&nbsp; object. <br />And finally, specify the pattern for series labels using&nbsp;the&nbsp;<a href="https://documentation.devexpress.com/#CoreLibraries/DevExpressXtraChartsSeriesLabelBase_TextPatterntopic">SeriesLabelBase.TextPattern</a>&nbsp; property.</p>

<br/>


