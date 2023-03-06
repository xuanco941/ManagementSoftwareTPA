namespace ManagementSoftware.GUI
{
    partial class WorkingList
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(WorkingList));
            labelHeader = new Label();
            panelMain = new Panel();
            dataGridView1 = new DataGridView();
            panel1 = new Panel();
            panelBoxSearch = new Panel();
            tableLayoutPanel5 = new TableLayoutPanel();
            tableLayoutPanel7 = new TableLayoutPanel();
            panel52 = new Panel();
            label22 = new Label();
            panel53 = new Panel();
            lbTotalPages = new Label();
            panel47 = new Panel();
            buttonGoto = new LW_PhanMemBaoGia.MyControls.ButtonCustom();
            pageNumberGoto = new Syncfusion.Windows.Forms.Tools.IntegerTextBox();
            panel46 = new Panel();
            tableLayoutPanel6 = new TableLayoutPanel();
            panel51 = new Panel();
            TimeEnd = new Syncfusion.WinForms.Input.SfDateTimeEdit();
            panel50 = new Panel();
            TimeStart = new Syncfusion.WinForms.Input.SfDateTimeEdit();
            panel49 = new Panel();
            label21 = new Label();
            panel48 = new Panel();
            label20 = new Label();
            buttonSearch = new LW_PhanMemBaoGia.MyControls.ButtonCustom();
            panel45 = new Panel();
            buttonPage = new LW_PhanMemBaoGia.MyControls.ButtonCustom();
            buttonNextPage = new LW_PhanMemBaoGia.MyControls.ButtonCustom();
            buttonPreviousPage = new LW_PhanMemBaoGia.MyControls.ButtonCustom();
            buttonCustomGoPage = new LW_PhanMemBaoGia.MyControls.ButtonCustom();
            inputNumPageGo = new Syncfusion.Windows.Forms.Tools.IntegerTextBox();
            panel2 = new Panel();
            tableLayoutPanel1 = new TableLayoutPanel();
            panel6 = new Panel();
            buttonAll = new LW_PhanMemBaoGia.MyControls.ButtonCustom();
            panel5 = new Panel();
            buttonNotDone = new LW_PhanMemBaoGia.MyControls.ButtonCustom();
            panel4 = new Panel();
            buttonDone = new LW_PhanMemBaoGia.MyControls.ButtonCustom();
            panel3 = new Panel();
            label1 = new Label();
            panelMain.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            panel1.SuspendLayout();
            panelBoxSearch.SuspendLayout();
            tableLayoutPanel5.SuspendLayout();
            tableLayoutPanel7.SuspendLayout();
            panel52.SuspendLayout();
            panel53.SuspendLayout();
            panel47.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pageNumberGoto).BeginInit();
            panel46.SuspendLayout();
            tableLayoutPanel6.SuspendLayout();
            panel51.SuspendLayout();
            panel50.SuspendLayout();
            panel49.SuspendLayout();
            panel48.SuspendLayout();
            panel45.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)inputNumPageGo).BeginInit();
            panel2.SuspendLayout();
            tableLayoutPanel1.SuspendLayout();
            panel6.SuspendLayout();
            panel5.SuspendLayout();
            panel4.SuspendLayout();
            panel3.SuspendLayout();
            SuspendLayout();
            // 
            // labelHeader
            // 
            labelHeader.Dock = DockStyle.Fill;
            labelHeader.Font = new Font("Segoe UI", 20.25F, FontStyle.Bold, GraphicsUnit.Point);
            labelHeader.ForeColor = SystemColors.ActiveCaption;
            labelHeader.Location = new Point(0, 0);
            labelHeader.Margin = new Padding(4, 0, 4, 0);
            labelHeader.Name = "labelHeader";
            labelHeader.Size = new Size(1016, 46);
            labelHeader.TabIndex = 14;
            labelHeader.Text = "Danh mục sản xuất của bạn";
            labelHeader.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // panelMain
            // 
            panelMain.AutoScroll = true;
            panelMain.BorderStyle = BorderStyle.FixedSingle;
            panelMain.Controls.Add(dataGridView1);
            panelMain.Dock = DockStyle.Fill;
            panelMain.Location = new Point(0, 48);
            panelMain.Margin = new Padding(4, 3, 4, 3);
            panelMain.Name = "panelMain";
            panelMain.Size = new Size(1018, 425);
            panelMain.TabIndex = 10;
            // 
            // dataGridView1
            // 
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.Dock = DockStyle.Fill;
            dataGridView1.Location = new Point(0, 0);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.RowTemplate.Height = 25;
            dataGridView1.Size = new Size(1016, 423);
            dataGridView1.TabIndex = 0;
            // 
            // panel1
            // 
            panel1.BorderStyle = BorderStyle.FixedSingle;
            panel1.Controls.Add(labelHeader);
            panel1.Dock = DockStyle.Top;
            panel1.Location = new Point(0, 0);
            panel1.Margin = new Padding(4, 3, 4, 3);
            panel1.Name = "panel1";
            panel1.Size = new Size(1018, 48);
            panel1.TabIndex = 9;
            // 
            // panelBoxSearch
            // 
            panelBoxSearch.BackColor = Color.FromArgb(32, 32, 32);
            panelBoxSearch.BorderStyle = BorderStyle.FixedSingle;
            panelBoxSearch.Controls.Add(tableLayoutPanel5);
            panelBoxSearch.Controls.Add(buttonCustomGoPage);
            panelBoxSearch.Controls.Add(inputNumPageGo);
            panelBoxSearch.Dock = DockStyle.Bottom;
            panelBoxSearch.Location = new Point(0, 473);
            panelBoxSearch.Margin = new Padding(4, 3, 4, 3);
            panelBoxSearch.Name = "panelBoxSearch";
            panelBoxSearch.Size = new Size(1018, 60);
            panelBoxSearch.TabIndex = 72;
            // 
            // tableLayoutPanel5
            // 
            tableLayoutPanel5.ColumnCount = 4;
            tableLayoutPanel5.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 22F));
            tableLayoutPanel5.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 10F));
            tableLayoutPanel5.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 53F));
            tableLayoutPanel5.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 15F));
            tableLayoutPanel5.Controls.Add(tableLayoutPanel7, 1, 0);
            tableLayoutPanel5.Controls.Add(panel47, 3, 0);
            tableLayoutPanel5.Controls.Add(panel46, 2, 0);
            tableLayoutPanel5.Controls.Add(panel45, 0, 0);
            tableLayoutPanel5.Dock = DockStyle.Fill;
            tableLayoutPanel5.Location = new Point(0, 0);
            tableLayoutPanel5.Name = "tableLayoutPanel5";
            tableLayoutPanel5.RowCount = 1;
            tableLayoutPanel5.RowStyles.Add(new RowStyle(SizeType.Percent, 100F));
            tableLayoutPanel5.Size = new Size(1016, 58);
            tableLayoutPanel5.TabIndex = 35;
            // 
            // tableLayoutPanel7
            // 
            tableLayoutPanel7.ColumnCount = 1;
            tableLayoutPanel7.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 100F));
            tableLayoutPanel7.Controls.Add(panel52, 0, 0);
            tableLayoutPanel7.Controls.Add(panel53, 0, 1);
            tableLayoutPanel7.Dock = DockStyle.Fill;
            tableLayoutPanel7.Location = new Point(226, 3);
            tableLayoutPanel7.Name = "tableLayoutPanel7";
            tableLayoutPanel7.RowCount = 2;
            tableLayoutPanel7.RowStyles.Add(new RowStyle(SizeType.Percent, 40F));
            tableLayoutPanel7.RowStyles.Add(new RowStyle(SizeType.Percent, 60F));
            tableLayoutPanel7.Size = new Size(95, 52);
            tableLayoutPanel7.TabIndex = 4;
            // 
            // panel52
            // 
            panel52.BorderStyle = BorderStyle.FixedSingle;
            panel52.Controls.Add(label22);
            panel52.Dock = DockStyle.Fill;
            panel52.Location = new Point(3, 3);
            panel52.Name = "panel52";
            panel52.Size = new Size(89, 14);
            panel52.TabIndex = 0;
            // 
            // label22
            // 
            label22.Dock = DockStyle.Fill;
            label22.Font = new Font("Segoe UI", 8.25F, FontStyle.Bold, GraphicsUnit.Point);
            label22.ForeColor = Color.SkyBlue;
            label22.Location = new Point(0, 0);
            label22.Name = "label22";
            label22.Size = new Size(87, 12);
            label22.TabIndex = 4;
            label22.Text = "Tổng trang";
            label22.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // panel53
            // 
            panel53.BorderStyle = BorderStyle.FixedSingle;
            panel53.Controls.Add(lbTotalPages);
            panel53.Dock = DockStyle.Fill;
            panel53.Location = new Point(3, 23);
            panel53.Name = "panel53";
            panel53.Size = new Size(89, 26);
            panel53.TabIndex = 1;
            // 
            // lbTotalPages
            // 
            lbTotalPages.Dock = DockStyle.Fill;
            lbTotalPages.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point);
            lbTotalPages.ForeColor = Color.SpringGreen;
            lbTotalPages.Location = new Point(0, 0);
            lbTotalPages.Name = "lbTotalPages";
            lbTotalPages.Size = new Size(87, 24);
            lbTotalPages.TabIndex = 5;
            lbTotalPages.Text = "1";
            lbTotalPages.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // panel47
            // 
            panel47.BorderStyle = BorderStyle.FixedSingle;
            panel47.Controls.Add(buttonGoto);
            panel47.Controls.Add(pageNumberGoto);
            panel47.Dock = DockStyle.Fill;
            panel47.Location = new Point(865, 3);
            panel47.Name = "panel47";
            panel47.Size = new Size(148, 52);
            panel47.TabIndex = 2;
            // 
            // buttonGoto
            // 
            buttonGoto.BackColor = Color.DodgerBlue;
            buttonGoto.BackgroundColor = Color.DodgerBlue;
            buttonGoto.BorderColor = Color.PaleVioletRed;
            buttonGoto.BorderRadius = 3;
            buttonGoto.BorderSize = 0;
            buttonGoto.Cursor = Cursors.Hand;
            buttonGoto.Dock = DockStyle.Fill;
            buttonGoto.FlatStyle = FlatStyle.Flat;
            buttonGoto.Font = new Font("Segoe UI", 9.75F, FontStyle.Bold, GraphicsUnit.Point);
            buttonGoto.ForeColor = Color.Black;
            buttonGoto.Image = (Image)resources.GetObject("buttonGoto.Image");
            buttonGoto.ImageAlign = ContentAlignment.MiddleLeft;
            buttonGoto.Location = new Point(0, 25);
            buttonGoto.Margin = new Padding(4, 3, 4, 3);
            buttonGoto.Name = "buttonGoto";
            buttonGoto.Size = new Size(146, 25);
            buttonGoto.TabIndex = 34;
            buttonGoto.Text = "Tới trang";
            buttonGoto.TextAlign = ContentAlignment.MiddleRight;
            buttonGoto.TextColor = Color.Black;
            buttonGoto.TextImageRelation = TextImageRelation.TextBeforeImage;
            buttonGoto.UseVisualStyleBackColor = false;
            buttonGoto.Click += buttonGoto_Click;
            // 
            // pageNumberGoto
            // 
            pageNumberGoto.BeforeTouchSize = new Size(66, 35);
            pageNumberGoto.BorderStyle = BorderStyle.FixedSingle;
            pageNumberGoto.Dock = DockStyle.Top;
            pageNumberGoto.Font = new Font("Segoe UI", 9.75F, FontStyle.Regular, GraphicsUnit.Point);
            pageNumberGoto.IntegerValue = 1L;
            pageNumberGoto.Location = new Point(0, 0);
            pageNumberGoto.Margin = new Padding(4, 3, 4, 3);
            pageNumberGoto.Name = "pageNumberGoto";
            pageNumberGoto.Size = new Size(146, 25);
            pageNumberGoto.TabIndex = 7;
            pageNumberGoto.Text = "1";
            pageNumberGoto.TextAlign = HorizontalAlignment.Center;
            // 
            // panel46
            // 
            panel46.BorderStyle = BorderStyle.FixedSingle;
            panel46.Controls.Add(tableLayoutPanel6);
            panel46.Controls.Add(buttonSearch);
            panel46.Dock = DockStyle.Fill;
            panel46.Location = new Point(327, 3);
            panel46.Name = "panel46";
            panel46.Size = new Size(532, 52);
            panel46.TabIndex = 1;
            // 
            // tableLayoutPanel6
            // 
            tableLayoutPanel6.ColumnCount = 2;
            tableLayoutPanel6.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 50F));
            tableLayoutPanel6.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 50F));
            tableLayoutPanel6.Controls.Add(panel51, 1, 1);
            tableLayoutPanel6.Controls.Add(panel50, 0, 1);
            tableLayoutPanel6.Controls.Add(panel49, 1, 0);
            tableLayoutPanel6.Controls.Add(panel48, 0, 0);
            tableLayoutPanel6.Dock = DockStyle.Fill;
            tableLayoutPanel6.Location = new Point(0, 0);
            tableLayoutPanel6.Name = "tableLayoutPanel6";
            tableLayoutPanel6.RowCount = 2;
            tableLayoutPanel6.RowStyles.Add(new RowStyle(SizeType.Percent, 40F));
            tableLayoutPanel6.RowStyles.Add(new RowStyle(SizeType.Percent, 60F));
            tableLayoutPanel6.Size = new Size(425, 50);
            tableLayoutPanel6.TabIndex = 33;
            // 
            // panel51
            // 
            panel51.BorderStyle = BorderStyle.FixedSingle;
            panel51.Controls.Add(TimeEnd);
            panel51.Dock = DockStyle.Fill;
            panel51.Location = new Point(215, 23);
            panel51.Name = "panel51";
            panel51.Size = new Size(207, 24);
            panel51.TabIndex = 3;
            // 
            // TimeEnd
            // 
            TimeEnd.Dock = DockStyle.Fill;
            TimeEnd.Location = new Point(0, 0);
            TimeEnd.Name = "TimeEnd";
            TimeEnd.Size = new Size(205, 22);
            TimeEnd.TabIndex = 35;
            // 
            // panel50
            // 
            panel50.BorderStyle = BorderStyle.FixedSingle;
            panel50.Controls.Add(TimeStart);
            panel50.Dock = DockStyle.Fill;
            panel50.Location = new Point(3, 23);
            panel50.Name = "panel50";
            panel50.Size = new Size(206, 24);
            panel50.TabIndex = 2;
            // 
            // TimeStart
            // 
            TimeStart.Dock = DockStyle.Fill;
            TimeStart.Location = new Point(0, 0);
            TimeStart.Name = "TimeStart";
            TimeStart.Size = new Size(204, 22);
            TimeStart.TabIndex = 34;
            // 
            // panel49
            // 
            panel49.BorderStyle = BorderStyle.FixedSingle;
            panel49.Controls.Add(label21);
            panel49.Dock = DockStyle.Fill;
            panel49.Location = new Point(215, 3);
            panel49.Name = "panel49";
            panel49.Size = new Size(207, 14);
            panel49.TabIndex = 1;
            // 
            // label21
            // 
            label21.Dock = DockStyle.Fill;
            label21.Font = new Font("Segoe UI", 8.25F, FontStyle.Bold, GraphicsUnit.Point);
            label21.ForeColor = Color.SkyBlue;
            label21.Location = new Point(0, 0);
            label21.Name = "label21";
            label21.Size = new Size(205, 12);
            label21.TabIndex = 4;
            label21.Text = "Đến ngày";
            label21.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // panel48
            // 
            panel48.BorderStyle = BorderStyle.FixedSingle;
            panel48.Controls.Add(label20);
            panel48.Dock = DockStyle.Fill;
            panel48.Location = new Point(3, 3);
            panel48.Name = "panel48";
            panel48.Size = new Size(206, 14);
            panel48.TabIndex = 0;
            // 
            // label20
            // 
            label20.Dock = DockStyle.Fill;
            label20.Font = new Font("Segoe UI", 8.25F, FontStyle.Bold, GraphicsUnit.Point);
            label20.ForeColor = Color.SkyBlue;
            label20.Location = new Point(0, 0);
            label20.Name = "label20";
            label20.Size = new Size(204, 12);
            label20.TabIndex = 3;
            label20.Text = "Từ ngày";
            label20.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // buttonSearch
            // 
            buttonSearch.BackColor = Color.DeepSkyBlue;
            buttonSearch.BackgroundColor = Color.DeepSkyBlue;
            buttonSearch.BorderColor = Color.PaleVioletRed;
            buttonSearch.BorderRadius = 3;
            buttonSearch.BorderSize = 0;
            buttonSearch.Cursor = Cursors.Hand;
            buttonSearch.Dock = DockStyle.Right;
            buttonSearch.FlatStyle = FlatStyle.Flat;
            buttonSearch.Font = new Font("Segoe UI", 9.75F, FontStyle.Bold, GraphicsUnit.Point);
            buttonSearch.ForeColor = Color.Black;
            buttonSearch.Image = (Image)resources.GetObject("buttonSearch.Image");
            buttonSearch.ImageAlign = ContentAlignment.MiddleRight;
            buttonSearch.Location = new Point(425, 0);
            buttonSearch.Margin = new Padding(4, 3, 4, 3);
            buttonSearch.Name = "buttonSearch";
            buttonSearch.Size = new Size(105, 50);
            buttonSearch.TabIndex = 32;
            buttonSearch.Text = "Tìm kiếm";
            buttonSearch.TextAlign = ContentAlignment.MiddleLeft;
            buttonSearch.TextColor = Color.Black;
            buttonSearch.TextImageRelation = TextImageRelation.ImageBeforeText;
            buttonSearch.UseVisualStyleBackColor = false;
            buttonSearch.Click += buttonSearch_Click;
            // 
            // panel45
            // 
            panel45.BorderStyle = BorderStyle.FixedSingle;
            panel45.Controls.Add(buttonPage);
            panel45.Controls.Add(buttonNextPage);
            panel45.Controls.Add(buttonPreviousPage);
            panel45.Dock = DockStyle.Fill;
            panel45.Location = new Point(3, 3);
            panel45.Name = "panel45";
            panel45.Size = new Size(217, 52);
            panel45.TabIndex = 0;
            // 
            // buttonPage
            // 
            buttonPage.BackColor = SystemColors.ActiveCaption;
            buttonPage.BackgroundColor = SystemColors.ActiveCaption;
            buttonPage.BorderColor = Color.PaleVioletRed;
            buttonPage.BorderRadius = 3;
            buttonPage.BorderSize = 0;
            buttonPage.Cursor = Cursors.Hand;
            buttonPage.Dock = DockStyle.Fill;
            buttonPage.Enabled = false;
            buttonPage.FlatStyle = FlatStyle.Flat;
            buttonPage.Font = new Font("Segoe UI", 11.25F, FontStyle.Bold, GraphicsUnit.Point);
            buttonPage.ForeColor = Color.Black;
            buttonPage.ImageAlign = ContentAlignment.MiddleLeft;
            buttonPage.Location = new Point(60, 0);
            buttonPage.Margin = new Padding(4, 3, 4, 3);
            buttonPage.Name = "buttonPage";
            buttonPage.Size = new Size(95, 50);
            buttonPage.TabIndex = 32;
            buttonPage.Text = "1";
            buttonPage.TextColor = Color.Black;
            buttonPage.TextImageRelation = TextImageRelation.TextBeforeImage;
            buttonPage.UseVisualStyleBackColor = false;
            // 
            // buttonNextPage
            // 
            buttonNextPage.BackColor = SystemColors.ActiveCaption;
            buttonNextPage.BackgroundColor = SystemColors.ActiveCaption;
            buttonNextPage.BorderColor = Color.PaleVioletRed;
            buttonNextPage.BorderRadius = 3;
            buttonNextPage.BorderSize = 0;
            buttonNextPage.Cursor = Cursors.Hand;
            buttonNextPage.Dock = DockStyle.Right;
            buttonNextPage.FlatStyle = FlatStyle.Flat;
            buttonNextPage.Font = new Font("Segoe UI", 14.25F, FontStyle.Bold, GraphicsUnit.Point);
            buttonNextPage.ForeColor = Color.Black;
            buttonNextPage.ImageAlign = ContentAlignment.MiddleLeft;
            buttonNextPage.Location = new Point(155, 0);
            buttonNextPage.Margin = new Padding(4, 3, 4, 3);
            buttonNextPage.Name = "buttonNextPage";
            buttonNextPage.Size = new Size(60, 50);
            buttonNextPage.TabIndex = 31;
            buttonNextPage.Text = ">";
            buttonNextPage.TextColor = Color.Black;
            buttonNextPage.TextImageRelation = TextImageRelation.TextBeforeImage;
            buttonNextPage.UseVisualStyleBackColor = false;
            buttonNextPage.Click += buttonNextPage_Click;
            // 
            // buttonPreviousPage
            // 
            buttonPreviousPage.BackColor = SystemColors.ActiveCaption;
            buttonPreviousPage.BackgroundColor = SystemColors.ActiveCaption;
            buttonPreviousPage.BorderColor = Color.PaleVioletRed;
            buttonPreviousPage.BorderRadius = 3;
            buttonPreviousPage.BorderSize = 0;
            buttonPreviousPage.Cursor = Cursors.Hand;
            buttonPreviousPage.Dock = DockStyle.Left;
            buttonPreviousPage.FlatStyle = FlatStyle.Flat;
            buttonPreviousPage.Font = new Font("Segoe UI", 14.25F, FontStyle.Bold, GraphicsUnit.Point);
            buttonPreviousPage.ForeColor = Color.Black;
            buttonPreviousPage.ImageAlign = ContentAlignment.MiddleLeft;
            buttonPreviousPage.Location = new Point(0, 0);
            buttonPreviousPage.Margin = new Padding(4, 3, 4, 3);
            buttonPreviousPage.Name = "buttonPreviousPage";
            buttonPreviousPage.Size = new Size(60, 50);
            buttonPreviousPage.TabIndex = 29;
            buttonPreviousPage.Text = "<";
            buttonPreviousPage.TextColor = Color.Black;
            buttonPreviousPage.TextImageRelation = TextImageRelation.TextBeforeImage;
            buttonPreviousPage.UseVisualStyleBackColor = false;
            buttonPreviousPage.Click += buttonPreviousPage_Click;
            // 
            // buttonCustomGoPage
            // 
            buttonCustomGoPage.Anchor = AnchorStyles.Bottom | AnchorStyles.Right;
            buttonCustomGoPage.BackColor = Color.DodgerBlue;
            buttonCustomGoPage.BackgroundColor = Color.DodgerBlue;
            buttonCustomGoPage.BorderColor = Color.PaleVioletRed;
            buttonCustomGoPage.BorderRadius = 3;
            buttonCustomGoPage.BorderSize = 0;
            buttonCustomGoPage.Cursor = Cursors.Hand;
            buttonCustomGoPage.FlatStyle = FlatStyle.Flat;
            buttonCustomGoPage.Font = new Font("Segoe UI", 9.75F, FontStyle.Bold, GraphicsUnit.Point);
            buttonCustomGoPage.ForeColor = Color.Black;
            buttonCustomGoPage.Image = (Image)resources.GetObject("buttonCustomGoPage.Image");
            buttonCustomGoPage.ImageAlign = ContentAlignment.MiddleLeft;
            buttonCustomGoPage.Location = new Point(3977, -150);
            buttonCustomGoPage.Margin = new Padding(4, 3, 4, 3);
            buttonCustomGoPage.Name = "buttonCustomGoPage";
            buttonCustomGoPage.Size = new Size(93, 35);
            buttonCustomGoPage.TabIndex = 33;
            buttonCustomGoPage.Text = "Đi";
            buttonCustomGoPage.TextAlign = ContentAlignment.MiddleRight;
            buttonCustomGoPage.TextColor = Color.Black;
            buttonCustomGoPage.TextImageRelation = TextImageRelation.TextBeforeImage;
            buttonCustomGoPage.UseVisualStyleBackColor = false;
            // 
            // inputNumPageGo
            // 
            inputNumPageGo.Anchor = AnchorStyles.Bottom | AnchorStyles.Right;
            inputNumPageGo.BeforeTouchSize = new Size(66, 35);
            inputNumPageGo.BorderColor = SystemColors.ActiveCaption;
            inputNumPageGo.Font = new Font("Segoe UI", 18F, FontStyle.Regular, GraphicsUnit.Point);
            inputNumPageGo.IntegerValue = 1L;
            inputNumPageGo.Location = new Point(3907, -148);
            inputNumPageGo.Margin = new Padding(4, 3, 4, 3);
            inputNumPageGo.Multiline = true;
            inputNumPageGo.Name = "inputNumPageGo";
            inputNumPageGo.Size = new Size(66, 35);
            inputNumPageGo.TabIndex = 32;
            inputNumPageGo.Text = "1";
            inputNumPageGo.TextAlign = HorizontalAlignment.Center;
            // 
            // panel2
            // 
            panel2.Controls.Add(tableLayoutPanel1);
            panel2.Controls.Add(panel3);
            panel2.Dock = DockStyle.Right;
            panel2.Location = new Point(1018, 0);
            panel2.MaximumSize = new Size(240, 0);
            panel2.Name = "panel2";
            panel2.Size = new Size(240, 533);
            panel2.TabIndex = 73;
            // 
            // tableLayoutPanel1
            // 
            tableLayoutPanel1.ColumnCount = 1;
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 100F));
            tableLayoutPanel1.Controls.Add(panel6, 0, 0);
            tableLayoutPanel1.Controls.Add(panel5, 0, 2);
            tableLayoutPanel1.Controls.Add(panel4, 0, 1);
            tableLayoutPanel1.Dock = DockStyle.Top;
            tableLayoutPanel1.Location = new Point(0, 48);
            tableLayoutPanel1.Name = "tableLayoutPanel1";
            tableLayoutPanel1.RowCount = 3;
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Percent, 33.3333321F));
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Percent, 33.3333359F));
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Percent, 33.3333321F));
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Absolute, 20F));
            tableLayoutPanel1.Size = new Size(240, 304);
            tableLayoutPanel1.TabIndex = 2;
            // 
            // panel6
            // 
            panel6.Controls.Add(buttonAll);
            panel6.Dock = DockStyle.Fill;
            panel6.Location = new Point(3, 3);
            panel6.Name = "panel6";
            panel6.Size = new Size(234, 95);
            panel6.TabIndex = 38;
            // 
            // buttonAll
            // 
            buttonAll.BackColor = SystemColors.HotTrack;
            buttonAll.BackgroundColor = SystemColors.HotTrack;
            buttonAll.BorderColor = Color.PaleVioletRed;
            buttonAll.BorderRadius = 3;
            buttonAll.BorderSize = 0;
            buttonAll.Cursor = Cursors.Hand;
            buttonAll.Dock = DockStyle.Fill;
            buttonAll.FlatStyle = FlatStyle.Flat;
            buttonAll.Font = new Font("Segoe UI Semibold", 18F, FontStyle.Bold, GraphicsUnit.Point);
            buttonAll.ForeColor = Color.Black;
            buttonAll.Image = (Image)resources.GetObject("buttonAll.Image");
            buttonAll.ImageAlign = ContentAlignment.MiddleRight;
            buttonAll.Location = new Point(0, 0);
            buttonAll.Margin = new Padding(4, 3, 4, 3);
            buttonAll.Name = "buttonAll";
            buttonAll.Size = new Size(234, 95);
            buttonAll.TabIndex = 33;
            buttonAll.Text = "Tất cả";
            buttonAll.TextAlign = ContentAlignment.MiddleLeft;
            buttonAll.TextColor = Color.Black;
            buttonAll.TextImageRelation = TextImageRelation.ImageBeforeText;
            buttonAll.UseVisualStyleBackColor = false;
            buttonAll.Click += buttonAll_Click;
            // 
            // panel5
            // 
            panel5.Controls.Add(buttonNotDone);
            panel5.Dock = DockStyle.Fill;
            panel5.Location = new Point(3, 205);
            panel5.Name = "panel5";
            panel5.Size = new Size(234, 96);
            panel5.TabIndex = 37;
            // 
            // buttonNotDone
            // 
            buttonNotDone.BackColor = Color.Goldenrod;
            buttonNotDone.BackgroundColor = Color.Goldenrod;
            buttonNotDone.BorderColor = Color.PaleVioletRed;
            buttonNotDone.BorderRadius = 3;
            buttonNotDone.BorderSize = 0;
            buttonNotDone.Cursor = Cursors.Hand;
            buttonNotDone.Dock = DockStyle.Fill;
            buttonNotDone.FlatStyle = FlatStyle.Flat;
            buttonNotDone.Font = new Font("Segoe UI Semibold", 18F, FontStyle.Bold, GraphicsUnit.Point);
            buttonNotDone.ForeColor = Color.Black;
            buttonNotDone.Image = (Image)resources.GetObject("buttonNotDone.Image");
            buttonNotDone.ImageAlign = ContentAlignment.MiddleRight;
            buttonNotDone.Location = new Point(0, 0);
            buttonNotDone.Margin = new Padding(4, 3, 4, 3);
            buttonNotDone.Name = "buttonNotDone";
            buttonNotDone.Size = new Size(234, 96);
            buttonNotDone.TabIndex = 30;
            buttonNotDone.Text = "Chưa hoàn thành";
            buttonNotDone.TextAlign = ContentAlignment.MiddleLeft;
            buttonNotDone.TextColor = Color.Black;
            buttonNotDone.TextImageRelation = TextImageRelation.ImageBeforeText;
            buttonNotDone.UseVisualStyleBackColor = false;
            buttonNotDone.Click += buttonNotDone_Click;
            // 
            // panel4
            // 
            panel4.Controls.Add(buttonDone);
            panel4.Dock = DockStyle.Fill;
            panel4.Location = new Point(3, 104);
            panel4.Name = "panel4";
            panel4.Size = new Size(234, 95);
            panel4.TabIndex = 36;
            // 
            // buttonDone
            // 
            buttonDone.BackColor = Color.Green;
            buttonDone.BackgroundColor = Color.Green;
            buttonDone.BorderColor = Color.PaleVioletRed;
            buttonDone.BorderRadius = 3;
            buttonDone.BorderSize = 0;
            buttonDone.Cursor = Cursors.Hand;
            buttonDone.Dock = DockStyle.Fill;
            buttonDone.FlatStyle = FlatStyle.Flat;
            buttonDone.Font = new Font("Segoe UI Semibold", 18F, FontStyle.Bold, GraphicsUnit.Point);
            buttonDone.ForeColor = Color.Black;
            buttonDone.Image = (Image)resources.GetObject("buttonDone.Image");
            buttonDone.ImageAlign = ContentAlignment.MiddleRight;
            buttonDone.Location = new Point(0, 0);
            buttonDone.Margin = new Padding(4, 3, 4, 3);
            buttonDone.Name = "buttonDone";
            buttonDone.Size = new Size(234, 95);
            buttonDone.TabIndex = 32;
            buttonDone.Text = "Đã hoàn thành";
            buttonDone.TextAlign = ContentAlignment.MiddleLeft;
            buttonDone.TextColor = Color.Black;
            buttonDone.TextImageRelation = TextImageRelation.ImageBeforeText;
            buttonDone.UseVisualStyleBackColor = false;
            buttonDone.Click += buttonDone_Click;
            // 
            // panel3
            // 
            panel3.BorderStyle = BorderStyle.FixedSingle;
            panel3.Controls.Add(label1);
            panel3.Dock = DockStyle.Top;
            panel3.Location = new Point(0, 0);
            panel3.Name = "panel3";
            panel3.Size = new Size(240, 48);
            panel3.TabIndex = 0;
            // 
            // label1
            // 
            label1.Dock = DockStyle.Fill;
            label1.Font = new Font("Segoe UI", 20.25F, FontStyle.Bold, GraphicsUnit.Point);
            label1.ForeColor = SystemColors.ActiveCaption;
            label1.Location = new Point(0, 0);
            label1.Margin = new Padding(4, 0, 4, 0);
            label1.Name = "label1";
            label1.Size = new Size(238, 46);
            label1.TabIndex = 15;
            label1.Text = "Lọc danh mục";
            label1.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // WorkingList
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(41, 44, 51);
            ClientSize = new Size(1258, 533);
            Controls.Add(panelMain);
            Controls.Add(panelBoxSearch);
            Controls.Add(panel1);
            Controls.Add(panel2);
            Margin = new Padding(4, 3, 4, 3);
            Name = "WorkingList";
            Text = "FormWorkingList";
            Load += WorkingList_Load;
            panelMain.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            panel1.ResumeLayout(false);
            panelBoxSearch.ResumeLayout(false);
            panelBoxSearch.PerformLayout();
            tableLayoutPanel5.ResumeLayout(false);
            tableLayoutPanel7.ResumeLayout(false);
            panel52.ResumeLayout(false);
            panel53.ResumeLayout(false);
            panel47.ResumeLayout(false);
            panel47.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pageNumberGoto).EndInit();
            panel46.ResumeLayout(false);
            tableLayoutPanel6.ResumeLayout(false);
            panel51.ResumeLayout(false);
            panel50.ResumeLayout(false);
            panel49.ResumeLayout(false);
            panel48.ResumeLayout(false);
            panel45.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)inputNumPageGo).EndInit();
            panel2.ResumeLayout(false);
            tableLayoutPanel1.ResumeLayout(false);
            panel6.ResumeLayout(false);
            panel5.ResumeLayout(false);
            panel4.ResumeLayout(false);
            panel3.ResumeLayout(false);
            ResumeLayout(false);
        }

        #endregion
        private System.Windows.Forms.Label labelHeader;
        private System.Windows.Forms.Panel panelMain;
        private System.Windows.Forms.Panel panel1;
        private Panel panelBoxSearch;
        private TableLayoutPanel tableLayoutPanel5;
        private TableLayoutPanel tableLayoutPanel7;
        private Panel panel52;
        private Label label22;
        private Panel panel53;
        private Label lbTotalPages;
        private Panel panel47;
        private LW_PhanMemBaoGia.MyControls.ButtonCustom buttonGoto;
        private Syncfusion.Windows.Forms.Tools.IntegerTextBox pageNumberGoto;
        private Panel panel46;
        private TableLayoutPanel tableLayoutPanel6;
        private Panel panel51;
        private Syncfusion.WinForms.Input.SfDateTimeEdit TimeEnd;
        private Panel panel50;
        private Syncfusion.WinForms.Input.SfDateTimeEdit TimeStart;
        private Panel panel49;
        private Label label21;
        private Panel panel48;
        private Label label20;
        private LW_PhanMemBaoGia.MyControls.ButtonCustom buttonSearch;
        private Panel panel45;
        private LW_PhanMemBaoGia.MyControls.ButtonCustom buttonPage;
        private LW_PhanMemBaoGia.MyControls.ButtonCustom buttonNextPage;
        private LW_PhanMemBaoGia.MyControls.ButtonCustom buttonPreviousPage;
        private LW_PhanMemBaoGia.MyControls.ButtonCustom buttonCustomGoPage;
        private Syncfusion.Windows.Forms.Tools.IntegerTextBox inputNumPageGo;
        private DataGridView dataGridView1;
        private Panel panel2;
        private Panel panel3;
        private Label label1;
        private TableLayoutPanel tableLayoutPanel1;
        private Panel panel6;
        private LW_PhanMemBaoGia.MyControls.ButtonCustom buttonAll;
        private Panel panel5;
        private LW_PhanMemBaoGia.MyControls.ButtonCustom buttonNotDone;
        private Panel panel4;
        private LW_PhanMemBaoGia.MyControls.ButtonCustom buttonDone;
    }
}