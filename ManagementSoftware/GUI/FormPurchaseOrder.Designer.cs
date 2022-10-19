namespace ManagementSoftware.GUI
{
    partial class FormPurchaseOrder
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormPurchaseOrder));
            this.addPO = new Syncfusion.WinForms.Controls.SfButton();
            this.panel2 = new System.Windows.Forms.Panel();
            this.buttonPageNext = new LW_PhanMemBaoGia.MyControls.ButtonCustom();
            this.buttonPage3 = new LW_PhanMemBaoGia.MyControls.ButtonCustom();
            this.buttonPage1 = new LW_PhanMemBaoGia.MyControls.ButtonCustom();
            this.buttonPage2 = new LW_PhanMemBaoGia.MyControls.ButtonCustom();
            this.panel1 = new System.Windows.Forms.Panel();
            this.panel4 = new System.Windows.Forms.Panel();
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.panel5 = new System.Windows.Forms.Panel();
            this.textBoxSearchPO = new LW_PhanMemBaoGia.MyControls.TextBoxT();
            this.buttonCustom3 = new LW_PhanMemBaoGia.MyControls.ButtonCustom();
            this.panel2Button = new System.Windows.Forms.Panel();
            this.buttonNotDone = new LW_PhanMemBaoGia.MyControls.ButtonCustom();
            this.buttonDone = new LW_PhanMemBaoGia.MyControls.ButtonCustom();
            this.buttonAll = new LW_PhanMemBaoGia.MyControls.ButtonCustom();
            this.panelMain = new System.Windows.Forms.Panel();
            this.gridLayout1 = new Syncfusion.Windows.Forms.Tools.GridLayout(this.components);
            this.panel2.SuspendLayout();
            this.panel1.SuspendLayout();
            this.panel4.SuspendLayout();
            this.tableLayoutPanel1.SuspendLayout();
            this.panel5.SuspendLayout();
            this.panel2Button.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.gridLayout1)).BeginInit();
            this.SuspendLayout();
            // 
            // addPO
            // 
            this.addPO.AccessibleName = "Button";
            this.addPO.BackColor = System.Drawing.SystemColors.Highlight;
            this.addPO.Cursor = System.Windows.Forms.Cursors.Hand;
            this.addPO.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.addPO.Font = new System.Drawing.Font("Segoe UI Semibold", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.addPO.ForeColor = System.Drawing.SystemColors.Control;
            this.addPO.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.addPO.Location = new System.Drawing.Point(0, 376);
            this.addPO.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.addPO.MaximumSize = new System.Drawing.Size(0, 69);
            this.addPO.Name = "addPO";
            this.addPO.Size = new System.Drawing.Size(1101, 55);
            this.addPO.Style.BackColor = System.Drawing.SystemColors.Highlight;
            this.addPO.Style.ForeColor = System.Drawing.SystemColors.Control;
            this.addPO.TabIndex = 0;
            this.addPO.Text = "Nhập đơn hàng";
            this.addPO.TextImageRelation = System.Windows.Forms.TextImageRelation.TextBeforeImage;
            this.addPO.UseVisualStyleBackColor = false;
            this.addPO.Click += new System.EventHandler(this.addPO_Click);
            // 
            // panel2
            // 
            this.panel2.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel2.Controls.Add(this.buttonPageNext);
            this.panel2.Controls.Add(this.buttonPage3);
            this.panel2.Controls.Add(this.buttonPage1);
            this.panel2.Controls.Add(this.buttonPage2);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panel2.Location = new System.Drawing.Point(0, 320);
            this.panel2.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(1101, 56);
            this.panel2.TabIndex = 1;
            // 
            // buttonPageNext
            // 
            this.buttonPageNext.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.buttonPageNext.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.buttonPageNext.BackgroundColor = System.Drawing.SystemColors.ActiveCaption;
            this.buttonPageNext.BorderColor = System.Drawing.Color.PaleVioletRed;
            this.buttonPageNext.BorderRadius = 3;
            this.buttonPageNext.BorderSize = 0;
            this.buttonPageNext.Cursor = System.Windows.Forms.Cursors.Hand;
            this.buttonPageNext.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonPageNext.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.buttonPageNext.ForeColor = System.Drawing.Color.Black;
            this.buttonPageNext.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.buttonPageNext.Location = new System.Drawing.Point(244, 9);
            this.buttonPageNext.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.buttonPageNext.Name = "buttonPageNext";
            this.buttonPageNext.Size = new System.Drawing.Size(74, 35);
            this.buttonPageNext.TabIndex = 28;
            this.buttonPageNext.Text = ">>";
            this.buttonPageNext.TextColor = System.Drawing.Color.Black;
            this.buttonPageNext.TextImageRelation = System.Windows.Forms.TextImageRelation.TextBeforeImage;
            this.buttonPageNext.UseVisualStyleBackColor = false;
            this.buttonPageNext.Click += new System.EventHandler(this.buttonPageNext_Click);
            // 
            // buttonPage3
            // 
            this.buttonPage3.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.buttonPage3.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.buttonPage3.BackgroundColor = System.Drawing.SystemColors.ActiveCaption;
            this.buttonPage3.BorderColor = System.Drawing.Color.PaleVioletRed;
            this.buttonPage3.BorderRadius = 3;
            this.buttonPage3.BorderSize = 0;
            this.buttonPage3.Cursor = System.Windows.Forms.Cursors.Hand;
            this.buttonPage3.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonPage3.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.buttonPage3.ForeColor = System.Drawing.Color.Black;
            this.buttonPage3.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.buttonPage3.Location = new System.Drawing.Point(163, 9);
            this.buttonPage3.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.buttonPage3.Name = "buttonPage3";
            this.buttonPage3.Size = new System.Drawing.Size(74, 35);
            this.buttonPage3.TabIndex = 27;
            this.buttonPage3.Text = "3";
            this.buttonPage3.TextColor = System.Drawing.Color.Black;
            this.buttonPage3.TextImageRelation = System.Windows.Forms.TextImageRelation.TextBeforeImage;
            this.buttonPage3.UseVisualStyleBackColor = false;
            this.buttonPage3.Click += new System.EventHandler(this.buttonPage1_Click);
            // 
            // buttonPage1
            // 
            this.buttonPage1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.buttonPage1.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.buttonPage1.BackgroundColor = System.Drawing.SystemColors.ActiveCaption;
            this.buttonPage1.BorderColor = System.Drawing.Color.PaleVioletRed;
            this.buttonPage1.BorderRadius = 3;
            this.buttonPage1.BorderSize = 0;
            this.buttonPage1.Cursor = System.Windows.Forms.Cursors.Hand;
            this.buttonPage1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonPage1.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.buttonPage1.ForeColor = System.Drawing.Color.Black;
            this.buttonPage1.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.buttonPage1.Location = new System.Drawing.Point(4, 9);
            this.buttonPage1.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.buttonPage1.Name = "buttonPage1";
            this.buttonPage1.Size = new System.Drawing.Size(74, 35);
            this.buttonPage1.TabIndex = 26;
            this.buttonPage1.Text = "1";
            this.buttonPage1.TextColor = System.Drawing.Color.Black;
            this.buttonPage1.TextImageRelation = System.Windows.Forms.TextImageRelation.TextBeforeImage;
            this.buttonPage1.UseVisualStyleBackColor = false;
            this.buttonPage1.Click += new System.EventHandler(this.buttonPage1_Click);
            // 
            // buttonPage2
            // 
            this.buttonPage2.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.buttonPage2.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.buttonPage2.BackgroundColor = System.Drawing.SystemColors.ActiveCaption;
            this.buttonPage2.BorderColor = System.Drawing.Color.PaleVioletRed;
            this.buttonPage2.BorderRadius = 3;
            this.buttonPage2.BorderSize = 0;
            this.buttonPage2.Cursor = System.Windows.Forms.Cursors.Hand;
            this.buttonPage2.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonPage2.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.buttonPage2.ForeColor = System.Drawing.Color.Black;
            this.buttonPage2.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.buttonPage2.Location = new System.Drawing.Point(83, 9);
            this.buttonPage2.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.buttonPage2.Name = "buttonPage2";
            this.buttonPage2.Size = new System.Drawing.Size(74, 35);
            this.buttonPage2.TabIndex = 25;
            this.buttonPage2.Text = "2";
            this.buttonPage2.TextColor = System.Drawing.Color.Black;
            this.buttonPage2.TextImageRelation = System.Windows.Forms.TextImageRelation.TextBeforeImage;
            this.buttonPage2.UseVisualStyleBackColor = false;
            this.buttonPage2.Click += new System.EventHandler(this.buttonPage1_Click);
            // 
            // panel1
            // 
            this.panel1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel1.Controls.Add(this.panel4);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1101, 48);
            this.panel1.TabIndex = 2;
            // 
            // panel4
            // 
            this.panel4.Controls.Add(this.tableLayoutPanel1);
            this.panel4.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel4.Location = new System.Drawing.Point(0, 0);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(1099, 46);
            this.panel4.TabIndex = 1;
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.ColumnCount = 2;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 60F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 40F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tableLayoutPanel1.Controls.Add(this.panel5, 1, 0);
            this.tableLayoutPanel1.Controls.Add(this.panel2Button, 0, 0);
            this.tableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel1.Location = new System.Drawing.Point(0, 0);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 1;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(1099, 46);
            this.tableLayoutPanel1.TabIndex = 0;
            // 
            // panel5
            // 
            this.panel5.Controls.Add(this.textBoxSearchPO);
            this.panel5.Controls.Add(this.buttonCustom3);
            this.panel5.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel5.Location = new System.Drawing.Point(662, 3);
            this.panel5.Name = "panel5";
            this.panel5.Size = new System.Drawing.Size(434, 40);
            this.panel5.TabIndex = 1;
            // 
            // textBoxSearchPO
            // 
            this.textBoxSearchPO.BackColor = System.Drawing.SystemColors.Window;
            this.textBoxSearchPO.BorderColor = System.Drawing.Color.CornflowerBlue;
            this.textBoxSearchPO.BorderFocusColor = System.Drawing.SystemColors.ActiveCaption;
            this.textBoxSearchPO.BorderRadius = 5;
            this.textBoxSearchPO.BorderSize = 1;
            this.textBoxSearchPO.Dock = System.Windows.Forms.DockStyle.Fill;
            this.textBoxSearchPO.Font = new System.Drawing.Font("Segoe UI", 12.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.textBoxSearchPO.Location = new System.Drawing.Point(0, 0);
            this.textBoxSearchPO.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.textBoxSearchPO.Multiline = false;
            this.textBoxSearchPO.Name = "textBoxSearchPO";
            this.textBoxSearchPO.Padding = new System.Windows.Forms.Padding(8, 9, 8, 6);
            this.textBoxSearchPO.PasswordChar = false;
            this.textBoxSearchPO.PlaceholderColor = System.Drawing.Color.DarkGray;
            this.textBoxSearchPO.PlaceholderText = "Nhập mã đơn hàng";
            this.textBoxSearchPO.Size = new System.Drawing.Size(318, 39);
            this.textBoxSearchPO.TabIndex = 29;
            this.textBoxSearchPO.Texts = "Nhập mã đơn hàng";
            this.textBoxSearchPO.UnderlinedStyle = false;
            // 
            // buttonCustom3
            // 
            this.buttonCustom3.BackColor = System.Drawing.Color.LightSkyBlue;
            this.buttonCustom3.BackgroundColor = System.Drawing.Color.LightSkyBlue;
            this.buttonCustom3.BorderColor = System.Drawing.Color.PaleVioletRed;
            this.buttonCustom3.BorderRadius = 3;
            this.buttonCustom3.BorderSize = 0;
            this.buttonCustom3.Cursor = System.Windows.Forms.Cursors.Hand;
            this.buttonCustom3.Dock = System.Windows.Forms.DockStyle.Right;
            this.buttonCustom3.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonCustom3.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.buttonCustom3.ForeColor = System.Drawing.Color.Black;
            this.buttonCustom3.Image = ((System.Drawing.Image)(resources.GetObject("buttonCustom3.Image")));
            this.buttonCustom3.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.buttonCustom3.Location = new System.Drawing.Point(318, 0);
            this.buttonCustom3.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.buttonCustom3.Name = "buttonCustom3";
            this.buttonCustom3.Size = new System.Drawing.Size(116, 40);
            this.buttonCustom3.TabIndex = 24;
            this.buttonCustom3.Text = "Lọc";
            this.buttonCustom3.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.buttonCustom3.TextColor = System.Drawing.Color.Black;
            this.buttonCustom3.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.buttonCustom3.UseVisualStyleBackColor = false;
            this.buttonCustom3.Click += new System.EventHandler(this.buttonCustom3_Click);
            // 
            // panel2Button
            // 
            this.panel2Button.Controls.Add(this.buttonNotDone);
            this.panel2Button.Controls.Add(this.buttonDone);
            this.panel2Button.Controls.Add(this.buttonAll);
            this.panel2Button.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel2Button.Location = new System.Drawing.Point(3, 3);
            this.panel2Button.Name = "panel2Button";
            this.panel2Button.Size = new System.Drawing.Size(653, 40);
            this.panel2Button.TabIndex = 2;
            // 
            // buttonNotDone
            // 
            this.buttonNotDone.BackColor = System.Drawing.Color.Goldenrod;
            this.buttonNotDone.BackgroundColor = System.Drawing.Color.Goldenrod;
            this.buttonNotDone.BorderColor = System.Drawing.Color.PaleVioletRed;
            this.buttonNotDone.BorderRadius = 3;
            this.buttonNotDone.BorderSize = 0;
            this.buttonNotDone.Cursor = System.Windows.Forms.Cursors.Hand;
            this.buttonNotDone.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonNotDone.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.buttonNotDone.ForeColor = System.Drawing.Color.White;
            this.buttonNotDone.Image = ((System.Drawing.Image)(resources.GetObject("buttonNotDone.Image")));
            this.buttonNotDone.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.buttonNotDone.Location = new System.Drawing.Point(1, 0);
            this.buttonNotDone.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.buttonNotDone.Name = "buttonNotDone";
            this.gridLayout1.SetParticipateInLayout(this.buttonNotDone, true);
            this.buttonNotDone.Size = new System.Drawing.Size(217, 40);
            this.buttonNotDone.TabIndex = 28;
            this.buttonNotDone.Text = "Chưa hoàn thành";
            this.buttonNotDone.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.buttonNotDone.TextColor = System.Drawing.Color.White;
            this.buttonNotDone.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.buttonNotDone.UseVisualStyleBackColor = false;
            this.buttonNotDone.Click += new System.EventHandler(this.buttonNotDone_Click);
            // 
            // buttonDone
            // 
            this.buttonDone.BackColor = System.Drawing.Color.Green;
            this.buttonDone.BackgroundColor = System.Drawing.Color.Green;
            this.buttonDone.BorderColor = System.Drawing.Color.PaleVioletRed;
            this.buttonDone.BorderRadius = 3;
            this.buttonDone.BorderSize = 0;
            this.buttonDone.Cursor = System.Windows.Forms.Cursors.Hand;
            this.buttonDone.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonDone.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.buttonDone.ForeColor = System.Drawing.Color.White;
            this.buttonDone.Image = ((System.Drawing.Image)(resources.GetObject("buttonDone.Image")));
            this.buttonDone.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.buttonDone.Location = new System.Drawing.Point(218, 0);
            this.buttonDone.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.buttonDone.Name = "buttonDone";
            this.gridLayout1.SetParticipateInLayout(this.buttonDone, true);
            this.buttonDone.Size = new System.Drawing.Size(217, 40);
            this.buttonDone.TabIndex = 30;
            this.buttonDone.Text = "Đã hoàn thành";
            this.buttonDone.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.buttonDone.TextColor = System.Drawing.Color.White;
            this.buttonDone.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.buttonDone.UseVisualStyleBackColor = false;
            this.buttonDone.Click += new System.EventHandler(this.buttonDone_Click);
            // 
            // buttonAll
            // 
            this.buttonAll.BackColor = System.Drawing.SystemColors.HotTrack;
            this.buttonAll.BackgroundColor = System.Drawing.SystemColors.HotTrack;
            this.buttonAll.BorderColor = System.Drawing.Color.PaleVioletRed;
            this.buttonAll.BorderRadius = 3;
            this.buttonAll.BorderSize = 0;
            this.buttonAll.Cursor = System.Windows.Forms.Cursors.Hand;
            this.buttonAll.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonAll.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.buttonAll.ForeColor = System.Drawing.Color.White;
            this.buttonAll.Image = ((System.Drawing.Image)(resources.GetObject("buttonAll.Image")));
            this.buttonAll.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.buttonAll.Location = new System.Drawing.Point(435, 0);
            this.buttonAll.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.buttonAll.Name = "buttonAll";
            this.gridLayout1.SetParticipateInLayout(this.buttonAll, true);
            this.buttonAll.Size = new System.Drawing.Size(217, 40);
            this.buttonAll.TabIndex = 29;
            this.buttonAll.Text = "Tất cả";
            this.buttonAll.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.buttonAll.TextColor = System.Drawing.Color.White;
            this.buttonAll.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.buttonAll.UseVisualStyleBackColor = false;
            this.buttonAll.Click += new System.EventHandler(this.buttonAll_Click);
            // 
            // panelMain
            // 
            this.panelMain.AutoScroll = true;
            this.panelMain.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panelMain.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panelMain.Location = new System.Drawing.Point(0, 48);
            this.panelMain.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.panelMain.Name = "panelMain";
            this.panelMain.Padding = new System.Windows.Forms.Padding(0, 5, 0, 5);
            this.panelMain.Size = new System.Drawing.Size(1101, 272);
            this.panelMain.TabIndex = 3;
            // 
            // gridLayout1
            // 
            this.gridLayout1.Columns = 3;
            this.gridLayout1.ContainerControl = this.panel2Button;
            this.gridLayout1.Rows = 1;
            // 
            // FormPurchaseOrder
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(41)))), ((int)(((byte)(44)))), ((int)(((byte)(51)))));
            this.ClientSize = new System.Drawing.Size(1101, 431);
            this.Controls.Add(this.panelMain);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.addPO);
            this.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.Name = "FormPurchaseOrder";
            this.Text = "PurchaseOrder";
            this.panel2.ResumeLayout(false);
            this.panel1.ResumeLayout(false);
            this.panel4.ResumeLayout(false);
            this.tableLayoutPanel1.ResumeLayout(false);
            this.panel5.ResumeLayout(false);
            this.panel2Button.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.gridLayout1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private Syncfusion.WinForms.Controls.SfButton addPO;
        private System.Windows.Forms.Panel panel2;
        private LW_PhanMemBaoGia.MyControls.ButtonCustom buttonPageNext;
        private LW_PhanMemBaoGia.MyControls.ButtonCustom buttonPage3;
        private LW_PhanMemBaoGia.MyControls.ButtonCustom buttonPage1;
        private LW_PhanMemBaoGia.MyControls.ButtonCustom buttonPage2;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panelMain;
        private Syncfusion.Windows.Forms.Tools.GridLayout gridLayout1;
        private Panel panel4;
        private TableLayoutPanel tableLayoutPanel1;
        private Panel panel5;
        private LW_PhanMemBaoGia.MyControls.TextBoxT textBoxSearchPO;
        private LW_PhanMemBaoGia.MyControls.ButtonCustom buttonCustom3;
        private Panel panel2Button;
        private LW_PhanMemBaoGia.MyControls.ButtonCustom buttonNotDone;
        private LW_PhanMemBaoGia.MyControls.ButtonCustom buttonAll;
        private LW_PhanMemBaoGia.MyControls.ButtonCustom buttonDone;
    }
}