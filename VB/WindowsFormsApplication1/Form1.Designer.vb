Namespace WindowsFormsApplication1

    Partial Class Form1

        ''' <summary>
        ''' Required designer variable.
        ''' </summary>
        Private components As System.ComponentModel.IContainer = Nothing

        ''' <summary>
        ''' Clean up any resources being used.
        ''' </summary>
        ''' <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        Protected Overrides Sub Dispose(ByVal disposing As Boolean)
            If disposing AndAlso (Me.components IsNot Nothing) Then
                Me.components.Dispose()
            End If

            MyBase.Dispose(disposing)
        End Sub

'#Region "Windows Form Designer generated code"
        ''' <summary>
        ''' Required method for Designer support - do not modify
        ''' the contents of this method with the code editor.
        ''' </summary>
        Private Sub InitializeComponent()
            Dim linearScaleRange1 As DevExpress.XtraGauges.Core.Model.LinearScaleRange = New DevExpress.XtraGauges.Core.Model.LinearScaleRange()
            Dim linearScaleRange2 As DevExpress.XtraGauges.Core.Model.LinearScaleRange = New DevExpress.XtraGauges.Core.Model.LinearScaleRange()
            Dim linearScaleRange3 As DevExpress.XtraGauges.Core.Model.LinearScaleRange = New DevExpress.XtraGauges.Core.Model.LinearScaleRange()
            Me.gaugeControl1 = New DevExpress.XtraGauges.Win.GaugeControl()
            Me.linearGauge1 = New DevExpress.XtraGauges.Win.Gauges.Linear.LinearGauge()
            Me.linearScaleRangeBarComponent1 = New DevExpress.XtraGauges.Win.Gauges.Linear.LinearScaleRangeBarComponent()
            Me.linearScaleComponent1 = New DevExpress.XtraGauges.Win.Gauges.Linear.LinearScaleComponent()
            CType((Me.linearGauge1), System.ComponentModel.ISupportInitialize).BeginInit()
            CType((Me.linearScaleRangeBarComponent1), System.ComponentModel.ISupportInitialize).BeginInit()
            CType((Me.linearScaleComponent1), System.ComponentModel.ISupportInitialize).BeginInit()
            Me.SuspendLayout()
            ' 
            ' gaugeControl1
            ' 
            Me.gaugeControl1.Dock = System.Windows.Forms.DockStyle.Fill
            Me.gaugeControl1.Gauges.AddRange(New DevExpress.XtraGauges.Base.IGauge() {Me.linearGauge1})
            Me.gaugeControl1.Location = New System.Drawing.Point(0, 0)
            Me.gaugeControl1.Name = "gaugeControl1"
            Me.gaugeControl1.Size = New System.Drawing.Size(827, 343)
            Me.gaugeControl1.TabIndex = 0
            ' 
            ' linearGauge1
            ' 
            Me.linearGauge1.AutoSize = DevExpress.Utils.DefaultBoolean.[False]
            Me.linearGauge1.Bounds = New System.Drawing.Rectangle(6, 6, 815, 331)
            Me.linearGauge1.Name = "linearGauge1"
            Me.linearGauge1.Orientation = DevExpress.XtraGauges.Core.Model.ScaleOrientation.Horizontal
            Me.linearGauge1.RangeBars.AddRange(New DevExpress.XtraGauges.Win.Gauges.Linear.LinearScaleRangeBarComponent() {Me.linearScaleRangeBarComponent1})
            Me.linearGauge1.Scales.AddRange(New DevExpress.XtraGauges.Win.Gauges.Linear.LinearScaleComponent() {Me.linearScaleComponent1})
            ' 
            ' linearScaleRangeBarComponent1
            ' 
            Me.linearScaleRangeBarComponent1.AppearanceRangeBar.ContentBrush = New DevExpress.XtraGauges.Core.Drawing.SolidBrushObject("Color:#E73141")
            Me.linearScaleRangeBarComponent1.EndOffset = 8F
            Me.linearScaleRangeBarComponent1.LinearScale = Me.linearScaleComponent1
            Me.linearScaleRangeBarComponent1.Name = "linearGauge2_RangeBar1"
            Me.linearScaleRangeBarComponent1.StartOffset = 4F
            Me.linearScaleRangeBarComponent1.ZOrder = -100
            ' 
            ' linearScaleComponent1
            ' 
            Me.linearScaleComponent1.AppearanceScale.Brush = New DevExpress.XtraGauges.Core.Drawing.SolidBrushObject("Color:#4D4D4D")
            Me.linearScaleComponent1.AppearanceScale.Width = 4F
            Me.linearScaleComponent1.AppearanceTickmarkText.TextBrush = New DevExpress.XtraGauges.Core.Drawing.SolidBrushObject("Color:#4D4D4D")
            Me.linearScaleComponent1.CustomLogarithmicBase = 2F
            Me.linearScaleComponent1.EndPoint = New DevExpress.XtraGauges.Core.Base.PointF2D(62.5F, 0F)
            Me.linearScaleComponent1.MajorTickCount = 6
            Me.linearScaleComponent1.MajorTickmark.FormatString = "{0:F0}"
            Me.linearScaleComponent1.MajorTickmark.ShapeOffset = -7F
            Me.linearScaleComponent1.MajorTickmark.ShapeScale = New DevExpress.XtraGauges.Core.Base.FactorF2D(1.1F, 1F)
            Me.linearScaleComponent1.MajorTickmark.ShapeType = DevExpress.XtraGauges.Core.Model.TickmarkShapeType.Circular_Style28_1
            Me.linearScaleComponent1.MajorTickmark.TextOffset = -20F
            Me.linearScaleComponent1.MajorTickmark.TextOrientation = DevExpress.XtraGauges.Core.Model.LabelOrientation.BottomToTop
            Me.linearScaleComponent1.MaxValue = 50F
            Me.linearScaleComponent1.MinorTickCount = 4
            Me.linearScaleComponent1.MinorTickmark.ShapeOffset = -14F
            Me.linearScaleComponent1.MinorTickmark.ShapeType = DevExpress.XtraGauges.Core.Model.TickmarkShapeType.Circular_Style28_1
            Me.linearScaleComponent1.MinorTickmark.ShowTick = False
            Me.linearScaleComponent1.Name = "scale2"
            linearScaleRange1.AppearanceRange.ContentBrush = New DevExpress.XtraGauges.Core.Drawing.SolidBrushObject("Color:#59BB71")
            linearScaleRange1.EndThickness = 11F
            linearScaleRange1.EndValue = 30F
            linearScaleRange1.Name = "Range0"
            linearScaleRange1.ShapeOffset = 10F
            linearScaleRange1.StartThickness = 11F
            linearScaleRange2.AppearanceRange.ContentBrush = New DevExpress.XtraGauges.Core.Drawing.SolidBrushObject("Color:#F5E16B")
            linearScaleRange2.EndThickness = 11F
            linearScaleRange2.EndValue = 40F
            linearScaleRange2.Name = "Range1"
            linearScaleRange2.ShapeOffset = 10F
            linearScaleRange2.StartThickness = 11F
            linearScaleRange2.StartValue = 30F
            linearScaleRange3.AppearanceRange.ContentBrush = New DevExpress.XtraGauges.Core.Drawing.SolidBrushObject("Color:#D54367")
            linearScaleRange3.EndThickness = 11F
            linearScaleRange3.EndValue = 50F
            linearScaleRange3.Name = "Range2"
            linearScaleRange3.ShapeOffset = 10F
            linearScaleRange3.StartThickness = 11F
            linearScaleRange3.StartValue = 40F
            Me.linearScaleComponent1.Ranges.AddRange(New DevExpress.XtraGauges.Core.Model.IRange() {linearScaleRange1, linearScaleRange2, linearScaleRange3})
            Me.linearScaleComponent1.StartPoint = New DevExpress.XtraGauges.Core.Base.PointF2D(62.5F, 250F)
            Me.linearScaleComponent1.Value = 20F
            ' 
            ' Form1
            ' 
            Me.AutoScaleDimensions = New System.Drawing.SizeF(6F, 13F)
            Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
            Me.ClientSize = New System.Drawing.Size(827, 343)
            Me.Controls.Add(Me.gaugeControl1)
            Me.Name = "Form1"
            Me.Text = "Form1"
            AddHandler Me.Load, New System.EventHandler(AddressOf Me.Form1_Load)
            AddHandler Me.Resize, New System.EventHandler(AddressOf Me.Form1_Resize)
            CType((Me.linearGauge1), System.ComponentModel.ISupportInitialize).EndInit()
            CType((Me.linearScaleRangeBarComponent1), System.ComponentModel.ISupportInitialize).EndInit()
            CType((Me.linearScaleComponent1), System.ComponentModel.ISupportInitialize).EndInit()
            Me.ResumeLayout(False)
        End Sub

'#End Region
        Private gaugeControl1 As DevExpress.XtraGauges.Win.GaugeControl

        Private linearGauge1 As DevExpress.XtraGauges.Win.Gauges.Linear.LinearGauge

        Private linearScaleRangeBarComponent1 As DevExpress.XtraGauges.Win.Gauges.Linear.LinearScaleRangeBarComponent

        Private linearScaleComponent1 As DevExpress.XtraGauges.Win.Gauges.Linear.LinearScaleComponent
    End Class
End Namespace
