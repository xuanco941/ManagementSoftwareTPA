namespace ManagementSoftware
{
    partial class FormTest
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
            this.sfBarcode1 = new Syncfusion.Windows.Forms.Barcode.SfBarcode();
            this.radialGauge1 = new Syncfusion.Windows.Forms.Gauge.RadialGauge();
            this.digitalGauge1 = new Syncfusion.Windows.Forms.Gauge.DigitalGauge();
            this.digitalGauge2 = new Syncfusion.Windows.Forms.Gauge.DigitalGauge();
            this.linearGauge1 = new Syncfusion.Windows.Forms.Gauge.LinearGauge();
            this.chartControl1 = new Syncfusion.Windows.Forms.Chart.ChartControl();
            this.integerTextBox1 = new Syncfusion.Windows.Forms.Tools.IntegerTextBox();
            ((System.ComponentModel.ISupportInitialize)(this.integerTextBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // sfBarcode1
            // 
            this.sfBarcode1.DarkBarColor = System.Drawing.Color.Black;
            this.sfBarcode1.DisplayText = true;
            this.sfBarcode1.LightBarColor = System.Drawing.Color.White;
            this.sfBarcode1.Location = new System.Drawing.Point(59, 156);
            this.sfBarcode1.Name = "sfBarcode1";
            this.sfBarcode1.Size = new System.Drawing.Size(105, 150);
            this.sfBarcode1.Symbology = Syncfusion.Windows.Forms.Barcode.BarcodeSymbolType.QRBarcode;
            this.sfBarcode1.SymbologySettings = null;
            this.sfBarcode1.TabIndex = 0;
            this.sfBarcode1.TextAlignment = Syncfusion.Windows.Forms.Barcode.BarcodeTextAlignment.Center;
            this.sfBarcode1.TextColor = System.Drawing.Color.Black;
            this.sfBarcode1.TextGapHeight = 0F;
            // 
            // radialGauge1
            // 
            this.radialGauge1.ArcThickness = 2F;
            this.radialGauge1.EnableCustomNeedles = false;
            this.radialGauge1.FillColor = System.Drawing.Color.DarkGray;
            this.radialGauge1.FrameThickness = 12;
            this.radialGauge1.GaugeLabel = "Gauge";
            this.radialGauge1.GaugeLableFont = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.radialGauge1.GaugeValueFont = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.radialGauge1.Location = new System.Drawing.Point(192, 80);
            this.radialGauge1.MinimumSize = new System.Drawing.Size(125, 125);
            this.radialGauge1.Name = "radialGauge1";
            this.radialGauge1.ShowTicks = true;
            this.radialGauge1.Size = new System.Drawing.Size(226, 226);
            this.radialGauge1.TabIndex = 1;
            // 
            // digitalGauge1
            // 
            this.digitalGauge1.DisplayRecordIndex = 0;
            this.digitalGauge1.Location = new System.Drawing.Point(75, 338);
            this.digitalGauge1.MaximumSize = new System.Drawing.Size(500, 180);
            this.digitalGauge1.MinimumSize = new System.Drawing.Size(90, 90);
            this.digitalGauge1.Name = "digitalGauge1";
            this.digitalGauge1.Size = new System.Drawing.Size(180, 90);
            this.digitalGauge1.TabIndex = 2;
            // 
            // digitalGauge2
            // 
            this.digitalGauge2.DisplayRecordIndex = 0;
            this.digitalGauge2.Location = new System.Drawing.Point(49, 23);
            this.digitalGauge2.MaximumSize = new System.Drawing.Size(500, 180);
            this.digitalGauge2.MinimumSize = new System.Drawing.Size(90, 90);
            this.digitalGauge2.Name = "digitalGauge2";
            this.digitalGauge2.Size = new System.Drawing.Size(180, 90);
            this.digitalGauge2.TabIndex = 3;
            // 
            // linearGauge1
            // 
            this.linearGauge1.ForeColor = System.Drawing.Color.Gray;
            this.linearGauge1.GaugelabelFont = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.linearGauge1.LinearFrameType = Syncfusion.Windows.Forms.Gauge.LinearFrameType.Horizontal;
            this.linearGauge1.Location = new System.Drawing.Point(201, 395);
            this.linearGauge1.MajorTicksHeight = 15;
            this.linearGauge1.MinimumSize = new System.Drawing.Size(100, 50);
            this.linearGauge1.MinorTickCount = 5;
            this.linearGauge1.MinorTickHeight = 10;
            this.linearGauge1.Name = "linearGauge1";
            this.linearGauge1.PointerPlacement = Syncfusion.Windows.Forms.Gauge.Placement.Center;
            this.linearGauge1.ScaleColor = System.Drawing.Color.Gray;
            this.linearGauge1.Size = new System.Drawing.Size(300, 134);
            this.linearGauge1.TabIndex = 4;
            this.linearGauge1.Text = "linearGauge1";
            this.linearGauge1.ValueIndicatorColor = System.Drawing.Color.Gray;
            // 
            // chartControl1
            // 
            this.chartControl1.ChartArea.CursorLocation = new System.Drawing.Point(0, 0);
            this.chartControl1.ChartArea.CursorReDraw = false;
            this.chartControl1.IsWindowLess = false;
            // 
            // 
            // 
            this.chartControl1.Legend.Location = new System.Drawing.Point(707, 75);
            this.chartControl1.Localize = null;
            this.chartControl1.Location = new System.Drawing.Point(556, 133);
            this.chartControl1.Name = "chartControl1";
            this.chartControl1.PrimaryXAxis.LogLabelsDisplayMode = Syncfusion.Windows.Forms.Chart.LogLabelsDisplayMode.Default;
            this.chartControl1.PrimaryXAxis.Margin = true;
            this.chartControl1.PrimaryYAxis.LogLabelsDisplayMode = Syncfusion.Windows.Forms.Chart.LogLabelsDisplayMode.Default;
            this.chartControl1.PrimaryYAxis.Margin = true;
            this.chartControl1.Size = new System.Drawing.Size(816, 441);
            this.chartControl1.TabIndex = 5;
            this.chartControl1.Text = "chartControl1";
            // 
            // 
            // 
            this.chartControl1.Title.Name = "Default";
            this.chartControl1.Titles.Add(this.chartControl1.Title);
            this.chartControl1.VisualTheme = "";
            // 
            // integerTextBox1
            // 
            this.integerTextBox1.IntegerValue = ((long)(1));
            this.integerTextBox1.Location = new System.Drawing.Point(400, 23);
            this.integerTextBox1.Name = "integerTextBox1";
            this.integerTextBox1.Size = new System.Drawing.Size(100, 20);
            this.integerTextBox1.TabIndex = 6;
            this.integerTextBox1.Text = "1";
            // 
            // FormTest
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1384, 610);
            this.Controls.Add(this.integerTextBox1);
            this.Controls.Add(this.chartControl1);
            this.Controls.Add(this.linearGauge1);
            this.Controls.Add(this.digitalGauge2);
            this.Controls.Add(this.digitalGauge1);
            this.Controls.Add(this.radialGauge1);
            this.Controls.Add(this.sfBarcode1);
            this.Name = "FormTest";
            this.Text = "FormTest";
            ((System.ComponentModel.ISupportInitialize)(this.integerTextBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Syncfusion.Windows.Forms.Barcode.SfBarcode sfBarcode1;
        private Syncfusion.Windows.Forms.Gauge.RadialGauge radialGauge1;
        private Syncfusion.Windows.Forms.Gauge.DigitalGauge digitalGauge1;
        private Syncfusion.Windows.Forms.Gauge.DigitalGauge digitalGauge2;
        private Syncfusion.Windows.Forms.Gauge.LinearGauge linearGauge1;
        private Syncfusion.Windows.Forms.Chart.ChartControl chartControl1;
        private Syncfusion.Windows.Forms.Tools.IntegerTextBox integerTextBox1;
    }
}