namespace ManagementSoftware.GUI.Section
{
    partial class Chart
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
            chartControl1 = new Syncfusion.Windows.Forms.Chart.ChartControl();
            SuspendLayout();
            // 
            // chartControl1
            // 
            chartControl1.ChartArea.CursorLocation = new Point(0, 0);
            chartControl1.ChartArea.CursorReDraw = false;
            chartControl1.Dock = DockStyle.Fill;
            chartControl1.IsWindowLess = false;
            // 
            // 
            // 
            chartControl1.Legend.Location = new Point(691, 75);
            chartControl1.Localize = null;
            chartControl1.Location = new Point(0, 0);
            chartControl1.Name = "chartControl1";
            chartControl1.PrimaryXAxis.LogLabelsDisplayMode = Syncfusion.Windows.Forms.Chart.LogLabelsDisplayMode.Default;
            chartControl1.PrimaryXAxis.Margin = true;
            chartControl1.PrimaryYAxis.LogLabelsDisplayMode = Syncfusion.Windows.Forms.Chart.LogLabelsDisplayMode.Default;
            chartControl1.PrimaryYAxis.Margin = true;
            chartControl1.Size = new Size(800, 450);
            chartControl1.TabIndex = 0;
            chartControl1.Text = "chartControl1";
            // 
            // 
            // 
            chartControl1.Title.Name = "Default";
            chartControl1.Titles.Add(chartControl1.Title);
            chartControl1.VisualTheme = "";
            // 
            // Chart
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(chartControl1);
            Name = "Chart";
            Text = "Chart";
            ResumeLayout(false);
        }

        #endregion

        private Syncfusion.Windows.Forms.Chart.ChartControl chartControl1;
    }
}