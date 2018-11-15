<!-- default file list -->
*Files to look at*:

* [Form1.cs](./CS/WindowsFormsApplication1/Form1.cs) (VB: [Form1.vb](./VB/WindowsFormsApplication1/Form1.vb))
* [Program.cs](./CS/WindowsFormsApplication1/Program.cs) (VB: [Program.vb](./VB/WindowsFormsApplication1/Program.vb))
<!-- default file list end -->
# How to configure Linear Gauge to fill all space if width exceeds height significantly


<p>The default <a href="https://documentation.devexpress.com/#WindowsForms/CustomDocument4751">Linear Gauge</a> has 1:2 size proportion: <a href="https://documentation.devexpress.com/#WindowsForms/CustomDocument18220">Coordinate System</a>. This means that you are not able to resize it wider in automatic mode. If you simplify the gauge layout (e.g. remove  <a href="https://documentation.devexpress.com/#WindowsForms/CustomDocument11503">Background Layer</a>) and enable the <a href="https://documentation.devexpress.com/#WindowsForms/DevExpressXtraGaugesWinGaugesLinearLinearGauge_AutoSizetopic">AutoSize Property</a>, the gauge proportion will be recalculated automatically based on the current gauge layout. The following gauge has 1:4 height to width proportion. </p>
<img src="https://raw.githubusercontent.com/DevExpress-Examples/how-to-configure-linear-gauge-to-fill-all-space-if-width-exceeds-height-significantly-t158525/14.1.7+/media/3502ad27-4ec0-11e4-80ba-00155d624807.png"><br /><br />
<p>This example demonstrates how to scale the gauge horizontally to achieve the following result:</p>
<img src="https://raw.githubusercontent.com/DevExpress-Examples/how-to-configure-linear-gauge-to-fill-all-space-if-width-exceeds-height-significantly-t158525/14.1.7+/media/97aa6654-4ec0-11e4-80ba-00155d624807.png"><br />
<p><br />To accomplish this task, it is necessary to disable the <a href="https://documentation.devexpress.com/#WindowsForms/DevExpressXtraGaugesWinGaugesLinearLinearGauge_AutoSizetopic">AutoSize Property</a> and calculate <a href="https://documentation.devexpress.com/#CoreLibraries/DevExpressXtraGaugesCoreModelBaseGauge_Boundstopic">Bounds</a> manually to correctly align the gauge inside <a href="https://documentation.devexpress.com/#WindowsForms/clsDevExpressXtraGaugesWinGaugeControltopic">GaugeControl</a>. In addition, set <a href="https://documentation.devexpress.com/#CoreLibraries/DevExpressXtraGaugesCoreModelLinearScale_StartPointtopic">StartPoint</a> and <a href="https://documentation.devexpress.com/#CoreLibraries/DevExpressXtraGaugesCoreModelLinearScale_EndPointtopic">EndPoint</a> manually to stretch the scale. <br />Note that in the attached example, two constants are used "gaugeScaleProportion" and "markerSizeProportion". It is necessary to calculate them manually by making the default gauge screenshot. </p>

<br/>


