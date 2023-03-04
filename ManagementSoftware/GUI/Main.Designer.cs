using System.Windows.Forms;

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
            panelMenu = new Panel();
            panelItemMenu = new Panel();
            buttonDangXuat = new Button();
            buttonHelp = new Button();
            buttonSetting = new Button();
            buttonActivity = new Button();
            buttonEmployee = new Button();
            buttonResult = new Button();
            buttonQuanLyKho = new Button();
            buttonNhapKho = new Button();
            buttonWorkingList = new Button();
            buttonQuanLyDonHang = new Button();
            buttonDashboard = new Button();
            panel3 = new Panel();
            pictureBox1 = new PictureBox();
            labelHeader = new Label();
            panelContainer = new Panel();
            panelContent = new Panel();
            panelHeader = new Panel();
            tableLayoutPanel1 = new TableLayoutPanel();
            panelAleart = new Panel();
            panel2 = new Panel();
            panelMenu.SuspendLayout();
            panelItemMenu.SuspendLayout();
            panel3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            panelContainer.SuspendLayout();
            panelHeader.SuspendLayout();
            tableLayoutPanel1.SuspendLayout();
            panel2.SuspendLayout();
            SuspendLayout();
            // 
            // panelMenu
            // 
            panelMenu.Controls.Add(panelItemMenu);
            panelMenu.Controls.Add(panel3);
            panelMenu.Dock = DockStyle.Left;
            panelMenu.Location = new Point(0, 0);
            panelMenu.Name = "panelMenu";
            panelMenu.Size = new Size(211, 910);
            panelMenu.TabIndex = 0;
            // 
            // panelItemMenu
            // 
            panelItemMenu.AutoScroll = true;
            panelItemMenu.BorderStyle = BorderStyle.FixedSingle;
            panelItemMenu.Controls.Add(buttonDangXuat);
            panelItemMenu.Controls.Add(buttonHelp);
            panelItemMenu.Controls.Add(buttonSetting);
            panelItemMenu.Controls.Add(buttonActivity);
            panelItemMenu.Controls.Add(buttonEmployee);
            panelItemMenu.Controls.Add(buttonResult);
            panelItemMenu.Controls.Add(buttonQuanLyKho);
            panelItemMenu.Controls.Add(buttonNhapKho);
            panelItemMenu.Controls.Add(buttonWorkingList);
            panelItemMenu.Controls.Add(buttonQuanLyDonHang);
            panelItemMenu.Controls.Add(buttonDashboard);
            panelItemMenu.Dock = DockStyle.Fill;
            panelItemMenu.Location = new Point(0, 76);
            panelItemMenu.Name = "panelItemMenu";
            panelItemMenu.Size = new Size(211, 834);
            panelItemMenu.TabIndex = 1;
            // 
            // buttonDangXuat
            // 
            buttonDangXuat.Cursor = Cursors.Hand;
            buttonDangXuat.Dock = DockStyle.Top;
            buttonDangXuat.FlatAppearance.BorderSize = 0;
            buttonDangXuat.FlatStyle = FlatStyle.Flat;
            buttonDangXuat.Font = new Font("Segoe UI", 12.75F, FontStyle.Regular, GraphicsUnit.Point);
            buttonDangXuat.ForeColor = Color.White;
            buttonDangXuat.Image = Properties.Resources.red_x_10333;
            buttonDangXuat.Location = new Point(0, 790);
            buttonDangXuat.Name = "buttonDangXuat";
            buttonDangXuat.Size = new Size(192, 79);
            buttonDangXuat.TabIndex = 12;
            buttonDangXuat.Text = "Đăng xuất";
            buttonDangXuat.TextAlign = ContentAlignment.BottomCenter;
            buttonDangXuat.TextImageRelation = TextImageRelation.ImageAboveText;
            buttonDangXuat.UseVisualStyleBackColor = true;
            buttonDangXuat.Click += buttonDangXuat_Click;
            // 
            // buttonHelp
            // 
            buttonHelp.Cursor = Cursors.Hand;
            buttonHelp.Dock = DockStyle.Top;
            buttonHelp.FlatAppearance.BorderSize = 0;
            buttonHelp.FlatStyle = FlatStyle.Flat;
            buttonHelp.Font = new Font("Segoe UI", 12.75F, FontStyle.Regular, GraphicsUnit.Point);
            buttonHelp.ForeColor = Color.White;
            buttonHelp.Image = (Image)resources.GetObject("buttonHelp.Image");
            buttonHelp.Location = new Point(0, 711);
            buttonHelp.Name = "buttonHelp";
            buttonHelp.Size = new Size(192, 79);
            buttonHelp.TabIndex = 13;
            buttonHelp.Text = "Trợ giúp";
            buttonHelp.TextAlign = ContentAlignment.BottomCenter;
            buttonHelp.TextImageRelation = TextImageRelation.ImageAboveText;
            buttonHelp.UseVisualStyleBackColor = true;
            buttonHelp.Click += buttonHelp_Click;
            // 
            // buttonSetting
            // 
            buttonSetting.Cursor = Cursors.Hand;
            buttonSetting.Dock = DockStyle.Top;
            buttonSetting.FlatAppearance.BorderSize = 0;
            buttonSetting.FlatStyle = FlatStyle.Flat;
            buttonSetting.Font = new Font("Segoe UI", 12.75F, FontStyle.Regular, GraphicsUnit.Point);
            buttonSetting.ForeColor = Color.White;
            buttonSetting.Image = Properties.Resources.setting_24;
            buttonSetting.Location = new Point(0, 632);
            buttonSetting.Name = "buttonSetting";
            buttonSetting.Size = new Size(192, 79);
            buttonSetting.TabIndex = 11;
            buttonSetting.Text = "Cài đặt";
            buttonSetting.TextAlign = ContentAlignment.BottomCenter;
            buttonSetting.TextImageRelation = TextImageRelation.ImageAboveText;
            buttonSetting.UseVisualStyleBackColor = true;
            buttonSetting.Click += buttonSetting_Click;
            // 
            // buttonActivity
            // 
            buttonActivity.Cursor = Cursors.Hand;
            buttonActivity.Dock = DockStyle.Top;
            buttonActivity.FlatAppearance.BorderSize = 0;
            buttonActivity.FlatStyle = FlatStyle.Flat;
            buttonActivity.Font = new Font("Segoe UI", 12.75F, FontStyle.Regular, GraphicsUnit.Point);
            buttonActivity.ForeColor = Color.White;
            buttonActivity.Image = Properties.Resources.button3_Image;
            buttonActivity.Location = new Point(0, 553);
            buttonActivity.Name = "buttonActivity";
            buttonActivity.Size = new Size(192, 79);
            buttonActivity.TabIndex = 10;
            buttonActivity.Text = "Hoạt động";
            buttonActivity.TextAlign = ContentAlignment.BottomCenter;
            buttonActivity.TextImageRelation = TextImageRelation.ImageAboveText;
            buttonActivity.UseVisualStyleBackColor = true;
            buttonActivity.Click += buttonActivity_Click;
            // 
            // buttonEmployee
            // 
            buttonEmployee.Cursor = Cursors.Hand;
            buttonEmployee.Dock = DockStyle.Top;
            buttonEmployee.FlatAppearance.BorderSize = 0;
            buttonEmployee.FlatStyle = FlatStyle.Flat;
            buttonEmployee.Font = new Font("Segoe UI", 12.75F, FontStyle.Regular, GraphicsUnit.Point);
            buttonEmployee.ForeColor = Color.White;
            buttonEmployee.Image = Properties.Resources.button2_Image;
            buttonEmployee.Location = new Point(0, 474);
            buttonEmployee.Name = "buttonEmployee";
            buttonEmployee.Size = new Size(192, 79);
            buttonEmployee.TabIndex = 9;
            buttonEmployee.Text = "Quản lý nhân sự";
            buttonEmployee.TextAlign = ContentAlignment.BottomCenter;
            buttonEmployee.TextImageRelation = TextImageRelation.ImageAboveText;
            buttonEmployee.UseVisualStyleBackColor = true;
            buttonEmployee.Click += buttonEmployee_Click;
            // 
            // buttonResult
            // 
            buttonResult.Cursor = Cursors.Hand;
            buttonResult.Dock = DockStyle.Top;
            buttonResult.FlatAppearance.BorderSize = 0;
            buttonResult.FlatStyle = FlatStyle.Flat;
            buttonResult.Font = new Font("Segoe UI", 12.75F, FontStyle.Regular, GraphicsUnit.Point);
            buttonResult.ForeColor = Color.White;
            buttonResult.Image = Properties.Resources.book24;
            buttonResult.Location = new Point(0, 395);
            buttonResult.Name = "buttonResult";
            buttonResult.Size = new Size(192, 79);
            buttonResult.TabIndex = 8;
            buttonResult.Text = "Lịch sử nạp khí";
            buttonResult.TextAlign = ContentAlignment.BottomCenter;
            buttonResult.TextImageRelation = TextImageRelation.ImageAboveText;
            buttonResult.UseVisualStyleBackColor = true;
            buttonResult.Click += buttonResult_Click;
            // 
            // buttonQuanLyKho
            // 
            buttonQuanLyKho.Cursor = Cursors.Hand;
            buttonQuanLyKho.Dock = DockStyle.Top;
            buttonQuanLyKho.FlatAppearance.BorderSize = 0;
            buttonQuanLyKho.FlatStyle = FlatStyle.Flat;
            buttonQuanLyKho.Font = new Font("Segoe UI", 12.75F, FontStyle.Regular, GraphicsUnit.Point);
            buttonQuanLyKho.ForeColor = Color.White;
            buttonQuanLyKho.Image = (Image)resources.GetObject("buttonQuanLyKho.Image");
            buttonQuanLyKho.Location = new Point(0, 316);
            buttonQuanLyKho.Name = "buttonQuanLyKho";
            buttonQuanLyKho.Size = new Size(192, 79);
            buttonQuanLyKho.TabIndex = 15;
            buttonQuanLyKho.Text = "Quản lý kho";
            buttonQuanLyKho.TextAlign = ContentAlignment.BottomCenter;
            buttonQuanLyKho.TextImageRelation = TextImageRelation.ImageAboveText;
            buttonQuanLyKho.UseVisualStyleBackColor = true;
            buttonQuanLyKho.Click += buttonQuanLyKho_Click;
            // 
            // buttonNhapKho
            // 
            buttonNhapKho.Cursor = Cursors.Hand;
            buttonNhapKho.Dock = DockStyle.Top;
            buttonNhapKho.FlatAppearance.BorderSize = 0;
            buttonNhapKho.FlatStyle = FlatStyle.Flat;
            buttonNhapKho.Font = new Font("Segoe UI", 12.75F, FontStyle.Regular, GraphicsUnit.Point);
            buttonNhapKho.ForeColor = Color.White;
            buttonNhapKho.Image = (Image)resources.GetObject("buttonNhapKho.Image");
            buttonNhapKho.Location = new Point(0, 237);
            buttonNhapKho.Name = "buttonNhapKho";
            buttonNhapKho.Size = new Size(192, 79);
            buttonNhapKho.TabIndex = 17;
            buttonNhapKho.Text = "Nhập kho";
            buttonNhapKho.TextAlign = ContentAlignment.BottomCenter;
            buttonNhapKho.TextImageRelation = TextImageRelation.ImageAboveText;
            buttonNhapKho.UseVisualStyleBackColor = true;
            buttonNhapKho.Click += buttonNhapKho_Click;
            // 
            // buttonWorkingList
            // 
            buttonWorkingList.Cursor = Cursors.Hand;
            buttonWorkingList.Dock = DockStyle.Top;
            buttonWorkingList.FlatAppearance.BorderSize = 0;
            buttonWorkingList.FlatStyle = FlatStyle.Flat;
            buttonWorkingList.Font = new Font("Segoe UI", 12.75F, FontStyle.Regular, GraphicsUnit.Point);
            buttonWorkingList.ForeColor = Color.White;
            buttonWorkingList.Image = (Image)resources.GetObject("buttonWorkingList.Image");
            buttonWorkingList.Location = new Point(0, 158);
            buttonWorkingList.Name = "buttonWorkingList";
            buttonWorkingList.Size = new Size(192, 79);
            buttonWorkingList.TabIndex = 16;
            buttonWorkingList.Text = "Công việc";
            buttonWorkingList.TextAlign = ContentAlignment.BottomCenter;
            buttonWorkingList.TextImageRelation = TextImageRelation.ImageAboveText;
            buttonWorkingList.UseVisualStyleBackColor = true;
            buttonWorkingList.Click += buttonWorkingList_Click;
            // 
            // buttonQuanLyDonHang
            // 
            buttonQuanLyDonHang.Cursor = Cursors.Hand;
            buttonQuanLyDonHang.Dock = DockStyle.Top;
            buttonQuanLyDonHang.FlatAppearance.BorderSize = 0;
            buttonQuanLyDonHang.FlatStyle = FlatStyle.Flat;
            buttonQuanLyDonHang.Font = new Font("Segoe UI", 12.75F, FontStyle.Regular, GraphicsUnit.Point);
            buttonQuanLyDonHang.ForeColor = Color.White;
            buttonQuanLyDonHang.Image = (Image)resources.GetObject("buttonQuanLyDonHang.Image");
            buttonQuanLyDonHang.Location = new Point(0, 79);
            buttonQuanLyDonHang.Name = "buttonQuanLyDonHang";
            buttonQuanLyDonHang.Size = new Size(192, 79);
            buttonQuanLyDonHang.TabIndex = 14;
            buttonQuanLyDonHang.Text = "Quản lý đơn hàng";
            buttonQuanLyDonHang.TextAlign = ContentAlignment.BottomCenter;
            buttonQuanLyDonHang.TextImageRelation = TextImageRelation.ImageAboveText;
            buttonQuanLyDonHang.UseVisualStyleBackColor = true;
            buttonQuanLyDonHang.Click += buttonQuanLyDonHang_Click;
            // 
            // buttonDashboard
            // 
            buttonDashboard.BackColor = Color.FromArgb(41, 44, 51);
            buttonDashboard.Cursor = Cursors.Hand;
            buttonDashboard.Dock = DockStyle.Top;
            buttonDashboard.FlatAppearance.BorderSize = 0;
            buttonDashboard.FlatStyle = FlatStyle.Flat;
            buttonDashboard.Font = new Font("Segoe UI", 12.75F, FontStyle.Regular, GraphicsUnit.Point);
            buttonDashboard.ForeColor = Color.White;
            buttonDashboard.Image = (Image)resources.GetObject("buttonDashboard.Image");
            buttonDashboard.Location = new Point(0, 0);
            buttonDashboard.Name = "buttonDashboard";
            buttonDashboard.Size = new Size(192, 79);
            buttonDashboard.TabIndex = 7;
            buttonDashboard.Text = "Bảng điều khiển";
            buttonDashboard.TextAlign = ContentAlignment.BottomCenter;
            buttonDashboard.TextImageRelation = TextImageRelation.ImageAboveText;
            buttonDashboard.UseVisualStyleBackColor = false;
            buttonDashboard.Click += buttonDashboard_Click;
            // 
            // panel3
            // 
            panel3.BackColor = Color.FromArgb(192, 192, 0);
            panel3.Controls.Add(pictureBox1);
            panel3.Dock = DockStyle.Top;
            panel3.Location = new Point(0, 0);
            panel3.Name = "panel3";
            panel3.Size = new Size(211, 76);
            panel3.TabIndex = 0;
            // 
            // pictureBox1
            // 
            pictureBox1.Dock = DockStyle.Fill;
            pictureBox1.Image = (Image)resources.GetObject("pictureBox1.Image");
            pictureBox1.Location = new Point(0, 0);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(211, 76);
            pictureBox1.SizeMode = PictureBoxSizeMode.CenterImage;
            pictureBox1.TabIndex = 0;
            pictureBox1.TabStop = false;
            // 
            // labelHeader
            // 
            labelHeader.Dock = DockStyle.Fill;
            labelHeader.Font = new Font("Segoe UI Semibold", 15.75F, FontStyle.Bold, GraphicsUnit.Point);
            labelHeader.ForeColor = SystemColors.GradientActiveCaption;
            labelHeader.Location = new Point(0, 0);
            labelHeader.Name = "labelHeader";
            labelHeader.Size = new Size(187, 70);
            labelHeader.TabIndex = 2;
            labelHeader.Text = "Bảng điều khiển";
            labelHeader.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // panelContainer
            // 
            panelContainer.Controls.Add(panelContent);
            panelContainer.Controls.Add(panelHeader);
            panelContainer.Dock = DockStyle.Fill;
            panelContainer.Location = new Point(211, 0);
            panelContainer.Name = "panelContainer";
            panelContainer.Size = new Size(1227, 910);
            panelContainer.TabIndex = 3;
            // 
            // panelContent
            // 
            panelContent.BorderStyle = BorderStyle.FixedSingle;
            panelContent.Dock = DockStyle.Fill;
            panelContent.ForeColor = SystemColors.ControlText;
            panelContent.Location = new Point(0, 76);
            panelContent.Name = "panelContent";
            panelContent.Size = new Size(1227, 834);
            panelContent.TabIndex = 5;
            // 
            // panelHeader
            // 
            panelHeader.Controls.Add(tableLayoutPanel1);
            panelHeader.Dock = DockStyle.Top;
            panelHeader.Location = new Point(0, 0);
            panelHeader.Name = "panelHeader";
            panelHeader.Size = new Size(1227, 76);
            panelHeader.TabIndex = 4;
            // 
            // tableLayoutPanel1
            // 
            tableLayoutPanel1.ColumnCount = 2;
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Absolute, 193F));
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 100F));
            tableLayoutPanel1.Controls.Add(panelAleart, 1, 0);
            tableLayoutPanel1.Controls.Add(panel2, 0, 0);
            tableLayoutPanel1.Dock = DockStyle.Fill;
            tableLayoutPanel1.Location = new Point(0, 0);
            tableLayoutPanel1.Name = "tableLayoutPanel1";
            tableLayoutPanel1.RowCount = 1;
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Percent, 100F));
            tableLayoutPanel1.Size = new Size(1227, 76);
            tableLayoutPanel1.TabIndex = 0;
            // 
            // panelAleart
            // 
            panelAleart.AutoScroll = true;
            panelAleart.Dock = DockStyle.Right;
            panelAleart.Location = new Point(804, 3);
            panelAleart.MaximumSize = new Size(1260, 70);
            panelAleart.MinimumSize = new Size(420, 70);
            panelAleart.Name = "panelAleart";
            panelAleart.Size = new Size(420, 70);
            panelAleart.TabIndex = 5;
            // 
            // panel2
            // 
            panel2.Controls.Add(labelHeader);
            panel2.Dock = DockStyle.Fill;
            panel2.Location = new Point(3, 3);
            panel2.Name = "panel2";
            panel2.Size = new Size(187, 70);
            panel2.TabIndex = 0;
            // 
            // Main
            // 
            AutoScaleMode = AutoScaleMode.None;
            BackColor = Color.FromArgb(41, 44, 51);
            ClientSize = new Size(1438, 910);
            Controls.Add(panelContainer);
            Controls.Add(panelMenu);
            Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            ForeColor = Color.FromArgb(62, 120, 138);
            Icon = (Icon)resources.GetObject("$this.Icon");
            Name = "Main";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Máy nạp khí TPA";
            Load += Main_Load;
            panelMenu.ResumeLayout(false);
            panelItemMenu.ResumeLayout(false);
            panel3.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            panelContainer.ResumeLayout(false);
            panelHeader.ResumeLayout(false);
            tableLayoutPanel1.ResumeLayout(false);
            panel2.ResumeLayout(false);
            ResumeLayout(false);
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
        private Button buttonNhapKho;
    }
}

