using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using DevExpress.XtraGauges.Win.Gauges.Linear;
using System.Diagnostics;
using DevExpress.XtraGauges.Core.Base;

namespace WindowsFormsApplication1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }


        Size gaugeScaleProportion = new Size(523, 115);
        float markerSizeProportion = 0.2f;
        
        private void Form1_Load(object sender, EventArgs e)
        {
            UpdateGaugeSize(linearGauge1, gaugeControl1.Size, gaugeScaleProportion, markerSizeProportion); 
        }

        private void UpdateGaugeSize(LinearGauge gauge, SizeF containerSize, SizeF scaleProportion, float markerProportion)
        {
            float indentX = Math.Min(containerSize.Width / scaleProportion.Width * scaleProportion.Height * markerProportion, containerSize.Height * markerProportion);
            float indentY = containerSize.Height / 8f;
            SizeF targetArea = new SizeF(containerSize.Width - indentX * 2f, containerSize.Height - indentY * 2f);

            float proportion = Math.Max(1f, ((targetArea.Width / scaleProportion.Width) / (targetArea.Height / scaleProportion.Height)));
            gauge.Bounds = new Rectangle((int)indentX, (int)(indentY + (targetArea.Height - targetArea.Width / 2f / proportion) / 2f), (int)targetArea.Width, (int)(targetArea.Width / 2f / proportion));
            gauge.Scales[0].StartPoint = new PointF2D(62.5f, 125f * (1f + proportion));
            gauge.Scales[0].EndPoint = new PointF2D(62.5f, 125f * (1f - proportion));
        }

        private void Form1_Resize(object sender, EventArgs e)
        {
            UpdateGaugeSize(linearGauge1, gaugeControl1.Size, gaugeScaleProportion, markerSizeProportion); 
        }
    }
}
