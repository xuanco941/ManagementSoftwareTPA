using System.Windows.Forms;

namespace ManagementSoftware.GUI
{
    partial class ResultHistory
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
            DataGridViewCellStyle dataGridViewCellStyle3 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle4 = new DataGridViewCellStyle();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ResultHistory));
            panel3 = new Panel();
            dataGridView1 = new DataGridView();
            panelPagination = new Panel();
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
            panel1 = new Panel();
            tableLayoutPanel1 = new TableLayoutPanel();
            panel4 = new Panel();
            tableLayoutPanel2 = new TableLayoutPanel();
            panel5 = new Panel();
            panel7 = new Panel();
            panel8 = new Panel();
            panelLoc = new Panel();
            label5 = new Label();
            comboBoxLoaiKhi = new ComboBox();
            label6 = new Label();
            comboBoxNguoiVanHanh = new ComboBox();
            panel11 = new Panel();
            label1 = new Label();
            buttonCustomLoc = new LW_PhanMemBaoGia.MyControls.ButtonCustom();
            panel6 = new Panel();
            groupBox1 = new GroupBox();
            buttonPrint = new LW_PhanMemBaoGia.MyControls.ButtonCustom();
            buttonExcel = new LW_PhanMemBaoGia.MyControls.ButtonCustom();
            panel3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            panelPagination.SuspendLayout();
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
            panel1.SuspendLayout();
            tableLayoutPanel1.SuspendLayout();
            panel4.SuspendLayout();
            tableLayoutPanel2.SuspendLayout();
            panel5.SuspendLayout();
            panel7.SuspendLayout();
            panel8.SuspendLayout();
            panelLoc.SuspendLayout();
            panel11.SuspendLayout();
            panel6.SuspendLayout();
            groupBox1.SuspendLayout();
            SuspendLayout();
            // 
            // panel3
            // 
            panel3.Controls.Add(dataGridView1);
            panel3.Controls.Add(panelPagination);
            panel3.Dock = DockStyle.Fill;
            panel3.Location = new Point(0, 0);
            panel3.Margin = new Padding(4, 3, 4, 3);
            panel3.Name = "panel3";
            panel3.Size = new Size(1058, 542);
            panel3.TabIndex = 1;
            // 
            // dataGridView1
            // 
            dataGridView1.AllowUserToAddRows = false;
            dataGridView1.BackgroundColor = SystemColors.GradientActiveCaption;
            dataGridViewCellStyle1.Alignment = DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle1.BackColor = SystemColors.Control;
            dataGridViewCellStyle1.Font = new Font("Microsoft Sans Serif", 8.25F, FontStyle.Regular, GraphicsUnit.Point);
            dataGridViewCellStyle1.ForeColor = SystemColors.WindowText;
            dataGridViewCellStyle1.SelectionBackColor = SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = DataGridViewTriState.True;
            dataGridView1.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewCellStyle2.Alignment = DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle2.BackColor = SystemColors.Window;
            dataGridViewCellStyle2.Font = new Font("Microsoft Sans Serif", 8.25F, FontStyle.Regular, GraphicsUnit.Point);
            dataGridViewCellStyle2.ForeColor = SystemColors.ControlText;
            dataGridViewCellStyle2.SelectionBackColor = SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = DataGridViewTriState.False;
            dataGridView1.DefaultCellStyle = dataGridViewCellStyle2;
            dataGridView1.Dock = DockStyle.Fill;
            dataGridView1.Location = new Point(0, 0);
            dataGridView1.Margin = new Padding(4, 3, 4, 3);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.ReadOnly = true;
            dataGridViewCellStyle3.Alignment = DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle3.BackColor = SystemColors.Control;
            dataGridViewCellStyle3.Font = new Font("Microsoft Sans Serif", 8.25F, FontStyle.Regular, GraphicsUnit.Point);
            dataGridViewCellStyle3.ForeColor = SystemColors.WindowText;
            dataGridViewCellStyle3.SelectionBackColor = SystemColors.Highlight;
            dataGridViewCellStyle3.SelectionForeColor = SystemColors.HighlightText;
            dataGridViewCellStyle3.WrapMode = DataGridViewTriState.True;
            dataGridView1.RowHeadersDefaultCellStyle = dataGridViewCellStyle3;
            dataGridView1.RowHeadersVisible = false;
            dataGridViewCellStyle4.Alignment = DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle4.WrapMode = DataGridViewTriState.True;
            dataGridView1.RowsDefaultCellStyle = dataGridViewCellStyle4;
            dataGridView1.Size = new Size(1058, 482);
            dataGridView1.TabIndex = 0;
            // 
            // panelPagination
            // 
            panelPagination.BackColor = Color.FromArgb(32, 32, 32);
            panelPagination.BorderStyle = BorderStyle.FixedSingle;
            panelPagination.Controls.Add(tableLayoutPanel5);
            panelPagination.Controls.Add(buttonCustomGoPage);
            panelPagination.Controls.Add(inputNumPageGo);
            panelPagination.Dock = DockStyle.Bottom;
            panelPagination.Location = new Point(0, 482);
            panelPagination.Margin = new Padding(4, 3, 4, 3);
            panelPagination.Name = "panelPagination";
            panelPagination.Size = new Size(1058, 60);
            panelPagination.TabIndex = 2;
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
            tableLayoutPanel5.Size = new Size(1056, 58);
            tableLayoutPanel5.TabIndex = 35;
            // 
            // tableLayoutPanel7
            // 
            tableLayoutPanel7.ColumnCount = 1;
            tableLayoutPanel7.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 100F));
            tableLayoutPanel7.Controls.Add(panel52, 0, 0);
            tableLayoutPanel7.Controls.Add(panel53, 0, 1);
            tableLayoutPanel7.Dock = DockStyle.Fill;
            tableLayoutPanel7.Location = new Point(235, 3);
            tableLayoutPanel7.Name = "tableLayoutPanel7";
            tableLayoutPanel7.RowCount = 2;
            tableLayoutPanel7.RowStyles.Add(new RowStyle(SizeType.Percent, 40F));
            tableLayoutPanel7.RowStyles.Add(new RowStyle(SizeType.Percent, 60F));
            tableLayoutPanel7.Size = new Size(99, 52);
            tableLayoutPanel7.TabIndex = 4;
            // 
            // panel52
            // 
            panel52.BorderStyle = BorderStyle.FixedSingle;
            panel52.Controls.Add(label22);
            panel52.Dock = DockStyle.Fill;
            panel52.Location = new Point(3, 3);
            panel52.Name = "panel52";
            panel52.Size = new Size(93, 14);
            panel52.TabIndex = 0;
            // 
            // label22
            // 
            label22.Dock = DockStyle.Fill;
            label22.Font = new Font("Segoe UI", 8.25F, FontStyle.Bold, GraphicsUnit.Point);
            label22.ForeColor = Color.SkyBlue;
            label22.Location = new Point(0, 0);
            label22.Name = "label22";
            label22.Size = new Size(91, 12);
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
            panel53.Size = new Size(93, 26);
            panel53.TabIndex = 1;
            // 
            // lbTotalPages
            // 
            lbTotalPages.Dock = DockStyle.Fill;
            lbTotalPages.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point);
            lbTotalPages.ForeColor = Color.SpringGreen;
            lbTotalPages.Location = new Point(0, 0);
            lbTotalPages.Name = "lbTotalPages";
            lbTotalPages.Size = new Size(91, 24);
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
            panel47.Location = new Point(899, 3);
            panel47.Name = "panel47";
            panel47.Size = new Size(154, 52);
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
            buttonGoto.Size = new Size(152, 25);
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
            pageNumberGoto.Size = new Size(152, 25);
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
            panel46.Location = new Point(340, 3);
            panel46.Name = "panel46";
            panel46.Size = new Size(553, 52);
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
            tableLayoutPanel6.Size = new Size(446, 50);
            tableLayoutPanel6.TabIndex = 33;
            // 
            // panel51
            // 
            panel51.BorderStyle = BorderStyle.FixedSingle;
            panel51.Controls.Add(TimeEnd);
            panel51.Dock = DockStyle.Fill;
            panel51.Location = new Point(226, 23);
            panel51.Name = "panel51";
            panel51.Size = new Size(217, 24);
            panel51.TabIndex = 3;
            // 
            // TimeEnd
            // 
            TimeEnd.Dock = DockStyle.Fill;
            TimeEnd.Font = new Font("Segoe UI", 11.25F, FontStyle.Regular, GraphicsUnit.Point);
            TimeEnd.Format = "HH:mm:ss dd-MM-yyyy";
            TimeEnd.Location = new Point(0, 0);
            TimeEnd.Name = "TimeEnd";
            TimeEnd.Size = new Size(215, 22);
            TimeEnd.TabIndex = 35;
            // 
            // panel50
            // 
            panel50.BorderStyle = BorderStyle.FixedSingle;
            panel50.Controls.Add(TimeStart);
            panel50.Dock = DockStyle.Fill;
            panel50.Location = new Point(3, 23);
            panel50.Name = "panel50";
            panel50.Size = new Size(217, 24);
            panel50.TabIndex = 2;
            // 
            // TimeStart
            // 
            TimeStart.Dock = DockStyle.Fill;
            TimeStart.Font = new Font("Segoe UI", 11.25F, FontStyle.Regular, GraphicsUnit.Point);
            TimeStart.Location = new Point(0, 0);
            TimeStart.Name = "TimeStart";
            TimeStart.Size = new Size(215, 22);
            TimeStart.TabIndex = 34;
            // 
            // panel49
            // 
            panel49.BorderStyle = BorderStyle.FixedSingle;
            panel49.Controls.Add(label21);
            panel49.Dock = DockStyle.Fill;
            panel49.Location = new Point(226, 3);
            panel49.Name = "panel49";
            panel49.Size = new Size(217, 14);
            panel49.TabIndex = 1;
            // 
            // label21
            // 
            label21.Dock = DockStyle.Fill;
            label21.Font = new Font("Segoe UI", 8.25F, FontStyle.Bold, GraphicsUnit.Point);
            label21.ForeColor = Color.SkyBlue;
            label21.Location = new Point(0, 0);
            label21.Name = "label21";
            label21.Size = new Size(215, 12);
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
            panel48.Size = new Size(217, 14);
            panel48.TabIndex = 0;
            // 
            // label20
            // 
            label20.Dock = DockStyle.Fill;
            label20.Font = new Font("Segoe UI", 8.25F, FontStyle.Bold, GraphicsUnit.Point);
            label20.ForeColor = Color.SkyBlue;
            label20.Location = new Point(0, 0);
            label20.Name = "label20";
            label20.Size = new Size(215, 12);
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
            buttonSearch.Location = new Point(446, 0);
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
            panel45.Size = new Size(226, 52);
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
            buttonPage.Size = new Size(104, 50);
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
            buttonNextPage.Location = new Point(164, 0);
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
            buttonCustomGoPage.Location = new Point(2394, -70);
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
            inputNumPageGo.Location = new Point(2324, -68);
            inputNumPageGo.Margin = new Padding(4, 3, 4, 3);
            inputNumPageGo.Multiline = true;
            inputNumPageGo.Name = "inputNumPageGo";
            inputNumPageGo.Size = new Size(66, 35);
            inputNumPageGo.TabIndex = 32;
            inputNumPageGo.Text = "1";
            inputNumPageGo.TextAlign = HorizontalAlignment.Center;
            // 
            // panel1
            // 
            panel1.Controls.Add(panel3);
            panel1.Dock = DockStyle.Fill;
            panel1.Location = new Point(4, 3);
            panel1.Margin = new Padding(4, 3, 4, 3);
            panel1.Name = "panel1";
            panel1.Size = new Size(1058, 542);
            panel1.TabIndex = 0;
            // 
            // tableLayoutPanel1
            // 
            tableLayoutPanel1.ColumnCount = 2;
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 100F));
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Absolute, 250F));
            tableLayoutPanel1.Controls.Add(panel1, 0, 0);
            tableLayoutPanel1.Controls.Add(panel4, 1, 0);
            tableLayoutPanel1.Dock = DockStyle.Fill;
            tableLayoutPanel1.Location = new Point(0, 0);
            tableLayoutPanel1.Margin = new Padding(4, 3, 4, 3);
            tableLayoutPanel1.Name = "tableLayoutPanel1";
            tableLayoutPanel1.RowCount = 1;
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Percent, 100F));
            tableLayoutPanel1.Size = new Size(1316, 548);
            tableLayoutPanel1.TabIndex = 3;
            // 
            // panel4
            // 
            panel4.Controls.Add(tableLayoutPanel2);
            panel4.Dock = DockStyle.Fill;
            panel4.Location = new Point(1070, 3);
            panel4.Margin = new Padding(4, 3, 4, 3);
            panel4.Name = "panel4";
            panel4.Size = new Size(242, 542);
            panel4.TabIndex = 1;
            // 
            // tableLayoutPanel2
            // 
            tableLayoutPanel2.ColumnCount = 1;
            tableLayoutPanel2.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 100F));
            tableLayoutPanel2.Controls.Add(panel5, 0, 0);
            tableLayoutPanel2.Controls.Add(panel6, 0, 1);
            tableLayoutPanel2.Dock = DockStyle.Fill;
            tableLayoutPanel2.Location = new Point(0, 0);
            tableLayoutPanel2.Margin = new Padding(4, 3, 4, 3);
            tableLayoutPanel2.Name = "tableLayoutPanel2";
            tableLayoutPanel2.RowCount = 2;
            tableLayoutPanel2.RowStyles.Add(new RowStyle(SizeType.Percent, 100F));
            tableLayoutPanel2.RowStyles.Add(new RowStyle(SizeType.Absolute, 138F));
            tableLayoutPanel2.Size = new Size(242, 542);
            tableLayoutPanel2.TabIndex = 26;
            // 
            // panel5
            // 
            panel5.Controls.Add(panel7);
            panel5.Dock = DockStyle.Fill;
            panel5.Location = new Point(4, 3);
            panel5.Margin = new Padding(4, 3, 4, 3);
            panel5.Name = "panel5";
            panel5.Size = new Size(234, 398);
            panel5.TabIndex = 0;
            // 
            // panel7
            // 
            panel7.Controls.Add(panel8);
            panel7.Dock = DockStyle.Fill;
            panel7.Location = new Point(0, 0);
            panel7.Margin = new Padding(4, 3, 4, 3);
            panel7.Name = "panel7";
            panel7.Size = new Size(234, 398);
            panel7.TabIndex = 26;
            // 
            // panel8
            // 
            panel8.Controls.Add(panelLoc);
            panel8.Dock = DockStyle.Fill;
            panel8.Location = new Point(0, 0);
            panel8.Margin = new Padding(4, 3, 4, 3);
            panel8.Name = "panel8";
            panel8.Size = new Size(234, 398);
            panel8.TabIndex = 48;
            // 
            // panelLoc
            // 
            panelLoc.AutoScroll = true;
            panelLoc.Controls.Add(label5);
            panelLoc.Controls.Add(comboBoxLoaiKhi);
            panelLoc.Controls.Add(label6);
            panelLoc.Controls.Add(comboBoxNguoiVanHanh);
            panelLoc.Controls.Add(panel11);
            panelLoc.Controls.Add(buttonCustomLoc);
            panelLoc.Dock = DockStyle.Fill;
            panelLoc.Location = new Point(0, 0);
            panelLoc.Name = "panelLoc";
            panelLoc.Size = new Size(234, 398);
            panelLoc.TabIndex = 1;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            label5.Location = new Point(20, 111);
            label5.Margin = new Padding(4, 0, 4, 0);
            label5.Name = "label5";
            label5.Size = new Size(67, 21);
            label5.TabIndex = 94;
            label5.Text = "Loại khí:";
            // 
            // comboBoxLoaiKhi
            // 
            comboBoxLoaiKhi.DropDownStyle = ComboBoxStyle.DropDownList;
            comboBoxLoaiKhi.Font = new Font("Segoe UI", 14.25F, FontStyle.Regular, GraphicsUnit.Point);
            comboBoxLoaiKhi.FormattingEnabled = true;
            comboBoxLoaiKhi.Location = new Point(20, 133);
            comboBoxLoaiKhi.Margin = new Padding(4, 3, 4, 3);
            comboBoxLoaiKhi.Name = "comboBoxLoaiKhi";
            comboBoxLoaiKhi.Size = new Size(190, 33);
            comboBoxLoaiKhi.TabIndex = 93;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            label6.Location = new Point(20, 55);
            label6.Margin = new Padding(4, 0, 4, 0);
            label6.Name = "label6";
            label6.Size = new Size(125, 21);
            label6.TabIndex = 92;
            label6.Text = "Người vận hành:";
            // 
            // comboBoxNguoiVanHanh
            // 
            comboBoxNguoiVanHanh.DropDownStyle = ComboBoxStyle.DropDownList;
            comboBoxNguoiVanHanh.Font = new Font("Segoe UI", 14.25F, FontStyle.Regular, GraphicsUnit.Point);
            comboBoxNguoiVanHanh.FormattingEnabled = true;
            comboBoxNguoiVanHanh.Location = new Point(20, 77);
            comboBoxNguoiVanHanh.Margin = new Padding(4, 3, 4, 3);
            comboBoxNguoiVanHanh.Name = "comboBoxNguoiVanHanh";
            comboBoxNguoiVanHanh.Size = new Size(190, 33);
            comboBoxNguoiVanHanh.TabIndex = 91;
            // 
            // panel11
            // 
            panel11.Controls.Add(label1);
            panel11.Dock = DockStyle.Top;
            panel11.Location = new Point(0, 0);
            panel11.Name = "panel11";
            panel11.Size = new Size(234, 43);
            panel11.TabIndex = 85;
            // 
            // label1
            // 
            label1.Dock = DockStyle.Fill;
            label1.Font = new Font("Segoe UI", 18F, FontStyle.Bold, GraphicsUnit.Point);
            label1.Location = new Point(0, 0);
            label1.Margin = new Padding(4, 0, 4, 0);
            label1.Name = "label1";
            label1.Size = new Size(234, 43);
            label1.TabIndex = 50;
            label1.Text = "Lọc Dữ Liệu";
            label1.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // buttonCustomLoc
            // 
            buttonCustomLoc.BackColor = Color.LightSkyBlue;
            buttonCustomLoc.BackgroundColor = Color.LightSkyBlue;
            buttonCustomLoc.BorderColor = Color.PaleVioletRed;
            buttonCustomLoc.BorderRadius = 3;
            buttonCustomLoc.BorderSize = 0;
            buttonCustomLoc.Cursor = Cursors.Hand;
            buttonCustomLoc.FlatStyle = FlatStyle.Flat;
            buttonCustomLoc.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point);
            buttonCustomLoc.ForeColor = Color.Black;
            buttonCustomLoc.Image = (Image)resources.GetObject("buttonCustomLoc.Image");
            buttonCustomLoc.ImageAlign = ContentAlignment.MiddleRight;
            buttonCustomLoc.Location = new Point(60, 173);
            buttonCustomLoc.Margin = new Padding(4, 3, 4, 3);
            buttonCustomLoc.Name = "buttonCustomLoc";
            buttonCustomLoc.Size = new Size(120, 37);
            buttonCustomLoc.TabIndex = 67;
            buttonCustomLoc.Text = "Lọc";
            buttonCustomLoc.TextAlign = ContentAlignment.MiddleLeft;
            buttonCustomLoc.TextColor = Color.Black;
            buttonCustomLoc.TextImageRelation = TextImageRelation.ImageBeforeText;
            buttonCustomLoc.UseVisualStyleBackColor = false;
            buttonCustomLoc.Click += buttonCustomLoc_Click;
            // 
            // panel6
            // 
            panel6.Controls.Add(groupBox1);
            panel6.Dock = DockStyle.Fill;
            panel6.Location = new Point(4, 407);
            panel6.Margin = new Padding(4, 3, 4, 3);
            panel6.Name = "panel6";
            panel6.Size = new Size(234, 132);
            panel6.TabIndex = 1;
            // 
            // groupBox1
            // 
            groupBox1.Controls.Add(buttonPrint);
            groupBox1.Controls.Add(buttonExcel);
            groupBox1.Dock = DockStyle.Fill;
            groupBox1.ForeColor = SystemColors.HotTrack;
            groupBox1.Location = new Point(0, 0);
            groupBox1.Margin = new Padding(4, 3, 4, 3);
            groupBox1.Name = "groupBox1";
            groupBox1.Padding = new Padding(4, 3, 4, 3);
            groupBox1.Size = new Size(234, 132);
            groupBox1.TabIndex = 26;
            groupBox1.TabStop = false;
            groupBox1.Text = "Tùy chọn";
            // 
            // buttonPrint
            // 
            buttonPrint.Anchor = AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            buttonPrint.BackColor = SystemColors.ActiveCaption;
            buttonPrint.BackgroundColor = SystemColors.ActiveCaption;
            buttonPrint.BorderColor = Color.PaleVioletRed;
            buttonPrint.BorderRadius = 3;
            buttonPrint.BorderSize = 0;
            buttonPrint.Cursor = Cursors.Hand;
            buttonPrint.FlatStyle = FlatStyle.Flat;
            buttonPrint.Font = new Font("Segoe UI", 11.25F, FontStyle.Bold, GraphicsUnit.Point);
            buttonPrint.ForeColor = Color.Black;
            buttonPrint.Image = Properties.Resources.iconfinder_Save_278762;
            buttonPrint.ImageAlign = ContentAlignment.MiddleRight;
            buttonPrint.Location = new Point(46, 32);
            buttonPrint.Margin = new Padding(4, 3, 4, 3);
            buttonPrint.Name = "buttonPrint";
            buttonPrint.Size = new Size(145, 42);
            buttonPrint.TabIndex = 17;
            buttonPrint.Text = "Xuất báo cáo";
            buttonPrint.TextAlign = ContentAlignment.MiddleLeft;
            buttonPrint.TextColor = Color.Black;
            buttonPrint.TextImageRelation = TextImageRelation.ImageBeforeText;
            buttonPrint.UseVisualStyleBackColor = false;
            buttonPrint.Click += buttonPrint_Click;
            // 
            // buttonExcel
            // 
            buttonExcel.Anchor = AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            buttonExcel.BackColor = Color.MediumSeaGreen;
            buttonExcel.BackgroundColor = Color.MediumSeaGreen;
            buttonExcel.BorderColor = Color.PaleVioletRed;
            buttonExcel.BorderRadius = 3;
            buttonExcel.BorderSize = 0;
            buttonExcel.Cursor = Cursors.Hand;
            buttonExcel.FlatStyle = FlatStyle.Flat;
            buttonExcel.Font = new Font("Segoe UI", 11.25F, FontStyle.Bold, GraphicsUnit.Point);
            buttonExcel.ForeColor = Color.Black;
            buttonExcel.Image = Properties.Resources.Logoexe;
            buttonExcel.ImageAlign = ContentAlignment.MiddleRight;
            buttonExcel.Location = new Point(46, 81);
            buttonExcel.Margin = new Padding(4, 3, 4, 3);
            buttonExcel.Name = "buttonExcel";
            buttonExcel.Size = new Size(145, 40);
            buttonExcel.TabIndex = 16;
            buttonExcel.Text = "Xuất Excel";
            buttonExcel.TextAlign = ContentAlignment.MiddleLeft;
            buttonExcel.TextColor = Color.Black;
            buttonExcel.TextImageRelation = TextImageRelation.ImageBeforeText;
            buttonExcel.UseVisualStyleBackColor = false;
            buttonExcel.Click += buttonExcel_Click;
            // 
            // ResultHistory
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1316, 548);
            Controls.Add(tableLayoutPanel1);
            Icon = (Icon)resources.GetObject("$this.Icon");
            Margin = new Padding(4, 3, 4, 3);
            Name = "ResultHistory";
            Text = "FormResult";
            Load += ResultHistory_Load;
            panel3.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            panelPagination.ResumeLayout(false);
            panelPagination.PerformLayout();
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
            panel1.ResumeLayout(false);
            tableLayoutPanel1.ResumeLayout(false);
            panel4.ResumeLayout(false);
            tableLayoutPanel2.ResumeLayout(false);
            panel5.ResumeLayout(false);
            panel7.ResumeLayout(false);
            panel8.ResumeLayout(false);
            panelLoc.ResumeLayout(false);
            panelLoc.PerformLayout();
            panel11.ResumeLayout(false);
            panel6.ResumeLayout(false);
            groupBox1.ResumeLayout(false);
            ResumeLayout(false);
        }

        #endregion
        private Panel panel3;
        private Panel panel1;
        private TableLayoutPanel tableLayoutPanel1;
        private Panel panel4;
        private TableLayoutPanel tableLayoutPanel2;
        private Panel panel5;
        private Panel panel7;
        private Panel panel6;
        private Panel panel8;
        private GroupBox groupBox1;
        private LW_PhanMemBaoGia.MyControls.ButtonCustom buttonPrint;
        private LW_PhanMemBaoGia.MyControls.ButtonCustom buttonExcel;
        private DataGridView dataGridView1;
        private Panel panelLoc;
        private Panel panel11;
        private Label label1;
        private LW_PhanMemBaoGia.MyControls.ButtonCustom buttonCustomLoc;
        private Label label7;
        private CheckBox checkBoxTheTich;
        private Label label4;
        private CheckBox checkBoxApSuat;
        private Syncfusion.Windows.Forms.Tools.IntegerTextBox TheTichInput2;
        private Syncfusion.Windows.Forms.Tools.IntegerTextBox TheTichInput1;
        private Syncfusion.Windows.Forms.Tools.IntegerTextBox ApSuatInput2;
        private Syncfusion.Windows.Forms.Tools.IntegerTextBox ApSuatInput1;
        private Label label6;
        private ComboBox comboBoxNguoiVanHanh;
        private Panel panelPagination;
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
        private Label label5;
        private ComboBox comboBox1;
        private ComboBox comboBoxLoaiKhi;
    }
}