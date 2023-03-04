namespace ManagementSoftware.GUI.PurchaseOrderManagement
{
    partial class FormDirectiveDecomposition
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
            panelMain = new Panel();
            labelHeader = new Label();
            panel1 = new Panel();
            panel1.SuspendLayout();
            SuspendLayout();
            // 
            // panelMain
            // 
            panelMain.AutoScroll = true;
            panelMain.BackColor = Color.FromArgb(32, 32, 32);
            panelMain.BorderStyle = BorderStyle.FixedSingle;
            panelMain.Dock = DockStyle.Fill;
            panelMain.Location = new Point(0, 48);
            panelMain.Margin = new Padding(4, 3, 4, 3);
            panelMain.Name = "panelMain";
            panelMain.Size = new Size(1103, 737);
            panelMain.TabIndex = 13;
            // 
            // labelHeader
            // 
            labelHeader.BackColor = Color.FromArgb(32, 32, 32);
            labelHeader.Dock = DockStyle.Fill;
            labelHeader.Font = new Font("Segoe UI", 20.25F, FontStyle.Bold, GraphicsUnit.Point);
            labelHeader.ForeColor = SystemColors.ActiveCaption;
            labelHeader.Location = new Point(0, 0);
            labelHeader.Margin = new Padding(4, 0, 4, 0);
            labelHeader.Name = "labelHeader";
            labelHeader.Size = new Size(1101, 46);
            labelHeader.TabIndex = 14;
            labelHeader.Text = "Danh sách sản phẩm đơn hàng";
            labelHeader.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // panel1
            // 
            panel1.BorderStyle = BorderStyle.FixedSingle;
            panel1.Controls.Add(labelHeader);
            panel1.Dock = DockStyle.Top;
            panel1.Location = new Point(0, 0);
            panel1.Margin = new Padding(4, 3, 4, 3);
            panel1.Name = "panel1";
            panel1.Size = new Size(1103, 48);
            panel1.TabIndex = 12;
            // 
            // FormDirectiveDecomposition
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(41, 44, 51);
            ClientSize = new Size(1103, 785);
            Controls.Add(panelMain);
            Controls.Add(panel1);
            Name = "FormDirectiveDecomposition";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "FormDirectiveDecomposition";
            WindowState = FormWindowState.Maximized;
            panel1.ResumeLayout(false);
            ResumeLayout(false);
        }

        #endregion

        private Panel panelMain;
        private Label labelHeader;
        private Panel panel1;
    }
}