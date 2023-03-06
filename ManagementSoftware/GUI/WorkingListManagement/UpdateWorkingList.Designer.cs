namespace ManagementSoftware.GUI.WorkingListManagement
{
    partial class UpdateWorkingList
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
            components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(UpdateWorkingList));
            panel1 = new Panel();
            labelCT = new Label();
            panel2 = new Panel();
            groupBox9 = new GroupBox();
            TenSP = new TextBox();
            groupBox8 = new GroupBox();
            ApSuatNap = new TextBox();
            groupBox6 = new GroupBox();
            TheTichBinh = new TextBox();
            groupBox5 = new GroupBox();
            ChatLuongKhi = new TextBox();
            groupBox4 = new GroupBox();
            SLCanSX = new TextBox();
            groupBox3 = new GroupBox();
            SLDaSX = new TextBox();
            groupBox2 = new GroupBox();
            groupBox1 = new GroupBox();
            groupBox7 = new GroupBox();
            gridLayout1 = new Syncfusion.Windows.Forms.Tools.GridLayout(components);
            panel3 = new Panel();
            buttonUpdate = new LW_PhanMemBaoGia.MyControls.ButtonCustom();
            BeginAt = new DateTimePicker();
            EndAt = new DateTimePicker();
            comboBoxStatus = new ComboBox();
            panel1.SuspendLayout();
            panel2.SuspendLayout();
            groupBox9.SuspendLayout();
            groupBox8.SuspendLayout();
            groupBox6.SuspendLayout();
            groupBox5.SuspendLayout();
            groupBox4.SuspendLayout();
            groupBox3.SuspendLayout();
            groupBox2.SuspendLayout();
            groupBox1.SuspendLayout();
            groupBox7.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)gridLayout1).BeginInit();
            panel3.SuspendLayout();
            SuspendLayout();
            // 
            // panel1
            // 
            panel1.Controls.Add(labelCT);
            panel1.Dock = DockStyle.Top;
            panel1.Location = new Point(5, 5);
            panel1.Name = "panel1";
            panel1.Size = new Size(645, 78);
            panel1.TabIndex = 0;
            // 
            // labelCT
            // 
            labelCT.Dock = DockStyle.Fill;
            labelCT.Font = new Font("Segoe UI", 20.25F, FontStyle.Bold, GraphicsUnit.Point);
            labelCT.ForeColor = SystemColors.HotTrack;
            labelCT.Location = new Point(0, 0);
            labelCT.Margin = new Padding(4, 0, 4, 0);
            labelCT.Name = "labelCT";
            labelCT.Padding = new Padding(0, 0, 0, 10);
            labelCT.Size = new Size(645, 78);
            labelCT.TabIndex = 15;
            labelCT.Text = "CHỈ THỊ ";
            labelCT.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // panel2
            // 
            panel2.Controls.Add(groupBox9);
            panel2.Controls.Add(groupBox8);
            panel2.Controls.Add(groupBox6);
            panel2.Controls.Add(groupBox5);
            panel2.Controls.Add(groupBox4);
            panel2.Controls.Add(groupBox3);
            panel2.Controls.Add(groupBox2);
            panel2.Controls.Add(groupBox1);
            panel2.Controls.Add(groupBox7);
            panel2.Dock = DockStyle.Fill;
            panel2.Location = new Point(5, 83);
            panel2.Name = "panel2";
            panel2.Size = new Size(645, 273);
            panel2.TabIndex = 1;
            // 
            // groupBox9
            // 
            groupBox9.Controls.Add(TenSP);
            groupBox9.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold, GraphicsUnit.Point);
            groupBox9.Location = new Point(1, 1);
            groupBox9.Name = "groupBox9";
            groupBox9.Padding = new Padding(10, 3, 10, 3);
            gridLayout1.SetParticipateInLayout(groupBox9, true);
            groupBox9.Size = new Size(208, 84);
            groupBox9.TabIndex = 14;
            groupBox9.TabStop = false;
            groupBox9.Text = "Tên sản phẩm";
            // 
            // TenSP
            // 
            TenSP.Dock = DockStyle.Fill;
            TenSP.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            TenSP.Location = new Point(10, 25);
            TenSP.Name = "TenSP";
            TenSP.Size = new Size(188, 29);
            TenSP.TabIndex = 0;
            // 
            // groupBox8
            // 
            groupBox8.Controls.Add(ApSuatNap);
            groupBox8.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold, GraphicsUnit.Point);
            groupBox8.Location = new Point(219, 1);
            groupBox8.Name = "groupBox8";
            groupBox8.Padding = new Padding(10, 3, 10, 3);
            gridLayout1.SetParticipateInLayout(groupBox8, true);
            groupBox8.Size = new Size(208, 84);
            groupBox8.TabIndex = 13;
            groupBox8.TabStop = false;
            groupBox8.Text = "Áp suất nạp";
            // 
            // ApSuatNap
            // 
            ApSuatNap.Dock = DockStyle.Fill;
            ApSuatNap.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            ApSuatNap.Location = new Point(10, 25);
            ApSuatNap.Name = "ApSuatNap";
            ApSuatNap.Size = new Size(188, 29);
            ApSuatNap.TabIndex = 0;
            // 
            // groupBox6
            // 
            groupBox6.Controls.Add(TheTichBinh);
            groupBox6.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold, GraphicsUnit.Point);
            groupBox6.Location = new Point(437, 1);
            groupBox6.Name = "groupBox6";
            groupBox6.Padding = new Padding(10, 3, 10, 3);
            gridLayout1.SetParticipateInLayout(groupBox6, true);
            groupBox6.Size = new Size(208, 84);
            groupBox6.TabIndex = 12;
            groupBox6.TabStop = false;
            groupBox6.Text = "Thể tích bình";
            // 
            // TheTichBinh
            // 
            TheTichBinh.Dock = DockStyle.Fill;
            TheTichBinh.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            TheTichBinh.Location = new Point(10, 25);
            TheTichBinh.Name = "TheTichBinh";
            TheTichBinh.Size = new Size(188, 29);
            TheTichBinh.TabIndex = 0;
            // 
            // groupBox5
            // 
            groupBox5.Controls.Add(ChatLuongKhi);
            groupBox5.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold, GraphicsUnit.Point);
            groupBox5.Location = new Point(1, 95);
            groupBox5.Name = "groupBox5";
            groupBox5.Padding = new Padding(10, 3, 10, 3);
            gridLayout1.SetParticipateInLayout(groupBox5, true);
            groupBox5.Size = new Size(208, 84);
            groupBox5.TabIndex = 11;
            groupBox5.TabStop = false;
            groupBox5.Text = "Chất lượng khí";
            // 
            // ChatLuongKhi
            // 
            ChatLuongKhi.Dock = DockStyle.Fill;
            ChatLuongKhi.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            ChatLuongKhi.Location = new Point(10, 25);
            ChatLuongKhi.Name = "ChatLuongKhi";
            ChatLuongKhi.Size = new Size(188, 29);
            ChatLuongKhi.TabIndex = 0;
            // 
            // groupBox4
            // 
            groupBox4.Controls.Add(SLCanSX);
            groupBox4.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold, GraphicsUnit.Point);
            groupBox4.Location = new Point(219, 95);
            groupBox4.Name = "groupBox4";
            groupBox4.Padding = new Padding(10, 3, 10, 3);
            gridLayout1.SetParticipateInLayout(groupBox4, true);
            groupBox4.Size = new Size(208, 84);
            groupBox4.TabIndex = 10;
            groupBox4.TabStop = false;
            groupBox4.Text = "Số lượng cần sản xuất";
            // 
            // SLCanSX
            // 
            SLCanSX.Dock = DockStyle.Fill;
            SLCanSX.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            SLCanSX.Location = new Point(10, 25);
            SLCanSX.Name = "SLCanSX";
            SLCanSX.Size = new Size(188, 29);
            SLCanSX.TabIndex = 0;
            // 
            // groupBox3
            // 
            groupBox3.Controls.Add(SLDaSX);
            groupBox3.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold, GraphicsUnit.Point);
            groupBox3.Location = new Point(437, 95);
            groupBox3.Name = "groupBox3";
            groupBox3.Padding = new Padding(10, 3, 10, 3);
            gridLayout1.SetParticipateInLayout(groupBox3, true);
            groupBox3.Size = new Size(208, 84);
            groupBox3.TabIndex = 9;
            groupBox3.TabStop = false;
            groupBox3.Text = "Số lượng đã sản xuất";
            // 
            // SLDaSX
            // 
            SLDaSX.Dock = DockStyle.Fill;
            SLDaSX.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            SLDaSX.Location = new Point(10, 25);
            SLDaSX.Name = "SLDaSX";
            SLDaSX.Size = new Size(188, 29);
            SLDaSX.TabIndex = 0;
            // 
            // groupBox2
            // 
            groupBox2.Controls.Add(BeginAt);
            groupBox2.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold, GraphicsUnit.Point);
            groupBox2.Location = new Point(1, 189);
            groupBox2.Name = "groupBox2";
            groupBox2.Padding = new Padding(10, 3, 10, 3);
            gridLayout1.SetParticipateInLayout(groupBox2, true);
            groupBox2.Size = new Size(208, 84);
            groupBox2.TabIndex = 8;
            groupBox2.TabStop = false;
            groupBox2.Text = "Ngày bắt đầu";
            // 
            // groupBox1
            // 
            groupBox1.Controls.Add(EndAt);
            groupBox1.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold, GraphicsUnit.Point);
            groupBox1.Location = new Point(219, 189);
            groupBox1.Name = "groupBox1";
            groupBox1.Padding = new Padding(10, 3, 10, 3);
            gridLayout1.SetParticipateInLayout(groupBox1, true);
            groupBox1.Size = new Size(208, 84);
            groupBox1.TabIndex = 7;
            groupBox1.TabStop = false;
            groupBox1.Text = "Ngày kết thúc";
            // 
            // groupBox7
            // 
            groupBox7.Controls.Add(comboBoxStatus);
            groupBox7.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold, GraphicsUnit.Point);
            groupBox7.Location = new Point(437, 189);
            groupBox7.Name = "groupBox7";
            groupBox7.Padding = new Padding(10, 3, 10, 3);
            gridLayout1.SetParticipateInLayout(groupBox7, true);
            groupBox7.Size = new Size(208, 84);
            groupBox7.TabIndex = 6;
            groupBox7.TabStop = false;
            groupBox7.Text = "Trạng thái";
            // 
            // gridLayout1
            // 
            gridLayout1.Columns = 3;
            gridLayout1.ContainerControl = panel2;
            gridLayout1.HGap = 10;
            gridLayout1.Rows = 3;
            gridLayout1.VGap = 10;
            // 
            // panel3
            // 
            panel3.Controls.Add(buttonUpdate);
            panel3.Dock = DockStyle.Bottom;
            panel3.Location = new Point(5, 356);
            panel3.Name = "panel3";
            panel3.Padding = new Padding(220, 10, 220, 10);
            panel3.Size = new Size(645, 65);
            panel3.TabIndex = 71;
            // 
            // buttonUpdate
            // 
            buttonUpdate.BackColor = Color.DarkOrange;
            buttonUpdate.BackgroundColor = Color.DarkOrange;
            buttonUpdate.BorderColor = Color.PaleVioletRed;
            buttonUpdate.BorderRadius = 3;
            buttonUpdate.BorderSize = 0;
            buttonUpdate.Cursor = Cursors.Hand;
            buttonUpdate.Dock = DockStyle.Fill;
            buttonUpdate.FlatStyle = FlatStyle.Flat;
            buttonUpdate.Font = new Font("Segoe UI", 18F, FontStyle.Bold, GraphicsUnit.Point);
            buttonUpdate.ForeColor = Color.Black;
            buttonUpdate.Image = (Image)resources.GetObject("buttonUpdate.Image");
            buttonUpdate.ImageAlign = ContentAlignment.MiddleRight;
            buttonUpdate.Location = new Point(220, 10);
            buttonUpdate.Margin = new Padding(4, 3, 4, 3);
            buttonUpdate.Name = "buttonUpdate";
            buttonUpdate.Size = new Size(205, 45);
            buttonUpdate.TabIndex = 71;
            buttonUpdate.Text = "Cập nhật";
            buttonUpdate.TextAlign = ContentAlignment.MiddleLeft;
            buttonUpdate.TextColor = Color.Black;
            buttonUpdate.TextImageRelation = TextImageRelation.ImageBeforeText;
            buttonUpdate.UseVisualStyleBackColor = false;
            // 
            // BeginAt
            // 
            BeginAt.Dock = DockStyle.Fill;
            BeginAt.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            BeginAt.Format = DateTimePickerFormat.Custom;
            BeginAt.Location = new Point(10, 25);
            BeginAt.Margin = new Padding(4, 3, 4, 3);
            BeginAt.MaxDate = new DateTime(2050, 12, 31, 0, 0, 0, 0);
            BeginAt.MinDate = new DateTime(2022, 1, 1, 0, 0, 0, 0);
            BeginAt.Name = "BeginAt";
            BeginAt.Size = new Size(188, 29);
            BeginAt.TabIndex = 69;
            // 
            // EndAt
            // 
            EndAt.Dock = DockStyle.Fill;
            EndAt.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            EndAt.Format = DateTimePickerFormat.Custom;
            EndAt.Location = new Point(10, 25);
            EndAt.Margin = new Padding(4, 3, 4, 3);
            EndAt.MaxDate = new DateTime(2050, 12, 31, 0, 0, 0, 0);
            EndAt.MinDate = new DateTime(2022, 1, 1, 0, 0, 0, 0);
            EndAt.Name = "EndAt";
            EndAt.Size = new Size(188, 29);
            EndAt.TabIndex = 69;
            // 
            // comboBoxStatus
            // 
            comboBoxStatus.Dock = DockStyle.Fill;
            comboBoxStatus.DropDownStyle = ComboBoxStyle.DropDownList;
            comboBoxStatus.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            comboBoxStatus.FormattingEnabled = true;
            comboBoxStatus.Location = new Point(10, 25);
            comboBoxStatus.Name = "comboBoxStatus";
            comboBoxStatus.Size = new Size(188, 29);
            comboBoxStatus.TabIndex = 0;
            // 
            // UpdateWorkingList
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(655, 426);
            Controls.Add(panel2);
            Controls.Add(panel1);
            Controls.Add(panel3);
            MaximizeBox = false;
            MinimizeBox = false;
            Name = "UpdateWorkingList";
            Padding = new Padding(5);
            StartPosition = FormStartPosition.CenterParent;
            Text = "Cập nhật công việc";
            Load += UpdateWorkingList_Load;
            panel1.ResumeLayout(false);
            panel2.ResumeLayout(false);
            groupBox9.ResumeLayout(false);
            groupBox9.PerformLayout();
            groupBox8.ResumeLayout(false);
            groupBox8.PerformLayout();
            groupBox6.ResumeLayout(false);
            groupBox6.PerformLayout();
            groupBox5.ResumeLayout(false);
            groupBox5.PerformLayout();
            groupBox4.ResumeLayout(false);
            groupBox4.PerformLayout();
            groupBox3.ResumeLayout(false);
            groupBox3.PerformLayout();
            groupBox2.ResumeLayout(false);
            groupBox1.ResumeLayout(false);
            groupBox7.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)gridLayout1).EndInit();
            panel3.ResumeLayout(false);
            ResumeLayout(false);
        }

        #endregion

        private Panel panel1;
        private Label labelCT;
        private Panel panel2;
        private Syncfusion.Windows.Forms.Tools.GridLayout gridLayout1;
        private LW_PhanMemBaoGia.MyControls.ButtonCustom buttonAdd;
        private GroupBox groupBox7;
        private GroupBox groupBox9;
        private TextBox TenSP;
        private GroupBox groupBox8;
        private TextBox ApSuatNap;
        private GroupBox groupBox6;
        private TextBox TheTichBinh;
        private GroupBox groupBox5;
        private TextBox ChatLuongKhi;
        private GroupBox groupBox4;
        private TextBox SLCanSX;
        private GroupBox groupBox3;
        private TextBox SLDaSX;
        private GroupBox groupBox2;
        private GroupBox groupBox1;
        private Panel panel3;
        private LW_PhanMemBaoGia.MyControls.ButtonCustom buttonUpdate;
        private DateTimePicker BeginAt;
        private DateTimePicker EndAt;
        private ComboBox comboBoxStatus;
    }
}