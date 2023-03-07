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
            components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormAddProductOnPO));
            label8 = new Label();
            panel1 = new Panel();
            buttonThem = new LW_PhanMemBaoGia.MyControls.ButtonCustom();
            label4 = new Label();
            label1 = new Label();
            txtSlsx = new Syncfusion.Windows.Forms.Tools.IntegerTextBox();
            txtProductName = new Syncfusion.Windows.Forms.Tools.TextBoxExt();
            label2 = new Label();
            label3 = new Label();
            txtLoaiKhi = new Syncfusion.Windows.Forms.Tools.TextBoxExt();
            label5 = new Label();
            label6 = new Label();
            txtTheTichBinh = new Syncfusion.Windows.Forms.Tools.DoubleTextBox();
            txtApSuatNap = new Syncfusion.Windows.Forms.Tools.DoubleTextBox();
            txtChatLuongKhi = new Syncfusion.Windows.Forms.Tools.IntegerTextBox();
            QuyCachDouble = new Syncfusion.Windows.Forms.Tools.DoubleTextBox();
            label7 = new Label();
            panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)txtSlsx).BeginInit();
            ((System.ComponentModel.ISupportInitialize)txtProductName).BeginInit();
            ((System.ComponentModel.ISupportInitialize)txtLoaiKhi).BeginInit();
            ((System.ComponentModel.ISupportInitialize)txtTheTichBinh).BeginInit();
            ((System.ComponentModel.ISupportInitialize)txtApSuatNap).BeginInit();
            ((System.ComponentModel.ISupportInitialize)txtChatLuongKhi).BeginInit();
            ((System.ComponentModel.ISupportInitialize)QuyCachDouble).BeginInit();
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
            label8.Size = new Size(850, 96);
            label8.TabIndex = 31;
            label8.Text = "Thêm Sản Phẩm";
            label8.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // panel1
            // 
            panel1.Controls.Add(label8);
            panel1.Dock = DockStyle.Top;
            panel1.Location = new Point(0, 0);
            panel1.Name = "panel1";
            panel1.Size = new Size(850, 96);
            panel1.TabIndex = 88;
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
            buttonThem.Location = new Point(344, 450);
            buttonThem.Margin = new Padding(4, 3, 4, 3);
            buttonThem.Name = "buttonThem";
            buttonThem.Size = new Size(147, 42);
            buttonThem.TabIndex = 86;
            buttonThem.Text = "Thêm";
            buttonThem.TextAlign = ContentAlignment.MiddleRight;
            buttonThem.TextColor = Color.White;
            buttonThem.TextImageRelation = TextImageRelation.TextBeforeImage;
            buttonThem.UseVisualStyleBackColor = false;
            buttonThem.Click += buttonThem_Click;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            label4.ForeColor = SystemColors.Control;
            label4.Location = new Point(437, 119);
            label4.Margin = new Padding(4, 0, 4, 0);
            label4.Name = "label4";
            label4.Size = new Size(134, 21);
            label4.TabIndex = 81;
            label4.Text = "Số lượng sản xuất";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            label1.ForeColor = SystemColors.Control;
            label1.Location = new Point(155, 119);
            label1.Margin = new Padding(4, 0, 4, 0);
            label1.Name = "label1";
            label1.Size = new Size(105, 21);
            label1.TabIndex = 79;
            label1.Text = "Tên sản phẩm";
            // 
            // txtSlsx
            // 
            txtSlsx.BeforeTouchSize = new Size(235, 33);
            txtSlsx.BorderColor = Color.CornflowerBlue;
            txtSlsx.BorderStyle = BorderStyle.FixedSingle;
            txtSlsx.Font = new Font("Segoe UI", 14.25F, FontStyle.Regular, GraphicsUnit.Point);
            txtSlsx.IntegerValue = 0L;
            txtSlsx.Location = new Point(437, 143);
            txtSlsx.Margin = new Padding(4, 3, 4, 3);
            txtSlsx.MinValue = 0L;
            txtSlsx.Name = "txtSlsx";
            txtSlsx.Size = new Size(235, 33);
            txtSlsx.TabIndex = 89;
            txtSlsx.Text = "0";
            // 
            // txtProductName
            // 
            txtProductName.BeforeTouchSize = new Size(235, 33);
            txtProductName.BorderColor = Color.CornflowerBlue;
            txtProductName.BorderStyle = BorderStyle.FixedSingle;
            txtProductName.Font = new Font("Segoe UI", 14.25F, FontStyle.Regular, GraphicsUnit.Point);
            txtProductName.Location = new Point(155, 143);
            txtProductName.Name = "txtProductName";
            txtProductName.Size = new Size(235, 33);
            txtProductName.TabIndex = 90;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            label2.ForeColor = SystemColors.Control;
            label2.Location = new Point(155, 197);
            label2.Margin = new Padding(4, 0, 4, 0);
            label2.Name = "label2";
            label2.Size = new Size(87, 21);
            label2.TabIndex = 91;
            label2.Text = "Chất lượng";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            label3.ForeColor = SystemColors.Control;
            label3.Location = new Point(437, 197);
            label3.Margin = new Padding(4, 0, 4, 0);
            label3.Name = "label3";
            label3.Size = new Size(92, 21);
            label3.TabIndex = 93;
            label3.Text = "Áp suất nạp";
            // 
            // txtLoaiKhi
            // 
            txtLoaiKhi.BeforeTouchSize = new Size(235, 33);
            txtLoaiKhi.BorderColor = Color.CornflowerBlue;
            txtLoaiKhi.BorderStyle = BorderStyle.FixedSingle;
            txtLoaiKhi.Font = new Font("Segoe UI", 14.25F, FontStyle.Regular, GraphicsUnit.Point);
            txtLoaiKhi.Location = new Point(155, 299);
            txtLoaiKhi.Name = "txtLoaiKhi";
            txtLoaiKhi.Size = new Size(235, 33);
            txtLoaiKhi.TabIndex = 96;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            label5.ForeColor = SystemColors.Control;
            label5.Location = new Point(155, 275);
            label5.Margin = new Padding(4, 0, 4, 0);
            label5.Name = "label5";
            label5.Size = new Size(64, 21);
            label5.TabIndex = 95;
            label5.Text = "Loại khí";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            label6.ForeColor = SystemColors.Control;
            label6.Location = new Point(437, 275);
            label6.Margin = new Padding(4, 0, 4, 0);
            label6.Name = "label6";
            label6.Size = new Size(99, 21);
            label6.TabIndex = 98;
            label6.Text = "Thể tích bình";
            // 
            // txtTheTichBinh
            // 
            txtTheTichBinh.BeforeTouchSize = new Size(235, 33);
            txtTheTichBinh.BorderColor = Color.CornflowerBlue;
            txtTheTichBinh.BorderStyle = BorderStyle.FixedSingle;
            txtTheTichBinh.DoubleValue = 0D;
            txtTheTichBinh.Font = new Font("Segoe UI", 14.25F, FontStyle.Regular, GraphicsUnit.Point);
            txtTheTichBinh.Location = new Point(437, 299);
            txtTheTichBinh.MinValue = 0D;
            txtTheTichBinh.Name = "txtTheTichBinh";
            txtTheTichBinh.NumberDecimalDigits = 3;
            txtTheTichBinh.Size = new Size(235, 33);
            txtTheTichBinh.TabIndex = 100;
            txtTheTichBinh.Text = "0.000";
            // 
            // txtApSuatNap
            // 
            txtApSuatNap.BeforeTouchSize = new Size(235, 33);
            txtApSuatNap.BorderColor = Color.CornflowerBlue;
            txtApSuatNap.BorderStyle = BorderStyle.FixedSingle;
            txtApSuatNap.DoubleValue = 0D;
            txtApSuatNap.Font = new Font("Segoe UI", 14.25F, FontStyle.Regular, GraphicsUnit.Point);
            txtApSuatNap.Location = new Point(437, 221);
            txtApSuatNap.MinValue = 0D;
            txtApSuatNap.Name = "txtApSuatNap";
            txtApSuatNap.NumberDecimalDigits = 3;
            txtApSuatNap.Size = new Size(235, 33);
            txtApSuatNap.TabIndex = 101;
            txtApSuatNap.Text = "0.000";
            // 
            // txtChatLuongKhi
            // 
            txtChatLuongKhi.BeforeTouchSize = new Size(235, 33);
            txtChatLuongKhi.BorderColor = Color.CornflowerBlue;
            txtChatLuongKhi.BorderStyle = BorderStyle.FixedSingle;
            txtChatLuongKhi.Font = new Font("Segoe UI", 14.25F, FontStyle.Regular, GraphicsUnit.Point);
            txtChatLuongKhi.IntegerValue = 0L;
            txtChatLuongKhi.Location = new Point(155, 221);
            txtChatLuongKhi.Margin = new Padding(4, 3, 4, 3);
            txtChatLuongKhi.MinValue = 0L;
            txtChatLuongKhi.Name = "txtChatLuongKhi";
            txtChatLuongKhi.Size = new Size(235, 33);
            txtChatLuongKhi.TabIndex = 102;
            txtChatLuongKhi.Text = "0";
            // 
            // QuyCachDouble
            // 
            QuyCachDouble.BeforeTouchSize = new Size(235, 33);
            QuyCachDouble.BorderColor = Color.CornflowerBlue;
            QuyCachDouble.BorderStyle = BorderStyle.FixedSingle;
            QuyCachDouble.DoubleValue = 0D;
            QuyCachDouble.Font = new Font("Segoe UI", 14.25F, FontStyle.Regular, GraphicsUnit.Point);
            QuyCachDouble.Location = new Point(155, 380);
            QuyCachDouble.MinValue = 0D;
            QuyCachDouble.Name = "QuyCachDouble";
            QuyCachDouble.NumberDecimalDigits = 3;
            QuyCachDouble.Size = new Size(235, 33);
            QuyCachDouble.TabIndex = 104;
            QuyCachDouble.Text = "0.000";
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            label7.ForeColor = SystemColors.Control;
            label7.Location = new Point(155, 356);
            label7.Margin = new Padding(4, 0, 4, 0);
            label7.Name = "label7";
            label7.Size = new Size(96, 21);
            label7.TabIndex = 103;
            label7.Text = "Quy cách (L)";
            // 
            // FormAddProductOnPO
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(41, 44, 51);
            ClientSize = new Size(850, 546);
            Controls.Add(QuyCachDouble);
            Controls.Add(label7);
            Controls.Add(txtChatLuongKhi);
            Controls.Add(txtApSuatNap);
            Controls.Add(txtTheTichBinh);
            Controls.Add(label6);
            Controls.Add(txtLoaiKhi);
            Controls.Add(label5);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(txtProductName);
            Controls.Add(txtSlsx);
            Controls.Add(panel1);
            Controls.Add(buttonThem);
            Controls.Add(label4);
            Controls.Add(label1);
            MaximizeBox = false;
            MinimizeBox = false;
            Name = "FormAddProductOnPO";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "FormAddProductOnPO";
            panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)txtSlsx).EndInit();
            ((System.ComponentModel.ISupportInitialize)txtProductName).EndInit();
            ((System.ComponentModel.ISupportInitialize)txtLoaiKhi).EndInit();
            ((System.ComponentModel.ISupportInitialize)txtTheTichBinh).EndInit();
            ((System.ComponentModel.ISupportInitialize)txtApSuatNap).EndInit();
            ((System.ComponentModel.ISupportInitialize)txtChatLuongKhi).EndInit();
            ((System.ComponentModel.ISupportInitialize)QuyCachDouble).EndInit();
            ResumeLayout(false);
            PerformLayout();
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
        private Syncfusion.Windows.Forms.Tools.DoubleTextBox QuyCachDouble;
        private Label label7;
    }
}