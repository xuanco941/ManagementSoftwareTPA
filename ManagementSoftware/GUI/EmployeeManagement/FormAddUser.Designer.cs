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
            this.label8 = new System.Windows.Forms.Label();
            this.textBoxFullName = new LW_PhanMemBaoGia.MyControls.TextBoxT();
            this.textBoxUsername = new LW_PhanMemBaoGia.MyControls.TextBoxT();
            this.textBoxPassword = new LW_PhanMemBaoGia.MyControls.TextBoxT();
            this.textBoxEmail = new LW_PhanMemBaoGia.MyControls.TextBoxT();
            this.textBoxSoDienThoai = new LW_PhanMemBaoGia.MyControls.TextBoxT();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.buttonThem = new LW_PhanMemBaoGia.MyControls.ButtonCustom();
            this.comboBoxSelectShift = new System.Windows.Forms.ComboBox();
            this.comboBoxSelectGroup = new System.Windows.Forms.ComboBox();
            this.SuspendLayout();
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Showcard Gothic", 18F, System.Drawing.FontStyle.Bold);
            this.label8.ForeColor = System.Drawing.Color.YellowGreen;
            this.label8.Location = new System.Drawing.Point(249, 36);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(243, 30);
            this.label8.TabIndex = 31;
            this.label8.Text = "Thêm Thành Viên";
            // 
            // textBoxFullName
            // 
            this.textBoxFullName.BackColor = System.Drawing.SystemColors.Window;
            this.textBoxFullName.BorderColor = System.Drawing.Color.CornflowerBlue;
            this.textBoxFullName.BorderFocusColor = System.Drawing.SystemColors.ActiveCaption;
            this.textBoxFullName.BorderRadius = 5;
            this.textBoxFullName.BorderSize = 1;
            this.textBoxFullName.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBoxFullName.Location = new System.Drawing.Point(150, 110);
            this.textBoxFullName.Multiline = false;
            this.textBoxFullName.Name = "textBoxFullName";
            this.textBoxFullName.Padding = new System.Windows.Forms.Padding(7);
            this.textBoxFullName.PasswordChar = false;
            this.textBoxFullName.PlaceholderColor = System.Drawing.Color.DarkGray;
            this.textBoxFullName.PlaceholderText = "";
            this.textBoxFullName.Size = new System.Drawing.Size(200, 35);
            this.textBoxFullName.TabIndex = 49;
            this.textBoxFullName.Texts = "";
            this.textBoxFullName.UnderlinedStyle = false;
            // 
            // textBoxUsername
            // 
            this.textBoxUsername.BackColor = System.Drawing.SystemColors.Window;
            this.textBoxUsername.BorderColor = System.Drawing.Color.CornflowerBlue;
            this.textBoxUsername.BorderFocusColor = System.Drawing.SystemColors.ActiveCaption;
            this.textBoxUsername.BorderRadius = 5;
            this.textBoxUsername.BorderSize = 1;
            this.textBoxUsername.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBoxUsername.Location = new System.Drawing.Point(150, 174);
            this.textBoxUsername.Multiline = false;
            this.textBoxUsername.Name = "textBoxUsername";
            this.textBoxUsername.Padding = new System.Windows.Forms.Padding(7);
            this.textBoxUsername.PasswordChar = false;
            this.textBoxUsername.PlaceholderColor = System.Drawing.Color.DarkGray;
            this.textBoxUsername.PlaceholderText = "";
            this.textBoxUsername.Size = new System.Drawing.Size(200, 35);
            this.textBoxUsername.TabIndex = 50;
            this.textBoxUsername.Texts = "";
            this.textBoxUsername.UnderlinedStyle = false;
            // 
            // textBoxPassword
            // 
            this.textBoxPassword.BackColor = System.Drawing.SystemColors.Window;
            this.textBoxPassword.BorderColor = System.Drawing.Color.CornflowerBlue;
            this.textBoxPassword.BorderFocusColor = System.Drawing.SystemColors.ActiveCaption;
            this.textBoxPassword.BorderRadius = 5;
            this.textBoxPassword.BorderSize = 1;
            this.textBoxPassword.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBoxPassword.Location = new System.Drawing.Point(383, 174);
            this.textBoxPassword.Multiline = false;
            this.textBoxPassword.Name = "textBoxPassword";
            this.textBoxPassword.Padding = new System.Windows.Forms.Padding(7);
            this.textBoxPassword.PasswordChar = false;
            this.textBoxPassword.PlaceholderColor = System.Drawing.Color.DarkGray;
            this.textBoxPassword.PlaceholderText = "";
            this.textBoxPassword.Size = new System.Drawing.Size(200, 35);
            this.textBoxPassword.TabIndex = 51;
            this.textBoxPassword.Texts = "";
            this.textBoxPassword.UnderlinedStyle = false;
            // 
            // textBoxEmail
            // 
            this.textBoxEmail.BackColor = System.Drawing.SystemColors.Window;
            this.textBoxEmail.BorderColor = System.Drawing.Color.CornflowerBlue;
            this.textBoxEmail.BorderFocusColor = System.Drawing.SystemColors.ActiveCaption;
            this.textBoxEmail.BorderRadius = 5;
            this.textBoxEmail.BorderSize = 1;
            this.textBoxEmail.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBoxEmail.Location = new System.Drawing.Point(383, 241);
            this.textBoxEmail.Multiline = false;
            this.textBoxEmail.Name = "textBoxEmail";
            this.textBoxEmail.Padding = new System.Windows.Forms.Padding(7);
            this.textBoxEmail.PasswordChar = false;
            this.textBoxEmail.PlaceholderColor = System.Drawing.Color.DarkGray;
            this.textBoxEmail.PlaceholderText = "";
            this.textBoxEmail.Size = new System.Drawing.Size(200, 35);
            this.textBoxEmail.TabIndex = 52;
            this.textBoxEmail.Texts = "";
            this.textBoxEmail.UnderlinedStyle = false;
            // 
            // textBoxSoDienThoai
            // 
            this.textBoxSoDienThoai.BackColor = System.Drawing.SystemColors.Window;
            this.textBoxSoDienThoai.BorderColor = System.Drawing.Color.CornflowerBlue;
            this.textBoxSoDienThoai.BorderFocusColor = System.Drawing.SystemColors.ActiveCaption;
            this.textBoxSoDienThoai.BorderRadius = 5;
            this.textBoxSoDienThoai.BorderSize = 1;
            this.textBoxSoDienThoai.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBoxSoDienThoai.Location = new System.Drawing.Point(150, 241);
            this.textBoxSoDienThoai.Multiline = false;
            this.textBoxSoDienThoai.Name = "textBoxSoDienThoai";
            this.textBoxSoDienThoai.Padding = new System.Windows.Forms.Padding(7);
            this.textBoxSoDienThoai.PasswordChar = false;
            this.textBoxSoDienThoai.PlaceholderColor = System.Drawing.Color.DarkGray;
            this.textBoxSoDienThoai.PlaceholderText = "";
            this.textBoxSoDienThoai.Size = new System.Drawing.Size(200, 35);
            this.textBoxSoDienThoai.TabIndex = 55;
            this.textBoxSoDienThoai.Texts = "";
            this.textBoxSoDienThoai.UnderlinedStyle = false;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.SystemColors.Control;
            this.label1.Location = new System.Drawing.Point(146, 86);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(56, 21);
            this.label1.TabIndex = 7;
            this.label1.Text = "Họ tên";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.SystemColors.Control;
            this.label2.Location = new System.Drawing.Point(379, 150);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(75, 21);
            this.label2.TabIndex = 8;
            this.label2.Text = "Mật khẩu";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.SystemColors.Control;
            this.label4.Location = new System.Drawing.Point(146, 150);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(75, 21);
            this.label4.TabIndex = 10;
            this.label4.Text = "Tài khoản";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.ForeColor = System.Drawing.SystemColors.Control;
            this.label5.Location = new System.Drawing.Point(146, 217);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(101, 21);
            this.label5.TabIndex = 13;
            this.label5.Text = "Số điện thoại";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.SystemColors.Control;
            this.label3.Location = new System.Drawing.Point(144, 285);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(101, 21);
            this.label3.TabIndex = 25;
            this.label3.Text = "Nhóm quyền";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.ForeColor = System.Drawing.SystemColors.Control;
            this.label6.Location = new System.Drawing.Point(379, 217);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(48, 21);
            this.label6.TabIndex = 27;
            this.label6.Text = "Email";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.ForeColor = System.Drawing.SystemColors.Control;
            this.label7.Location = new System.Drawing.Point(379, 88);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(58, 21);
            this.label7.TabIndex = 29;
            this.label7.Text = "Ca làm";
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
            this.buttonThem.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonThem.ForeColor = System.Drawing.Color.White;
            this.buttonThem.Image = ((System.Drawing.Image)(resources.GetObject("buttonThem.Image")));
            this.buttonThem.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.buttonThem.Location = new System.Drawing.Point(304, 364);
            this.buttonThem.Name = "buttonThem";
            this.buttonThem.Size = new System.Drawing.Size(126, 36);
            this.buttonThem.TabIndex = 56;
            this.buttonThem.Text = "Thêm";
            this.buttonThem.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.buttonThem.TextColor = System.Drawing.Color.White;
            this.buttonThem.TextImageRelation = System.Windows.Forms.TextImageRelation.TextBeforeImage;
            this.buttonThem.UseVisualStyleBackColor = false;
            // 
            // comboBoxSelectShift
            // 
            this.comboBoxSelectShift.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBoxSelectShift.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.comboBoxSelectShift.FormattingEnabled = true;
            this.comboBoxSelectShift.IntegralHeight = false;
            this.comboBoxSelectShift.Location = new System.Drawing.Point(383, 110);
            this.comboBoxSelectShift.MaxDropDownItems = 9;
            this.comboBoxSelectShift.Name = "comboBoxSelectShift";
            this.comboBoxSelectShift.Size = new System.Drawing.Size(200, 33);
            this.comboBoxSelectShift.TabIndex = 76;
            // 
            // comboBoxSelectGroup
            // 
            this.comboBoxSelectGroup.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBoxSelectGroup.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.comboBoxSelectGroup.FormattingEnabled = true;
            this.comboBoxSelectGroup.IntegralHeight = false;
            this.comboBoxSelectGroup.ItemHeight = 25;
            this.comboBoxSelectGroup.Location = new System.Drawing.Point(148, 309);
            this.comboBoxSelectGroup.MaxDropDownItems = 9;
            this.comboBoxSelectGroup.Name = "comboBoxSelectGroup";
            this.comboBoxSelectGroup.Size = new System.Drawing.Size(435, 33);
            this.comboBoxSelectGroup.TabIndex = 77;
            // 
            // FormAddUser
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(41)))), ((int)(((byte)(44)))), ((int)(((byte)(51)))));
            this.ClientSize = new System.Drawing.Size(754, 457);
            this.Controls.Add(this.comboBoxSelectGroup);
            this.Controls.Add(this.comboBoxSelectShift);
            this.Controls.Add(this.buttonThem);
            this.Controls.Add(this.textBoxSoDienThoai);
            this.Controls.Add(this.textBoxEmail);
            this.Controls.Add(this.textBoxPassword);
            this.Controls.Add(this.textBoxUsername);
            this.Controls.Add(this.textBoxFullName);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "FormAddUser";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Thêm nhân viên";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private Label label8;
        private LW_PhanMemBaoGia.MyControls.TextBoxT textBoxFullName;
        private LW_PhanMemBaoGia.MyControls.TextBoxT textBoxUsername;
        private LW_PhanMemBaoGia.MyControls.TextBoxT textBoxPassword;
        private LW_PhanMemBaoGia.MyControls.TextBoxT textBoxEmail;
        private LW_PhanMemBaoGia.MyControls.TextBoxT textBoxSoDienThoai;
        private Label label1;
        private Label label2;
        private Label label4;
        private Label label5;
        private Label label3;
        private Label label6;
        private Label label7;
        private LW_PhanMemBaoGia.MyControls.ButtonCustom buttonThem;
        private ComboBox comboBoxSelectShift;
        private ComboBox comboBoxSelectGroup;
    }
}