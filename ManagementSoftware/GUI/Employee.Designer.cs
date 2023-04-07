using System.Windows.Forms;

namespace ManagementSoftware.GUI
{
    partial class Employee
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
            DataGridViewCellStyle dataGridViewCellStyle1 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle2 = new DataGridViewCellStyle();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Employee));
            DataGridViewCellStyle dataGridViewCellStyle3 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle4 = new DataGridViewCellStyle();
            tabControl1 = new TabControl();
            tabPageUser = new TabPage();
            panel2 = new Panel();
            dataGridViewUser = new DataGridView();
            panel3 = new Panel();
            buttonChangeUser = new LW_PhanMemBaoGia.MyControls.ButtonCustom();
            buttonAddUser = new LW_PhanMemBaoGia.MyControls.ButtonCustom();
            buttonThemNhanVien = new Button();
            buttonSuaNhanVien = new Button();
            tabPageGroup = new TabPage();
            panel1 = new Panel();
            dataGridViewGroup = new DataGridView();
            tabControl1.SuspendLayout();
            tabPageUser.SuspendLayout();
            panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridViewUser).BeginInit();
            panel3.SuspendLayout();
            tabPageGroup.SuspendLayout();
            panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridViewGroup).BeginInit();
            SuspendLayout();
            // 
            // tabControl1
            // 
            tabControl1.Controls.Add(tabPageUser);
            tabControl1.Controls.Add(tabPageGroup);
            tabControl1.Dock = DockStyle.Fill;
            tabControl1.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold, GraphicsUnit.Point);
            tabControl1.Location = new Point(0, 0);
            tabControl1.Margin = new Padding(4, 3, 4, 3);
            tabControl1.Name = "tabControl1";
            tabControl1.SelectedIndex = 0;
            tabControl1.Size = new Size(1163, 595);
            tabControl1.TabIndex = 0;
            // 
            // tabPageUser
            // 
            tabPageUser.BackColor = SystemColors.InactiveCaption;
            tabPageUser.Controls.Add(panel2);
            tabPageUser.Controls.Add(panel3);
            tabPageUser.Location = new Point(4, 30);
            tabPageUser.Margin = new Padding(4, 3, 4, 3);
            tabPageUser.Name = "tabPageUser";
            tabPageUser.Padding = new Padding(4, 3, 4, 3);
            tabPageUser.Size = new Size(1155, 561);
            tabPageUser.TabIndex = 0;
            tabPageUser.Text = "Tài khoản thành viên";
            // 
            // panel2
            // 
            panel2.Controls.Add(dataGridViewUser);
            panel2.Dock = DockStyle.Fill;
            panel2.Location = new Point(4, 3);
            panel2.Margin = new Padding(4, 3, 4, 3);
            panel2.Name = "panel2";
            panel2.Size = new Size(1147, 496);
            panel2.TabIndex = 8;
            // 
            // dataGridViewUser
            // 
            dataGridViewUser.AllowUserToAddRows = false;
            dataGridViewUser.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dataGridViewUser.BackgroundColor = Color.LightGray;
            dataGridViewCellStyle1.Alignment = DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle1.BackColor = SystemColors.Control;
            dataGridViewCellStyle1.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold, GraphicsUnit.Point);
            dataGridViewCellStyle1.ForeColor = SystemColors.WindowText;
            dataGridViewCellStyle1.SelectionBackColor = SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = DataGridViewTriState.True;
            dataGridViewUser.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            dataGridViewUser.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewUser.Dock = DockStyle.Fill;
            dataGridViewUser.Location = new Point(0, 0);
            dataGridViewUser.Margin = new Padding(4, 3, 4, 3);
            dataGridViewUser.Name = "dataGridViewUser";
            dataGridViewUser.ReadOnly = true;
            dataGridViewUser.RowHeadersVisible = false;
            dataGridViewCellStyle2.Alignment = DataGridViewContentAlignment.MiddleCenter;
            dataGridViewUser.RowsDefaultCellStyle = dataGridViewCellStyle2;
            dataGridViewUser.Size = new Size(1147, 496);
            dataGridViewUser.TabIndex = 0;
            // 
            // panel3
            // 
            panel3.BackColor = Color.Transparent;
            panel3.Controls.Add(buttonChangeUser);
            panel3.Controls.Add(buttonAddUser);
            panel3.Controls.Add(buttonThemNhanVien);
            panel3.Controls.Add(buttonSuaNhanVien);
            panel3.Dock = DockStyle.Bottom;
            panel3.Font = new Font("Segoe UI", 9.75F, FontStyle.Regular, GraphicsUnit.Point);
            panel3.Location = new Point(4, 499);
            panel3.Margin = new Padding(4, 3, 4, 3);
            panel3.Name = "panel3";
            panel3.Size = new Size(1147, 59);
            panel3.TabIndex = 9;
            // 
            // buttonChangeUser
            // 
            buttonChangeUser.Anchor = AnchorStyles.Bottom | AnchorStyles.Right;
            buttonChangeUser.BackColor = Color.DarkGoldenrod;
            buttonChangeUser.BackgroundColor = Color.DarkGoldenrod;
            buttonChangeUser.BorderColor = Color.PaleVioletRed;
            buttonChangeUser.BorderRadius = 3;
            buttonChangeUser.BorderSize = 0;
            buttonChangeUser.Cursor = Cursors.Hand;
            buttonChangeUser.FlatStyle = FlatStyle.Flat;
            buttonChangeUser.Font = new Font("Segoe UI", 9.75F, FontStyle.Bold, GraphicsUnit.Point);
            buttonChangeUser.ForeColor = Color.White;
            buttonChangeUser.Image = Properties.Resources.iconfinder_Synchronize_278832;
            buttonChangeUser.ImageAlign = ContentAlignment.MiddleLeft;
            buttonChangeUser.Location = new Point(1017, 14);
            buttonChangeUser.Margin = new Padding(4, 3, 4, 3);
            buttonChangeUser.Name = "buttonChangeUser";
            buttonChangeUser.Size = new Size(124, 33);
            buttonChangeUser.TabIndex = 22;
            buttonChangeUser.Text = "Thay đổi";
            buttonChangeUser.TextAlign = ContentAlignment.MiddleRight;
            buttonChangeUser.TextColor = Color.White;
            buttonChangeUser.TextImageRelation = TextImageRelation.TextBeforeImage;
            buttonChangeUser.UseVisualStyleBackColor = false;
            buttonChangeUser.Click += buttonChangeUser_Click;
            // 
            // buttonAddUser
            // 
            buttonAddUser.Anchor = AnchorStyles.Bottom | AnchorStyles.Right;
            buttonAddUser.BackColor = Color.Green;
            buttonAddUser.BackgroundColor = Color.Green;
            buttonAddUser.BorderColor = Color.PaleVioletRed;
            buttonAddUser.BorderRadius = 3;
            buttonAddUser.BorderSize = 0;
            buttonAddUser.Cursor = Cursors.Hand;
            buttonAddUser.FlatStyle = FlatStyle.Flat;
            buttonAddUser.Font = new Font("Segoe UI", 9.75F, FontStyle.Bold, GraphicsUnit.Point);
            buttonAddUser.ForeColor = Color.White;
            buttonAddUser.Image = (Image)resources.GetObject("buttonAddUser.Image");
            buttonAddUser.ImageAlign = ContentAlignment.MiddleLeft;
            buttonAddUser.Location = new Point(890, 14);
            buttonAddUser.Margin = new Padding(4, 3, 4, 3);
            buttonAddUser.Name = "buttonAddUser";
            buttonAddUser.Size = new Size(124, 33);
            buttonAddUser.TabIndex = 21;
            buttonAddUser.Text = "Thêm mới";
            buttonAddUser.TextAlign = ContentAlignment.MiddleRight;
            buttonAddUser.TextColor = Color.White;
            buttonAddUser.TextImageRelation = TextImageRelation.TextBeforeImage;
            buttonAddUser.UseVisualStyleBackColor = false;
            buttonAddUser.Click += buttonAddUser_Click;
            // 
            // buttonThemNhanVien
            // 
            buttonThemNhanVien.Anchor = AnchorStyles.Bottom | AnchorStyles.Right;
            buttonThemNhanVien.Font = new Font("Microsoft Sans Serif", 9.75F, FontStyle.Regular, GraphicsUnit.Point);
            buttonThemNhanVien.Image = Properties.Resources.iconfinder_Stock_Index_Up_278812;
            buttonThemNhanVien.ImageAlign = ContentAlignment.MiddleRight;
            buttonThemNhanVien.Location = new Point(1793, -31);
            buttonThemNhanVien.Margin = new Padding(4, 3, 4, 3);
            buttonThemNhanVien.Name = "buttonThemNhanVien";
            buttonThemNhanVien.Size = new Size(94, 28);
            buttonThemNhanVien.TabIndex = 2;
            buttonThemNhanVien.Text = "Thêm mới";
            buttonThemNhanVien.TextAlign = ContentAlignment.MiddleLeft;
            buttonThemNhanVien.UseVisualStyleBackColor = true;
            // 
            // buttonSuaNhanVien
            // 
            buttonSuaNhanVien.Anchor = AnchorStyles.Bottom | AnchorStyles.Right;
            buttonSuaNhanVien.Font = new Font("Microsoft Sans Serif", 9.75F, FontStyle.Regular, GraphicsUnit.Point);
            buttonSuaNhanVien.Image = Properties.Resources.iconfinder_Synchronize_278832;
            buttonSuaNhanVien.ImageAlign = ContentAlignment.MiddleRight;
            buttonSuaNhanVien.Location = new Point(1895, -31);
            buttonSuaNhanVien.Margin = new Padding(4, 3, 4, 3);
            buttonSuaNhanVien.Name = "buttonSuaNhanVien";
            buttonSuaNhanVien.Size = new Size(94, 28);
            buttonSuaNhanVien.TabIndex = 3;
            buttonSuaNhanVien.Text = "Thay đổi";
            buttonSuaNhanVien.TextAlign = ContentAlignment.MiddleLeft;
            buttonSuaNhanVien.UseVisualStyleBackColor = true;
            // 
            // tabPageGroup
            // 
            tabPageGroup.BackColor = SystemColors.InactiveCaption;
            tabPageGroup.Controls.Add(panel1);
            tabPageGroup.Location = new Point(4, 30);
            tabPageGroup.Margin = new Padding(4, 3, 4, 3);
            tabPageGroup.Name = "tabPageGroup";
            tabPageGroup.Padding = new Padding(4, 3, 4, 3);
            tabPageGroup.Size = new Size(1155, 561);
            tabPageGroup.TabIndex = 1;
            tabPageGroup.Text = "Quyền người dùng";
            // 
            // panel1
            // 
            panel1.Controls.Add(dataGridViewGroup);
            panel1.Dock = DockStyle.Fill;
            panel1.Location = new Point(4, 3);
            panel1.Margin = new Padding(4, 3, 4, 3);
            panel1.Name = "panel1";
            panel1.Size = new Size(1147, 555);
            panel1.TabIndex = 10;
            // 
            // dataGridViewGroup
            // 
            dataGridViewGroup.AllowUserToAddRows = false;
            dataGridViewGroup.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dataGridViewGroup.BackgroundColor = Color.LightGray;
            dataGridViewCellStyle3.Alignment = DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle3.BackColor = SystemColors.Control;
            dataGridViewCellStyle3.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold, GraphicsUnit.Point);
            dataGridViewCellStyle3.ForeColor = SystemColors.WindowText;
            dataGridViewCellStyle3.SelectionBackColor = SystemColors.Highlight;
            dataGridViewCellStyle3.SelectionForeColor = SystemColors.HighlightText;
            dataGridViewCellStyle3.WrapMode = DataGridViewTriState.True;
            dataGridViewGroup.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle3;
            dataGridViewGroup.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewGroup.Dock = DockStyle.Fill;
            dataGridViewGroup.Location = new Point(0, 0);
            dataGridViewGroup.Margin = new Padding(4, 3, 4, 3);
            dataGridViewGroup.Name = "dataGridViewGroup";
            dataGridViewGroup.ReadOnly = true;
            dataGridViewGroup.RowHeadersVisible = false;
            dataGridViewCellStyle4.Alignment = DataGridViewContentAlignment.MiddleCenter;
            dataGridViewGroup.RowsDefaultCellStyle = dataGridViewCellStyle4;
            dataGridViewGroup.Size = new Size(1147, 555);
            dataGridViewGroup.TabIndex = 0;
            // 
            // Employee
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.Control;
            ClientSize = new Size(1163, 595);
            Controls.Add(tabControl1);
            Icon = (Icon)resources.GetObject("$this.Icon");
            Margin = new Padding(4, 3, 4, 3);
            Name = "Employee";
            Text = "FormEmployeeManagement";
            Load += Employee_Load;
            tabControl1.ResumeLayout(false);
            tabPageUser.ResumeLayout(false);
            panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)dataGridViewUser).EndInit();
            panel3.ResumeLayout(false);
            tabPageGroup.ResumeLayout(false);
            panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)dataGridViewGroup).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private TabControl tabControl1;
        private TabPage tabPageUser;
        private TabPage tabPageGroup;
        private Panel panel2;
        private DataGridView dataGridViewUser;
        private Panel panel3;
        private Button buttonThemNhanVien;
        private Button buttonSuaNhanVien;
        private Panel panel1;
        private DataGridView dataGridViewGroup;
        private LW_PhanMemBaoGia.MyControls.ButtonCustom buttonAddUser;
        private LW_PhanMemBaoGia.MyControls.ButtonCustom buttonChangeUser;
    }
}