namespace ManagementSoftware.GUI.Section
{
    partial class FormItemPO
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormItemPO));
            panelItemPO = new Panel();
            panelGrid = new Panel();
            panel8 = new Panel();
            labelMaPO = new Label();
            panel7 = new Panel();
            labelNgayGiao = new Label();
            panel6 = new Panel();
            labelTrangThai = new Label();
            panel5 = new Panel();
            labelMaKhachHang = new Label();
            panel4 = new Panel();
            labelTenKhachHang = new Label();
            panel3 = new Panel();
            labelDiaDiem = new Label();
            panelProcess = new Panel();
            progressBarTienTrinh = new Syncfusion.Windows.Forms.Tools.ProgressBarAdv();
            panelBtn = new Panel();
            buttonViewDetail = new Button();
            pictureBox2 = new PictureBox();
            gridLayout1 = new Syncfusion.Windows.Forms.Tools.GridLayout(components);
            panelItemPO.SuspendLayout();
            panelGrid.SuspendLayout();
            panel8.SuspendLayout();
            panel7.SuspendLayout();
            panel6.SuspendLayout();
            panel5.SuspendLayout();
            panel4.SuspendLayout();
            panel3.SuspendLayout();
            panelProcess.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)progressBarTienTrinh).BeginInit();
            panelBtn.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).BeginInit();
            ((System.ComponentModel.ISupportInitialize)gridLayout1).BeginInit();
            SuspendLayout();
            // 
            // panelItemPO
            // 
            panelItemPO.BackColor = Color.LightSkyBlue;
            panelItemPO.BorderStyle = BorderStyle.FixedSingle;
            panelItemPO.Controls.Add(panelGrid);
            panelItemPO.Controls.Add(panelProcess);
            panelItemPO.Controls.Add(panelBtn);
            panelItemPO.Controls.Add(pictureBox2);
            panelItemPO.Dock = DockStyle.Fill;
            panelItemPO.Location = new Point(10, 5);
            panelItemPO.Margin = new Padding(4, 3, 4, 3);
            panelItemPO.Name = "panelItemPO";
            panelItemPO.Size = new Size(1112, 115);
            panelItemPO.TabIndex = 6;
            // 
            // panelGrid
            // 
            panelGrid.BorderStyle = BorderStyle.FixedSingle;
            panelGrid.Controls.Add(panel8);
            panelGrid.Controls.Add(panel7);
            panelGrid.Controls.Add(panel6);
            panelGrid.Controls.Add(panel5);
            panelGrid.Controls.Add(panel4);
            panelGrid.Controls.Add(panel3);
            panelGrid.Dock = DockStyle.Fill;
            panelGrid.Location = new Point(184, 0);
            panelGrid.Name = "panelGrid";
            panelGrid.Size = new Size(779, 82);
            panelGrid.TabIndex = 7;
            // 
            // panel8
            // 
            panel8.Controls.Add(labelMaPO);
            panel8.Location = new Point(0, 0);
            panel8.Name = "panel8";
            gridLayout1.SetParticipateInLayout(panel8, true);
            panel8.Size = new Size(259, 40);
            panel8.TabIndex = 5;
            // 
            // labelMaPO
            // 
            labelMaPO.Dock = DockStyle.Fill;
            labelMaPO.Font = new Font("Segoe UI Semibold", 12.75F, FontStyle.Bold, GraphicsUnit.Point);
            labelMaPO.Location = new Point(0, 0);
            labelMaPO.Margin = new Padding(4, 0, 4, 0);
            labelMaPO.Name = "labelMaPO";
            labelMaPO.Size = new Size(259, 40);
            labelMaPO.TabIndex = 14;
            labelMaPO.Text = "Số PO :";
            labelMaPO.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // panel7
            // 
            panel7.Controls.Add(labelNgayGiao);
            panel7.Location = new Point(259, 0);
            panel7.Name = "panel7";
            gridLayout1.SetParticipateInLayout(panel7, true);
            panel7.Size = new Size(259, 40);
            panel7.TabIndex = 4;
            // 
            // labelNgayGiao
            // 
            labelNgayGiao.Dock = DockStyle.Fill;
            labelNgayGiao.Font = new Font("Segoe UI Semibold", 12.75F, FontStyle.Bold, GraphicsUnit.Point);
            labelNgayGiao.Location = new Point(0, 0);
            labelNgayGiao.Margin = new Padding(4, 0, 4, 0);
            labelNgayGiao.Name = "labelNgayGiao";
            labelNgayGiao.Size = new Size(259, 40);
            labelNgayGiao.TabIndex = 14;
            labelNgayGiao.Text = "Ngày giao: 30/5/2022";
            labelNgayGiao.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // panel6
            // 
            panel6.Controls.Add(labelTrangThai);
            panel6.Location = new Point(518, 0);
            panel6.Name = "panel6";
            gridLayout1.SetParticipateInLayout(panel6, true);
            panel6.Size = new Size(259, 40);
            panel6.TabIndex = 3;
            // 
            // labelTrangThai
            // 
            labelTrangThai.Dock = DockStyle.Fill;
            labelTrangThai.Font = new Font("Segoe UI Semibold", 12.75F, FontStyle.Bold, GraphicsUnit.Point);
            labelTrangThai.Location = new Point(0, 0);
            labelTrangThai.Margin = new Padding(4, 0, 4, 0);
            labelTrangThai.Name = "labelTrangThai";
            labelTrangThai.Size = new Size(259, 40);
            labelTrangThai.TabIndex = 14;
            labelTrangThai.Text = "Trạng thái: Đang sản xuất";
            labelTrangThai.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // panel5
            // 
            panel5.Controls.Add(labelMaKhachHang);
            panel5.Location = new Point(0, 40);
            panel5.Name = "panel5";
            gridLayout1.SetParticipateInLayout(panel5, true);
            panel5.Size = new Size(259, 40);
            panel5.TabIndex = 2;
            // 
            // labelMaKhachHang
            // 
            labelMaKhachHang.Dock = DockStyle.Fill;
            labelMaKhachHang.Font = new Font("Segoe UI Semibold", 12.75F, FontStyle.Bold, GraphicsUnit.Point);
            labelMaKhachHang.Location = new Point(0, 0);
            labelMaKhachHang.Margin = new Padding(4, 0, 4, 0);
            labelMaKhachHang.Name = "labelMaKhachHang";
            labelMaKhachHang.Size = new Size(259, 40);
            labelMaKhachHang.TabIndex = 14;
            labelMaKhachHang.Text = "Mã khách hàng : ";
            labelMaKhachHang.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // panel4
            // 
            panel4.Controls.Add(labelTenKhachHang);
            panel4.Location = new Point(259, 40);
            panel4.Name = "panel4";
            gridLayout1.SetParticipateInLayout(panel4, true);
            panel4.Size = new Size(259, 40);
            panel4.TabIndex = 1;
            // 
            // labelTenKhachHang
            // 
            labelTenKhachHang.Dock = DockStyle.Fill;
            labelTenKhachHang.Font = new Font("Segoe UI Semibold", 12.75F, FontStyle.Bold, GraphicsUnit.Point);
            labelTenKhachHang.Location = new Point(0, 0);
            labelTenKhachHang.Margin = new Padding(4, 0, 4, 0);
            labelTenKhachHang.Name = "labelTenKhachHang";
            labelTenKhachHang.Size = new Size(259, 40);
            labelTenKhachHang.TabIndex = 14;
            labelTenKhachHang.Text = "Tên Khách hàng :";
            labelTenKhachHang.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // panel3
            // 
            panel3.Controls.Add(labelDiaDiem);
            panel3.Location = new Point(518, 40);
            panel3.Name = "panel3";
            gridLayout1.SetParticipateInLayout(panel3, true);
            panel3.Size = new Size(259, 40);
            panel3.TabIndex = 0;
            // 
            // labelDiaDiem
            // 
            labelDiaDiem.Dock = DockStyle.Fill;
            labelDiaDiem.Font = new Font("Segoe UI Semibold", 12.75F, FontStyle.Bold, GraphicsUnit.Point);
            labelDiaDiem.Location = new Point(0, 0);
            labelDiaDiem.Margin = new Padding(4, 0, 4, 0);
            labelDiaDiem.Name = "labelDiaDiem";
            labelDiaDiem.Size = new Size(259, 40);
            labelDiaDiem.TabIndex = 13;
            labelDiaDiem.Text = "Địa điểm : Hà Nội";
            labelDiaDiem.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // panelProcess
            // 
            panelProcess.BorderStyle = BorderStyle.FixedSingle;
            panelProcess.Controls.Add(progressBarTienTrinh);
            panelProcess.Dock = DockStyle.Bottom;
            panelProcess.Location = new Point(184, 82);
            panelProcess.Name = "panelProcess";
            panelProcess.Size = new Size(779, 31);
            panelProcess.TabIndex = 6;
            // 
            // progressBarTienTrinh
            // 
            progressBarTienTrinh.BackColor = Color.Goldenrod;
            progressBarTienTrinh.BackMultipleColors = (new Color[] { Color.Empty });
            progressBarTienTrinh.BackSegments = false;
            progressBarTienTrinh.CustomText = null;
            progressBarTienTrinh.CustomWaitingRender = false;
            progressBarTienTrinh.Dock = DockStyle.Fill;
            progressBarTienTrinh.ForeColor = Color.Green;
            progressBarTienTrinh.ForegroundImage = null;
            progressBarTienTrinh.Location = new Point(0, 0);
            progressBarTienTrinh.MultipleColors = (new Color[] { Color.Empty });
            progressBarTienTrinh.Name = "progressBarTienTrinh";
            progressBarTienTrinh.SegmentWidth = 12;
            progressBarTienTrinh.Size = new Size(777, 29);
            progressBarTienTrinh.TabIndex = 0;
            progressBarTienTrinh.Text = "progressBarAdv1";
            progressBarTienTrinh.WaitingGradientWidth = 400;
            // 
            // panelBtn
            // 
            panelBtn.BorderStyle = BorderStyle.FixedSingle;
            panelBtn.Controls.Add(buttonViewDetail);
            panelBtn.Dock = DockStyle.Right;
            panelBtn.Location = new Point(963, 0);
            panelBtn.Name = "panelBtn";
            panelBtn.Size = new Size(147, 113);
            panelBtn.TabIndex = 5;
            // 
            // buttonViewDetail
            // 
            buttonViewDetail.Cursor = Cursors.Hand;
            buttonViewDetail.Dock = DockStyle.Fill;
            buttonViewDetail.FlatAppearance.BorderSize = 0;
            buttonViewDetail.FlatStyle = FlatStyle.Flat;
            buttonViewDetail.Font = new Font("Segoe UI Semibold", 14.25F, FontStyle.Bold, GraphicsUnit.Point);
            buttonViewDetail.ForeColor = Color.Black;
            buttonViewDetail.Image = (Image)resources.GetObject("buttonViewDetail.Image");
            buttonViewDetail.Location = new Point(0, 0);
            buttonViewDetail.Name = "buttonViewDetail";
            buttonViewDetail.Size = new Size(145, 111);
            buttonViewDetail.TabIndex = 17;
            buttonViewDetail.Text = "Xem chi tiết";
            buttonViewDetail.TextAlign = ContentAlignment.BottomCenter;
            buttonViewDetail.TextImageRelation = TextImageRelation.ImageAboveText;
            buttonViewDetail.UseVisualStyleBackColor = true;
            buttonViewDetail.Click += buttonViewDetail_Click;
            // 
            // pictureBox2
            // 
            pictureBox2.Dock = DockStyle.Left;
            pictureBox2.Image = Properties.Resources.ETEK_LOGO_01;
            pictureBox2.Location = new Point(0, 0);
            pictureBox2.Margin = new Padding(4, 3, 4, 3);
            pictureBox2.Name = "pictureBox2";
            pictureBox2.Size = new Size(184, 113);
            pictureBox2.SizeMode = PictureBoxSizeMode.CenterImage;
            pictureBox2.TabIndex = 0;
            pictureBox2.TabStop = false;
            // 
            // gridLayout1
            // 
            gridLayout1.Columns = 3;
            gridLayout1.ContainerControl = panelGrid;
            gridLayout1.Rows = 2;
            // 
            // FormItemPO
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(41, 44, 51);
            ClientSize = new Size(1132, 125);
            Controls.Add(panelItemPO);
            Name = "FormItemPO";
            Padding = new Padding(10, 5, 10, 5);
            Text = "FormItemPO";
            panelItemPO.ResumeLayout(false);
            panelGrid.ResumeLayout(false);
            panel8.ResumeLayout(false);
            panel7.ResumeLayout(false);
            panel6.ResumeLayout(false);
            panel5.ResumeLayout(false);
            panel4.ResumeLayout(false);
            panel3.ResumeLayout(false);
            panelProcess.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)progressBarTienTrinh).EndInit();
            panelBtn.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)pictureBox2).EndInit();
            ((System.ComponentModel.ISupportInitialize)gridLayout1).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private Panel panelItemPO;
        private Panel panelGrid;
        private Panel panelProcess;
        private Panel panelBtn;
        private PictureBox pictureBox2;
        private Button buttonViewDetail;
        private Syncfusion.Windows.Forms.Tools.GridLayout gridLayout1;
        private Panel panel8;
        private Panel panel7;
        private Panel panel6;
        private Panel panel5;
        private Panel panel4;
        private Panel panel3;
        private Label labelDiaDiem;
        private Label labelMaPO;
        private Label labelNgayGiao;
        private Label labelTrangThai;
        private Label labelMaKhachHang;
        private Label labelTenKhachHang;
        private Syncfusion.Windows.Forms.Tools.ProgressBarAdv progressBarTienTrinh;
    }
}