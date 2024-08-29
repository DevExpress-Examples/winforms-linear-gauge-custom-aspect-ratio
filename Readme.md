<!-- default badges list -->
![](https://img.shields.io/endpoint?url=https://codecentral.devexpress.com/api/v1/VersionRange/128623720/24.2.1%2B)
[![](https://img.shields.io/badge/Open_in_DevExpress_Support_Center-FF7200?style=flat-square&logo=DevExpress&logoColor=white)](https://supportcenter.devexpress.com/ticket/details/T158525)
[![](https://img.shields.io/badge/📖_How_to_use_DevExpress_Examples-e9f6fc?style=flat-square)](https://docs.devexpress.com/GeneralInformation/403183)
[![](https://img.shields.io/badge/💬_Leave_Feedback-feecdd?style=flat-square)](#does-this-example-address-your-development-requirementsobjectives)
<!-- default badges end -->

# WinForms Gauge - Configure linear gauge to fill the entire space if the width is significantly greater than the height

The Linear Gauge has an aspect ratio of 1:2 ([Coordinate System](https://docs.devexpress.com/WindowsForms/18220/controls-and-libraries/gauges/concepts/coordinate-system)). You cannot make the Linear Gauge wider in automatic mode. If you simplify the gauge layout (for example, remove the [Background Layer](https://docs.devexpress.com/WindowsForms/DevExpress.XtraGauges.Win.Gauges.Linear.LinearGauge.BackgroundLayers)) and enable the [AutoSize](https://docs.devexpress.com/WindowsForms/DevExpress.XtraGauges.Win.Gauges.Linear.LinearGauge.AutoSize) option, the aspect ratio will be recalculated based on the gauge layout.

The following gauge has a 1:4 aspect ratio:

![WinForms Linear Gauge](https://raw.githubusercontent.com/DevExpress-Examples/how-to-configure-linear-gauge-to-fill-all-space-if-width-exceeds-height-significantly-t158525/14.1.7+/media/3502ad27-4ec0-11e4-80ba-00155d624807.png)

This example demonstrates how to scale the linear gauge horizontally:

![WinForms Linear Gauge with Custom Aspect Ratio](https://raw.githubusercontent.com/DevExpress-Examples/how-to-configure-linear-gauge-to-fill-all-space-if-width-exceeds-height-significantly-t158525/14.1.7+/media/97aa6654-4ec0-11e4-80ba-00155d624807.png)

## Implementation Details

* Disable the [AutoSize](https://docs.devexpress.com/WindowsForms/DevExpress.XtraGauges.Win.Gauges.Linear.LinearGauge.AutoSize) option.
* Calculate [Bounds](https://documentation.devexpress.com/#CoreLibraries/DevExpressXtraGaugesCoreModelBaseGauge_Boundstopic) to align the linear gauge inside the Gauge Control.
* Specify [StartPoint](https://docs.devexpress.com/CoreLibraries/DevExpress.XtraGauges.Core.Model.LinearScale.StartPoint) and [EndPoint](https://docs.devexpress.com/CoreLibraries/DevExpress.XtraGauges.Core.Model.LinearScale.EndPoint) properties to stretch the scale.


## Files to Review

* [Form1.cs](./CS/WindowsFormsApplication1/Form1.cs) (VB: [Form1.vb](./VB/WindowsFormsApplication1/Form1.vb))
<!-- feedback -->
## Does this example address your development requirements/objectives?

[<img src="https://www.devexpress.com/support/examples/i/yes-button.svg"/>](https://www.devexpress.com/support/examples/survey.xml?utm_source=github&utm_campaign=winforms-linear-gauge-custom-aspect-ratio&~~~was_helpful=yes) [<img src="https://www.devexpress.com/support/examples/i/no-button.svg"/>](https://www.devexpress.com/support/examples/survey.xml?utm_source=github&utm_campaign=winforms-linear-gauge-custom-aspect-ratio&~~~was_helpful=no)

(you will be redirected to DevExpress.com to submit your response)
<!-- feedback end -->
