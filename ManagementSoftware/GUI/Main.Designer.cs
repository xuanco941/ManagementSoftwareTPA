﻿using System.Windows.Forms;

namespace ManagementSoftware.GUI
{
    partial class Main
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Main));
            this.panelMenu = new System.Windows.Forms.Panel();
            this.panelItemMenu = new System.Windows.Forms.Panel();
            this.buttonDangXuat = new System.Windows.Forms.Button();
            this.buttonHelp = new System.Windows.Forms.Button();
            this.buttonSetting = new System.Windows.Forms.Button();
            this.buttonActivity = new System.Windows.Forms.Button();
            this.buttonEmployee = new System.Windows.Forms.Button();
            this.buttonResult = new System.Windows.Forms.Button();
            this.buttonQuanLyKho = new System.Windows.Forms.Button();
            this.buttonWorkingList = new System.Windows.Forms.Button();
            this.buttonQuanLyDonHang = new System.Windows.Forms.Button();
            this.buttonDashboard = new System.Windows.Forms.Button();
            this.panel3 = new System.Windows.Forms.Panel();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.labelHeader = new System.Windows.Forms.Label();
            this.panelContainer = new System.Windows.Forms.Panel();
            this.panelContent = new System.Windows.Forms.Panel();
            this.panelHeader = new System.Windows.Forms.Panel();
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.panelAleart = new System.Windows.Forms.Panel();
            this.panel2 = new System.Windows.Forms.Panel();
            this.panelMenu.SuspendLayout();
            this.panelItemMenu.SuspendLayout();
            this.panel3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.panelContainer.SuspendLayout();
            this.panelHeader.SuspendLayout();
            this.tableLayoutPanel1.SuspendLayout();
            this.panel2.SuspendLayout();
            this.SuspendLayout();
            // 
            // panelMenu
            // 
            this.panelMenu.Controls.Add(this.panelItemMenu);
            this.panelMenu.Controls.Add(this.panel3);
            this.panelMenu.Dock = System.Windows.Forms.DockStyle.Left;
            this.panelMenu.Location = new System.Drawing.Point(0, 0);
            this.panelMenu.Name = "panelMenu";
            this.panelMenu.Size = new System.Drawing.Size(211, 910);
            this.panelMenu.TabIndex = 0;
            // 
            // panelItemMenu
            // 
            this.panelItemMenu.AutoScroll = true;
            this.panelItemMenu.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panelItemMenu.Controls.Add(this.buttonDangXuat);
            this.panelItemMenu.Controls.Add(this.buttonHelp);
            this.panelItemMenu.Controls.Add(this.buttonSetting);
            this.panelItemMenu.Controls.Add(this.buttonActivity);
            this.panelItemMenu.Controls.Add(this.buttonEmployee);
            this.panelItemMenu.Controls.Add(this.buttonResult);
            this.panelItemMenu.Controls.Add(this.buttonQuanLyKho);
            this.panelItemMenu.Controls.Add(this.buttonWorkingList);
            this.panelItemMenu.Controls.Add(this.buttonQuanLyDonHang);
            this.panelItemMenu.Controls.Add(this.buttonDashboard);
            this.panelItemMenu.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panelItemMenu.Location = new System.Drawing.Point(0, 76);
            this.panelItemMenu.Name = "panelItemMenu";
            this.panelItemMenu.Size = new System.Drawing.Size(211, 834);
            this.panelItemMenu.TabIndex = 1;
            // 
            // buttonDangXuat
            // 
            this.buttonDangXuat.Cursor = System.Windows.Forms.Cursors.Hand;
            this.buttonDangXuat.Dock = System.Windows.Forms.DockStyle.Top;
            this.buttonDangXuat.FlatAppearance.BorderSize = 0;
            this.buttonDangXuat.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonDangXuat.Font = new System.Drawing.Font("Segoe UI", 12.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.buttonDangXuat.ForeColor = System.Drawing.Color.White;
            this.buttonDangXuat.Image = global::ManagementSoftware.Properties.Resources.red_x_10333;
            this.buttonDangXuat.Location = new System.Drawing.Point(0, 711);
            this.buttonDangXuat.Name = "buttonDangXuat";
            this.buttonDangXuat.Size = new System.Drawing.Size(209, 79);
            this.buttonDangXuat.TabIndex = 12;
            this.buttonDangXuat.Text = "Đăng xuất";
            this.buttonDangXuat.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.buttonDangXuat.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.buttonDangXuat.UseVisualStyleBackColor = true;
            this.buttonDangXuat.Click += new System.EventHandler(this.buttonDangXuat_Click);
            // 
            // buttonHelp
            // 
            this.buttonHelp.Cursor = System.Windows.Forms.Cursors.Hand;
            this.buttonHelp.Dock = System.Windows.Forms.DockStyle.Top;
            this.buttonHelp.FlatAppearance.BorderSize = 0;
            this.buttonHelp.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonHelp.Font = new System.Drawing.Font("Segoe UI", 12.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.buttonHelp.ForeColor = System.Drawing.Color.White;
            this.buttonHelp.Image = ((System.Drawing.Image)(resources.GetObject("buttonHelp.Image")));
            this.buttonHelp.Location = new System.Drawing.Point(0, 632);
            this.buttonHelp.Name = "buttonHelp";
            this.buttonHelp.Size = new System.Drawing.Size(209, 79);
            this.buttonHelp.TabIndex = 13;
            this.buttonHelp.Text = "Trợ giúp";
            this.buttonHelp.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.buttonHelp.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.buttonHelp.UseVisualStyleBackColor = true;
            this.buttonHelp.Click += new System.EventHandler(this.buttonHelp_Click);
            // 
            // buttonSetting
            // 
            this.buttonSetting.Cursor = System.Windows.Forms.Cursors.Hand;
            this.buttonSetting.Dock = System.Windows.Forms.DockStyle.Top;
            this.buttonSetting.FlatAppearance.BorderSize = 0;
            this.buttonSetting.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonSetting.Font = new System.Drawing.Font("Segoe UI", 12.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.buttonSetting.ForeColor = System.Drawing.Color.White;
            this.buttonSetting.Image = global::ManagementSoftware.Properties.Resources.setting_24;
            this.buttonSetting.Location = new System.Drawing.Point(0, 553);
            this.buttonSetting.Name = "buttonSetting";
            this.buttonSetting.Size = new System.Drawing.Size(209, 79);
            this.buttonSetting.TabIndex = 11;
            this.buttonSetting.Text = "Cài đặt";
            this.buttonSetting.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.buttonSetting.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.buttonSetting.UseVisualStyleBackColor = true;
            this.buttonSetting.Click += new System.EventHandler(this.buttonSetting_Click);
            // 
            // buttonActivity
            // 
            this.buttonActivity.Cursor = System.Windows.Forms.Cursors.Hand;
            this.buttonActivity.Dock = System.Windows.Forms.DockStyle.Top;
            this.buttonActivity.FlatAppearance.BorderSize = 0;
            this.buttonActivity.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonActivity.Font = new System.Drawing.Font("Segoe UI", 12.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.buttonActivity.ForeColor = System.Drawing.Color.White;
            this.buttonActivity.Image = global::ManagementSoftware.Properties.Resources.button3_Image;
            this.buttonActivity.Location = new System.Drawing.Point(0, 474);
            this.buttonActivity.Name = "buttonActivity";
            this.buttonActivity.Size = new System.Drawing.Size(209, 79);
            this.buttonActivity.TabIndex = 10;
            this.buttonActivity.Text = "Hoạt động";
            this.buttonActivity.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.buttonActivity.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.buttonActivity.UseVisualStyleBackColor = true;
            this.buttonActivity.Click += new System.EventHandler(this.buttonActivity_Click);
            // 
            // buttonEmployee
            // 
            this.buttonEmployee.Cursor = System.Windows.Forms.Cursors.Hand;
            this.buttonEmployee.Dock = System.Windows.Forms.DockStyle.Top;
            this.buttonEmployee.FlatAppearance.BorderSize = 0;
            this.buttonEmployee.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonEmployee.Font = new System.Drawing.Font("Segoe UI", 12.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.buttonEmployee.ForeColor = System.Drawing.Color.White;
            this.buttonEmployee.Image = global::ManagementSoftware.Properties.Resources.button2_Image;
            this.buttonEmployee.Location = new System.Drawing.Point(0, 395);
            this.buttonEmployee.Name = "buttonEmployee";
            this.buttonEmployee.Size = new System.Drawing.Size(209, 79);
            this.buttonEmployee.TabIndex = 9;
            this.buttonEmployee.Text = "Quản lý nhân sự";
            this.buttonEmployee.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.buttonEmployee.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.buttonEmployee.UseVisualStyleBackColor = true;
            this.buttonEmployee.Click += new System.EventHandler(this.buttonEmployee_Click);
            // 
            // buttonResult
            // 
            this.buttonResult.Cursor = System.Windows.Forms.Cursors.Hand;
            this.buttonResult.Dock = System.Windows.Forms.DockStyle.Top;
            this.buttonResult.FlatAppearance.BorderSize = 0;
            this.buttonResult.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonResult.Font = new System.Drawing.Font("Segoe UI", 12.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.buttonResult.ForeColor = System.Drawing.Color.White;
            this.buttonResult.Image = global::ManagementSoftware.Properties.Resources.book24;
            this.buttonResult.Location = new System.Drawing.Point(0, 316);
            this.buttonResult.Name = "buttonResult";
            this.buttonResult.Size = new System.Drawing.Size(209, 79);
            this.buttonResult.TabIndex = 8;
            this.buttonResult.Text = "Lịch sử nạp khí";
            this.buttonResult.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.buttonResult.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.buttonResult.UseVisualStyleBackColor = true;
            this.buttonResult.Click += new System.EventHandler(this.buttonResult_Click);
            // 
            // buttonQuanLyKho
            // 
            this.buttonQuanLyKho.Cursor = System.Windows.Forms.Cursors.Hand;
            this.buttonQuanLyKho.Dock = System.Windows.Forms.DockStyle.Top;
            this.buttonQuanLyKho.FlatAppearance.BorderSize = 0;
            this.buttonQuanLyKho.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonQuanLyKho.Font = new System.Drawing.Font("Segoe UI", 12.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.buttonQuanLyKho.ForeColor = System.Drawing.Color.White;
            this.buttonQuanLyKho.Image = ((System.Drawing.Image)(resources.GetObject("buttonQuanLyKho.Image")));
            this.buttonQuanLyKho.Location = new System.Drawing.Point(0, 237);
            this.buttonQuanLyKho.Name = "buttonQuanLyKho";
            this.buttonQuanLyKho.Size = new System.Drawing.Size(209, 79);
            this.buttonQuanLyKho.TabIndex = 15;
            this.buttonQuanLyKho.Text = "Quản lý kho";
            this.buttonQuanLyKho.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.buttonQuanLyKho.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.buttonQuanLyKho.UseVisualStyleBackColor = true;
            this.buttonQuanLyKho.Click += new System.EventHandler(this.buttonQuanLyKho_Click);
            // 
            // buttonWorkingList
            // 
            this.buttonWorkingList.Cursor = System.Windows.Forms.Cursors.Hand;
            this.buttonWorkingList.Dock = System.Windows.Forms.DockStyle.Top;
            this.buttonWorkingList.FlatAppearance.BorderSize = 0;
            this.buttonWorkingList.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonWorkingList.Font = new System.Drawing.Font("Segoe UI", 12.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.buttonWorkingList.ForeColor = System.Drawing.Color.White;
            this.buttonWorkingList.Image = ((System.Drawing.Image)(resources.GetObject("buttonWorkingList.Image")));
            this.buttonWorkingList.Location = new System.Drawing.Point(0, 158);
            this.buttonWorkingList.Name = "buttonWorkingList";
            this.buttonWorkingList.Size = new System.Drawing.Size(209, 79);
            this.buttonWorkingList.TabIndex = 16;
            this.buttonWorkingList.Text = "Công việc";
            this.buttonWorkingList.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.buttonWorkingList.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.buttonWorkingList.UseVisualStyleBackColor = true;
            this.buttonWorkingList.Click += new System.EventHandler(this.buttonWorkingList_Click);
            // 
            // buttonQuanLyDonHang
            // 
            this.buttonQuanLyDonHang.Cursor = System.Windows.Forms.Cursors.Hand;
            this.buttonQuanLyDonHang.Dock = System.Windows.Forms.DockStyle.Top;
            this.buttonQuanLyDonHang.FlatAppearance.BorderSize = 0;
            this.buttonQuanLyDonHang.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonQuanLyDonHang.Font = new System.Drawing.Font("Segoe UI", 12.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.buttonQuanLyDonHang.ForeColor = System.Drawing.Color.White;
            this.buttonQuanLyDonHang.Image = ((System.Drawing.Image)(resources.GetObject("buttonQuanLyDonHang.Image")));
            this.buttonQuanLyDonHang.Location = new System.Drawing.Point(0, 79);
            this.buttonQuanLyDonHang.Name = "buttonQuanLyDonHang";
            this.buttonQuanLyDonHang.Size = new System.Drawing.Size(209, 79);
            this.buttonQuanLyDonHang.TabIndex = 14;
            this.buttonQuanLyDonHang.Text = "Quản lý đơn hàng";
            this.buttonQuanLyDonHang.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.buttonQuanLyDonHang.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.buttonQuanLyDonHang.UseVisualStyleBackColor = true;
            this.buttonQuanLyDonHang.Click += new System.EventHandler(this.buttonQuanLyDonHang_Click);
            // 
            // buttonDashboard
            // 
            this.buttonDashboard.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(41)))), ((int)(((byte)(44)))), ((int)(((byte)(51)))));
            this.buttonDashboard.Cursor = System.Windows.Forms.Cursors.Hand;
            this.buttonDashboard.Dock = System.Windows.Forms.DockStyle.Top;
            this.buttonDashboard.FlatAppearance.BorderSize = 0;
            this.buttonDashboard.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonDashboard.Font = new System.Drawing.Font("Segoe UI", 12.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.buttonDashboard.ForeColor = System.Drawing.Color.White;
            this.buttonDashboard.Image = ((System.Drawing.Image)(resources.GetObject("buttonDashboard.Image")));
            this.buttonDashboard.Location = new System.Drawing.Point(0, 0);
            this.buttonDashboard.Name = "buttonDashboard";
            this.buttonDashboard.Size = new System.Drawing.Size(209, 79);
            this.buttonDashboard.TabIndex = 7;
            this.buttonDashboard.Text = "Bảng điều khiển";
            this.buttonDashboard.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.buttonDashboard.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.buttonDashboard.UseVisualStyleBackColor = false;
            this.buttonDashboard.Click += new System.EventHandler(this.buttonDashboard_Click);
            // 
            // panel3
            // 
            this.panel3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(192)))), ((int)(((byte)(0)))));
            this.panel3.Controls.Add(this.pictureBox1);
            this.panel3.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel3.Location = new System.Drawing.Point(0, 0);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(211, 76);
            this.panel3.TabIndex = 0;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(0, 0);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(211, 76);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.CenterImage;
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            // 
            // labelHeader
            // 
            this.labelHeader.AutoSize = true;
            this.labelHeader.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.labelHeader.ForeColor = System.Drawing.Color.LightGray;
            this.labelHeader.Location = new System.Drawing.Point(13, 24);
            this.labelHeader.Name = "labelHeader";
            this.labelHeader.Size = new System.Drawing.Size(148, 25);
            this.labelHeader.TabIndex = 2;
            this.labelHeader.Text = "Bảng điều khiển";
            // 
            // panelContainer
            // 
            this.panelContainer.Controls.Add(this.panelContent);
            this.panelContainer.Controls.Add(this.panelHeader);
            this.panelContainer.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panelContainer.Location = new System.Drawing.Point(211, 0);
            this.panelContainer.Name = "panelContainer";
            this.panelContainer.Size = new System.Drawing.Size(1227, 910);
            this.panelContainer.TabIndex = 3;
            // 
            // panelContent
            // 
            this.panelContent.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panelContent.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panelContent.Location = new System.Drawing.Point(0, 76);
            this.panelContent.Name = "panelContent";
            this.panelContent.Size = new System.Drawing.Size(1227, 834);
            this.panelContent.TabIndex = 5;
            // 
            // panelHeader
            // 
            this.panelHeader.Controls.Add(this.tableLayoutPanel1);
            this.panelHeader.Dock = System.Windows.Forms.DockStyle.Top;
            this.panelHeader.Location = new System.Drawing.Point(0, 0);
            this.panelHeader.Name = "panelHeader";
            this.panelHeader.Size = new System.Drawing.Size(1227, 76);
            this.panelHeader.TabIndex = 4;
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.ColumnCount = 2;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 193F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel1.Controls.Add(this.panelAleart, 1, 0);
            this.tableLayoutPanel1.Controls.Add(this.panel2, 0, 0);
            this.tableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel1.Location = new System.Drawing.Point(0, 0);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 1;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(1227, 76);
            this.tableLayoutPanel1.TabIndex = 0;
            // 
            // panelAleart
            // 
            this.panelAleart.AutoScroll = true;
            this.panelAleart.Dock = System.Windows.Forms.DockStyle.Right;
            this.panelAleart.Location = new System.Drawing.Point(804, 3);
            this.panelAleart.MaximumSize = new System.Drawing.Size(1260, 70);
            this.panelAleart.MinimumSize = new System.Drawing.Size(420, 70);
            this.panelAleart.Name = "panelAleart";
            this.panelAleart.Size = new System.Drawing.Size(420, 70);
            this.panelAleart.TabIndex = 5;
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.labelHeader);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel2.Location = new System.Drawing.Point(3, 3);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(187, 70);
            this.panel2.TabIndex = 0;
            // 
            // Main
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(41)))), ((int)(((byte)(44)))), ((int)(((byte)(51)))));
            this.ClientSize = new System.Drawing.Size(1438, 910);
            this.Controls.Add(this.panelContainer);
            this.Controls.Add(this.panelMenu);
            this.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(62)))), ((int)(((byte)(120)))), ((int)(((byte)(138)))));
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Main";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Máy nạp khí TPA";
            this.panelMenu.ResumeLayout(false);
            this.panelItemMenu.ResumeLayout(false);
            this.panel3.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.panelContainer.ResumeLayout(false);
            this.panelHeader.ResumeLayout(false);
            this.tableLayoutPanel1.ResumeLayout(false);
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panelMenu;
        private System.Windows.Forms.Label labelHeader;
        private System.Windows.Forms.Panel panelContainer;
        private System.Windows.Forms.Panel panelContent;
        private System.Windows.Forms.Panel panelHeader;
        private TableLayoutPanel tableLayoutPanel1;
        private Panel panelAleart;
        private Panel panel2;
        private Panel panel3;
        private PictureBox pictureBox1;
        private Panel panelItemMenu;
        private Button buttonDangXuat;
        private Button buttonSetting;
        private Button buttonActivity;
        private Button buttonEmployee;
        private Button buttonResult;
        private Button buttonDashboard;
        private Button buttonHelp;
        private Button buttonQuanLyKho;
        private Button buttonQuanLyDonHang;
        private Button buttonWorkingList;
    }
}

