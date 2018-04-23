namespace WindowsFormsApplication1
{
    partial class Form1
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            DevExpress.XtraGauges.Core.Model.LinearScaleRange linearScaleRange1 = new DevExpress.XtraGauges.Core.Model.LinearScaleRange();
            DevExpress.XtraGauges.Core.Model.LinearScaleRange linearScaleRange2 = new DevExpress.XtraGauges.Core.Model.LinearScaleRange();
            DevExpress.XtraGauges.Core.Model.LinearScaleRange linearScaleRange3 = new DevExpress.XtraGauges.Core.Model.LinearScaleRange();
            this.gaugeControl1 = new DevExpress.XtraGauges.Win.GaugeControl();
            this.linearGauge1 = new DevExpress.XtraGauges.Win.Gauges.Linear.LinearGauge();
            this.linearScaleRangeBarComponent1 = new DevExpress.XtraGauges.Win.Gauges.Linear.LinearScaleRangeBarComponent();
            this.linearScaleComponent1 = new DevExpress.XtraGauges.Win.Gauges.Linear.LinearScaleComponent();
            ((System.ComponentModel.ISupportInitialize)(this.linearGauge1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.linearScaleRangeBarComponent1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.linearScaleComponent1)).BeginInit();
            this.SuspendLayout();
            // 
            // gaugeControl1
            // 
            this.gaugeControl1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.gaugeControl1.Gauges.AddRange(new DevExpress.XtraGauges.Base.IGauge[] {
            this.linearGauge1});
            this.gaugeControl1.Location = new System.Drawing.Point(0, 0);
            this.gaugeControl1.Name = "gaugeControl1";
            this.gaugeControl1.Size = new System.Drawing.Size(827, 343);
            this.gaugeControl1.TabIndex = 0;
            // 
            // linearGauge1
            // 
            this.linearGauge1.AutoSize = DevExpress.Utils.DefaultBoolean.False;
            this.linearGauge1.Bounds = new System.Drawing.Rectangle(6, 6, 815, 331);
            this.linearGauge1.Name = "linearGauge1";
            this.linearGauge1.Orientation = DevExpress.XtraGauges.Core.Model.ScaleOrientation.Horizontal;
            this.linearGauge1.RangeBars.AddRange(new DevExpress.XtraGauges.Win.Gauges.Linear.LinearScaleRangeBarComponent[] {
            this.linearScaleRangeBarComponent1});
            this.linearGauge1.Scales.AddRange(new DevExpress.XtraGauges.Win.Gauges.Linear.LinearScaleComponent[] {
            this.linearScaleComponent1});
            // 
            // linearScaleRangeBarComponent1
            // 
            this.linearScaleRangeBarComponent1.AppearanceRangeBar.ContentBrush = new DevExpress.XtraGauges.Core.Drawing.SolidBrushObject("Color:#E73141");
            this.linearScaleRangeBarComponent1.EndOffset = 8F;
            this.linearScaleRangeBarComponent1.LinearScale = this.linearScaleComponent1;
            this.linearScaleRangeBarComponent1.Name = "linearGauge2_RangeBar1";
            this.linearScaleRangeBarComponent1.StartOffset = 4F;
            this.linearScaleRangeBarComponent1.ZOrder = -100;
            // 
            // linearScaleComponent1
            // 
            this.linearScaleComponent1.AppearanceScale.Brush = new DevExpress.XtraGauges.Core.Drawing.SolidBrushObject("Color:#4D4D4D");
            this.linearScaleComponent1.AppearanceScale.Width = 4F;
            this.linearScaleComponent1.AppearanceTickmarkText.TextBrush = new DevExpress.XtraGauges.Core.Drawing.SolidBrushObject("Color:#4D4D4D");
            this.linearScaleComponent1.CustomLogarithmicBase = 2F;
            this.linearScaleComponent1.EndPoint = new DevExpress.XtraGauges.Core.Base.PointF2D(62.5F, 0F);
            this.linearScaleComponent1.MajorTickCount = 6;
            this.linearScaleComponent1.MajorTickmark.FormatString = "{0:F0}";
            this.linearScaleComponent1.MajorTickmark.ShapeOffset = -7F;
            this.linearScaleComponent1.MajorTickmark.ShapeScale = new DevExpress.XtraGauges.Core.Base.FactorF2D(1.1F, 1F);
            this.linearScaleComponent1.MajorTickmark.ShapeType = DevExpress.XtraGauges.Core.Model.TickmarkShapeType.Circular_Style28_1;
            this.linearScaleComponent1.MajorTickmark.TextOffset = -20F;
            this.linearScaleComponent1.MajorTickmark.TextOrientation = DevExpress.XtraGauges.Core.Model.LabelOrientation.BottomToTop;
            this.linearScaleComponent1.MaxValue = 50F;
            this.linearScaleComponent1.MinorTickCount = 4;
            this.linearScaleComponent1.MinorTickmark.ShapeOffset = -14F;
            this.linearScaleComponent1.MinorTickmark.ShapeType = DevExpress.XtraGauges.Core.Model.TickmarkShapeType.Circular_Style28_1;
            this.linearScaleComponent1.MinorTickmark.ShowTick = false;
            this.linearScaleComponent1.Name = "scale2";
            linearScaleRange1.AppearanceRange.ContentBrush = new DevExpress.XtraGauges.Core.Drawing.SolidBrushObject("Color:#59BB71");
            linearScaleRange1.EndThickness = 11F;
            linearScaleRange1.EndValue = 30F;
            linearScaleRange1.Name = "Range0";
            linearScaleRange1.ShapeOffset = 10F;
            linearScaleRange1.StartThickness = 11F;
            linearScaleRange2.AppearanceRange.ContentBrush = new DevExpress.XtraGauges.Core.Drawing.SolidBrushObject("Color:#F5E16B");
            linearScaleRange2.EndThickness = 11F;
            linearScaleRange2.EndValue = 40F;
            linearScaleRange2.Name = "Range1";
            linearScaleRange2.ShapeOffset = 10F;
            linearScaleRange2.StartThickness = 11F;
            linearScaleRange2.StartValue = 30F;
            linearScaleRange3.AppearanceRange.ContentBrush = new DevExpress.XtraGauges.Core.Drawing.SolidBrushObject("Color:#D54367");
            linearScaleRange3.EndThickness = 11F;
            linearScaleRange3.EndValue = 50F;
            linearScaleRange3.Name = "Range2";
            linearScaleRange3.ShapeOffset = 10F;
            linearScaleRange3.StartThickness = 11F;
            linearScaleRange3.StartValue = 40F;
            this.linearScaleComponent1.Ranges.AddRange(new DevExpress.XtraGauges.Core.Model.IRange[] {
            linearScaleRange1,
            linearScaleRange2,
            linearScaleRange3});
            this.linearScaleComponent1.StartPoint = new DevExpress.XtraGauges.Core.Base.PointF2D(62.5F, 250F);
            this.linearScaleComponent1.Value = 20F;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(827, 343);
            this.Controls.Add(this.gaugeControl1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.Resize += new System.EventHandler(this.Form1_Resize);
            ((System.ComponentModel.ISupportInitialize)(this.linearGauge1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.linearScaleRangeBarComponent1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.linearScaleComponent1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private DevExpress.XtraGauges.Win.GaugeControl gaugeControl1;
        private DevExpress.XtraGauges.Win.Gauges.Linear.LinearGauge linearGauge1;
        private DevExpress.XtraGauges.Win.Gauges.Linear.LinearScaleRangeBarComponent linearScaleRangeBarComponent1;
        private DevExpress.XtraGauges.Win.Gauges.Linear.LinearScaleComponent linearScaleComponent1;
    }
}

