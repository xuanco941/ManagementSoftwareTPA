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
            sfBarcode1 = new Syncfusion.Windows.Forms.Barcode.SfBarcode();
            radialGauge1 = new Syncfusion.Windows.Forms.Gauge.RadialGauge();
            digitalGauge2 = new Syncfusion.Windows.Forms.Gauge.DigitalGauge();
            linearGauge1 = new Syncfusion.Windows.Forms.Gauge.LinearGauge();
            chartControl1 = new Syncfusion.Windows.Forms.Chart.ChartControl();
            integerTextBox1 = new Syncfusion.Windows.Forms.Tools.IntegerTextBox();
            textBox1 = new TextBox();
            panelPrintBarcode = new Panel();
            button1 = new Button();
            ((System.ComponentModel.ISupportInitialize)integerTextBox1).BeginInit();
            panelPrintBarcode.SuspendLayout();
            SuspendLayout();
            // 
            // sfBarcode1
            // 
            sfBarcode1.DarkBarColor = Color.Black;
            sfBarcode1.DisplayText = true;
            sfBarcode1.Dock = DockStyle.Fill;
            sfBarcode1.LightBarColor = Color.White;
            sfBarcode1.Location = new Point(0, 0);
            sfBarcode1.Margin = new Padding(5, 3, 5, 3);
            sfBarcode1.Name = "sfBarcode1";
            sfBarcode1.Size = new Size(242, 100);
            sfBarcode1.Symbology = Syncfusion.Windows.Forms.Barcode.BarcodeSymbolType.QRBarcode;
            sfBarcode1.SymbologySettings = null;
            sfBarcode1.TabIndex = 0;
            sfBarcode1.TextAlignment = Syncfusion.Windows.Forms.Barcode.BarcodeTextAlignment.Center;
            sfBarcode1.TextColor = Color.Black;
            sfBarcode1.TextGapHeight = 0F;
            // 
            // radialGauge1
            // 
            radialGauge1.ArcThickness = 2F;
            radialGauge1.BackgroundGradientStartColor = SystemColors.ButtonFace;
            radialGauge1.EnableCustomNeedles = false;
            radialGauge1.FillColor = Color.DarkGray;
            radialGauge1.FrameThickness = 12;
            radialGauge1.GaugeLabel = "Gauge";
            radialGauge1.GaugeLableFont = new Font("Segoe UI", 8.25F, FontStyle.Regular, GraphicsUnit.Point);
            radialGauge1.GaugeValueFont = new Font("Segoe UI", 8.25F, FontStyle.Regular, GraphicsUnit.Point);
            radialGauge1.InnerFrameGradientStartColor = SystemColors.ActiveBorder;
            radialGauge1.Location = new Point(224, 92);
            radialGauge1.Margin = new Padding(4, 3, 4, 3);
            radialGauge1.MinimumSize = new Size(125, 125);
            radialGauge1.Name = "radialGauge1";
            radialGauge1.ShowTicks = true;
            radialGauge1.Size = new Size(261, 261);
            radialGauge1.TabIndex = 1;
            // 
            // digitalGauge2
            // 
            digitalGauge2.DisplayRecordIndex = 0;
            digitalGauge2.Location = new Point(57, 27);
            digitalGauge2.Margin = new Padding(4, 3, 4, 3);
            digitalGauge2.MaximumSize = new Size(583, 208);
            digitalGauge2.MinimumSize = new Size(105, 104);
            digitalGauge2.Name = "digitalGauge2";
            digitalGauge2.Size = new Size(210, 104);
            digitalGauge2.TabIndex = 3;
            // 
            // linearGauge1
            // 
            linearGauge1.ForeColor = Color.Gray;
            linearGauge1.GaugelabelFont = new Font("Segoe UI", 8.25F, FontStyle.Regular, GraphicsUnit.Point);
            linearGauge1.LinearFrameType = Syncfusion.Windows.Forms.Gauge.LinearFrameType.Horizontal;
            linearGauge1.Location = new Point(117, 350);
            linearGauge1.MajorTicksHeight = 15;
            linearGauge1.Margin = new Padding(4, 3, 4, 3);
            linearGauge1.MinimumSize = new Size(100, 50);
            linearGauge1.MinorTickCount = 5;
            linearGauge1.MinorTickHeight = 10;
            linearGauge1.Name = "linearGauge1";
            linearGauge1.PointerPlacement = Syncfusion.Windows.Forms.Gauge.Placement.Center;
            linearGauge1.ScaleColor = Color.Gray;
            linearGauge1.Size = new Size(350, 155);
            linearGauge1.TabIndex = 4;
            linearGauge1.Text = "linearGauge1";
            linearGauge1.ValueIndicatorColor = Color.Gray;
            // 
            // chartControl1
            // 
            chartControl1.ChartArea.CursorLocation = new Point(0, 0);
            chartControl1.ChartArea.CursorReDraw = false;
            chartControl1.IsWindowLess = false;
            // 
            // 
            // 
            chartControl1.Legend.Location = new Point(369, 75);
            chartControl1.Legend.Margin = new Padding(4, 3, 4, 3);
            chartControl1.Localize = null;
            chartControl1.Location = new Point(588, 180);
            chartControl1.Margin = new Padding(4, 3, 4, 3);
            chartControl1.Name = "chartControl1";
            chartControl1.PrimaryXAxis.LogLabelsDisplayMode = Syncfusion.Windows.Forms.Chart.LogLabelsDisplayMode.Default;
            chartControl1.PrimaryXAxis.Margin = true;
            chartControl1.PrimaryYAxis.LogLabelsDisplayMode = Syncfusion.Windows.Forms.Chart.LogLabelsDisplayMode.Default;
            chartControl1.PrimaryYAxis.Margin = true;
            chartControl1.Size = new Size(478, 279);
            chartControl1.TabIndex = 5;
            chartControl1.Text = "chartControl1";
            // 
            // 
            // 
            chartControl1.Title.Name = "Default";
            chartControl1.Titles.Add(chartControl1.Title);
            chartControl1.VisualTheme = "";
            // 
            // integerTextBox1
            // 
            integerTextBox1.BeforeTouchSize = new Size(66, 35);
            integerTextBox1.IntegerValue = 1L;
            integerTextBox1.Location = new Point(467, 27);
            integerTextBox1.Margin = new Padding(4, 3, 4, 3);
            integerTextBox1.Name = "integerTextBox1";
            integerTextBox1.Size = new Size(116, 23);
            integerTextBox1.TabIndex = 6;
            integerTextBox1.Text = "1";
            // 
            // textBox1
            // 
            textBox1.Location = new Point(433, 91);
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(100, 23);
            textBox1.TabIndex = 7;
            // 
            // panelPrintBarcode
            // 
            panelPrintBarcode.Controls.Add(sfBarcode1);
            panelPrintBarcode.Location = new Point(727, 54);
            panelPrintBarcode.Name = "panelPrintBarcode";
            panelPrintBarcode.Size = new Size(242, 100);
            panelPrintBarcode.TabIndex = 8;
            // 
            // button1
            // 
            button1.FlatStyle = FlatStyle.Popup;
            button1.Location = new Point(1012, 117);
            button1.Name = "button1";
            button1.Size = new Size(75, 23);
            button1.TabIndex = 9;
            button1.Text = "button1";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click_1;
            // 
            // FormTest
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1146, 517);
            Controls.Add(button1);
            Controls.Add(panelPrintBarcode);
            Controls.Add(textBox1);
            Controls.Add(integerTextBox1);
            Controls.Add(chartControl1);
            Controls.Add(linearGauge1);
            Controls.Add(digitalGauge2);
            Controls.Add(radialGauge1);
            Margin = new Padding(4, 3, 4, 3);
            Name = "FormTest";
            Text = "FormTest";
            ((System.ComponentModel.ISupportInitialize)integerTextBox1).EndInit();
            panelPrintBarcode.ResumeLayout(false);
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Syncfusion.Windows.Forms.Barcode.SfBarcode sfBarcode1;
        private Syncfusion.Windows.Forms.Gauge.RadialGauge radialGauge1;
        private Syncfusion.Windows.Forms.Gauge.DigitalGauge digitalGauge2;
        private Syncfusion.Windows.Forms.Gauge.LinearGauge linearGauge1;
        private Syncfusion.Windows.Forms.Chart.ChartControl chartControl1;
        private Syncfusion.Windows.Forms.Tools.IntegerTextBox integerTextBox1;
        private TextBox textBox1;
        private Panel panelPrintBarcode;
        private Button button1;
    }
}