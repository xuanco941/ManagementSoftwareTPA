using System.Windows.Forms;

namespace ManagementSoftware.GUI.EmployeeManagement
{
    partial class FormAddUser
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormAddUser));
            label8 = new Label();
            textBoxFullName = new LW_PhanMemBaoGia.MyControls.TextBoxT();
            textBoxUsername = new LW_PhanMemBaoGia.MyControls.TextBoxT();
            textBoxPassword = new LW_PhanMemBaoGia.MyControls.TextBoxT();
            label1 = new Label();
            label2 = new Label();
            label4 = new Label();
            label3 = new Label();
            buttonThem = new LW_PhanMemBaoGia.MyControls.ButtonCustom();
            comboBoxSelectGroup = new ComboBox();
            panel1 = new Panel();
            textBoxtEmail = new LW_PhanMemBaoGia.MyControls.TextBoxT();
            label5 = new Label();
            textBoxtSDT = new LW_PhanMemBaoGia.MyControls.TextBoxT();
            label6 = new Label();
            panel1.SuspendLayout();
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
            label8.Size = new Size(857, 96);
            label8.TabIndex = 31;
            label8.Text = "Thêm Thành Viên";
            label8.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // textBoxFullName
            // 
            textBoxFullName.BackColor = SystemColors.Window;
            textBoxFullName.BorderColor = Color.CornflowerBlue;
            textBoxFullName.BorderFocusColor = SystemColors.ActiveCaption;
            textBoxFullName.BorderRadius = 5;
            textBoxFullName.BorderSize = 1;
            textBoxFullName.Font = new Font("Segoe UI", 11.25F, FontStyle.Regular, GraphicsUnit.Point);
            textBoxFullName.Location = new Point(175, 127);
            textBoxFullName.Margin = new Padding(4, 3, 4, 3);
            textBoxFullName.Multiline = false;
            textBoxFullName.Name = "textBoxFullName";
            textBoxFullName.Padding = new Padding(8);
            textBoxFullName.PasswordChar = false;
            textBoxFullName.PlaceholderColor = Color.DarkGray;
            textBoxFullName.PlaceholderText = "";
            textBoxFullName.Size = new Size(505, 37);
            textBoxFullName.TabIndex = 49;
            textBoxFullName.Texts = "";
            textBoxFullName.UnderlinedStyle = false;
            // 
            // textBoxUsername
            // 
            textBoxUsername.BackColor = SystemColors.Window;
            textBoxUsername.BorderColor = Color.CornflowerBlue;
            textBoxUsername.BorderFocusColor = SystemColors.ActiveCaption;
            textBoxUsername.BorderRadius = 5;
            textBoxUsername.BorderSize = 1;
            textBoxUsername.Font = new Font("Segoe UI", 11.25F, FontStyle.Regular, GraphicsUnit.Point);
            textBoxUsername.Location = new Point(175, 201);
            textBoxUsername.Margin = new Padding(4, 3, 4, 3);
            textBoxUsername.Multiline = false;
            textBoxUsername.Name = "textBoxUsername";
            textBoxUsername.Padding = new Padding(8);
            textBoxUsername.PasswordChar = false;
            textBoxUsername.PlaceholderColor = Color.DarkGray;
            textBoxUsername.PlaceholderText = "";
            textBoxUsername.Size = new Size(233, 37);
            textBoxUsername.TabIndex = 50;
            textBoxUsername.Texts = "";
            textBoxUsername.UnderlinedStyle = false;
            // 
            // textBoxPassword
            // 
            textBoxPassword.BackColor = SystemColors.Window;
            textBoxPassword.BorderColor = Color.CornflowerBlue;
            textBoxPassword.BorderFocusColor = SystemColors.ActiveCaption;
            textBoxPassword.BorderRadius = 5;
            textBoxPassword.BorderSize = 1;
            textBoxPassword.Font = new Font("Segoe UI", 11.25F, FontStyle.Regular, GraphicsUnit.Point);
            textBoxPassword.Location = new Point(447, 201);
            textBoxPassword.Margin = new Padding(4, 3, 4, 3);
            textBoxPassword.Multiline = false;
            textBoxPassword.Name = "textBoxPassword";
            textBoxPassword.Padding = new Padding(8);
            textBoxPassword.PasswordChar = false;
            textBoxPassword.PlaceholderColor = Color.DarkGray;
            textBoxPassword.PlaceholderText = "";
            textBoxPassword.Size = new Size(233, 37);
            textBoxPassword.TabIndex = 51;
            textBoxPassword.Texts = "";
            textBoxPassword.UnderlinedStyle = false;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            label1.ForeColor = SystemColors.Control;
            label1.Location = new Point(170, 99);
            label1.Margin = new Padding(4, 0, 4, 0);
            label1.Name = "label1";
            label1.Size = new Size(56, 21);
            label1.TabIndex = 7;
            label1.Text = "Họ tên";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            label2.ForeColor = SystemColors.Control;
            label2.Location = new Point(442, 173);
            label2.Margin = new Padding(4, 0, 4, 0);
            label2.Name = "label2";
            label2.Size = new Size(75, 21);
            label2.TabIndex = 8;
            label2.Text = "Mật khẩu";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            label4.ForeColor = SystemColors.Control;
            label4.Location = new Point(170, 173);
            label4.Margin = new Padding(4, 0, 4, 0);
            label4.Name = "label4";
            label4.Size = new Size(75, 21);
            label4.TabIndex = 10;
            label4.Text = "Tài khoản";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            label3.ForeColor = SystemColors.Control;
            label3.Location = new Point(173, 420);
            label3.Margin = new Padding(4, 0, 4, 0);
            label3.Name = "label3";
            label3.Size = new Size(101, 21);
            label3.TabIndex = 25;
            label3.Text = "Nhóm quyền";
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
            buttonThem.Font = new Font("Segoe UI", 14.25F, FontStyle.Bold, GraphicsUnit.Point);
            buttonThem.ForeColor = Color.White;
            buttonThem.Image = (Image)resources.GetObject("buttonThem.Image");
            buttonThem.ImageAlign = ContentAlignment.MiddleLeft;
            buttonThem.Location = new Point(349, 530);
            buttonThem.Margin = new Padding(4, 3, 4, 3);
            buttonThem.Name = "buttonThem";
            buttonThem.Size = new Size(168, 51);
            buttonThem.TabIndex = 56;
            buttonThem.Text = "Thêm";
            buttonThem.TextAlign = ContentAlignment.MiddleRight;
            buttonThem.TextColor = Color.White;
            buttonThem.TextImageRelation = TextImageRelation.TextBeforeImage;
            buttonThem.UseVisualStyleBackColor = false;
            buttonThem.Click += buttonThem_Click;
            // 
            // comboBoxSelectGroup
            // 
            comboBoxSelectGroup.DropDownStyle = ComboBoxStyle.DropDownList;
            comboBoxSelectGroup.Font = new Font("Segoe UI", 14.25F, FontStyle.Regular, GraphicsUnit.Point);
            comboBoxSelectGroup.FormattingEnabled = true;
            comboBoxSelectGroup.IntegralHeight = false;
            comboBoxSelectGroup.ItemHeight = 25;
            comboBoxSelectGroup.Location = new Point(173, 444);
            comboBoxSelectGroup.Margin = new Padding(4, 3, 4, 3);
            comboBoxSelectGroup.MaxDropDownItems = 9;
            comboBoxSelectGroup.Name = "comboBoxSelectGroup";
            comboBoxSelectGroup.Size = new Size(507, 33);
            comboBoxSelectGroup.TabIndex = 77;
            // 
            // panel1
            // 
            panel1.Controls.Add(label8);
            panel1.Dock = DockStyle.Top;
            panel1.Location = new Point(0, 0);
            panel1.Name = "panel1";
            panel1.Size = new Size(857, 96);
            panel1.TabIndex = 78;
            // 
            // textBoxtEmail
            // 
            textBoxtEmail.BackColor = SystemColors.Window;
            textBoxtEmail.BorderColor = Color.CornflowerBlue;
            textBoxtEmail.BorderFocusColor = SystemColors.ActiveCaption;
            textBoxtEmail.BorderRadius = 5;
            textBoxtEmail.BorderSize = 1;
            textBoxtEmail.Font = new Font("Segoe UI", 11.25F, FontStyle.Regular, GraphicsUnit.Point);
            textBoxtEmail.Location = new Point(175, 284);
            textBoxtEmail.Margin = new Padding(4, 3, 4, 3);
            textBoxtEmail.Multiline = false;
            textBoxtEmail.Name = "textBoxtEmail";
            textBoxtEmail.Padding = new Padding(8);
            textBoxtEmail.PasswordChar = false;
            textBoxtEmail.PlaceholderColor = Color.DarkGray;
            textBoxtEmail.PlaceholderText = "";
            textBoxtEmail.Size = new Size(505, 37);
            textBoxtEmail.TabIndex = 80;
            textBoxtEmail.Texts = "";
            textBoxtEmail.UnderlinedStyle = false;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            label5.ForeColor = SystemColors.Control;
            label5.Location = new Point(170, 256);
            label5.Margin = new Padding(4, 0, 4, 0);
            label5.Name = "label5";
            label5.Size = new Size(48, 21);
            label5.TabIndex = 79;
            label5.Text = "Email";
            // 
            // textBoxtSDT
            // 
            textBoxtSDT.BackColor = SystemColors.Window;
            textBoxtSDT.BorderColor = Color.CornflowerBlue;
            textBoxtSDT.BorderFocusColor = SystemColors.ActiveCaption;
            textBoxtSDT.BorderRadius = 5;
            textBoxtSDT.BorderSize = 1;
            textBoxtSDT.Font = new Font("Segoe UI", 11.25F, FontStyle.Regular, GraphicsUnit.Point);
            textBoxtSDT.Location = new Point(175, 362);
            textBoxtSDT.Margin = new Padding(4, 3, 4, 3);
            textBoxtSDT.Multiline = false;
            textBoxtSDT.Name = "textBoxtSDT";
            textBoxtSDT.Padding = new Padding(8);
            textBoxtSDT.PasswordChar = false;
            textBoxtSDT.PlaceholderColor = Color.DarkGray;
            textBoxtSDT.PlaceholderText = "";
            textBoxtSDT.Size = new Size(505, 37);
            textBoxtSDT.TabIndex = 82;
            textBoxtSDT.Texts = "";
            textBoxtSDT.UnderlinedStyle = false;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            label6.ForeColor = SystemColors.Control;
            label6.Location = new Point(170, 334);
            label6.Margin = new Padding(4, 0, 4, 0);
            label6.Name = "label6";
            label6.Size = new Size(101, 21);
            label6.TabIndex = 81;
            label6.Text = "Số điện thoại";
            // 
            // FormAddUser
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(41, 44, 51);
            ClientSize = new Size(857, 625);
            Controls.Add(textBoxtSDT);
            Controls.Add(label6);
            Controls.Add(textBoxtEmail);
            Controls.Add(label5);
            Controls.Add(panel1);
            Controls.Add(comboBoxSelectGroup);
            Controls.Add(buttonThem);
            Controls.Add(textBoxPassword);
            Controls.Add(textBoxUsername);
            Controls.Add(textBoxFullName);
            Controls.Add(label3);
            Controls.Add(label4);
            Controls.Add(label2);
            Controls.Add(label1);
            Icon = (Icon)resources.GetObject("$this.Icon");
            Margin = new Padding(4, 3, 4, 3);
            MaximizeBox = false;
            MinimizeBox = false;
            Name = "FormAddUser";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Thêm nhân viên";
            Load += FormAddUser_Load;
            panel1.ResumeLayout(false);
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
        private Label label8;
        private LW_PhanMemBaoGia.MyControls.TextBoxT textBoxFullName;
        private LW_PhanMemBaoGia.MyControls.TextBoxT textBoxUsername;
        private LW_PhanMemBaoGia.MyControls.TextBoxT textBoxPassword;
        private Label label1;
        private Label label2;
        private Label label4;
        private Label label3;
        private LW_PhanMemBaoGia.MyControls.ButtonCustom buttonThem;
        private ComboBox comboBoxSelectGroup;
        private Panel panel1;
        private LW_PhanMemBaoGia.MyControls.TextBoxT textBoxtEmail;
        private Label label5;
        private LW_PhanMemBaoGia.MyControls.TextBoxT textBoxtSDT;
        private Label label6;
    }
}