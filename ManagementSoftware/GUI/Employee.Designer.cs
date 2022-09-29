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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Employee));
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle4 = new System.Windows.Forms.DataGridViewCellStyle();
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.tabPageUser = new System.Windows.Forms.TabPage();
            this.panel2 = new System.Windows.Forms.Panel();
            this.dataGridViewUser = new System.Windows.Forms.DataGridView();
            this.panel3 = new System.Windows.Forms.Panel();
            this.textBoxSearchUser = new LW_PhanMemBaoGia.MyControls.TextBoxT();
            this.buttonChangeUser = new LW_PhanMemBaoGia.MyControls.ButtonCustom();
            this.buttonAddUser = new LW_PhanMemBaoGia.MyControls.ButtonCustom();
            this.buttonSearchUser = new LW_PhanMemBaoGia.MyControls.ButtonCustom();
            this.buttonThemNhanVien = new System.Windows.Forms.Button();
            this.buttonSuaNhanVien = new System.Windows.Forms.Button();
            this.tabPageGroup = new System.Windows.Forms.TabPage();
            this.panel1 = new System.Windows.Forms.Panel();
            this.dataGridViewGroup = new System.Windows.Forms.DataGridView();
            this.panel4 = new System.Windows.Forms.Panel();
            this.textBoxSearchGroup = new LW_PhanMemBaoGia.MyControls.TextBoxT();
            this.buttonChangeGroup = new LW_PhanMemBaoGia.MyControls.ButtonCustom();
            this.buttonAddGroup = new LW_PhanMemBaoGia.MyControls.ButtonCustom();
            this.buttonSearchGroup = new LW_PhanMemBaoGia.MyControls.ButtonCustom();
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.button4 = new System.Windows.Forms.Button();
            this.button5 = new System.Windows.Forms.Button();
            this.tabControl1.SuspendLayout();
            this.tabPageUser.SuspendLayout();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewUser)).BeginInit();
            this.panel3.SuspendLayout();
            this.tabPageGroup.SuspendLayout();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewGroup)).BeginInit();
            this.panel4.SuspendLayout();
            this.SuspendLayout();
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.tabPageUser);
            this.tabControl1.Controls.Add(this.tabPageGroup);
            this.tabControl1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tabControl1.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold);
            this.tabControl1.Location = new System.Drawing.Point(0, 0);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(997, 516);
            this.tabControl1.TabIndex = 0;
            // 
            // tabPageUser
            // 
            this.tabPageUser.BackColor = System.Drawing.SystemColors.InactiveCaption;
            this.tabPageUser.Controls.Add(this.panel2);
            this.tabPageUser.Controls.Add(this.panel3);
            this.tabPageUser.Location = new System.Drawing.Point(4, 30);
            this.tabPageUser.Name = "tabPageUser";
            this.tabPageUser.Padding = new System.Windows.Forms.Padding(3);
            this.tabPageUser.Size = new System.Drawing.Size(989, 482);
            this.tabPageUser.TabIndex = 0;
            this.tabPageUser.Text = "Tài khoản thành viên";
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.dataGridViewUser);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel2.Location = new System.Drawing.Point(3, 3);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(983, 425);
            this.panel2.TabIndex = 8;
            // 
            // dataGridViewUser
            // 
            this.dataGridViewUser.AllowUserToAddRows = false;
            this.dataGridViewUser.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGridViewUser.BackgroundColor = System.Drawing.Color.LightGray;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold);
            dataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dataGridViewUser.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.dataGridViewUser.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewUser.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dataGridViewUser.Location = new System.Drawing.Point(0, 0);
            this.dataGridViewUser.Name = "dataGridViewUser";
            this.dataGridViewUser.ReadOnly = true;
            this.dataGridViewUser.RowHeadersVisible = false;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            this.dataGridViewUser.RowsDefaultCellStyle = dataGridViewCellStyle2;
            this.dataGridViewUser.Size = new System.Drawing.Size(983, 425);
            this.dataGridViewUser.TabIndex = 0;
            // 
            // panel3
            // 
            this.panel3.BackColor = System.Drawing.Color.Transparent;
            this.panel3.Controls.Add(this.textBoxSearchUser);
            this.panel3.Controls.Add(this.buttonChangeUser);
            this.panel3.Controls.Add(this.buttonAddUser);
            this.panel3.Controls.Add(this.buttonSearchUser);
            this.panel3.Controls.Add(this.buttonThemNhanVien);
            this.panel3.Controls.Add(this.buttonSuaNhanVien);
            this.panel3.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panel3.Font = new System.Drawing.Font("Segoe UI", 9.75F);
            this.panel3.Location = new System.Drawing.Point(3, 428);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(983, 51);
            this.panel3.TabIndex = 9;
            // 
            // textBoxSearchUser
            // 
            this.textBoxSearchUser.BackColor = System.Drawing.SystemColors.Window;
            this.textBoxSearchUser.BorderColor = System.Drawing.Color.CornflowerBlue;
            this.textBoxSearchUser.BorderFocusColor = System.Drawing.SystemColors.ActiveCaption;
            this.textBoxSearchUser.BorderRadius = 5;
            this.textBoxSearchUser.BorderSize = 1;
            this.textBoxSearchUser.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBoxSearchUser.Location = new System.Drawing.Point(5, 11);
            this.textBoxSearchUser.Multiline = false;
            this.textBoxSearchUser.Name = "textBoxSearchUser";
            this.textBoxSearchUser.Padding = new System.Windows.Forms.Padding(7, 8, 7, 5);
            this.textBoxSearchUser.PasswordChar = false;
            this.textBoxSearchUser.PlaceholderColor = System.Drawing.Color.DarkGray;
            this.textBoxSearchUser.PlaceholderText = "Nhập tên người dùng";
            this.textBoxSearchUser.Size = new System.Drawing.Size(162, 34);
            this.textBoxSearchUser.TabIndex = 26;
            this.textBoxSearchUser.Texts = "Nhập tên người dùng";
            this.textBoxSearchUser.UnderlinedStyle = false;
            // 
            // buttonChangeUser
            // 
            this.buttonChangeUser.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.buttonChangeUser.BackColor = System.Drawing.Color.DarkGoldenrod;
            this.buttonChangeUser.BackgroundColor = System.Drawing.Color.DarkGoldenrod;
            this.buttonChangeUser.BorderColor = System.Drawing.Color.PaleVioletRed;
            this.buttonChangeUser.BorderRadius = 3;
            this.buttonChangeUser.BorderSize = 0;
            this.buttonChangeUser.Cursor = System.Windows.Forms.Cursors.Hand;
            this.buttonChangeUser.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonChangeUser.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonChangeUser.ForeColor = System.Drawing.Color.White;
            this.buttonChangeUser.Image = global::ManagementSoftware.Properties.Resources.iconfinder_Synchronize_278832;
            this.buttonChangeUser.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.buttonChangeUser.Location = new System.Drawing.Point(872, 12);
            this.buttonChangeUser.Name = "buttonChangeUser";
            this.buttonChangeUser.Size = new System.Drawing.Size(106, 29);
            this.buttonChangeUser.TabIndex = 22;
            this.buttonChangeUser.Text = "Thay đổi";
            this.buttonChangeUser.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.buttonChangeUser.TextColor = System.Drawing.Color.White;
            this.buttonChangeUser.TextImageRelation = System.Windows.Forms.TextImageRelation.TextBeforeImage;
            this.buttonChangeUser.UseVisualStyleBackColor = false;
            // 
            // buttonAddUser
            // 
            this.buttonAddUser.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.buttonAddUser.BackColor = System.Drawing.Color.Green;
            this.buttonAddUser.BackgroundColor = System.Drawing.Color.Green;
            this.buttonAddUser.BorderColor = System.Drawing.Color.PaleVioletRed;
            this.buttonAddUser.BorderRadius = 3;
            this.buttonAddUser.BorderSize = 0;
            this.buttonAddUser.Cursor = System.Windows.Forms.Cursors.Hand;
            this.buttonAddUser.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonAddUser.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonAddUser.ForeColor = System.Drawing.Color.White;
            this.buttonAddUser.Image = ((System.Drawing.Image)(resources.GetObject("buttonAddUser.Image")));
            this.buttonAddUser.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.buttonAddUser.Location = new System.Drawing.Point(763, 12);
            this.buttonAddUser.Name = "buttonAddUser";
            this.buttonAddUser.Size = new System.Drawing.Size(106, 29);
            this.buttonAddUser.TabIndex = 21;
            this.buttonAddUser.Text = "Thêm mới";
            this.buttonAddUser.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.buttonAddUser.TextColor = System.Drawing.Color.White;
            this.buttonAddUser.TextImageRelation = System.Windows.Forms.TextImageRelation.TextBeforeImage;
            this.buttonAddUser.UseVisualStyleBackColor = false;
            // 
            // buttonSearchUser
            // 
            this.buttonSearchUser.BackColor = System.Drawing.Color.LightSkyBlue;
            this.buttonSearchUser.BackgroundColor = System.Drawing.Color.LightSkyBlue;
            this.buttonSearchUser.BorderColor = System.Drawing.Color.PaleVioletRed;
            this.buttonSearchUser.BorderRadius = 3;
            this.buttonSearchUser.BorderSize = 0;
            this.buttonSearchUser.Cursor = System.Windows.Forms.Cursors.Hand;
            this.buttonSearchUser.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonSearchUser.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonSearchUser.ForeColor = System.Drawing.Color.Black;
            this.buttonSearchUser.Image = ((System.Drawing.Image)(resources.GetObject("buttonSearchUser.Image")));
            this.buttonSearchUser.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.buttonSearchUser.Location = new System.Drawing.Point(173, 12);
            this.buttonSearchUser.Name = "buttonSearchUser";
            this.buttonSearchUser.Size = new System.Drawing.Size(72, 29);
            this.buttonSearchUser.TabIndex = 20;
            this.buttonSearchUser.Text = "Tìm";
            this.buttonSearchUser.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.buttonSearchUser.TextColor = System.Drawing.Color.Black;
            this.buttonSearchUser.TextImageRelation = System.Windows.Forms.TextImageRelation.TextBeforeImage;
            this.buttonSearchUser.UseVisualStyleBackColor = false;
            // 
            // buttonThemNhanVien
            // 
            this.buttonThemNhanVien.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.buttonThemNhanVien.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F);
            this.buttonThemNhanVien.Image = global::ManagementSoftware.Properties.Resources.iconfinder_Stock_Index_Up_278812;
            this.buttonThemNhanVien.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.buttonThemNhanVien.Location = new System.Drawing.Point(1537, -27);
            this.buttonThemNhanVien.Name = "buttonThemNhanVien";
            this.buttonThemNhanVien.Size = new System.Drawing.Size(81, 24);
            this.buttonThemNhanVien.TabIndex = 2;
            this.buttonThemNhanVien.Text = "Thêm mới";
            this.buttonThemNhanVien.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.buttonThemNhanVien.UseVisualStyleBackColor = true;
            // 
            // buttonSuaNhanVien
            // 
            this.buttonSuaNhanVien.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.buttonSuaNhanVien.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F);
            this.buttonSuaNhanVien.Image = global::ManagementSoftware.Properties.Resources.iconfinder_Synchronize_278832;
            this.buttonSuaNhanVien.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.buttonSuaNhanVien.Location = new System.Drawing.Point(1624, -27);
            this.buttonSuaNhanVien.Name = "buttonSuaNhanVien";
            this.buttonSuaNhanVien.Size = new System.Drawing.Size(81, 24);
            this.buttonSuaNhanVien.TabIndex = 3;
            this.buttonSuaNhanVien.Text = "Thay đổi";
            this.buttonSuaNhanVien.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.buttonSuaNhanVien.UseVisualStyleBackColor = true;
            // 
            // tabPageGroup
            // 
            this.tabPageGroup.BackColor = System.Drawing.SystemColors.InactiveCaption;
            this.tabPageGroup.Controls.Add(this.panel1);
            this.tabPageGroup.Controls.Add(this.panel4);
            this.tabPageGroup.Location = new System.Drawing.Point(4, 30);
            this.tabPageGroup.Name = "tabPageGroup";
            this.tabPageGroup.Padding = new System.Windows.Forms.Padding(3);
            this.tabPageGroup.Size = new System.Drawing.Size(989, 482);
            this.tabPageGroup.TabIndex = 1;
            this.tabPageGroup.Text = "Phân quyền";
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.dataGridViewGroup);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel1.Location = new System.Drawing.Point(3, 3);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(983, 425);
            this.panel1.TabIndex = 10;
            // 
            // dataGridViewGroup
            // 
            this.dataGridViewGroup.AllowUserToAddRows = false;
            this.dataGridViewGroup.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGridViewGroup.BackgroundColor = System.Drawing.Color.LightGray;
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle3.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold);
            dataGridViewCellStyle3.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dataGridViewGroup.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle3;
            this.dataGridViewGroup.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewGroup.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dataGridViewGroup.Location = new System.Drawing.Point(0, 0);
            this.dataGridViewGroup.Name = "dataGridViewGroup";
            this.dataGridViewGroup.ReadOnly = true;
            this.dataGridViewGroup.RowHeadersVisible = false;
            dataGridViewCellStyle4.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            this.dataGridViewGroup.RowsDefaultCellStyle = dataGridViewCellStyle4;
            this.dataGridViewGroup.Size = new System.Drawing.Size(983, 425);
            this.dataGridViewGroup.TabIndex = 0;
            // 
            // panel4
            // 
            this.panel4.BackColor = System.Drawing.Color.Transparent;
            this.panel4.Controls.Add(this.textBoxSearchGroup);
            this.panel4.Controls.Add(this.buttonChangeGroup);
            this.panel4.Controls.Add(this.buttonAddGroup);
            this.panel4.Controls.Add(this.buttonSearchGroup);
            this.panel4.Controls.Add(this.button1);
            this.panel4.Controls.Add(this.button2);
            this.panel4.Controls.Add(this.button4);
            this.panel4.Controls.Add(this.button5);
            this.panel4.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panel4.Font = new System.Drawing.Font("Segoe UI", 12F);
            this.panel4.Location = new System.Drawing.Point(3, 428);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(983, 51);
            this.panel4.TabIndex = 11;
            // 
            // textBoxSearchGroup
            // 
            this.textBoxSearchGroup.BackColor = System.Drawing.SystemColors.Window;
            this.textBoxSearchGroup.BorderColor = System.Drawing.Color.CornflowerBlue;
            this.textBoxSearchGroup.BorderFocusColor = System.Drawing.SystemColors.ActiveCaption;
            this.textBoxSearchGroup.BorderRadius = 5;
            this.textBoxSearchGroup.BorderSize = 1;
            this.textBoxSearchGroup.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBoxSearchGroup.Location = new System.Drawing.Point(3, 11);
            this.textBoxSearchGroup.Multiline = false;
            this.textBoxSearchGroup.Name = "textBoxSearchGroup";
            this.textBoxSearchGroup.Padding = new System.Windows.Forms.Padding(7, 8, 7, 5);
            this.textBoxSearchGroup.PasswordChar = false;
            this.textBoxSearchGroup.PlaceholderColor = System.Drawing.Color.DarkGray;
            this.textBoxSearchGroup.PlaceholderText = "Nhập tên quyền";
            this.textBoxSearchGroup.Size = new System.Drawing.Size(162, 34);
            this.textBoxSearchGroup.TabIndex = 25;
            this.textBoxSearchGroup.Texts = "Nhập tên quyền";
            this.textBoxSearchGroup.UnderlinedStyle = false;
            // 
            // buttonChangeGroup
            // 
            this.buttonChangeGroup.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.buttonChangeGroup.BackColor = System.Drawing.Color.DarkGoldenrod;
            this.buttonChangeGroup.BackgroundColor = System.Drawing.Color.DarkGoldenrod;
            this.buttonChangeGroup.BorderColor = System.Drawing.Color.PaleVioletRed;
            this.buttonChangeGroup.BorderRadius = 3;
            this.buttonChangeGroup.BorderSize = 0;
            this.buttonChangeGroup.Cursor = System.Windows.Forms.Cursors.Hand;
            this.buttonChangeGroup.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonChangeGroup.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonChangeGroup.ForeColor = System.Drawing.Color.White;
            this.buttonChangeGroup.Image = global::ManagementSoftware.Properties.Resources.iconfinder_Synchronize_278832;
            this.buttonChangeGroup.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.buttonChangeGroup.Location = new System.Drawing.Point(874, 12);
            this.buttonChangeGroup.Name = "buttonChangeGroup";
            this.buttonChangeGroup.Size = new System.Drawing.Size(106, 29);
            this.buttonChangeGroup.TabIndex = 24;
            this.buttonChangeGroup.Text = "Thay đổi";
            this.buttonChangeGroup.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.buttonChangeGroup.TextColor = System.Drawing.Color.White;
            this.buttonChangeGroup.TextImageRelation = System.Windows.Forms.TextImageRelation.TextBeforeImage;
            this.buttonChangeGroup.UseVisualStyleBackColor = false;
            // 
            // buttonAddGroup
            // 
            this.buttonAddGroup.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.buttonAddGroup.BackColor = System.Drawing.Color.Green;
            this.buttonAddGroup.BackgroundColor = System.Drawing.Color.Green;
            this.buttonAddGroup.BorderColor = System.Drawing.Color.PaleVioletRed;
            this.buttonAddGroup.BorderRadius = 3;
            this.buttonAddGroup.BorderSize = 0;
            this.buttonAddGroup.Cursor = System.Windows.Forms.Cursors.Hand;
            this.buttonAddGroup.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonAddGroup.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonAddGroup.ForeColor = System.Drawing.Color.White;
            this.buttonAddGroup.Image = ((System.Drawing.Image)(resources.GetObject("buttonAddGroup.Image")));
            this.buttonAddGroup.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.buttonAddGroup.Location = new System.Drawing.Point(765, 12);
            this.buttonAddGroup.Name = "buttonAddGroup";
            this.buttonAddGroup.Size = new System.Drawing.Size(106, 29);
            this.buttonAddGroup.TabIndex = 23;
            this.buttonAddGroup.Text = "Thêm mới";
            this.buttonAddGroup.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.buttonAddGroup.TextColor = System.Drawing.Color.White;
            this.buttonAddGroup.TextImageRelation = System.Windows.Forms.TextImageRelation.TextBeforeImage;
            this.buttonAddGroup.UseVisualStyleBackColor = false;
            // 
            // buttonSearchGroup
            // 
            this.buttonSearchGroup.BackColor = System.Drawing.Color.LightSkyBlue;
            this.buttonSearchGroup.BackgroundColor = System.Drawing.Color.LightSkyBlue;
            this.buttonSearchGroup.BorderColor = System.Drawing.Color.PaleVioletRed;
            this.buttonSearchGroup.BorderRadius = 3;
            this.buttonSearchGroup.BorderSize = 0;
            this.buttonSearchGroup.Cursor = System.Windows.Forms.Cursors.Hand;
            this.buttonSearchGroup.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonSearchGroup.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonSearchGroup.ForeColor = System.Drawing.Color.Black;
            this.buttonSearchGroup.Image = ((System.Drawing.Image)(resources.GetObject("buttonSearchGroup.Image")));
            this.buttonSearchGroup.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.buttonSearchGroup.Location = new System.Drawing.Point(171, 12);
            this.buttonSearchGroup.Name = "buttonSearchGroup";
            this.buttonSearchGroup.Size = new System.Drawing.Size(72, 29);
            this.buttonSearchGroup.TabIndex = 21;
            this.buttonSearchGroup.Text = "Tìm";
            this.buttonSearchGroup.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.buttonSearchGroup.TextColor = System.Drawing.Color.Black;
            this.buttonSearchGroup.TextImageRelation = System.Windows.Forms.TextImageRelation.TextBeforeImage;
            this.buttonSearchGroup.UseVisualStyleBackColor = false;
            // 
            // button1
            // 
            this.button1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.button1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F);
            this.button1.Image = global::ManagementSoftware.Properties.Resources.iconfinder_Stock_Index_Up_278812;
            this.button1.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.button1.Location = new System.Drawing.Point(1437, -23);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(81, 24);
            this.button1.TabIndex = 6;
            this.button1.Text = "Thêm mới";
            this.button1.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.button1.UseVisualStyleBackColor = true;
            // 
            // button2
            // 
            this.button2.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.button2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F);
            this.button2.Image = global::ManagementSoftware.Properties.Resources.iconfinder_Synchronize_278832;
            this.button2.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.button2.Location = new System.Drawing.Point(1524, -23);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(81, 24);
            this.button2.TabIndex = 7;
            this.button2.Text = "Thay đổi";
            this.button2.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.button2.UseVisualStyleBackColor = true;
            // 
            // button4
            // 
            this.button4.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.button4.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F);
            this.button4.Image = global::ManagementSoftware.Properties.Resources.iconfinder_Stock_Index_Up_278812;
            this.button4.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.button4.Location = new System.Drawing.Point(2162, -62);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(81, 24);
            this.button4.TabIndex = 2;
            this.button4.Text = "Thêm mới";
            this.button4.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.button4.UseVisualStyleBackColor = true;
            // 
            // button5
            // 
            this.button5.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.button5.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F);
            this.button5.Image = global::ManagementSoftware.Properties.Resources.iconfinder_Synchronize_278832;
            this.button5.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.button5.Location = new System.Drawing.Point(2249, -62);
            this.button5.Name = "button5";
            this.button5.Size = new System.Drawing.Size(81, 24);
            this.button5.TabIndex = 3;
            this.button5.Text = "Thay đổi";
            this.button5.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.button5.UseVisualStyleBackColor = true;
            // 
            // FormEmployeeManagement
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Control;
            this.ClientSize = new System.Drawing.Size(997, 516);
            this.Controls.Add(this.tabControl1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "FormEmployeeManagement";
            this.Text = "FormEmployeeManagement";
            this.tabControl1.ResumeLayout(false);
            this.tabPageUser.ResumeLayout(false);
            this.panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewUser)).EndInit();
            this.panel3.ResumeLayout(false);
            this.tabPageGroup.ResumeLayout(false);
            this.panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewGroup)).EndInit();
            this.panel4.ResumeLayout(false);
            this.ResumeLayout(false);

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
        private Panel panel4;
        private Button button1;
        private Button button2;
        private Button button4;
        private Button button5;
        private LW_PhanMemBaoGia.MyControls.ButtonCustom buttonSearchUser;
        private LW_PhanMemBaoGia.MyControls.ButtonCustom buttonSearchGroup;
        private LW_PhanMemBaoGia.MyControls.ButtonCustom buttonAddUser;
        private LW_PhanMemBaoGia.MyControls.ButtonCustom buttonChangeUser;
        private LW_PhanMemBaoGia.MyControls.ButtonCustom buttonChangeGroup;
        private LW_PhanMemBaoGia.MyControls.ButtonCustom buttonAddGroup;
        private LW_PhanMemBaoGia.MyControls.TextBoxT textBoxSearchGroup;
        private LW_PhanMemBaoGia.MyControls.TextBoxT textBoxSearchUser;
    }
}