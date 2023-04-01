namespace ManagementSoftware.GUI.ResultManagement
{
    partial class ResultHeNap
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
            components = new System.ComponentModel.Container();
            tableLayoutPanel1 = new TableLayoutPanel();
            panel1 = new Panel();
            tableLayoutPanel2 = new TableLayoutPanel();
            panelApSuatChart = new Panel();
            panelTheTichChart = new Panel();
            panel2 = new Panel();
            label10 = new Label();
            gridLayout1 = new Syncfusion.Windows.Forms.Tools.GridLayout(components);
            label9 = new Label();
            label1 = new Label();
            label2 = new Label();
            label3 = new Label();
            label4 = new Label();
            label5 = new Label();
            label6 = new Label();
            label7 = new Label();
            label26 = new Label();
            label8 = new Label();
            panelThongTin = new Panel();
            tableLayoutPanel1.SuspendLayout();
            panel1.SuspendLayout();
            tableLayoutPanel2.SuspendLayout();
            panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)gridLayout1).BeginInit();
            panelThongTin.SuspendLayout();
            SuspendLayout();
            // 
            // tableLayoutPanel1
            // 
            tableLayoutPanel1.ColumnCount = 2;
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 50F));
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 50F));
            tableLayoutPanel1.Controls.Add(panel1, 0, 0);
            tableLayoutPanel1.Controls.Add(panel2, 1, 0);
            tableLayoutPanel1.Dock = DockStyle.Fill;
            tableLayoutPanel1.Location = new Point(0, 0);
            tableLayoutPanel1.Name = "tableLayoutPanel1";
            tableLayoutPanel1.RowCount = 1;
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Percent, 100F));
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Absolute, 20F));
            tableLayoutPanel1.Size = new Size(1071, 522);
            tableLayoutPanel1.TabIndex = 0;
            // 
            // panel1
            // 
            panel1.Controls.Add(tableLayoutPanel2);
            panel1.Dock = DockStyle.Fill;
            panel1.Location = new Point(3, 3);
            panel1.Name = "panel1";
            panel1.Size = new Size(529, 516);
            panel1.TabIndex = 0;
            // 
            // tableLayoutPanel2
            // 
            tableLayoutPanel2.ColumnCount = 1;
            tableLayoutPanel2.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 100F));
            tableLayoutPanel2.ColumnStyles.Add(new ColumnStyle(SizeType.Absolute, 20F));
            tableLayoutPanel2.Controls.Add(panelApSuatChart, 0, 0);
            tableLayoutPanel2.Controls.Add(panelTheTichChart, 0, 1);
            tableLayoutPanel2.Dock = DockStyle.Fill;
            tableLayoutPanel2.Location = new Point(0, 0);
            tableLayoutPanel2.Name = "tableLayoutPanel2";
            tableLayoutPanel2.RowCount = 2;
            tableLayoutPanel2.RowStyles.Add(new RowStyle(SizeType.Percent, 50F));
            tableLayoutPanel2.RowStyles.Add(new RowStyle(SizeType.Percent, 50F));
            tableLayoutPanel2.Size = new Size(529, 516);
            tableLayoutPanel2.TabIndex = 0;
            // 
            // panelApSuatChart
            // 
            panelApSuatChart.Dock = DockStyle.Fill;
            panelApSuatChart.Location = new Point(3, 3);
            panelApSuatChart.Name = "panelApSuatChart";
            panelApSuatChart.Size = new Size(523, 252);
            panelApSuatChart.TabIndex = 0;
            // 
            // panelTheTichChart
            // 
            panelTheTichChart.Dock = DockStyle.Fill;
            panelTheTichChart.Location = new Point(3, 261);
            panelTheTichChart.Name = "panelTheTichChart";
            panelTheTichChart.Size = new Size(523, 252);
            panelTheTichChart.TabIndex = 1;
            // 
            // panel2
            // 
            panel2.Controls.Add(panelThongTin);
            panel2.Controls.Add(label10);
            panel2.Dock = DockStyle.Fill;
            panel2.Location = new Point(538, 3);
            panel2.Name = "panel2";
            panel2.Size = new Size(530, 516);
            panel2.TabIndex = 1;
            // 
            // label10
            // 
            label10.BackColor = Color.PaleGreen;
            label10.BorderStyle = BorderStyle.FixedSingle;
            label10.Dock = DockStyle.Top;
            label10.Font = new Font("Segoe UI", 18F, FontStyle.Bold, GraphicsUnit.Point);
            label10.ForeColor = SystemColors.ActiveCaptionText;
            label10.Location = new Point(0, 0);
            label10.Margin = new Padding(0);
            label10.Name = "label10";
            label10.Padding = new Padding(0, 1, 0, 1);
            label10.Size = new Size(530, 69);
            label10.TabIndex = 52;
            label10.Text = "Dữ liệu Hệ Nạp 1 (Result ID-94)";
            label10.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // gridLayout1
            // 
            gridLayout1.Columns = 1;
            gridLayout1.ContainerControl = panelThongTin;
            gridLayout1.Rows = 10;
            // 
            // label9
            // 
            label9.BackColor = Color.DimGray;
            label9.BorderStyle = BorderStyle.FixedSingle;
            label9.Font = new Font("Segoe UI Semibold", 15F, FontStyle.Bold, GraphicsUnit.Point);
            label9.ForeColor = SystemColors.ButtonHighlight;
            label9.Location = new Point(0, 400);
            label9.Margin = new Padding(0);
            label9.Name = "label9";
            label9.Padding = new Padding(0, 1, 0, 1);
            gridLayout1.SetParticipateInLayout(label9, true);
            label9.Size = new Size(530, 44);
            label9.TabIndex = 52;
            label9.Text = "Thời gian trích mẫu : 100s";
            label9.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // label1
            // 
            label1.BackColor = Color.DimGray;
            label1.BorderStyle = BorderStyle.FixedSingle;
            label1.Font = new Font("Segoe UI Semibold", 15F, FontStyle.Bold, GraphicsUnit.Point);
            label1.ForeColor = SystemColors.ButtonHighlight;
            label1.Location = new Point(0, 356);
            label1.Margin = new Padding(0);
            label1.Name = "label1";
            label1.Padding = new Padding(0, 1, 0, 1);
            gridLayout1.SetParticipateInLayout(label1, true);
            label1.Size = new Size(530, 44);
            label1.TabIndex = 44;
            label1.Text = "Hệ số tiêu chuẩn : 0";
            label1.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // label2
            // 
            label2.BackColor = Color.DimGray;
            label2.BorderStyle = BorderStyle.FixedSingle;
            label2.Font = new Font("Segoe UI Semibold", 15F, FontStyle.Bold, GraphicsUnit.Point);
            label2.ForeColor = SystemColors.ButtonHighlight;
            label2.Location = new Point(0, 312);
            label2.Margin = new Padding(0);
            label2.Name = "label2";
            label2.Padding = new Padding(0, 1, 0, 1);
            gridLayout1.SetParticipateInLayout(label2, true);
            label2.Size = new Size(530, 44);
            label2.TabIndex = 45;
            label2.Text = "Thể tích tiêu chuẩn : 20L";
            label2.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // label3
            // 
            label3.BackColor = Color.DimGray;
            label3.BorderStyle = BorderStyle.FixedSingle;
            label3.Font = new Font("Segoe UI Semibold", 15F, FontStyle.Bold, GraphicsUnit.Point);
            label3.ForeColor = SystemColors.ButtonHighlight;
            label3.Location = new Point(0, 268);
            label3.Margin = new Padding(0);
            label3.Name = "label3";
            gridLayout1.SetParticipateInLayout(label3, true);
            label3.Size = new Size(530, 44);
            label3.TabIndex = 46;
            label3.Text = "Thể tích cần nạp : 10L";
            label3.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // label4
            // 
            label4.BackColor = Color.DimGray;
            label4.BorderStyle = BorderStyle.FixedSingle;
            label4.Font = new Font("Segoe UI Semibold", 15F, FontStyle.Bold, GraphicsUnit.Point);
            label4.ForeColor = SystemColors.ButtonHighlight;
            label4.Location = new Point(0, 224);
            label4.Margin = new Padding(0);
            label4.Name = "label4";
            label4.Padding = new Padding(0, 1, 0, 1);
            gridLayout1.SetParticipateInLayout(label4, true);
            label4.Size = new Size(530, 44);
            label4.TabIndex = 47;
            label4.Text = "Thời gian kết thúc : 13:00:00 21/03/2023";
            label4.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // label5
            // 
            label5.BackColor = Color.DimGray;
            label5.BorderStyle = BorderStyle.FixedSingle;
            label5.Font = new Font("Segoe UI Semibold", 15F, FontStyle.Bold, GraphicsUnit.Point);
            label5.ForeColor = SystemColors.ButtonHighlight;
            label5.Location = new Point(0, 180);
            label5.Margin = new Padding(0);
            label5.Name = "label5";
            label5.Padding = new Padding(0, 1, 0, 1);
            gridLayout1.SetParticipateInLayout(label5, true);
            label5.Size = new Size(530, 44);
            label5.TabIndex = 48;
            label5.Text = "Thời gian bắt đầu : 13:00:00 21/03/2023";
            label5.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // label6
            // 
            label6.BackColor = Color.DimGray;
            label6.BorderStyle = BorderStyle.FixedSingle;
            label6.Font = new Font("Segoe UI Semibold", 15F, FontStyle.Bold, GraphicsUnit.Point);
            label6.ForeColor = SystemColors.ButtonHighlight;
            label6.Location = new Point(0, 136);
            label6.Margin = new Padding(0);
            label6.Name = "label6";
            label6.Padding = new Padding(0, 1, 0, 1);
            gridLayout1.SetParticipateInLayout(label6, true);
            label6.Size = new Size(530, 44);
            label6.TabIndex = 49;
            label6.Text = "Loại khí : Oxy";
            label6.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // label7
            // 
            label7.BackColor = Color.DimGray;
            label7.BorderStyle = BorderStyle.FixedSingle;
            label7.Font = new Font("Segoe UI Semibold", 15F, FontStyle.Bold, GraphicsUnit.Point);
            label7.ForeColor = SystemColors.ButtonHighlight;
            label7.Location = new Point(0, 92);
            label7.Margin = new Padding(0);
            label7.Name = "label7";
            label7.Padding = new Padding(0, 1, 0, 1);
            gridLayout1.SetParticipateInLayout(label7, true);
            label7.Size = new Size(530, 44);
            label7.TabIndex = 50;
            label7.Text = "Số lượng bình nạp : 100";
            label7.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // label26
            // 
            label26.BackColor = Color.DimGray;
            label26.BorderStyle = BorderStyle.FixedSingle;
            label26.Font = new Font("Segoe UI Semibold", 15F, FontStyle.Bold, GraphicsUnit.Point);
            label26.ForeColor = SystemColors.ButtonHighlight;
            label26.Location = new Point(0, 48);
            label26.Margin = new Padding(0);
            label26.Name = "label26";
            label26.Padding = new Padding(0, 1, 0, 1);
            gridLayout1.SetParticipateInLayout(label26, true);
            label26.Size = new Size(530, 44);
            label26.TabIndex = 43;
            label26.Text = "Người vận hành : admin";
            label26.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // label8
            // 
            label8.BackColor = Color.DimGray;
            label8.BorderStyle = BorderStyle.FixedSingle;
            label8.Font = new Font("Segoe UI Semibold", 15F, FontStyle.Bold, GraphicsUnit.Point);
            label8.ForeColor = SystemColors.ButtonHighlight;
            label8.Location = new Point(0, 4);
            label8.Margin = new Padding(0);
            label8.Name = "label8";
            label8.Padding = new Padding(0, 1, 0, 1);
            gridLayout1.SetParticipateInLayout(label8, true);
            label8.Size = new Size(530, 44);
            label8.TabIndex = 51;
            label8.Text = "Áp suất tiêu chuẩn : 30 bar";
            label8.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // panelThongTin
            // 
            panelThongTin.Controls.Add(label8);
            panelThongTin.Controls.Add(label26);
            panelThongTin.Controls.Add(label7);
            panelThongTin.Controls.Add(label6);
            panelThongTin.Controls.Add(label5);
            panelThongTin.Controls.Add(label4);
            panelThongTin.Controls.Add(label3);
            panelThongTin.Controls.Add(label2);
            panelThongTin.Controls.Add(label1);
            panelThongTin.Controls.Add(label9);
            panelThongTin.Dock = DockStyle.Fill;
            panelThongTin.Location = new Point(0, 69);
            panelThongTin.Name = "panelThongTin";
            panelThongTin.Size = new Size(530, 447);
            panelThongTin.TabIndex = 1;
            // 
            // ResultHeNap
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1071, 522);
            Controls.Add(tableLayoutPanel1);
            Name = "ResultHeNap";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "ResultHeNap";
            Load += ResultHeNap_Load;
            tableLayoutPanel1.ResumeLayout(false);
            panel1.ResumeLayout(false);
            tableLayoutPanel2.ResumeLayout(false);
            panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)gridLayout1).EndInit();
            panelThongTin.ResumeLayout(false);
            ResumeLayout(false);
        }

        #endregion

        private TableLayoutPanel tableLayoutPanel1;
        private Panel panel1;
        private TableLayoutPanel tableLayoutPanel2;
        private Panel panelApSuatChart;
        private Panel panelTheTichChart;
        private Panel panel2;
        private Syncfusion.Windows.Forms.Tools.GridLayout gridLayout1;
        private Label label10;
        private Panel panelThongTin;
        private Label label8;
        private Label label26;
        private Label label7;
        private Label label6;
        private Label label5;
        private Label label4;
        private Label label3;
        private Label label2;
        private Label label1;
        private Label label9;
    }
}