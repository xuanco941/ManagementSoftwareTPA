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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle21 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle22 = new System.Windows.Forms.DataGridViewCellStyle();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Employee));
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle23 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle24 = new System.Windows.Forms.DataGridViewCellStyle();
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.tabPageUser = new System.Windows.Forms.TabPage();
            this.panel2 = new System.Windows.Forms.Panel();
            this.dataGridViewUser = new System.Windows.Forms.DataGridView();
            this.panel3 = new System.Windows.Forms.Panel();
            this.buttonChangeUser = new LW_PhanMemBaoGia.MyControls.ButtonCustom();
            this.buttonAddUser = new LW_PhanMemBaoGia.MyControls.ButtonCustom();
            this.buttonThemNhanVien = new System.Windows.Forms.Button();
            this.buttonSuaNhanVien = new System.Windows.Forms.Button();
            this.tabPageGroup = new System.Windows.Forms.TabPage();
            this.panel1 = new System.Windows.Forms.Panel();
            this.dataGridViewGroup = new System.Windows.Forms.DataGridView();
            this.panel4 = new System.Windows.Forms.Panel();
            this.buttonChangeGroup = new LW_PhanMemBaoGia.MyControls.ButtonCustom();
            this.buttonAddGroup = new LW_PhanMemBaoGia.MyControls.ButtonCustom();
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.button4 = new System.Windows.Forms.Button();
            this.button5 = new System.Windows.Forms.Button();
            this.buttonCustom1 = new LW_PhanMemBaoGia.MyControls.ButtonCustom();
            this.buttonCustom2 = new LW_PhanMemBaoGia.MyControls.ButtonCustom();
            this.buttonCustom3 = new LW_PhanMemBaoGia.MyControls.ButtonCustom();
            this.buttonCustom4 = new LW_PhanMemBaoGia.MyControls.ButtonCustom();
            this.buttonCustom5 = new LW_PhanMemBaoGia.MyControls.ButtonCustom();
            this.buttonCustom6 = new LW_PhanMemBaoGia.MyControls.ButtonCustom();
            this.buttonCustom7 = new LW_PhanMemBaoGia.MyControls.ButtonCustom();
            this.buttonCustom8 = new LW_PhanMemBaoGia.MyControls.ButtonCustom();
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
            this.tabControl1.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.tabControl1.Location = new System.Drawing.Point(0, 0);
            this.tabControl1.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(1163, 595);
            this.tabControl1.TabIndex = 0;
            // 
            // tabPageUser
            // 
            this.tabPageUser.BackColor = System.Drawing.SystemColors.InactiveCaption;
            this.tabPageUser.Controls.Add(this.panel2);
            this.tabPageUser.Controls.Add(this.panel3);
            this.tabPageUser.Location = new System.Drawing.Point(4, 30);
            this.tabPageUser.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.tabPageUser.Name = "tabPageUser";
            this.tabPageUser.Padding = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.tabPageUser.Size = new System.Drawing.Size(1155, 561);
            this.tabPageUser.TabIndex = 0;
            this.tabPageUser.Text = "Tài khoản thành viên";
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.dataGridViewUser);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel2.Location = new System.Drawing.Point(4, 3);
            this.panel2.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(1147, 496);
            this.panel2.TabIndex = 8;
            // 
            // dataGridViewUser
            // 
            this.dataGridViewUser.AllowUserToAddRows = false;
            this.dataGridViewUser.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGridViewUser.BackgroundColor = System.Drawing.Color.LightGray;
            dataGridViewCellStyle21.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle21.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle21.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            dataGridViewCellStyle21.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle21.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle21.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle21.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dataGridViewUser.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle21;
            this.dataGridViewUser.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewUser.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dataGridViewUser.Location = new System.Drawing.Point(0, 0);
            this.dataGridViewUser.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.dataGridViewUser.Name = "dataGridViewUser";
            this.dataGridViewUser.ReadOnly = true;
            this.dataGridViewUser.RowHeadersVisible = false;
            dataGridViewCellStyle22.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            this.dataGridViewUser.RowsDefaultCellStyle = dataGridViewCellStyle22;
            this.dataGridViewUser.Size = new System.Drawing.Size(1147, 496);
            this.dataGridViewUser.TabIndex = 0;
            // 
            // panel3
            // 
            this.panel3.BackColor = System.Drawing.Color.Transparent;
            this.panel3.Controls.Add(this.buttonCustom1);
            this.panel3.Controls.Add(this.buttonCustom2);
            this.panel3.Controls.Add(this.buttonCustom3);
            this.panel3.Controls.Add(this.buttonCustom4);
            this.panel3.Controls.Add(this.buttonChangeUser);
            this.panel3.Controls.Add(this.buttonAddUser);
            this.panel3.Controls.Add(this.buttonThemNhanVien);
            this.panel3.Controls.Add(this.buttonSuaNhanVien);
            this.panel3.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panel3.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.panel3.Location = new System.Drawing.Point(4, 499);
            this.panel3.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(1147, 59);
            this.panel3.TabIndex = 9;
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
            this.buttonChangeUser.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.buttonChangeUser.ForeColor = System.Drawing.Color.White;
            this.buttonChangeUser.Image = global::ManagementSoftware.Properties.Resources.iconfinder_Synchronize_278832;
            this.buttonChangeUser.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.buttonChangeUser.Location = new System.Drawing.Point(1017, 14);
            this.buttonChangeUser.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.buttonChangeUser.Name = "buttonChangeUser";
            this.buttonChangeUser.Size = new System.Drawing.Size(124, 33);
            this.buttonChangeUser.TabIndex = 22;
            this.buttonChangeUser.Text = "Thay đổi";
            this.buttonChangeUser.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.buttonChangeUser.TextColor = System.Drawing.Color.White;
            this.buttonChangeUser.TextImageRelation = System.Windows.Forms.TextImageRelation.TextBeforeImage;
            this.buttonChangeUser.UseVisualStyleBackColor = false;
            this.buttonChangeUser.Click += new System.EventHandler(this.buttonChangeUser_Click);
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
            this.buttonAddUser.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.buttonAddUser.ForeColor = System.Drawing.Color.White;
            this.buttonAddUser.Image = ((System.Drawing.Image)(resources.GetObject("buttonAddUser.Image")));
            this.buttonAddUser.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.buttonAddUser.Location = new System.Drawing.Point(890, 14);
            this.buttonAddUser.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.buttonAddUser.Name = "buttonAddUser";
            this.buttonAddUser.Size = new System.Drawing.Size(124, 33);
            this.buttonAddUser.TabIndex = 21;
            this.buttonAddUser.Text = "Thêm mới";
            this.buttonAddUser.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.buttonAddUser.TextColor = System.Drawing.Color.White;
            this.buttonAddUser.TextImageRelation = System.Windows.Forms.TextImageRelation.TextBeforeImage;
            this.buttonAddUser.UseVisualStyleBackColor = false;
            this.buttonAddUser.Click += new System.EventHandler(this.buttonAddUser_Click);
            // 
            // buttonThemNhanVien
            // 
            this.buttonThemNhanVien.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.buttonThemNhanVien.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.buttonThemNhanVien.Image = global::ManagementSoftware.Properties.Resources.iconfinder_Stock_Index_Up_278812;
            this.buttonThemNhanVien.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.buttonThemNhanVien.Location = new System.Drawing.Point(1793, -31);
            this.buttonThemNhanVien.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.buttonThemNhanVien.Name = "buttonThemNhanVien";
            this.buttonThemNhanVien.Size = new System.Drawing.Size(94, 28);
            this.buttonThemNhanVien.TabIndex = 2;
            this.buttonThemNhanVien.Text = "Thêm mới";
            this.buttonThemNhanVien.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.buttonThemNhanVien.UseVisualStyleBackColor = true;
            // 
            // buttonSuaNhanVien
            // 
            this.buttonSuaNhanVien.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.buttonSuaNhanVien.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.buttonSuaNhanVien.Image = global::ManagementSoftware.Properties.Resources.iconfinder_Synchronize_278832;
            this.buttonSuaNhanVien.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.buttonSuaNhanVien.Location = new System.Drawing.Point(1895, -31);
            this.buttonSuaNhanVien.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.buttonSuaNhanVien.Name = "buttonSuaNhanVien";
            this.buttonSuaNhanVien.Size = new System.Drawing.Size(94, 28);
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
            this.tabPageGroup.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.tabPageGroup.Name = "tabPageGroup";
            this.tabPageGroup.Padding = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.tabPageGroup.Size = new System.Drawing.Size(1155, 561);
            this.tabPageGroup.TabIndex = 1;
            this.tabPageGroup.Text = "Phân quyền";
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.dataGridViewGroup);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel1.Location = new System.Drawing.Point(4, 3);
            this.panel1.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1147, 496);
            this.panel1.TabIndex = 10;
            // 
            // dataGridViewGroup
            // 
            this.dataGridViewGroup.AllowUserToAddRows = false;
            this.dataGridViewGroup.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGridViewGroup.BackgroundColor = System.Drawing.Color.LightGray;
            dataGridViewCellStyle23.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle23.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle23.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            dataGridViewCellStyle23.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle23.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle23.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle23.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dataGridViewGroup.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle23;
            this.dataGridViewGroup.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewGroup.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dataGridViewGroup.Location = new System.Drawing.Point(0, 0);
            this.dataGridViewGroup.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.dataGridViewGroup.Name = "dataGridViewGroup";
            this.dataGridViewGroup.ReadOnly = true;
            this.dataGridViewGroup.RowHeadersVisible = false;
            dataGridViewCellStyle24.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            this.dataGridViewGroup.RowsDefaultCellStyle = dataGridViewCellStyle24;
            this.dataGridViewGroup.Size = new System.Drawing.Size(1147, 496);
            this.dataGridViewGroup.TabIndex = 0;
            // 
            // panel4
            // 
            this.panel4.BackColor = System.Drawing.Color.Transparent;
            this.panel4.Controls.Add(this.buttonCustom5);
            this.panel4.Controls.Add(this.buttonCustom6);
            this.panel4.Controls.Add(this.buttonCustom7);
            this.panel4.Controls.Add(this.buttonCustom8);
            this.panel4.Controls.Add(this.buttonChangeGroup);
            this.panel4.Controls.Add(this.buttonAddGroup);
            this.panel4.Controls.Add(this.button1);
            this.panel4.Controls.Add(this.button2);
            this.panel4.Controls.Add(this.button4);
            this.panel4.Controls.Add(this.button5);
            this.panel4.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panel4.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.panel4.Location = new System.Drawing.Point(4, 499);
            this.panel4.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(1147, 59);
            this.panel4.TabIndex = 11;
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
            this.buttonChangeGroup.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.buttonChangeGroup.ForeColor = System.Drawing.Color.White;
            this.buttonChangeGroup.Image = global::ManagementSoftware.Properties.Resources.iconfinder_Synchronize_278832;
            this.buttonChangeGroup.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.buttonChangeGroup.Location = new System.Drawing.Point(1020, 14);
            this.buttonChangeGroup.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.buttonChangeGroup.Name = "buttonChangeGroup";
            this.buttonChangeGroup.Size = new System.Drawing.Size(124, 33);
            this.buttonChangeGroup.TabIndex = 24;
            this.buttonChangeGroup.Text = "Thay đổi";
            this.buttonChangeGroup.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.buttonChangeGroup.TextColor = System.Drawing.Color.White;
            this.buttonChangeGroup.TextImageRelation = System.Windows.Forms.TextImageRelation.TextBeforeImage;
            this.buttonChangeGroup.UseVisualStyleBackColor = false;
            this.buttonChangeGroup.Click += new System.EventHandler(this.buttonChangeGroup_Click);
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
            this.buttonAddGroup.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.buttonAddGroup.ForeColor = System.Drawing.Color.White;
            this.buttonAddGroup.Image = ((System.Drawing.Image)(resources.GetObject("buttonAddGroup.Image")));
            this.buttonAddGroup.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.buttonAddGroup.Location = new System.Drawing.Point(892, 14);
            this.buttonAddGroup.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.buttonAddGroup.Name = "buttonAddGroup";
            this.buttonAddGroup.Size = new System.Drawing.Size(124, 33);
            this.buttonAddGroup.TabIndex = 23;
            this.buttonAddGroup.Text = "Thêm mới";
            this.buttonAddGroup.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.buttonAddGroup.TextColor = System.Drawing.Color.White;
            this.buttonAddGroup.TextImageRelation = System.Windows.Forms.TextImageRelation.TextBeforeImage;
            this.buttonAddGroup.UseVisualStyleBackColor = false;
            this.buttonAddGroup.Click += new System.EventHandler(this.buttonAddGroup_Click);
            // 
            // button1
            // 
            this.button1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.button1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.button1.Image = global::ManagementSoftware.Properties.Resources.iconfinder_Stock_Index_Up_278812;
            this.button1.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.button1.Location = new System.Drawing.Point(1676, -27);
            this.button1.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(94, 28);
            this.button1.TabIndex = 6;
            this.button1.Text = "Thêm mới";
            this.button1.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.button1.UseVisualStyleBackColor = true;
            // 
            // button2
            // 
            this.button2.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.button2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.button2.Image = global::ManagementSoftware.Properties.Resources.iconfinder_Synchronize_278832;
            this.button2.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.button2.Location = new System.Drawing.Point(1778, -27);
            this.button2.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(94, 28);
            this.button2.TabIndex = 7;
            this.button2.Text = "Thay đổi";
            this.button2.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.button2.UseVisualStyleBackColor = true;
            // 
            // button4
            // 
            this.button4.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.button4.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.button4.Image = global::ManagementSoftware.Properties.Resources.iconfinder_Stock_Index_Up_278812;
            this.button4.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.button4.Location = new System.Drawing.Point(2522, -72);
            this.button4.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(94, 28);
            this.button4.TabIndex = 2;
            this.button4.Text = "Thêm mới";
            this.button4.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.button4.UseVisualStyleBackColor = true;
            // 
            // button5
            // 
            this.button5.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.button5.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.button5.Image = global::ManagementSoftware.Properties.Resources.iconfinder_Synchronize_278832;
            this.button5.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.button5.Location = new System.Drawing.Point(2624, -72);
            this.button5.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.button5.Name = "button5";
            this.button5.Size = new System.Drawing.Size(94, 28);
            this.button5.TabIndex = 3;
            this.button5.Text = "Thay đổi";
            this.button5.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.button5.UseVisualStyleBackColor = true;
            // 
            // buttonCustom1
            // 
            this.buttonCustom1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.buttonCustom1.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.buttonCustom1.BackgroundColor = System.Drawing.SystemColors.ActiveCaption;
            this.buttonCustom1.BorderColor = System.Drawing.Color.PaleVioletRed;
            this.buttonCustom1.BorderRadius = 3;
            this.buttonCustom1.BorderSize = 0;
            this.buttonCustom1.Cursor = System.Windows.Forms.Cursors.Hand;
            this.buttonCustom1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonCustom1.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.buttonCustom1.ForeColor = System.Drawing.Color.Black;
            this.buttonCustom1.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.buttonCustom1.Location = new System.Drawing.Point(244, 14);
            this.buttonCustom1.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.buttonCustom1.Name = "buttonCustom1";
            this.buttonCustom1.Size = new System.Drawing.Size(74, 35);
            this.buttonCustom1.TabIndex = 32;
            this.buttonCustom1.Text = ">>";
            this.buttonCustom1.TextColor = System.Drawing.Color.Black;
            this.buttonCustom1.TextImageRelation = System.Windows.Forms.TextImageRelation.TextBeforeImage;
            this.buttonCustom1.UseVisualStyleBackColor = false;
            // 
            // buttonCustom2
            // 
            this.buttonCustom2.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.buttonCustom2.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.buttonCustom2.BackgroundColor = System.Drawing.SystemColors.ActiveCaption;
            this.buttonCustom2.BorderColor = System.Drawing.Color.PaleVioletRed;
            this.buttonCustom2.BorderRadius = 3;
            this.buttonCustom2.BorderSize = 0;
            this.buttonCustom2.Cursor = System.Windows.Forms.Cursors.Hand;
            this.buttonCustom2.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonCustom2.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.buttonCustom2.ForeColor = System.Drawing.Color.Black;
            this.buttonCustom2.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.buttonCustom2.Location = new System.Drawing.Point(163, 14);
            this.buttonCustom2.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.buttonCustom2.Name = "buttonCustom2";
            this.buttonCustom2.Size = new System.Drawing.Size(74, 35);
            this.buttonCustom2.TabIndex = 31;
            this.buttonCustom2.Text = "3";
            this.buttonCustom2.TextColor = System.Drawing.Color.Black;
            this.buttonCustom2.TextImageRelation = System.Windows.Forms.TextImageRelation.TextBeforeImage;
            this.buttonCustom2.UseVisualStyleBackColor = false;
            // 
            // buttonCustom3
            // 
            this.buttonCustom3.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.buttonCustom3.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.buttonCustom3.BackgroundColor = System.Drawing.SystemColors.ActiveCaption;
            this.buttonCustom3.BorderColor = System.Drawing.Color.PaleVioletRed;
            this.buttonCustom3.BorderRadius = 3;
            this.buttonCustom3.BorderSize = 0;
            this.buttonCustom3.Cursor = System.Windows.Forms.Cursors.Hand;
            this.buttonCustom3.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonCustom3.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.buttonCustom3.ForeColor = System.Drawing.Color.Black;
            this.buttonCustom3.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.buttonCustom3.Location = new System.Drawing.Point(4, 14);
            this.buttonCustom3.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.buttonCustom3.Name = "buttonCustom3";
            this.buttonCustom3.Size = new System.Drawing.Size(74, 35);
            this.buttonCustom3.TabIndex = 30;
            this.buttonCustom3.Text = "1";
            this.buttonCustom3.TextColor = System.Drawing.Color.Black;
            this.buttonCustom3.TextImageRelation = System.Windows.Forms.TextImageRelation.TextBeforeImage;
            this.buttonCustom3.UseVisualStyleBackColor = false;
            // 
            // buttonCustom4
            // 
            this.buttonCustom4.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.buttonCustom4.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.buttonCustom4.BackgroundColor = System.Drawing.SystemColors.ActiveCaption;
            this.buttonCustom4.BorderColor = System.Drawing.Color.PaleVioletRed;
            this.buttonCustom4.BorderRadius = 3;
            this.buttonCustom4.BorderSize = 0;
            this.buttonCustom4.Cursor = System.Windows.Forms.Cursors.Hand;
            this.buttonCustom4.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonCustom4.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.buttonCustom4.ForeColor = System.Drawing.Color.Black;
            this.buttonCustom4.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.buttonCustom4.Location = new System.Drawing.Point(83, 14);
            this.buttonCustom4.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.buttonCustom4.Name = "buttonCustom4";
            this.buttonCustom4.Size = new System.Drawing.Size(74, 35);
            this.buttonCustom4.TabIndex = 29;
            this.buttonCustom4.Text = "2";
            this.buttonCustom4.TextColor = System.Drawing.Color.Black;
            this.buttonCustom4.TextImageRelation = System.Windows.Forms.TextImageRelation.TextBeforeImage;
            this.buttonCustom4.UseVisualStyleBackColor = false;
            // 
            // buttonCustom5
            // 
            this.buttonCustom5.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.buttonCustom5.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.buttonCustom5.BackgroundColor = System.Drawing.SystemColors.ActiveCaption;
            this.buttonCustom5.BorderColor = System.Drawing.Color.PaleVioletRed;
            this.buttonCustom5.BorderRadius = 3;
            this.buttonCustom5.BorderSize = 0;
            this.buttonCustom5.Cursor = System.Windows.Forms.Cursors.Hand;
            this.buttonCustom5.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonCustom5.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.buttonCustom5.ForeColor = System.Drawing.Color.Black;
            this.buttonCustom5.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.buttonCustom5.Location = new System.Drawing.Point(244, 13);
            this.buttonCustom5.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.buttonCustom5.Name = "buttonCustom5";
            this.buttonCustom5.Size = new System.Drawing.Size(74, 35);
            this.buttonCustom5.TabIndex = 32;
            this.buttonCustom5.Text = ">>";
            this.buttonCustom5.TextColor = System.Drawing.Color.Black;
            this.buttonCustom5.TextImageRelation = System.Windows.Forms.TextImageRelation.TextBeforeImage;
            this.buttonCustom5.UseVisualStyleBackColor = false;
            // 
            // buttonCustom6
            // 
            this.buttonCustom6.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.buttonCustom6.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.buttonCustom6.BackgroundColor = System.Drawing.SystemColors.ActiveCaption;
            this.buttonCustom6.BorderColor = System.Drawing.Color.PaleVioletRed;
            this.buttonCustom6.BorderRadius = 3;
            this.buttonCustom6.BorderSize = 0;
            this.buttonCustom6.Cursor = System.Windows.Forms.Cursors.Hand;
            this.buttonCustom6.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonCustom6.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.buttonCustom6.ForeColor = System.Drawing.Color.Black;
            this.buttonCustom6.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.buttonCustom6.Location = new System.Drawing.Point(163, 13);
            this.buttonCustom6.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.buttonCustom6.Name = "buttonCustom6";
            this.buttonCustom6.Size = new System.Drawing.Size(74, 35);
            this.buttonCustom6.TabIndex = 31;
            this.buttonCustom6.Text = "3";
            this.buttonCustom6.TextColor = System.Drawing.Color.Black;
            this.buttonCustom6.TextImageRelation = System.Windows.Forms.TextImageRelation.TextBeforeImage;
            this.buttonCustom6.UseVisualStyleBackColor = false;
            // 
            // buttonCustom7
            // 
            this.buttonCustom7.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.buttonCustom7.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.buttonCustom7.BackgroundColor = System.Drawing.SystemColors.ActiveCaption;
            this.buttonCustom7.BorderColor = System.Drawing.Color.PaleVioletRed;
            this.buttonCustom7.BorderRadius = 3;
            this.buttonCustom7.BorderSize = 0;
            this.buttonCustom7.Cursor = System.Windows.Forms.Cursors.Hand;
            this.buttonCustom7.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonCustom7.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.buttonCustom7.ForeColor = System.Drawing.Color.Black;
            this.buttonCustom7.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.buttonCustom7.Location = new System.Drawing.Point(4, 13);
            this.buttonCustom7.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.buttonCustom7.Name = "buttonCustom7";
            this.buttonCustom7.Size = new System.Drawing.Size(74, 35);
            this.buttonCustom7.TabIndex = 30;
            this.buttonCustom7.Text = "1";
            this.buttonCustom7.TextColor = System.Drawing.Color.Black;
            this.buttonCustom7.TextImageRelation = System.Windows.Forms.TextImageRelation.TextBeforeImage;
            this.buttonCustom7.UseVisualStyleBackColor = false;
            // 
            // buttonCustom8
            // 
            this.buttonCustom8.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.buttonCustom8.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.buttonCustom8.BackgroundColor = System.Drawing.SystemColors.ActiveCaption;
            this.buttonCustom8.BorderColor = System.Drawing.Color.PaleVioletRed;
            this.buttonCustom8.BorderRadius = 3;
            this.buttonCustom8.BorderSize = 0;
            this.buttonCustom8.Cursor = System.Windows.Forms.Cursors.Hand;
            this.buttonCustom8.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonCustom8.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.buttonCustom8.ForeColor = System.Drawing.Color.Black;
            this.buttonCustom8.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.buttonCustom8.Location = new System.Drawing.Point(83, 13);
            this.buttonCustom8.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.buttonCustom8.Name = "buttonCustom8";
            this.buttonCustom8.Size = new System.Drawing.Size(74, 35);
            this.buttonCustom8.TabIndex = 29;
            this.buttonCustom8.Text = "2";
            this.buttonCustom8.TextColor = System.Drawing.Color.Black;
            this.buttonCustom8.TextImageRelation = System.Windows.Forms.TextImageRelation.TextBeforeImage;
            this.buttonCustom8.UseVisualStyleBackColor = false;
            // 
            // Employee
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Control;
            this.ClientSize = new System.Drawing.Size(1163, 595);
            this.Controls.Add(this.tabControl1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.Name = "Employee";
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
        private LW_PhanMemBaoGia.MyControls.ButtonCustom buttonAddUser;
        private LW_PhanMemBaoGia.MyControls.ButtonCustom buttonChangeUser;
        private LW_PhanMemBaoGia.MyControls.ButtonCustom buttonChangeGroup;
        private LW_PhanMemBaoGia.MyControls.ButtonCustom buttonAddGroup;
        private LW_PhanMemBaoGia.MyControls.ButtonCustom buttonCustom1;
        private LW_PhanMemBaoGia.MyControls.ButtonCustom buttonCustom2;
        private LW_PhanMemBaoGia.MyControls.ButtonCustom buttonCustom3;
        private LW_PhanMemBaoGia.MyControls.ButtonCustom buttonCustom4;
        private LW_PhanMemBaoGia.MyControls.ButtonCustom buttonCustom5;
        private LW_PhanMemBaoGia.MyControls.ButtonCustom buttonCustom6;
        private LW_PhanMemBaoGia.MyControls.ButtonCustom buttonCustom7;
        private LW_PhanMemBaoGia.MyControls.ButtonCustom buttonCustom8;
    }
}