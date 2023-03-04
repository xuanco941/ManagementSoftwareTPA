namespace ManagementSoftware.GUI.PurchaseOrderManagement
{
    partial class FormAddDirective
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormAddDirective));
            label8 = new Label();
            label5 = new Label();
            label2 = new Label();
            panel1 = new Panel();
            buttonThem = new LW_PhanMemBaoGia.MyControls.ButtonCustom();
            label1 = new Label();
            txtSoLuongSX = new Syncfusion.Windows.Forms.Tools.IntegerTextBox();
            label6 = new Label();
            NgayBatDau = new Syncfusion.WinForms.Input.SfDateTimeEdit();
            NgayKetThuc = new Syncfusion.WinForms.Input.SfDateTimeEdit();
            comboBoxTenNguoiLam = new ComboBox();
            panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)txtSoLuongSX).BeginInit();
            SuspendLayout();
            // 
            // label8
            // 
            label8.Dock = DockStyle.Fill;
            label8.Font = new Font("Segoe UI Semibold", 18F, FontStyle.Bold, GraphicsUnit.Point);
            label8.ForeColor = Color.YellowGreen;
            label8.Location = new Point(0, 0);
            label8.Margin = new Padding(4, 0, 4, 0);
            label8.Name = "label8";
            label8.Size = new Size(692, 96);
            label8.TabIndex = 31;
            label8.Text = "Thêm Chỉ Thị Sản Xuất Mới";
            label8.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            label5.ForeColor = SystemColors.Control;
            label5.Location = new Point(155, 275);
            label5.Margin = new Padding(4, 0, 4, 0);
            label5.Name = "label5";
            label5.Size = new Size(103, 21);
            label5.TabIndex = 111;
            label5.Text = "Ngày bắt đầu";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            label2.ForeColor = SystemColors.Control;
            label2.Location = new Point(155, 197);
            label2.Margin = new Padding(4, 0, 4, 0);
            label2.Name = "label2";
            label2.Size = new Size(134, 21);
            label2.TabIndex = 109;
            label2.Text = "Số lượng sản xuất";
            // 
            // panel1
            // 
            panel1.Controls.Add(label8);
            panel1.Dock = DockStyle.Top;
            panel1.Location = new Point(0, 0);
            panel1.Name = "panel1";
            panel1.Size = new Size(692, 96);
            panel1.TabIndex = 106;
            // 
            // buttonThem
            // 
            buttonThem.BackColor = Color.Green;
            buttonThem.BackgroundColor = Color.Green;
            buttonThem.BorderColor = Color.PaleVioletRed;
            buttonThem.BorderRadius = 3;
            buttonThem.BorderSize = 0;
            buttonThem.Cursor = Cursors.Hand;
            buttonThem.FlatStyle = FlatStyle.Flat;
            buttonThem.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold, GraphicsUnit.Point);
            buttonThem.ForeColor = Color.White;
            buttonThem.Image = (Image)resources.GetObject("buttonThem.Image");
            buttonThem.ImageAlign = ContentAlignment.MiddleLeft;
            buttonThem.Location = new Point(250, 373);
            buttonThem.Margin = new Padding(4, 3, 4, 3);
            buttonThem.Name = "buttonThem";
            buttonThem.Size = new Size(175, 42);
            buttonThem.TabIndex = 105;
            buttonThem.Text = "Thêm";
            buttonThem.TextAlign = ContentAlignment.MiddleRight;
            buttonThem.TextColor = Color.White;
            buttonThem.TextImageRelation = TextImageRelation.TextBeforeImage;
            buttonThem.UseVisualStyleBackColor = false;
            buttonThem.Click += buttonThem_Click;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            label1.ForeColor = SystemColors.Control;
            label1.Location = new Point(155, 119);
            label1.Margin = new Padding(4, 0, 4, 0);
            label1.Name = "label1";
            label1.Size = new Size(122, 21);
            label1.TabIndex = 103;
            label1.Text = "Người thực hiện";
            // 
            // txtSoLuongSX
            // 
            txtSoLuongSX.BeforeTouchSize = new Size(381, 33);
            txtSoLuongSX.BorderColor = Color.CornflowerBlue;
            txtSoLuongSX.BorderStyle = BorderStyle.FixedSingle;
            txtSoLuongSX.Font = new Font("Segoe UI", 14.25F, FontStyle.Regular, GraphicsUnit.Point);
            txtSoLuongSX.IntegerValue = 0L;
            txtSoLuongSX.Location = new Point(155, 221);
            txtSoLuongSX.Margin = new Padding(4, 3, 4, 3);
            txtSoLuongSX.MinValue = 0L;
            txtSoLuongSX.Name = "txtSoLuongSX";
            txtSoLuongSX.Size = new Size(381, 33);
            txtSoLuongSX.TabIndex = 116;
            txtSoLuongSX.Text = "0";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            label6.ForeColor = SystemColors.Control;
            label6.Location = new Point(376, 275);
            label6.Margin = new Padding(4, 0, 4, 0);
            label6.Name = "label6";
            label6.Size = new Size(106, 21);
            label6.TabIndex = 113;
            label6.Text = "Ngày kết thúc";
            // 
            // NgayBatDau
            // 
            NgayBatDau.Cursor = Cursors.IBeam;
            NgayBatDau.DateTimePattern = Syncfusion.WinForms.Input.Enums.DateTimePattern.Custom;
            NgayBatDau.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            NgayBatDau.Format = "dd/MM/yyyy";
            NgayBatDau.Location = new Point(155, 299);
            NgayBatDau.Margin = new Padding(4, 3, 4, 3);
            NgayBatDau.MinDateTime = new DateTime(2022, 1, 1, 23, 59, 0, 0);
            NgayBatDau.Name = "NgayBatDau";
            NgayBatDau.Size = new Size(160, 36);
            NgayBatDau.TabIndex = 117;
            NgayBatDau.Value = new DateTime(2022, 10, 1, 23, 59, 0, 0);
            // 
            // NgayKetThuc
            // 
            NgayKetThuc.Cursor = Cursors.IBeam;
            NgayKetThuc.DateTimePattern = Syncfusion.WinForms.Input.Enums.DateTimePattern.Custom;
            NgayKetThuc.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            NgayKetThuc.Format = "dd/MM/yyyy";
            NgayKetThuc.Location = new Point(376, 299);
            NgayKetThuc.Margin = new Padding(4, 3, 4, 3);
            NgayKetThuc.MinDateTime = new DateTime(2022, 1, 1, 23, 59, 0, 0);
            NgayKetThuc.Name = "NgayKetThuc";
            NgayKetThuc.Size = new Size(160, 36);
            NgayKetThuc.TabIndex = 118;
            NgayKetThuc.Value = new DateTime(2022, 10, 1, 23, 59, 0, 0);
            // 
            // comboBoxTenNguoiLam
            // 
            comboBoxTenNguoiLam.DropDownStyle = ComboBoxStyle.DropDownList;
            comboBoxTenNguoiLam.Font = new Font("Segoe UI", 14.25F, FontStyle.Regular, GraphicsUnit.Point);
            comboBoxTenNguoiLam.FormattingEnabled = true;
            comboBoxTenNguoiLam.Location = new Point(156, 143);
            comboBoxTenNguoiLam.Name = "comboBoxTenNguoiLam";
            comboBoxTenNguoiLam.Size = new Size(380, 33);
            comboBoxTenNguoiLam.TabIndex = 32;
            // 
            // FormAddDirective
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(41, 44, 51);
            ClientSize = new Size(692, 475);
            Controls.Add(comboBoxTenNguoiLam);
            Controls.Add(NgayKetThuc);
            Controls.Add(NgayBatDau);
            Controls.Add(txtSoLuongSX);
            Controls.Add(label6);
            Controls.Add(label5);
            Controls.Add(label2);
            Controls.Add(panel1);
            Controls.Add(buttonThem);
            Controls.Add(label1);
            MaximizeBox = false;
            MinimizeBox = false;
            Name = "FormAddDirective";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "FormAddDirective";
            panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)txtSoLuongSX).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label8;
        private Label label5;
        private Label label2;
        private Panel panel1;
        private LW_PhanMemBaoGia.MyControls.ButtonCustom buttonThem;
        private Label label1;
        private Syncfusion.Windows.Forms.Tools.IntegerTextBox txtSoLuongSX;
        private Label label6;
        private Syncfusion.WinForms.Input.SfDateTimeEdit NgayBatDau;
        private Syncfusion.WinForms.Input.SfDateTimeEdit NgayKetThuc;
        private ComboBox comboBoxTenNguoiLam;
    }
}