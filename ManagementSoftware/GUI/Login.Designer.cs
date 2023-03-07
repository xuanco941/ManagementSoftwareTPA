namespace ManagementSoftware.GUI
{
    partial class Login
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Login));
            label2 = new Label();
            label1 = new Label();
            textBoxTaiKhoan = new LW_PhanMemBaoGia.MyControls.TextBoxT();
            textBoxMatKhau = new LW_PhanMemBaoGia.MyControls.TextBoxT();
            buttonExit = new LW_PhanMemBaoGia.MyControls.ButtonCustom();
            buttonDangNhap = new LW_PhanMemBaoGia.MyControls.ButtonCustom();
            label3 = new Label();
            pictureBox2 = new PictureBox();
            panel1 = new Panel();
            buttonChangeStringConnect = new Button();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).BeginInit();
            panel1.SuspendLayout();
            SuspendLayout();
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 11.25F, FontStyle.Regular, GraphicsUnit.Point);
            label2.ForeColor = Color.Transparent;
            label2.Location = new Point(141, 188);
            label2.Margin = new Padding(4, 0, 4, 0);
            label2.Name = "label2";
            label2.Size = new Size(73, 20);
            label2.TabIndex = 8;
            label2.Text = "Mật khẩu:";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 11.25F, FontStyle.Regular, GraphicsUnit.Point);
            label1.ForeColor = Color.Transparent;
            label1.Location = new Point(141, 134);
            label1.Margin = new Padding(4, 0, 4, 0);
            label1.Name = "label1";
            label1.Size = new Size(74, 20);
            label1.TabIndex = 7;
            label1.Text = "Tài khoản:";
            // 
            // textBoxTaiKhoan
            // 
            textBoxTaiKhoan.BackColor = SystemColors.Window;
            textBoxTaiKhoan.BorderColor = Color.CornflowerBlue;
            textBoxTaiKhoan.BorderFocusColor = SystemColors.ActiveCaption;
            textBoxTaiKhoan.BorderRadius = 5;
            textBoxTaiKhoan.BorderSize = 1;
            textBoxTaiKhoan.Font = new Font("Microsoft Sans Serif", 11.25F, FontStyle.Regular, GraphicsUnit.Point);
            textBoxTaiKhoan.Location = new Point(232, 127);
            textBoxTaiKhoan.Margin = new Padding(4, 3, 4, 3);
            textBoxTaiKhoan.Multiline = false;
            textBoxTaiKhoan.Name = "textBoxTaiKhoan";
            textBoxTaiKhoan.Padding = new Padding(8);
            textBoxTaiKhoan.PasswordChar = false;
            textBoxTaiKhoan.PlaceholderColor = Color.DarkGray;
            textBoxTaiKhoan.PlaceholderText = "";
            textBoxTaiKhoan.Size = new Size(241, 35);
            textBoxTaiKhoan.TabIndex = 14;
            textBoxTaiKhoan.Texts = "";
            textBoxTaiKhoan.UnderlinedStyle = false;
            textBoxTaiKhoan.KeyDown += textBoxTaiKhoan_KeyDown;
            // 
            // textBoxMatKhau
            // 
            textBoxMatKhau.BackColor = SystemColors.Window;
            textBoxMatKhau.BorderColor = Color.CornflowerBlue;
            textBoxMatKhau.BorderFocusColor = SystemColors.ActiveCaption;
            textBoxMatKhau.BorderRadius = 5;
            textBoxMatKhau.BorderSize = 1;
            textBoxMatKhau.Font = new Font("Microsoft Sans Serif", 11.25F, FontStyle.Regular, GraphicsUnit.Point);
            textBoxMatKhau.Location = new Point(232, 181);
            textBoxMatKhau.Margin = new Padding(4, 3, 4, 3);
            textBoxMatKhau.Multiline = false;
            textBoxMatKhau.Name = "textBoxMatKhau";
            textBoxMatKhau.Padding = new Padding(8);
            textBoxMatKhau.PasswordChar = true;
            textBoxMatKhau.PlaceholderColor = Color.DarkGray;
            textBoxMatKhau.PlaceholderText = "";
            textBoxMatKhau.Size = new Size(241, 35);
            textBoxMatKhau.TabIndex = 15;
            textBoxMatKhau.Texts = "";
            textBoxMatKhau.UnderlinedStyle = false;
            textBoxMatKhau.KeyDown += textBoxTaiKhoan_KeyDown;
            // 
            // buttonExit
            // 
            buttonExit.BackColor = Color.Firebrick;
            buttonExit.BackgroundColor = Color.Firebrick;
            buttonExit.BorderColor = Color.PaleVioletRed;
            buttonExit.BorderRadius = 15;
            buttonExit.BorderSize = 0;
            buttonExit.Cursor = Cursors.Hand;
            buttonExit.FlatStyle = FlatStyle.Flat;
            buttonExit.Font = new Font("Segoe UI Semibold", 9.75F, FontStyle.Bold, GraphicsUnit.Point);
            buttonExit.ForeColor = Color.White;
            buttonExit.Image = (Image)resources.GetObject("buttonExit.Image");
            buttonExit.ImageAlign = ContentAlignment.MiddleLeft;
            buttonExit.Location = new Point(368, 239);
            buttonExit.Margin = new Padding(4, 3, 4, 3);
            buttonExit.Name = "buttonExit";
            buttonExit.Size = new Size(104, 42);
            buttonExit.TabIndex = 13;
            buttonExit.Text = "Thoát";
            buttonExit.TextAlign = ContentAlignment.MiddleRight;
            buttonExit.TextColor = Color.White;
            buttonExit.TextImageRelation = TextImageRelation.TextBeforeImage;
            buttonExit.UseVisualStyleBackColor = false;
            buttonExit.Click += buttonExit_Click;
            // 
            // buttonDangNhap
            // 
            buttonDangNhap.BackColor = Color.SteelBlue;
            buttonDangNhap.BackgroundColor = Color.SteelBlue;
            buttonDangNhap.BorderColor = Color.PaleVioletRed;
            buttonDangNhap.BorderRadius = 15;
            buttonDangNhap.BorderSize = 0;
            buttonDangNhap.Cursor = Cursors.Hand;
            buttonDangNhap.FlatStyle = FlatStyle.Flat;
            buttonDangNhap.Font = new Font("Segoe UI Semibold", 9.75F, FontStyle.Bold, GraphicsUnit.Point);
            buttonDangNhap.ForeColor = Color.White;
            buttonDangNhap.Image = (Image)resources.GetObject("buttonDangNhap.Image");
            buttonDangNhap.ImageAlign = ContentAlignment.MiddleLeft;
            buttonDangNhap.Location = new Point(232, 239);
            buttonDangNhap.Margin = new Padding(4, 3, 4, 3);
            buttonDangNhap.Name = "buttonDangNhap";
            buttonDangNhap.Size = new Size(118, 42);
            buttonDangNhap.TabIndex = 12;
            buttonDangNhap.Text = "Đăng nhập";
            buttonDangNhap.TextAlign = ContentAlignment.MiddleRight;
            buttonDangNhap.TextColor = Color.White;
            buttonDangNhap.TextImageRelation = TextImageRelation.TextBeforeImage;
            buttonDangNhap.UseVisualStyleBackColor = false;
            buttonDangNhap.Click += buttonDangNhap_Click;
            // 
            // label3
            // 
            label3.Dock = DockStyle.Fill;
            label3.Font = new Font("MS Reference Sans Serif", 24F, FontStyle.Bold, GraphicsUnit.Point);
            label3.ForeColor = Color.CornflowerBlue;
            label3.Location = new Point(0, 0);
            label3.Margin = new Padding(4, 0, 4, 0);
            label3.Name = "label3";
            label3.Size = new Size(642, 104);
            label3.TabIndex = 10;
            label3.Text = "MÁY NẠP KHÍ TPA";
            label3.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // pictureBox2
            // 
            pictureBox2.Anchor = AnchorStyles.Bottom | AnchorStyles.Right;
            pictureBox2.Image = (Image)resources.GetObject("pictureBox2.Image");
            pictureBox2.Location = new Point(555, 336);
            pictureBox2.Margin = new Padding(4, 3, 4, 3);
            pictureBox2.Name = "pictureBox2";
            pictureBox2.Size = new Size(87, 24);
            pictureBox2.SizeMode = PictureBoxSizeMode.CenterImage;
            pictureBox2.TabIndex = 17;
            pictureBox2.TabStop = false;
            // 
            // panel1
            // 
            panel1.Controls.Add(label3);
            panel1.Dock = DockStyle.Top;
            panel1.Location = new Point(0, 0);
            panel1.Name = "panel1";
            panel1.Size = new Size(642, 104);
            panel1.TabIndex = 19;
            // 
            // buttonChangeStringConnect
            // 
            buttonChangeStringConnect.BackColor = Color.FromArgb(32, 32, 32);
            buttonChangeStringConnect.Cursor = Cursors.Hand;
            buttonChangeStringConnect.FlatAppearance.BorderSize = 0;
            buttonChangeStringConnect.FlatStyle = FlatStyle.Flat;
            buttonChangeStringConnect.Font = new Font("Segoe UI", 6.75F, FontStyle.Regular, GraphicsUnit.Point);
            buttonChangeStringConnect.ForeColor = Color.White;
            buttonChangeStringConnect.Location = new Point(0, 327);
            buttonChangeStringConnect.Name = "buttonChangeStringConnect";
            buttonChangeStringConnect.Size = new Size(92, 33);
            buttonChangeStringConnect.TabIndex = 21;
            buttonChangeStringConnect.Text = "Thay chuỗi kết nối Database";
            buttonChangeStringConnect.UseVisualStyleBackColor = false;
            buttonChangeStringConnect.Click += buttonBepTu_Click;
            // 
            // Login
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(41, 44, 51);
            ClientSize = new Size(642, 361);
            Controls.Add(buttonChangeStringConnect);
            Controls.Add(panel1);
            Controls.Add(pictureBox2);
            Controls.Add(textBoxMatKhau);
            Controls.Add(textBoxTaiKhoan);
            Controls.Add(buttonExit);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(buttonDangNhap);
            FormBorderStyle = FormBorderStyle.None;
            Icon = (Icon)resources.GetObject("$this.Icon");
            Margin = new Padding(4, 3, 4, 3);
            MaximizeBox = false;
            MinimizeBox = false;
            Name = "Login";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Đăng nhập";
            Load += Login_Load;
            ((System.ComponentModel.ISupportInitialize)pictureBox2).EndInit();
            panel1.ResumeLayout(false);
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private LW_PhanMemBaoGia.MyControls.ButtonCustom buttonDangNhap;
        private LW_PhanMemBaoGia.MyControls.ButtonCustom buttonExit;
        private LW_PhanMemBaoGia.MyControls.TextBoxT textBoxTaiKhoan;
        private LW_PhanMemBaoGia.MyControls.TextBoxT textBoxMatKhau;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.PictureBox pictureBox2;
        private Panel panel1;
        private Button buttonChangeStringConnect;
    }
}