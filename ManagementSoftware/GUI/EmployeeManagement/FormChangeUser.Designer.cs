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
            label7 = new Label();
            label8 = new Label();
            textBoxPassword = new LW_PhanMemBaoGia.MyControls.TextBoxT();
            textBoxFullName = new LW_PhanMemBaoGia.MyControls.TextBoxT();
            label3 = new Label();
            label2 = new Label();
            label9 = new Label();
            comboBoxSelectUsername = new ComboBox();
            comboBoxSelectGroup = new ComboBox();
            buttonDelete = new LW_PhanMemBaoGia.MyControls.ButtonCustom();
            buttonUpdate = new LW_PhanMemBaoGia.MyControls.ButtonCustom();
            panel1 = new Panel();
            textBoxtEmail = new LW_PhanMemBaoGia.MyControls.TextBoxT();
            label1 = new Label();
            textBoxtSDT = new LW_PhanMemBaoGia.MyControls.TextBoxT();
            label4 = new Label();
            panel1.SuspendLayout();
            SuspendLayout();
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            label7.ForeColor = Color.Transparent;
            label7.Location = new Point(198, 103);
            label7.Margin = new Padding(4, 0, 4, 0);
            label7.Name = "label7";
            label7.Size = new Size(115, 21);
            label7.TabIndex = 27;
            label7.Text = "Chọn tài khoản";
            // 
            // label8
            // 
            label8.Dock = DockStyle.Fill;
            label8.Font = new Font("Segoe UI Semibold", 18F, FontStyle.Bold, GraphicsUnit.Point);
            label8.ForeColor = Color.Goldenrod;
            label8.Location = new Point(0, 0);
            label8.Margin = new Padding(4, 0, 4, 0);
            label8.Name = "label8";
            label8.Size = new Size(910, 100);
            label8.TabIndex = 32;
            label8.Text = "Thay Đổi Thông Tin";
            label8.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // textBoxPassword
            // 
            textBoxPassword.BackColor = SystemColors.Window;
            textBoxPassword.BorderColor = Color.CornflowerBlue;
            textBoxPassword.BorderFocusColor = SystemColors.ActiveCaption;
            textBoxPassword.BorderRadius = 5;
            textBoxPassword.BorderSize = 1;
            textBoxPassword.Font = new Font("Segoe UI", 11.25F, FontStyle.Regular, GraphicsUnit.Point);
            textBoxPassword.Location = new Point(202, 280);
            textBoxPassword.Margin = new Padding(4, 3, 4, 3);
            textBoxPassword.Multiline = false;
            textBoxPassword.Name = "textBoxPassword";
            textBoxPassword.Padding = new Padding(8);
            textBoxPassword.PasswordChar = false;
            textBoxPassword.PlaceholderColor = Color.DarkGray;
            textBoxPassword.PlaceholderText = "";
            textBoxPassword.Size = new Size(505, 37);
            textBoxPassword.TabIndex = 65;
            textBoxPassword.Texts = "";
            textBoxPassword.UnderlinedStyle = false;
            // 
            // textBoxFullName
            // 
            textBoxFullName.BackColor = SystemColors.Window;
            textBoxFullName.BorderColor = Color.CornflowerBlue;
            textBoxFullName.BorderFocusColor = SystemColors.ActiveCaption;
            textBoxFullName.BorderRadius = 5;
            textBoxFullName.BorderSize = 1;
            textBoxFullName.Font = new Font("Segoe UI", 11.25F, FontStyle.Regular, GraphicsUnit.Point);
            textBoxFullName.Location = new Point(202, 201);
            textBoxFullName.Margin = new Padding(4, 3, 4, 3);
            textBoxFullName.Multiline = false;
            textBoxFullName.Name = "textBoxFullName";
            textBoxFullName.Padding = new Padding(8);
            textBoxFullName.PasswordChar = false;
            textBoxFullName.PlaceholderColor = Color.DarkGray;
            textBoxFullName.PlaceholderText = "";
            textBoxFullName.Size = new Size(505, 37);
            textBoxFullName.TabIndex = 63;
            textBoxFullName.Texts = "";
            textBoxFullName.UnderlinedStyle = false;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            label3.ForeColor = SystemColors.Control;
            label3.Location = new Point(198, 497);
            label3.Margin = new Padding(4, 0, 4, 0);
            label3.Name = "label3";
            label3.Size = new Size(101, 21);
            label3.TabIndex = 60;
            label3.Text = "Nhóm quyền";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            label2.ForeColor = SystemColors.Control;
            label2.Location = new Point(202, 256);
            label2.Margin = new Padding(4, 0, 4, 0);
            label2.Name = "label2";
            label2.Size = new Size(75, 21);
            label2.TabIndex = 57;
            label2.Text = "Mật khẩu";
            // 
            // label9
            // 
            label9.AutoSize = true;
            label9.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            label9.ForeColor = SystemColors.Control;
            label9.Location = new Point(198, 173);
            label9.Margin = new Padding(4, 0, 4, 0);
            label9.Name = "label9";
            label9.Size = new Size(56, 21);
            label9.TabIndex = 56;
            label9.Text = "Họ tên";
            // 
            // comboBoxSelectUsername
            // 
            comboBoxSelectUsername.DropDownStyle = ComboBoxStyle.DropDownList;
            comboBoxSelectUsername.Font = new Font("Segoe UI", 14.25F, FontStyle.Regular, GraphicsUnit.Point);
            comboBoxSelectUsername.FormattingEnabled = true;
            comboBoxSelectUsername.IntegralHeight = false;
            comboBoxSelectUsername.Location = new Point(202, 130);
            comboBoxSelectUsername.Margin = new Padding(4, 3, 4, 3);
            comboBoxSelectUsername.MaxDropDownItems = 9;
            comboBoxSelectUsername.Name = "comboBoxSelectUsername";
            comboBoxSelectUsername.Size = new Size(504, 33);
            comboBoxSelectUsername.TabIndex = 78;
            comboBoxSelectUsername.SelectedIndexChanged += comboBoxSelectUsername_SelectedIndexChanged;
            // 
            // comboBoxSelectGroup
            // 
            comboBoxSelectGroup.DropDownStyle = ComboBoxStyle.DropDownList;
            comboBoxSelectGroup.Font = new Font("Segoe UI", 14.25F, FontStyle.Regular, GraphicsUnit.Point);
            comboBoxSelectGroup.FormattingEnabled = true;
            comboBoxSelectGroup.IntegralHeight = false;
            comboBoxSelectGroup.Location = new Point(202, 521);
            comboBoxSelectGroup.Margin = new Padding(4, 3, 4, 3);
            comboBoxSelectGroup.MaxDropDownItems = 9;
            comboBoxSelectGroup.Name = "comboBoxSelectGroup";
            comboBoxSelectGroup.Size = new Size(505, 33);
            comboBoxSelectGroup.TabIndex = 79;
            // 
            // buttonDelete
            // 
            buttonDelete.BackColor = Color.Brown;
            buttonDelete.BackgroundColor = Color.Brown;
            buttonDelete.BorderColor = Color.PaleVioletRed;
            buttonDelete.BorderRadius = 3;
            buttonDelete.BorderSize = 0;
            buttonDelete.Cursor = Cursors.Hand;
            buttonDelete.FlatStyle = FlatStyle.Flat;
            buttonDelete.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold, GraphicsUnit.Point);
            buttonDelete.ForeColor = SystemColors.Control;
            buttonDelete.Image = (Image)resources.GetObject("buttonDelete.Image");
            buttonDelete.ImageAlign = ContentAlignment.MiddleLeft;
            buttonDelete.Location = new Point(471, 603);
            buttonDelete.Margin = new Padding(4, 3, 4, 3);
            buttonDelete.Name = "buttonDelete";
            buttonDelete.Size = new Size(166, 42);
            buttonDelete.TabIndex = 72;
            buttonDelete.Text = "Xóa tài khoản";
            buttonDelete.TextAlign = ContentAlignment.MiddleRight;
            buttonDelete.TextColor = SystemColors.Control;
            buttonDelete.TextImageRelation = TextImageRelation.TextBeforeImage;
            buttonDelete.UseVisualStyleBackColor = false;
            buttonDelete.Click += buttonDelete_Click;
            // 
            // buttonUpdate
            // 
            buttonUpdate.BackColor = Color.DarkGoldenrod;
            buttonUpdate.BackgroundColor = Color.DarkGoldenrod;
            buttonUpdate.BorderColor = Color.PaleVioletRed;
            buttonUpdate.BorderRadius = 3;
            buttonUpdate.BorderSize = 0;
            buttonUpdate.Cursor = Cursors.Hand;
            buttonUpdate.FlatStyle = FlatStyle.Flat;
            buttonUpdate.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold, GraphicsUnit.Point);
            buttonUpdate.ForeColor = SystemColors.Control;
            buttonUpdate.Image = Properties.Resources.iconfinder_Synchronize_278832;
            buttonUpdate.ImageAlign = ContentAlignment.MiddleLeft;
            buttonUpdate.Location = new Point(267, 603);
            buttonUpdate.Margin = new Padding(4, 3, 4, 3);
            buttonUpdate.Name = "buttonUpdate";
            buttonUpdate.Size = new Size(166, 42);
            buttonUpdate.TabIndex = 71;
            buttonUpdate.Text = "Cập nhật";
            buttonUpdate.TextAlign = ContentAlignment.MiddleRight;
            buttonUpdate.TextColor = SystemColors.Control;
            buttonUpdate.TextImageRelation = TextImageRelation.TextBeforeImage;
            buttonUpdate.UseVisualStyleBackColor = false;
            buttonUpdate.Click += buttonUpdate_Click;
            // 
            // panel1
            // 
            panel1.Controls.Add(label8);
            panel1.Dock = DockStyle.Top;
            panel1.Location = new Point(0, 0);
            panel1.Name = "panel1";
            panel1.Size = new Size(910, 100);
            panel1.TabIndex = 82;
            // 
            // textBoxtEmail
            // 
            textBoxtEmail.BackColor = SystemColors.Window;
            textBoxtEmail.BorderColor = Color.CornflowerBlue;
            textBoxtEmail.BorderFocusColor = SystemColors.ActiveCaption;
            textBoxtEmail.BorderRadius = 5;
            textBoxtEmail.BorderSize = 1;
            textBoxtEmail.Font = new Font("Segoe UI", 11.25F, FontStyle.Regular, GraphicsUnit.Point);
            textBoxtEmail.Location = new Point(202, 360);
            textBoxtEmail.Margin = new Padding(4, 3, 4, 3);
            textBoxtEmail.Multiline = false;
            textBoxtEmail.Name = "textBoxtEmail";
            textBoxtEmail.Padding = new Padding(8);
            textBoxtEmail.PasswordChar = false;
            textBoxtEmail.PlaceholderColor = Color.DarkGray;
            textBoxtEmail.PlaceholderText = "";
            textBoxtEmail.Size = new Size(505, 37);
            textBoxtEmail.TabIndex = 84;
            textBoxtEmail.Texts = "";
            textBoxtEmail.UnderlinedStyle = false;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            label1.ForeColor = SystemColors.Control;
            label1.Location = new Point(202, 336);
            label1.Margin = new Padding(4, 0, 4, 0);
            label1.Name = "label1";
            label1.Size = new Size(48, 21);
            label1.TabIndex = 83;
            label1.Text = "Email";
            // 
            // textBoxtSDT
            // 
            textBoxtSDT.BackColor = SystemColors.Window;
            textBoxtSDT.BorderColor = Color.CornflowerBlue;
            textBoxtSDT.BorderFocusColor = SystemColors.ActiveCaption;
            textBoxtSDT.BorderRadius = 5;
            textBoxtSDT.BorderSize = 1;
            textBoxtSDT.Font = new Font("Segoe UI", 11.25F, FontStyle.Regular, GraphicsUnit.Point);
            textBoxtSDT.Location = new Point(201, 438);
            textBoxtSDT.Margin = new Padding(4, 3, 4, 3);
            textBoxtSDT.Multiline = false;
            textBoxtSDT.Name = "textBoxtSDT";
            textBoxtSDT.Padding = new Padding(8);
            textBoxtSDT.PasswordChar = false;
            textBoxtSDT.PlaceholderColor = Color.DarkGray;
            textBoxtSDT.PlaceholderText = "";
            textBoxtSDT.Size = new Size(505, 37);
            textBoxtSDT.TabIndex = 86;
            textBoxtSDT.Texts = "";
            textBoxtSDT.UnderlinedStyle = false;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            label4.ForeColor = SystemColors.Control;
            label4.Location = new Point(201, 414);
            label4.Margin = new Padding(4, 0, 4, 0);
            label4.Name = "label4";
            label4.Size = new Size(101, 21);
            label4.TabIndex = 85;
            label4.Text = "Số điện thoại";
            // 
            // FormChangeUser
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(41, 44, 51);
            ClientSize = new Size(910, 698);
            Controls.Add(textBoxtSDT);
            Controls.Add(label4);
            Controls.Add(textBoxtEmail);
            Controls.Add(label1);
            Controls.Add(panel1);
            Controls.Add(comboBoxSelectGroup);
            Controls.Add(comboBoxSelectUsername);
            Controls.Add(buttonDelete);
            Controls.Add(buttonUpdate);
            Controls.Add(textBoxPassword);
            Controls.Add(textBoxFullName);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label9);
            Controls.Add(label7);
            Icon = (Icon)resources.GetObject("$this.Icon");
            Margin = new Padding(4, 3, 4, 3);
            MaximizeBox = false;
            MinimizeBox = false;
            Name = "FormChangeUser";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Sửa thông tin nhân viên";
            Load += FormChangeUser_Load;
            panel1.ResumeLayout(false);
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
        private Label label7;
        private Label label8;
        private LW_PhanMemBaoGia.MyControls.TextBoxT textBoxPassword;
        private LW_PhanMemBaoGia.MyControls.TextBoxT textBoxFullName;
        private Label label3;
        private Label label2;
        private Label label9;
        private LW_PhanMemBaoGia.MyControls.ButtonCustom buttonUpdate;
        private LW_PhanMemBaoGia.MyControls.ButtonCustom buttonDelete;
        private ComboBox comboBoxSelectUsername;
        private ComboBox comboBoxSelectGroup;
        private Panel panel1;
        private LW_PhanMemBaoGia.MyControls.TextBoxT textBoxtEmail;
        private Label label1;
        private LW_PhanMemBaoGia.MyControls.TextBoxT textBoxtSDT;
        private Label label4;
    }
}