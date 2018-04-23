Imports System
Imports System.Collections.Generic
Imports System.ComponentModel
Imports System.Data
Imports System.Drawing
Imports System.Linq
Imports System.Text
Imports System.Windows.Forms
Imports DevExpress.XtraGauges.Win.Gauges.Linear
Imports System.Diagnostics
Imports DevExpress.XtraGauges.Core.Base

Namespace WindowsFormsApplication1
    Partial Public Class Form1
        Inherits Form

        Public Sub New()
            InitializeComponent()
        End Sub


        Private gaugeScaleProportion As New Size(523, 115)
        Private markerSizeProportion As Single = 0.2F

        Private Sub Form1_Load(ByVal sender As Object, ByVal e As EventArgs) Handles MyBase.Load
            UpdateGaugeSize(linearGauge1, gaugeControl1.Size, gaugeScaleProportion, markerSizeProportion)
        End Sub

        Private Sub UpdateGaugeSize(ByVal gauge As LinearGauge, ByVal containerSize As SizeF, ByVal scaleProportion As SizeF, ByVal markerProportion As Single)
            Dim indentX As Single = Math.Min(containerSize.Width / scaleProportion.Width * scaleProportion.Height * markerProportion, containerSize.Height * markerProportion)
            Dim indentY As Single = containerSize.Height / 8F
            Dim targetArea As New SizeF(containerSize.Width - indentX * 2F, containerSize.Height - indentY * 2F)

            Dim proportion As Single = Math.Max(1F, ((targetArea.Width \ scaleProportion.Width) \ (targetArea.Height \ scaleProportion.Height)))
            gauge.Bounds = New Rectangle(CInt((indentX)), CInt((indentY + (targetArea.Height - targetArea.Width / 2F / proportion) / 2F)), CInt(targetArea.Width), CInt((targetArea.Width / 2F / proportion)))
            gauge.Scales(0).StartPoint = New PointF2D(62.5F, 125F * (1F + proportion))
            gauge.Scales(0).EndPoint = New PointF2D(62.5F, 125F * (1F - proportion))
        End Sub

        Private Sub Form1_Resize(ByVal sender As Object, ByVal e As EventArgs) Handles MyBase.Resize
            UpdateGaugeSize(linearGauge1, gaugeControl1.Size, gaugeScaleProportion, markerSizeProportion)
        End Sub
    End Class
End Namespace
