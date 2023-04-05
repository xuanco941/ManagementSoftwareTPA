namespace ManagementSoftware.GUI
{
    partial class ErrorDashboard
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
            dataGridView1 = new DataGridView();
            labelBangLoi = new Label();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            SuspendLayout();
            // 
            // dataGridView1
            // 
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.Dock = DockStyle.Fill;
            dataGridView1.Location = new Point(0, 46);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.RowTemplate.Height = 25;
            dataGridView1.Size = new Size(937, 502);
            dataGridView1.TabIndex = 1;
            // 
            // labelBangLoi
            // 
            labelBangLoi.BackColor = Color.Crimson;
            labelBangLoi.Dock = DockStyle.Top;
            labelBangLoi.Font = new Font("Segoe UI", 15.75F, FontStyle.Bold, GraphicsUnit.Point);
            labelBangLoi.ForeColor = SystemColors.ButtonHighlight;
            labelBangLoi.Location = new Point(0, 0);
            labelBangLoi.Margin = new Padding(0);
            labelBangLoi.Name = "labelBangLoi";
            labelBangLoi.Size = new Size(937, 46);
            labelBangLoi.TabIndex = 35;
            labelBangLoi.Text = "BẢNG LỖI";
            labelBangLoi.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // ErrorDashboard
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(937, 548);
            Controls.Add(dataGridView1);
            Controls.Add(labelBangLoi);
            Name = "ErrorDashboard";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Error";
            Load += ErrorDashboard_Load;
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private DataGridView dataGridView1;
        private Label labelBangLoi;
    }
}