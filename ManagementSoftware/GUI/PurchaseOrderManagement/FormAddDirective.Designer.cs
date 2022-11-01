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
            this.label8 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.buttonThem = new LW_PhanMemBaoGia.MyControls.ButtonCustom();
            this.label1 = new System.Windows.Forms.Label();
            this.txtSoLuongSX = new Syncfusion.Windows.Forms.Tools.IntegerTextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.NgayBatDau = new Syncfusion.WinForms.Input.SfDateTimeEdit();
            this.NgayKetThuc = new Syncfusion.WinForms.Input.SfDateTimeEdit();
            this.comboBoxTenNguoiLam = new System.Windows.Forms.ComboBox();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.txtSoLuongSX)).BeginInit();
            this.SuspendLayout();
            // 
            // label8
            // 
            this.label8.Dock = System.Windows.Forms.DockStyle.Fill;
            this.label8.Font = new System.Drawing.Font("Segoe UI Semibold", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label8.ForeColor = System.Drawing.Color.YellowGreen;
            this.label8.Location = new System.Drawing.Point(0, 0);
            this.label8.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(692, 96);
            this.label8.TabIndex = 31;
            this.label8.Text = "Thêm Chỉ Thị Sản Xuất Mới";
            this.label8.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label5.ForeColor = System.Drawing.SystemColors.Control;
            this.label5.Location = new System.Drawing.Point(155, 275);
            this.label5.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(103, 21);
            this.label5.TabIndex = 111;
            this.label5.Text = "Ngày bắt đầu";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label2.ForeColor = System.Drawing.SystemColors.Control;
            this.label2.Location = new System.Drawing.Point(155, 197);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(134, 21);
            this.label2.TabIndex = 109;
            this.label2.Text = "Số lượng sản xuất";
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.label8);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(692, 96);
            this.panel1.TabIndex = 106;
            // 
            // buttonThem
            // 
            this.buttonThem.BackColor = System.Drawing.Color.Green;
            this.buttonThem.BackgroundColor = System.Drawing.Color.Green;
            this.buttonThem.BorderColor = System.Drawing.Color.PaleVioletRed;
            this.buttonThem.BorderRadius = 3;
            this.buttonThem.BorderSize = 0;
            this.buttonThem.Cursor = System.Windows.Forms.Cursors.Hand;
            this.buttonThem.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonThem.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.buttonThem.ForeColor = System.Drawing.Color.White;
            this.buttonThem.Image = ((System.Drawing.Image)(resources.GetObject("buttonThem.Image")));
            this.buttonThem.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.buttonThem.Location = new System.Drawing.Point(250, 373);
            this.buttonThem.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.buttonThem.Name = "buttonThem";
            this.buttonThem.Size = new System.Drawing.Size(175, 42);
            this.buttonThem.TabIndex = 105;
            this.buttonThem.Text = "Thêm";
            this.buttonThem.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.buttonThem.TextColor = System.Drawing.Color.White;
            this.buttonThem.TextImageRelation = System.Windows.Forms.TextImageRelation.TextBeforeImage;
            this.buttonThem.UseVisualStyleBackColor = false;
            this.buttonThem.Click += new System.EventHandler(this.buttonThem_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label1.ForeColor = System.Drawing.SystemColors.Control;
            this.label1.Location = new System.Drawing.Point(155, 119);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(122, 21);
            this.label1.TabIndex = 103;
            this.label1.Text = "Người thực hiện";
            // 
            // txtSoLuongSX
            // 
            this.txtSoLuongSX.BeforeTouchSize = new System.Drawing.Size(316, 29);
            this.txtSoLuongSX.BorderColor = System.Drawing.Color.CornflowerBlue;
            this.txtSoLuongSX.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtSoLuongSX.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.txtSoLuongSX.IntegerValue = ((long)(0));
            this.txtSoLuongSX.Location = new System.Drawing.Point(155, 221);
            this.txtSoLuongSX.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.txtSoLuongSX.MinValue = ((long)(0));
            this.txtSoLuongSX.Name = "txtSoLuongSX";
            this.txtSoLuongSX.Size = new System.Drawing.Size(381, 33);
            this.txtSoLuongSX.TabIndex = 116;
            this.txtSoLuongSX.Text = "0";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label6.ForeColor = System.Drawing.SystemColors.Control;
            this.label6.Location = new System.Drawing.Point(376, 275);
            this.label6.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(106, 21);
            this.label6.TabIndex = 113;
            this.label6.Text = "Ngày kết thúc";
            // 
            // NgayBatDau
            // 
            this.NgayBatDau.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.NgayBatDau.DateTimePattern = Syncfusion.WinForms.Input.Enums.DateTimePattern.Custom;
            this.NgayBatDau.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.NgayBatDau.Format = "dd/MM/yyyy";
            this.NgayBatDau.Location = new System.Drawing.Point(155, 299);
            this.NgayBatDau.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.NgayBatDau.MinDateTime = new System.DateTime(2022, 1, 1, 23, 59, 0, 0);
            this.NgayBatDau.Name = "NgayBatDau";
            this.NgayBatDau.Size = new System.Drawing.Size(160, 36);
            this.NgayBatDau.TabIndex = 117;
            this.NgayBatDau.Value = new System.DateTime(2022, 10, 1, 23, 59, 0, 0);
            // 
            // NgayKetThuc
            // 
            this.NgayKetThuc.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.NgayKetThuc.DateTimePattern = Syncfusion.WinForms.Input.Enums.DateTimePattern.Custom;
            this.NgayKetThuc.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.NgayKetThuc.Format = "dd/MM/yyyy";
            this.NgayKetThuc.Location = new System.Drawing.Point(376, 299);
            this.NgayKetThuc.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.NgayKetThuc.MinDateTime = new System.DateTime(2022, 1, 1, 23, 59, 0, 0);
            this.NgayKetThuc.Name = "NgayKetThuc";
            this.NgayKetThuc.Size = new System.Drawing.Size(160, 36);
            this.NgayKetThuc.TabIndex = 118;
            this.NgayKetThuc.Value = new System.DateTime(2022, 10, 1, 23, 59, 0, 0);
            // 
            // comboBoxTenNguoiLam
            // 
            this.comboBoxTenNguoiLam.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBoxTenNguoiLam.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.comboBoxTenNguoiLam.FormattingEnabled = true;
            this.comboBoxTenNguoiLam.Location = new System.Drawing.Point(156, 143);
            this.comboBoxTenNguoiLam.Name = "comboBoxTenNguoiLam";
            this.comboBoxTenNguoiLam.Size = new System.Drawing.Size(380, 33);
            this.comboBoxTenNguoiLam.TabIndex = 32;
            // 
            // FormAddDirective
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(41)))), ((int)(((byte)(44)))), ((int)(((byte)(51)))));
            this.ClientSize = new System.Drawing.Size(692, 475);
            this.Controls.Add(this.comboBoxTenNguoiLam);
            this.Controls.Add(this.NgayKetThuc);
            this.Controls.Add(this.NgayBatDau);
            this.Controls.Add(this.txtSoLuongSX);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.buttonThem);
            this.Controls.Add(this.label1);
            this.MaximizeBox = false;
            this.Name = "FormAddDirective";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "FormAddDirective";
            this.panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.txtSoLuongSX)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

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