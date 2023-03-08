namespace ManagementSoftware.GUI
{
    partial class WareHouse
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(WareHouse));
            panel45 = new Panel();
            buttonPage = new LW_PhanMemBaoGia.MyControls.ButtonCustom();
            buttonNextPage = new LW_PhanMemBaoGia.MyControls.ButtonCustom();
            buttonPreviousPage = new LW_PhanMemBaoGia.MyControls.ButtonCustom();
            buttonCustomGoPage = new LW_PhanMemBaoGia.MyControls.ButtonCustom();
            inputNumPageGo = new Syncfusion.Windows.Forms.Tools.IntegerTextBox();
            panel2 = new Panel();
            label29 = new Label();
            panelSearch = new Panel();
            panel4 = new Panel();
            textBoxSearchProduct = new LW_PhanMemBaoGia.MyControls.TextBoxT();
            buttonCustom1 = new LW_PhanMemBaoGia.MyControls.ButtonCustom();
            panel3 = new Panel();
            textBoxSearchPO = new LW_PhanMemBaoGia.MyControls.TextBoxT();
            buttonCustomLoc = new LW_PhanMemBaoGia.MyControls.ButtonCustom();
            panel5 = new Panel();
            label1 = new Label();
            tableLayoutPanel1 = new TableLayoutPanel();
            panelForm = new Panel();
            panelMain = new Panel();
            dataGridView1 = new DataGridView();
            panel1 = new Panel();
            tableLayoutPanel5 = new TableLayoutPanel();
            tableLayoutPanel7 = new TableLayoutPanel();
            panel52 = new Panel();
            label22 = new Label();
            panel53 = new Panel();
            lbTotalPages = new Label();
            panel47 = new Panel();
            buttonGoto = new LW_PhanMemBaoGia.MyControls.ButtonCustom();
            pageNumberGoto = new Syncfusion.Windows.Forms.Tools.IntegerTextBox();
            panel45.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)inputNumPageGo).BeginInit();
            panel2.SuspendLayout();
            panelSearch.SuspendLayout();
            panel4.SuspendLayout();
            panel3.SuspendLayout();
            panel5.SuspendLayout();
            tableLayoutPanel1.SuspendLayout();
            panelForm.SuspendLayout();
            panelMain.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            panel1.SuspendLayout();
            tableLayoutPanel5.SuspendLayout();
            tableLayoutPanel7.SuspendLayout();
            panel52.SuspendLayout();
            panel53.SuspendLayout();
            panel47.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pageNumberGoto).BeginInit();
            SuspendLayout();
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
            panel45.Size = new Size(239, 52);
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
            buttonPage.Size = new Size(117, 50);
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
            buttonNextPage.Location = new Point(177, 0);
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
            buttonCustomGoPage.Location = new Point(2813, -110);
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
            inputNumPageGo.Location = new Point(2743, -108);
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
            panel2.BorderStyle = BorderStyle.FixedSingle;
            panel2.Controls.Add(label29);
            panel2.Dock = DockStyle.Top;
            panel2.Location = new Point(0, 0);
            panel2.Margin = new Padding(4, 3, 4, 3);
            panel2.Name = "panel2";
            panel2.Size = new Size(812, 48);
            panel2.TabIndex = 15;
            // 
            // label29
            // 
            label29.Dock = DockStyle.Fill;
            label29.Font = new Font("Segoe UI", 20.25F, FontStyle.Bold, GraphicsUnit.Point);
            label29.ForeColor = SystemColors.ControlLight;
            label29.Location = new Point(0, 0);
            label29.Margin = new Padding(4, 0, 4, 0);
            label29.Name = "label29";
            label29.Size = new Size(810, 46);
            label29.TabIndex = 14;
            label29.Text = "Danh mục sản phẩm nhập kho";
            label29.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // panelSearch
            // 
            panelSearch.BackColor = SystemColors.ControlLight;
            panelSearch.BorderStyle = BorderStyle.FixedSingle;
            panelSearch.Controls.Add(panel4);
            panelSearch.Controls.Add(panel3);
            panelSearch.Controls.Add(panel5);
            panelSearch.Dock = DockStyle.Fill;
            panelSearch.Location = new Point(823, 3);
            panelSearch.Name = "panelSearch";
            panelSearch.Size = new Size(254, 468);
            panelSearch.TabIndex = 1;
            // 
            // panel4
            // 
            panel4.Controls.Add(textBoxSearchProduct);
            panel4.Controls.Add(buttonCustom1);
            panel4.Dock = DockStyle.Top;
            panel4.Location = new Point(0, 144);
            panel4.Name = "panel4";
            panel4.Padding = new Padding(3, 0, 3, 0);
            panel4.Size = new Size(252, 96);
            panel4.TabIndex = 72;
            // 
            // textBoxSearchProduct
            // 
            textBoxSearchProduct.BackColor = Color.FromArgb(41, 44, 51);
            textBoxSearchProduct.BorderColor = Color.CornflowerBlue;
            textBoxSearchProduct.BorderFocusColor = SystemColors.ActiveCaption;
            textBoxSearchProduct.BorderRadius = 5;
            textBoxSearchProduct.BorderSize = 0;
            textBoxSearchProduct.Dock = DockStyle.Top;
            textBoxSearchProduct.Font = new Font("Microsoft Sans Serif", 15.75F, FontStyle.Regular, GraphicsUnit.Point);
            textBoxSearchProduct.ForeColor = Color.White;
            textBoxSearchProduct.Location = new Point(3, 0);
            textBoxSearchProduct.Margin = new Padding(4, 3, 4, 3);
            textBoxSearchProduct.Multiline = false;
            textBoxSearchProduct.Name = "textBoxSearchProduct";
            textBoxSearchProduct.Padding = new Padding(8);
            textBoxSearchProduct.PasswordChar = false;
            textBoxSearchProduct.PlaceholderColor = Color.DarkGray;
            textBoxSearchProduct.PlaceholderText = "Nhập mã chỉ thị";
            textBoxSearchProduct.Size = new Size(246, 42);
            textBoxSearchProduct.TabIndex = 70;
            textBoxSearchProduct.Texts = "Nhập mã sản phẩm";
            textBoxSearchProduct.UnderlinedStyle = false;
            // 
            // buttonCustom1
            // 
            buttonCustom1.BackColor = Color.Lime;
            buttonCustom1.BackgroundColor = Color.Lime;
            buttonCustom1.BorderColor = Color.PaleVioletRed;
            buttonCustom1.BorderRadius = 3;
            buttonCustom1.BorderSize = 0;
            buttonCustom1.Cursor = Cursors.Hand;
            buttonCustom1.FlatStyle = FlatStyle.Flat;
            buttonCustom1.Font = new Font("Segoe UI", 14.25F, FontStyle.Bold, GraphicsUnit.Point);
            buttonCustom1.ForeColor = Color.Black;
            buttonCustom1.Image = (Image)resources.GetObject("buttonCustom1.Image");
            buttonCustom1.ImageAlign = ContentAlignment.MiddleRight;
            buttonCustom1.Location = new Point(63, 43);
            buttonCustom1.Margin = new Padding(4, 3, 4, 3);
            buttonCustom1.Name = "buttonCustom1";
            buttonCustom1.Size = new Size(130, 34);
            buttonCustom1.TabIndex = 68;
            buttonCustom1.Text = "Lọc";
            buttonCustom1.TextAlign = ContentAlignment.MiddleLeft;
            buttonCustom1.TextColor = Color.Black;
            buttonCustom1.TextImageRelation = TextImageRelation.ImageBeforeText;
            buttonCustom1.UseVisualStyleBackColor = false;
            buttonCustom1.Click += buttonCustom1_Click;
            // 
            // panel3
            // 
            panel3.Controls.Add(textBoxSearchPO);
            panel3.Controls.Add(buttonCustomLoc);
            panel3.Dock = DockStyle.Top;
            panel3.Location = new Point(0, 48);
            panel3.Name = "panel3";
            panel3.Padding = new Padding(3, 0, 3, 0);
            panel3.Size = new Size(252, 96);
            panel3.TabIndex = 71;
            // 
            // textBoxSearchPO
            // 
            textBoxSearchPO.BackColor = Color.FromArgb(41, 44, 51);
            textBoxSearchPO.BorderColor = Color.CornflowerBlue;
            textBoxSearchPO.BorderFocusColor = SystemColors.ActiveCaption;
            textBoxSearchPO.BorderRadius = 5;
            textBoxSearchPO.BorderSize = 0;
            textBoxSearchPO.Dock = DockStyle.Top;
            textBoxSearchPO.Font = new Font("Microsoft Sans Serif", 15.75F, FontStyle.Regular, GraphicsUnit.Point);
            textBoxSearchPO.ForeColor = Color.White;
            textBoxSearchPO.Location = new Point(3, 0);
            textBoxSearchPO.Margin = new Padding(4, 3, 4, 3);
            textBoxSearchPO.Multiline = false;
            textBoxSearchPO.Name = "textBoxSearchPO";
            textBoxSearchPO.Padding = new Padding(8);
            textBoxSearchPO.PasswordChar = false;
            textBoxSearchPO.PlaceholderColor = Color.DarkGray;
            textBoxSearchPO.PlaceholderText = "Nhập mã chỉ thị";
            textBoxSearchPO.Size = new Size(246, 42);
            textBoxSearchPO.TabIndex = 70;
            textBoxSearchPO.Texts = "Nhập mã PO";
            textBoxSearchPO.UnderlinedStyle = false;
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
            buttonCustomLoc.Font = new Font("Segoe UI", 14.25F, FontStyle.Bold, GraphicsUnit.Point);
            buttonCustomLoc.ForeColor = Color.Black;
            buttonCustomLoc.Image = (Image)resources.GetObject("buttonCustomLoc.Image");
            buttonCustomLoc.ImageAlign = ContentAlignment.MiddleRight;
            buttonCustomLoc.Location = new Point(63, 43);
            buttonCustomLoc.Margin = new Padding(4, 3, 4, 3);
            buttonCustomLoc.Name = "buttonCustomLoc";
            buttonCustomLoc.Size = new Size(130, 34);
            buttonCustomLoc.TabIndex = 68;
            buttonCustomLoc.Text = "Lọc";
            buttonCustomLoc.TextAlign = ContentAlignment.MiddleLeft;
            buttonCustomLoc.TextColor = Color.Black;
            buttonCustomLoc.TextImageRelation = TextImageRelation.ImageBeforeText;
            buttonCustomLoc.UseVisualStyleBackColor = false;
            buttonCustomLoc.Click += buttonCustomLoc_Click;
            // 
            // panel5
            // 
            panel5.BorderStyle = BorderStyle.FixedSingle;
            panel5.Controls.Add(label1);
            panel5.Dock = DockStyle.Top;
            panel5.Location = new Point(0, 0);
            panel5.Name = "panel5";
            panel5.Size = new Size(252, 48);
            panel5.TabIndex = 0;
            // 
            // label1
            // 
            label1.Dock = DockStyle.Fill;
            label1.Font = new Font("Segoe UI", 20.25F, FontStyle.Bold, GraphicsUnit.Point);
            label1.ForeColor = Color.FromArgb(41, 44, 51);
            label1.Location = new Point(0, 0);
            label1.Margin = new Padding(4, 0, 4, 0);
            label1.Name = "label1";
            label1.Size = new Size(250, 46);
            label1.TabIndex = 15;
            label1.Text = "Tìm kiếm";
            label1.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // tableLayoutPanel1
            // 
            tableLayoutPanel1.ColumnCount = 2;
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 100F));
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Absolute, 260F));
            tableLayoutPanel1.Controls.Add(panelForm, 0, 0);
            tableLayoutPanel1.Controls.Add(panelSearch, 1, 0);
            tableLayoutPanel1.Dock = DockStyle.Fill;
            tableLayoutPanel1.Location = new Point(0, 0);
            tableLayoutPanel1.Name = "tableLayoutPanel1";
            tableLayoutPanel1.RowCount = 1;
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Percent, 100F));
            tableLayoutPanel1.Size = new Size(1080, 474);
            tableLayoutPanel1.TabIndex = 1;
            // 
            // panelForm
            // 
            panelForm.BorderStyle = BorderStyle.FixedSingle;
            panelForm.Controls.Add(panelMain);
            panelForm.Controls.Add(panel1);
            panelForm.Controls.Add(panel2);
            panelForm.Dock = DockStyle.Fill;
            panelForm.Location = new Point(3, 3);
            panelForm.Name = "panelForm";
            panelForm.Size = new Size(814, 468);
            panelForm.TabIndex = 0;
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
            panelMain.Size = new Size(812, 358);
            panelMain.TabIndex = 17;
            // 
            // dataGridView1
            // 
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.Dock = DockStyle.Fill;
            dataGridView1.Location = new Point(0, 0);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.RowTemplate.Height = 25;
            dataGridView1.Size = new Size(810, 356);
            dataGridView1.TabIndex = 0;
            // 
            // panel1
            // 
            panel1.BackColor = Color.FromArgb(32, 32, 32);
            panel1.BorderStyle = BorderStyle.FixedSingle;
            panel1.Controls.Add(tableLayoutPanel5);
            panel1.Controls.Add(buttonCustomGoPage);
            panel1.Controls.Add(inputNumPageGo);
            panel1.Dock = DockStyle.Bottom;
            panel1.Location = new Point(0, 406);
            panel1.Margin = new Padding(4, 3, 4, 3);
            panel1.Name = "panel1";
            panel1.Size = new Size(812, 60);
            panel1.TabIndex = 18;
            // 
            // tableLayoutPanel5
            // 
            tableLayoutPanel5.ColumnCount = 3;
            tableLayoutPanel5.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 45.539032F));
            tableLayoutPanel5.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 23.4200745F));
            tableLayoutPanel5.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 31.0408916F));
            tableLayoutPanel5.ColumnStyles.Add(new ColumnStyle(SizeType.Absolute, 20F));
            tableLayoutPanel5.Controls.Add(tableLayoutPanel7, 1, 0);
            tableLayoutPanel5.Controls.Add(panel47, 2, 0);
            tableLayoutPanel5.Controls.Add(panel45, 0, 0);
            tableLayoutPanel5.Dock = DockStyle.Left;
            tableLayoutPanel5.Location = new Point(0, 0);
            tableLayoutPanel5.Name = "tableLayoutPanel5";
            tableLayoutPanel5.RowCount = 1;
            tableLayoutPanel5.RowStyles.Add(new RowStyle(SizeType.Percent, 100F));
            tableLayoutPanel5.Size = new Size(539, 58);
            tableLayoutPanel5.TabIndex = 35;
            // 
            // tableLayoutPanel7
            // 
            tableLayoutPanel7.ColumnCount = 1;
            tableLayoutPanel7.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 100F));
            tableLayoutPanel7.Controls.Add(panel52, 0, 0);
            tableLayoutPanel7.Controls.Add(panel53, 0, 1);
            tableLayoutPanel7.Dock = DockStyle.Fill;
            tableLayoutPanel7.Location = new Point(248, 3);
            tableLayoutPanel7.Name = "tableLayoutPanel7";
            tableLayoutPanel7.RowCount = 2;
            tableLayoutPanel7.RowStyles.Add(new RowStyle(SizeType.Percent, 40F));
            tableLayoutPanel7.RowStyles.Add(new RowStyle(SizeType.Percent, 60F));
            tableLayoutPanel7.Size = new Size(120, 52);
            tableLayoutPanel7.TabIndex = 4;
            // 
            // panel52
            // 
            panel52.BorderStyle = BorderStyle.FixedSingle;
            panel52.Controls.Add(label22);
            panel52.Dock = DockStyle.Fill;
            panel52.Location = new Point(3, 3);
            panel52.Name = "panel52";
            panel52.Size = new Size(114, 14);
            panel52.TabIndex = 0;
            // 
            // label22
            // 
            label22.Dock = DockStyle.Fill;
            label22.Font = new Font("Segoe UI", 8.25F, FontStyle.Bold, GraphicsUnit.Point);
            label22.ForeColor = Color.SkyBlue;
            label22.Location = new Point(0, 0);
            label22.Name = "label22";
            label22.Size = new Size(112, 12);
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
            panel53.Size = new Size(114, 26);
            panel53.TabIndex = 1;
            // 
            // lbTotalPages
            // 
            lbTotalPages.Dock = DockStyle.Fill;
            lbTotalPages.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point);
            lbTotalPages.ForeColor = Color.SpringGreen;
            lbTotalPages.Location = new Point(0, 0);
            lbTotalPages.Name = "lbTotalPages";
            lbTotalPages.Size = new Size(112, 24);
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
            panel47.Location = new Point(374, 3);
            panel47.Name = "panel47";
            panel47.Size = new Size(162, 52);
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
            buttonGoto.Location = new Point(0, 27);
            buttonGoto.Margin = new Padding(4, 3, 4, 3);
            buttonGoto.Name = "buttonGoto";
            buttonGoto.Size = new Size(160, 23);
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
            pageNumberGoto.Font = new Font("Segoe UI Semibold", 11.25F, FontStyle.Bold, GraphicsUnit.Point);
            pageNumberGoto.IntegerValue = 1L;
            pageNumberGoto.Location = new Point(0, 0);
            pageNumberGoto.Margin = new Padding(4, 3, 4, 3);
            pageNumberGoto.Name = "pageNumberGoto";
            pageNumberGoto.Size = new Size(160, 27);
            pageNumberGoto.TabIndex = 7;
            pageNumberGoto.Text = "1";
            pageNumberGoto.TextAlign = HorizontalAlignment.Center;
            // 
            // WareHouse
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(41, 44, 51);
            ClientSize = new Size(1080, 474);
            Controls.Add(tableLayoutPanel1);
            Margin = new Padding(4, 3, 4, 3);
            Name = "WareHouse";
            Text = "FormInventoryManagement";
            Load += WareHouse_Load;
            panel45.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)inputNumPageGo).EndInit();
            panel2.ResumeLayout(false);
            panelSearch.ResumeLayout(false);
            panel4.ResumeLayout(false);
            panel3.ResumeLayout(false);
            panel5.ResumeLayout(false);
            tableLayoutPanel1.ResumeLayout(false);
            panelForm.ResumeLayout(false);
            panelMain.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            tableLayoutPanel5.ResumeLayout(false);
            tableLayoutPanel7.ResumeLayout(false);
            panel52.ResumeLayout(false);
            panel53.ResumeLayout(false);
            panel47.ResumeLayout(false);
            panel47.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pageNumberGoto).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private Panel panel45;
        private LW_PhanMemBaoGia.MyControls.ButtonCustom buttonPage;
        private LW_PhanMemBaoGia.MyControls.ButtonCustom buttonNextPage;
        private LW_PhanMemBaoGia.MyControls.ButtonCustom buttonPreviousPage;
        private LW_PhanMemBaoGia.MyControls.ButtonCustom buttonCustomGoPage;
        private Syncfusion.Windows.Forms.Tools.IntegerTextBox inputNumPageGo;
        private Panel panel2;
        private Label label29;
        private Panel panelSearch;
        private Panel panel3;
        private LW_PhanMemBaoGia.MyControls.TextBoxT textBoxSearchPO;
        private LW_PhanMemBaoGia.MyControls.ButtonCustom buttonCustomLoc;
        private Panel panel5;
        private Label label1;
        private TableLayoutPanel tableLayoutPanel1;
        private Panel panelForm;
        private Panel panelMain;
        private Panel panel1;
        private TableLayoutPanel tableLayoutPanel5;
        private TableLayoutPanel tableLayoutPanel7;
        private Panel panel52;
        private Label label22;
        private Panel panel53;
        private Label lbTotalPages;
        private Panel panel47;
        private LW_PhanMemBaoGia.MyControls.ButtonCustom buttonGoto;
        private Syncfusion.Windows.Forms.Tools.IntegerTextBox pageNumberGoto;
        private DataGridView dataGridView1;
        private Panel panel4;
        private LW_PhanMemBaoGia.MyControls.TextBoxT textBoxSearchProduct;
        private LW_PhanMemBaoGia.MyControls.ButtonCustom buttonCustom1;
    }
}