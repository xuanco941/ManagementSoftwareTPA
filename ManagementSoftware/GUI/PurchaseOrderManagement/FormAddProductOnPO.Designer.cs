namespace ManagementSoftware.GUI.PurchaseOrderManagement
{
    partial class FormAddProductOnPO
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormAddProductOnPO));
            this.label8 = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.buttonThem = new LW_PhanMemBaoGia.MyControls.ButtonCustom();
            this.label4 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.txtSlsx = new Syncfusion.Windows.Forms.Tools.IntegerTextBox();
            this.txtProductName = new Syncfusion.Windows.Forms.Tools.TextBoxExt();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.txtLoaiKhi = new Syncfusion.Windows.Forms.Tools.TextBoxExt();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.txtTheTichBinh = new Syncfusion.Windows.Forms.Tools.DoubleTextBox();
            this.txtApSuatNap = new Syncfusion.Windows.Forms.Tools.DoubleTextBox();
            this.txtChatLuongKhi = new Syncfusion.Windows.Forms.Tools.IntegerTextBox();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.txtSlsx)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtProductName)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtLoaiKhi)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtTheTichBinh)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtApSuatNap)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtChatLuongKhi)).BeginInit();
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
            this.label8.Size = new System.Drawing.Size(831, 96);
            this.label8.TabIndex = 31;
            this.label8.Text = "Thêm Sản Phẩm";
            this.label8.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.label8);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(831, 96);
            this.panel1.TabIndex = 88;
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
            this.buttonThem.Location = new System.Drawing.Point(344, 377);
            this.buttonThem.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.buttonThem.Name = "buttonThem";
            this.buttonThem.Size = new System.Drawing.Size(147, 42);
            this.buttonThem.TabIndex = 86;
            this.buttonThem.Text = "Thêm";
            this.buttonThem.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.buttonThem.TextColor = System.Drawing.Color.White;
            this.buttonThem.TextImageRelation = System.Windows.Forms.TextImageRelation.TextBeforeImage;
            this.buttonThem.UseVisualStyleBackColor = false;
            this.buttonThem.Click += new System.EventHandler(this.buttonThem_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label4.ForeColor = System.Drawing.SystemColors.Control;
            this.label4.Location = new System.Drawing.Point(437, 119);
            this.label4.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(134, 21);
            this.label4.TabIndex = 81;
            this.label4.Text = "Số lượng sản xuất";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label1.ForeColor = System.Drawing.SystemColors.Control;
            this.label1.Location = new System.Drawing.Point(155, 119);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(105, 21);
            this.label1.TabIndex = 79;
            this.label1.Text = "Tên sản phẩm";
            // 
            // txtSlsx
            // 
            this.txtSlsx.BeforeTouchSize = new System.Drawing.Size(235, 33);
            this.txtSlsx.BorderColor = System.Drawing.Color.CornflowerBlue;
            this.txtSlsx.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtSlsx.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.txtSlsx.IntegerValue = ((long)(0));
            this.txtSlsx.Location = new System.Drawing.Point(437, 143);
            this.txtSlsx.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.txtSlsx.MinValue = ((long)(0));
            this.txtSlsx.Name = "txtSlsx";
            this.txtSlsx.Size = new System.Drawing.Size(235, 33);
            this.txtSlsx.TabIndex = 89;
            this.txtSlsx.Text = "0";
            // 
            // txtProductName
            // 
            this.txtProductName.BeforeTouchSize = new System.Drawing.Size(235, 33);
            this.txtProductName.BorderColor = System.Drawing.Color.CornflowerBlue;
            this.txtProductName.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtProductName.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.txtProductName.Location = new System.Drawing.Point(155, 143);
            this.txtProductName.Name = "txtProductName";
            this.txtProductName.Size = new System.Drawing.Size(235, 33);
            this.txtProductName.TabIndex = 90;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label2.ForeColor = System.Drawing.SystemColors.Control;
            this.label2.Location = new System.Drawing.Point(155, 197);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(87, 21);
            this.label2.TabIndex = 91;
            this.label2.Text = "Chất lượng";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label3.ForeColor = System.Drawing.SystemColors.Control;
            this.label3.Location = new System.Drawing.Point(437, 197);
            this.label3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(92, 21);
            this.label3.TabIndex = 93;
            this.label3.Text = "Áp suất nạp";
            // 
            // txtLoaiKhi
            // 
            this.txtLoaiKhi.BeforeTouchSize = new System.Drawing.Size(235, 33);
            this.txtLoaiKhi.BorderColor = System.Drawing.Color.CornflowerBlue;
            this.txtLoaiKhi.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtLoaiKhi.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.txtLoaiKhi.Location = new System.Drawing.Point(155, 299);
            this.txtLoaiKhi.Name = "txtLoaiKhi";
            this.txtLoaiKhi.Size = new System.Drawing.Size(235, 33);
            this.txtLoaiKhi.TabIndex = 96;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label5.ForeColor = System.Drawing.SystemColors.Control;
            this.label5.Location = new System.Drawing.Point(155, 275);
            this.label5.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(64, 21);
            this.label5.TabIndex = 95;
            this.label5.Text = "Loại khí";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label6.ForeColor = System.Drawing.SystemColors.Control;
            this.label6.Location = new System.Drawing.Point(437, 275);
            this.label6.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(99, 21);
            this.label6.TabIndex = 98;
            this.label6.Text = "Thể tích bình";
            // 
            // txtTheTichBinh
            // 
            this.txtTheTichBinh.BeforeTouchSize = new System.Drawing.Size(235, 33);
            this.txtTheTichBinh.BorderColor = System.Drawing.Color.CornflowerBlue;
            this.txtTheTichBinh.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtTheTichBinh.DoubleValue = 0D;
            this.txtTheTichBinh.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.txtTheTichBinh.Location = new System.Drawing.Point(437, 299);
            this.txtTheTichBinh.MinValue = 0D;
            this.txtTheTichBinh.Name = "txtTheTichBinh";
            this.txtTheTichBinh.NumberDecimalDigits = 3;
            this.txtTheTichBinh.Size = new System.Drawing.Size(235, 33);
            this.txtTheTichBinh.TabIndex = 100;
            this.txtTheTichBinh.Text = "0,000";
            // 
            // txtApSuatNap
            // 
            this.txtApSuatNap.BeforeTouchSize = new System.Drawing.Size(235, 33);
            this.txtApSuatNap.BorderColor = System.Drawing.Color.CornflowerBlue;
            this.txtApSuatNap.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtApSuatNap.DoubleValue = 0D;
            this.txtApSuatNap.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.txtApSuatNap.Location = new System.Drawing.Point(437, 221);
            this.txtApSuatNap.MinValue = 0D;
            this.txtApSuatNap.Name = "txtApSuatNap";
            this.txtApSuatNap.NumberDecimalDigits = 3;
            this.txtApSuatNap.Size = new System.Drawing.Size(235, 33);
            this.txtApSuatNap.TabIndex = 101;
            this.txtApSuatNap.Text = "0,000";
            // 
            // txtChatLuongKhi
            // 
            this.txtChatLuongKhi.BeforeTouchSize = new System.Drawing.Size(235, 33);
            this.txtChatLuongKhi.BorderColor = System.Drawing.Color.CornflowerBlue;
            this.txtChatLuongKhi.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtChatLuongKhi.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.txtChatLuongKhi.IntegerValue = ((long)(0));
            this.txtChatLuongKhi.Location = new System.Drawing.Point(155, 221);
            this.txtChatLuongKhi.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.txtChatLuongKhi.MinValue = ((long)(0));
            this.txtChatLuongKhi.Name = "txtChatLuongKhi";
            this.txtChatLuongKhi.Size = new System.Drawing.Size(235, 33);
            this.txtChatLuongKhi.TabIndex = 102;
            this.txtChatLuongKhi.Text = "0";
            // 
            // FormAddProductOnPO
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(41)))), ((int)(((byte)(44)))), ((int)(((byte)(51)))));
            this.ClientSize = new System.Drawing.Size(831, 467);
            this.Controls.Add(this.txtChatLuongKhi);
            this.Controls.Add(this.txtApSuatNap);
            this.Controls.Add(this.txtTheTichBinh);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.txtLoaiKhi);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.txtProductName);
            this.Controls.Add(this.txtSlsx);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.buttonThem);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label1);
            this.Name = "FormAddProductOnPO";
            this.Text = "FormAddProductOnPO";
            this.panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.txtSlsx)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtProductName)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtLoaiKhi)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtTheTichBinh)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtApSuatNap)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtChatLuongKhi)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Label label8;
        private Panel panel1;
        private LW_PhanMemBaoGia.MyControls.ButtonCustom buttonThem;
        private Label label4;
        private Label label1;
        private Syncfusion.Windows.Forms.Tools.IntegerTextBox txtSlsx;
        private Syncfusion.Windows.Forms.Tools.TextBoxExt txtProductName;
        private Label label2;
        private Label label3;
        private Syncfusion.Windows.Forms.Tools.TextBoxExt txtLoaiKhi;
        private Label label5;
        private Label label6;
        private Syncfusion.Windows.Forms.Tools.DoubleTextBox txtTheTichBinh;
        private Syncfusion.Windows.Forms.Tools.DoubleTextBox txtApSuatNap;
        private Syncfusion.Windows.Forms.Tools.IntegerTextBox txtChatLuongKhi;
    }
}