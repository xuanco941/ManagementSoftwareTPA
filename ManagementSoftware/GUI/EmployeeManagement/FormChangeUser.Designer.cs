using System.Windows.Forms;

namespace ManagementSoftware.GUI.EmployeeManagement
{
    partial class FormChangeUser
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormChangeUser));
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.textBoxPhoneNumber = new LW_PhanMemBaoGia.MyControls.TextBoxT();
            this.textBoxEmail = new LW_PhanMemBaoGia.MyControls.TextBoxT();
            this.textBoxPassword = new LW_PhanMemBaoGia.MyControls.TextBoxT();
            this.textBoxFullName = new LW_PhanMemBaoGia.MyControls.TextBoxT();
            this.label1 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.comboBoxSelectShift = new System.Windows.Forms.ComboBox();
            this.comboBoxSelectUsername = new System.Windows.Forms.ComboBox();
            this.comboBoxSelectGroup = new System.Windows.Forms.ComboBox();
            this.textBoxUsername = new LW_PhanMemBaoGia.MyControls.TextBoxT();
            this.label4 = new System.Windows.Forms.Label();
            this.buttonDelete = new LW_PhanMemBaoGia.MyControls.ButtonCustom();
            this.buttonUpdate = new LW_PhanMemBaoGia.MyControls.ButtonCustom();
            this.SuspendLayout();
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.ForeColor = System.Drawing.Color.Transparent;
            this.label7.Location = new System.Drawing.Point(191, 89);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(115, 21);
            this.label7.TabIndex = 27;
            this.label7.Text = "Chọn tài khoản";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Showcard Gothic", 18F, System.Drawing.FontStyle.Bold);
            this.label8.ForeColor = System.Drawing.Color.Goldenrod;
            this.label8.Location = new System.Drawing.Point(275, 32);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(274, 30);
            this.label8.TabIndex = 32;
            this.label8.Text = "Thay Đổi Thông Tin";
            // 
            // textBoxPhoneNumber
            // 
            this.textBoxPhoneNumber.BackColor = System.Drawing.SystemColors.Window;
            this.textBoxPhoneNumber.BorderColor = System.Drawing.Color.CornflowerBlue;
            this.textBoxPhoneNumber.BorderFocusColor = System.Drawing.SystemColors.ActiveCaption;
            this.textBoxPhoneNumber.BorderRadius = 5;
            this.textBoxPhoneNumber.BorderSize = 1;
            this.textBoxPhoneNumber.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBoxPhoneNumber.Location = new System.Drawing.Point(195, 305);
            this.textBoxPhoneNumber.Multiline = false;
            this.textBoxPhoneNumber.Name = "textBoxPhoneNumber";
            this.textBoxPhoneNumber.Padding = new System.Windows.Forms.Padding(7);
            this.textBoxPhoneNumber.PasswordChar = false;
            this.textBoxPhoneNumber.PlaceholderColor = System.Drawing.Color.DarkGray;
            this.textBoxPhoneNumber.PlaceholderText = "";
            this.textBoxPhoneNumber.Size = new System.Drawing.Size(200, 35);
            this.textBoxPhoneNumber.TabIndex = 69;
            this.textBoxPhoneNumber.Texts = "";
            this.textBoxPhoneNumber.UnderlinedStyle = false;
            // 
            // textBoxEmail
            // 
            this.textBoxEmail.BackColor = System.Drawing.SystemColors.Window;
            this.textBoxEmail.BorderColor = System.Drawing.Color.CornflowerBlue;
            this.textBoxEmail.BorderFocusColor = System.Drawing.SystemColors.ActiveCaption;
            this.textBoxEmail.BorderRadius = 5;
            this.textBoxEmail.BorderSize = 1;
            this.textBoxEmail.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBoxEmail.Location = new System.Drawing.Point(428, 305);
            this.textBoxEmail.Multiline = false;
            this.textBoxEmail.Name = "textBoxEmail";
            this.textBoxEmail.Padding = new System.Windows.Forms.Padding(7);
            this.textBoxEmail.PasswordChar = false;
            this.textBoxEmail.PlaceholderColor = System.Drawing.Color.DarkGray;
            this.textBoxEmail.PlaceholderText = "";
            this.textBoxEmail.Size = new System.Drawing.Size(200, 35);
            this.textBoxEmail.TabIndex = 66;
            this.textBoxEmail.Texts = "";
            this.textBoxEmail.UnderlinedStyle = false;
            // 
            // textBoxPassword
            // 
            this.textBoxPassword.BackColor = System.Drawing.SystemColors.Window;
            this.textBoxPassword.BorderColor = System.Drawing.Color.CornflowerBlue;
            this.textBoxPassword.BorderFocusColor = System.Drawing.SystemColors.ActiveCaption;
            this.textBoxPassword.BorderRadius = 5;
            this.textBoxPassword.BorderSize = 1;
            this.textBoxPassword.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBoxPassword.Location = new System.Drawing.Point(428, 243);
            this.textBoxPassword.Multiline = false;
            this.textBoxPassword.Name = "textBoxPassword";
            this.textBoxPassword.Padding = new System.Windows.Forms.Padding(7);
            this.textBoxPassword.PasswordChar = false;
            this.textBoxPassword.PlaceholderColor = System.Drawing.Color.DarkGray;
            this.textBoxPassword.PlaceholderText = "";
            this.textBoxPassword.Size = new System.Drawing.Size(200, 35);
            this.textBoxPassword.TabIndex = 65;
            this.textBoxPassword.Texts = "";
            this.textBoxPassword.UnderlinedStyle = false;
            // 
            // textBoxFullName
            // 
            this.textBoxFullName.BackColor = System.Drawing.SystemColors.Window;
            this.textBoxFullName.BorderColor = System.Drawing.Color.CornflowerBlue;
            this.textBoxFullName.BorderFocusColor = System.Drawing.SystemColors.ActiveCaption;
            this.textBoxFullName.BorderRadius = 5;
            this.textBoxFullName.BorderSize = 1;
            this.textBoxFullName.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBoxFullName.Location = new System.Drawing.Point(195, 174);
            this.textBoxFullName.Multiline = false;
            this.textBoxFullName.Name = "textBoxFullName";
            this.textBoxFullName.Padding = new System.Windows.Forms.Padding(7);
            this.textBoxFullName.PasswordChar = false;
            this.textBoxFullName.PlaceholderColor = System.Drawing.Color.DarkGray;
            this.textBoxFullName.PlaceholderText = "";
            this.textBoxFullName.Size = new System.Drawing.Size(200, 35);
            this.textBoxFullName.TabIndex = 63;
            this.textBoxFullName.Texts = "";
            this.textBoxFullName.UnderlinedStyle = false;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.SystemColors.Control;
            this.label1.Location = new System.Drawing.Point(424, 152);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(58, 21);
            this.label1.TabIndex = 62;
            this.label1.Text = "Ca làm";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.ForeColor = System.Drawing.SystemColors.Control;
            this.label6.Location = new System.Drawing.Point(424, 281);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(48, 21);
            this.label6.TabIndex = 61;
            this.label6.Text = "Email";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.SystemColors.Control;
            this.label3.Location = new System.Drawing.Point(189, 349);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(101, 21);
            this.label3.TabIndex = 60;
            this.label3.Text = "Nhóm quyền";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.ForeColor = System.Drawing.SystemColors.Control;
            this.label5.Location = new System.Drawing.Point(191, 281);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(101, 21);
            this.label5.TabIndex = 59;
            this.label5.Text = "Số điện thoại";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.SystemColors.Control;
            this.label2.Location = new System.Drawing.Point(424, 219);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(75, 21);
            this.label2.TabIndex = 57;
            this.label2.Text = "Mật khẩu";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.ForeColor = System.Drawing.SystemColors.Control;
            this.label9.Location = new System.Drawing.Point(191, 150);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(56, 21);
            this.label9.TabIndex = 56;
            this.label9.Text = "Họ tên";
            // 
            // comboBoxSelectShift
            // 
            this.comboBoxSelectShift.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBoxSelectShift.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.comboBoxSelectShift.FormattingEnabled = true;
            this.comboBoxSelectShift.IntegralHeight = false;
            this.comboBoxSelectShift.Location = new System.Drawing.Point(428, 176);
            this.comboBoxSelectShift.MaxDropDownItems = 9;
            this.comboBoxSelectShift.Name = "comboBoxSelectShift";
            this.comboBoxSelectShift.Size = new System.Drawing.Size(200, 33);
            this.comboBoxSelectShift.TabIndex = 77;
            // 
            // comboBoxSelectUsername
            // 
            this.comboBoxSelectUsername.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBoxSelectUsername.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.comboBoxSelectUsername.FormattingEnabled = true;
            this.comboBoxSelectUsername.IntegralHeight = false;
            this.comboBoxSelectUsername.Location = new System.Drawing.Point(195, 113);
            this.comboBoxSelectUsername.MaxDropDownItems = 9;
            this.comboBoxSelectUsername.Name = "comboBoxSelectUsername";
            this.comboBoxSelectUsername.Size = new System.Drawing.Size(433, 33);
            this.comboBoxSelectUsername.TabIndex = 78;
            // 
            // comboBoxSelectGroup
            // 
            this.comboBoxSelectGroup.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBoxSelectGroup.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.comboBoxSelectGroup.FormattingEnabled = true;
            this.comboBoxSelectGroup.IntegralHeight = false;
            this.comboBoxSelectGroup.Location = new System.Drawing.Point(195, 373);
            this.comboBoxSelectGroup.MaxDropDownItems = 9;
            this.comboBoxSelectGroup.Name = "comboBoxSelectGroup";
            this.comboBoxSelectGroup.Size = new System.Drawing.Size(433, 33);
            this.comboBoxSelectGroup.TabIndex = 79;
            // 
            // textBoxUsername
            // 
            this.textBoxUsername.BackColor = System.Drawing.SystemColors.Window;
            this.textBoxUsername.BorderColor = System.Drawing.Color.CornflowerBlue;
            this.textBoxUsername.BorderFocusColor = System.Drawing.SystemColors.ActiveCaption;
            this.textBoxUsername.BorderRadius = 5;
            this.textBoxUsername.BorderSize = 1;
            this.textBoxUsername.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBoxUsername.Location = new System.Drawing.Point(195, 243);
            this.textBoxUsername.Multiline = false;
            this.textBoxUsername.Name = "textBoxUsername";
            this.textBoxUsername.Padding = new System.Windows.Forms.Padding(7);
            this.textBoxUsername.PasswordChar = false;
            this.textBoxUsername.PlaceholderColor = System.Drawing.Color.DarkGray;
            this.textBoxUsername.PlaceholderText = "";
            this.textBoxUsername.Size = new System.Drawing.Size(200, 35);
            this.textBoxUsername.TabIndex = 81;
            this.textBoxUsername.Texts = "";
            this.textBoxUsername.UnderlinedStyle = false;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.SystemColors.Control;
            this.label4.Location = new System.Drawing.Point(191, 219);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(75, 21);
            this.label4.TabIndex = 80;
            this.label4.Text = "Tài khoản";
            // 
            // buttonDelete
            // 
            this.buttonDelete.BackColor = System.Drawing.Color.Brown;
            this.buttonDelete.BackgroundColor = System.Drawing.Color.Brown;
            this.buttonDelete.BorderColor = System.Drawing.Color.PaleVioletRed;
            this.buttonDelete.BorderRadius = 3;
            this.buttonDelete.BorderSize = 0;
            this.buttonDelete.Cursor = System.Windows.Forms.Cursors.Hand;
            this.buttonDelete.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonDelete.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonDelete.ForeColor = System.Drawing.SystemColors.Control;
            this.buttonDelete.Image = ((System.Drawing.Image)(resources.GetObject("buttonDelete.Image")));
            this.buttonDelete.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.buttonDelete.Location = new System.Drawing.Point(428, 440);
            this.buttonDelete.Name = "buttonDelete";
            this.buttonDelete.Size = new System.Drawing.Size(142, 36);
            this.buttonDelete.TabIndex = 72;
            this.buttonDelete.Text = "Xóa tài khoản";
            this.buttonDelete.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.buttonDelete.TextColor = System.Drawing.SystemColors.Control;
            this.buttonDelete.TextImageRelation = System.Windows.Forms.TextImageRelation.TextBeforeImage;
            this.buttonDelete.UseVisualStyleBackColor = false;
            // 
            // buttonUpdate
            // 
            this.buttonUpdate.BackColor = System.Drawing.Color.DarkGoldenrod;
            this.buttonUpdate.BackgroundColor = System.Drawing.Color.DarkGoldenrod;
            this.buttonUpdate.BorderColor = System.Drawing.Color.PaleVioletRed;
            this.buttonUpdate.BorderRadius = 3;
            this.buttonUpdate.BorderSize = 0;
            this.buttonUpdate.Cursor = System.Windows.Forms.Cursors.Hand;
            this.buttonUpdate.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonUpdate.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonUpdate.ForeColor = System.Drawing.SystemColors.Control;
            this.buttonUpdate.Image = global::ManagementSoftware.Properties.Resources.iconfinder_Synchronize_278832;
            this.buttonUpdate.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.buttonUpdate.Location = new System.Drawing.Point(253, 440);
            this.buttonUpdate.Name = "buttonUpdate";
            this.buttonUpdate.Size = new System.Drawing.Size(142, 36);
            this.buttonUpdate.TabIndex = 71;
            this.buttonUpdate.Text = "Cập nhật";
            this.buttonUpdate.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.buttonUpdate.TextColor = System.Drawing.SystemColors.Control;
            this.buttonUpdate.TextImageRelation = System.Windows.Forms.TextImageRelation.TextBeforeImage;
            this.buttonUpdate.UseVisualStyleBackColor = false;
            // 
            // FormChangeUser
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(41)))), ((int)(((byte)(44)))), ((int)(((byte)(51)))));
            this.ClientSize = new System.Drawing.Size(811, 536);
            this.Controls.Add(this.textBoxUsername);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.comboBoxSelectGroup);
            this.Controls.Add(this.comboBoxSelectUsername);
            this.Controls.Add(this.comboBoxSelectShift);
            this.Controls.Add(this.buttonDelete);
            this.Controls.Add(this.buttonUpdate);
            this.Controls.Add(this.textBoxPhoneNumber);
            this.Controls.Add(this.textBoxEmail);
            this.Controls.Add(this.textBoxPassword);
            this.Controls.Add(this.textBoxFullName);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.label7);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "FormChangeUser";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Sửa thông tin nhân viên";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private Label label7;
        private Label label8;
        private LW_PhanMemBaoGia.MyControls.TextBoxT textBoxPhoneNumber;
        private LW_PhanMemBaoGia.MyControls.TextBoxT textBoxEmail;
        private LW_PhanMemBaoGia.MyControls.TextBoxT textBoxPassword;
        private LW_PhanMemBaoGia.MyControls.TextBoxT textBoxFullName;
        private Label label1;
        private Label label6;
        private Label label3;
        private Label label5;
        private Label label2;
        private Label label9;
        private LW_PhanMemBaoGia.MyControls.ButtonCustom buttonUpdate;
        private LW_PhanMemBaoGia.MyControls.ButtonCustom buttonDelete;
        private ComboBox comboBoxSelectShift;
        private ComboBox comboBoxSelectUsername;
        private ComboBox comboBoxSelectGroup;
        private LW_PhanMemBaoGia.MyControls.TextBoxT textBoxUsername;
        private Label label4;
    }
}