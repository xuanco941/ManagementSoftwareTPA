namespace ManagementSoftware.GUI.ResultManagement
{
    partial class FormData
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormData));
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            this.panelSearchData = new System.Windows.Forms.Panel();
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.panel1 = new System.Windows.Forms.Panel();
            this.buttonUpdate = new LW_PhanMemBaoGia.MyControls.ButtonCustom();
            this.label1 = new System.Windows.Forms.Label();
            this.textBoxIDResult = new LW_PhanMemBaoGia.MyControls.TextBoxT();
            this.buttonViewDetsil = new LW_PhanMemBaoGia.MyControls.ButtonCustom();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.labelLuuLuongTB = new System.Windows.Forms.Label();
            this.labelTheTichTB = new System.Windows.Forms.Label();
            this.labelApSuatTB = new System.Windows.Forms.Label();
            this.labelStatus = new System.Windows.Forms.Label();
            this.labelMaMe = new System.Windows.Forms.Label();
            this.labelFullNameUser = new System.Windows.Forms.Label();
            this.labelMachine = new System.Windows.Forms.Label();
            this.labelNgayKetThuc = new System.Windows.Forms.Label();
            this.labelNgayBatDau = new System.Windows.Forms.Label();
            this.dataGridViewSearchData = new System.Windows.Forms.DataGridView();
            this.toolTip1 = new System.Windows.Forms.ToolTip(this.components);
            this.panelSearchData.SuspendLayout();
            this.tableLayoutPanel1.SuspendLayout();
            this.panel1.SuspendLayout();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewSearchData)).BeginInit();
            this.SuspendLayout();
            // 
            // panelSearchData
            // 
            this.panelSearchData.AutoScroll = true;
            this.panelSearchData.Controls.Add(this.tableLayoutPanel1);
            this.panelSearchData.Dock = System.Windows.Forms.DockStyle.Right;
            this.panelSearchData.Location = new System.Drawing.Point(802, 0);
            this.panelSearchData.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.panelSearchData.Name = "panelSearchData";
            this.panelSearchData.Size = new System.Drawing.Size(277, 612);
            this.panelSearchData.TabIndex = 2;
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.CellBorderStyle = System.Windows.Forms.TableLayoutPanelCellBorderStyle.Single;
            this.tableLayoutPanel1.ColumnCount = 1;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel1.Controls.Add(this.panel1, 0, 1);
            this.tableLayoutPanel1.Controls.Add(this.groupBox1, 0, 0);
            this.tableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel1.Location = new System.Drawing.Point(0, 0);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 2;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 270F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(277, 612);
            this.tableLayoutPanel1.TabIndex = 55;
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.LightGray;
            this.panel1.Controls.Add(this.buttonUpdate);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Controls.Add(this.textBoxIDResult);
            this.panel1.Controls.Add(this.buttonViewDetsil);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel1.Location = new System.Drawing.Point(4, 344);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(269, 264);
            this.panel1.TabIndex = 57;
            // 
            // buttonUpdate
            // 
            this.buttonUpdate.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.buttonUpdate.BackColor = System.Drawing.Color.Goldenrod;
            this.buttonUpdate.BackgroundColor = System.Drawing.Color.Goldenrod;
            this.buttonUpdate.BorderColor = System.Drawing.Color.PaleVioletRed;
            this.buttonUpdate.BorderRadius = 3;
            this.buttonUpdate.BorderSize = 0;
            this.buttonUpdate.Cursor = System.Windows.Forms.Cursors.Hand;
            this.buttonUpdate.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonUpdate.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Bold);
            this.buttonUpdate.ForeColor = System.Drawing.Color.Black;
            this.buttonUpdate.Image = ((System.Drawing.Image)(resources.GetObject("buttonUpdate.Image")));
            this.buttonUpdate.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.buttonUpdate.Location = new System.Drawing.Point(72, 152);
            this.buttonUpdate.Name = "buttonUpdate";
            this.buttonUpdate.Size = new System.Drawing.Size(132, 40);
            this.buttonUpdate.TabIndex = 54;
            this.buttonUpdate.Text = "Cập nhật";
            this.buttonUpdate.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.buttonUpdate.TextColor = System.Drawing.Color.Black;
            this.buttonUpdate.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.toolTip1.SetToolTip(this.buttonUpdate, "Cập nhật thống kê  dữ liệu từ đầu mẻ nạp tới thời điểm hiện tại dù chưa kết thúc " +
        "mẻ nạp.");
            this.buttonUpdate.UseVisualStyleBackColor = false;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI Semibold", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(62)))), ((int)(((byte)(120)))), ((int)(((byte)(138)))));
            this.label1.Location = new System.Drawing.Point(37, 28);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(73, 15);
            this.label1.TabIndex = 53;
            this.label1.Text = "Mã mẻ nạp :";
            // 
            // textBoxIDResult
            // 
            this.textBoxIDResult.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.textBoxIDResult.BackColor = System.Drawing.SystemColors.Window;
            this.textBoxIDResult.BorderColor = System.Drawing.Color.CornflowerBlue;
            this.textBoxIDResult.BorderFocusColor = System.Drawing.SystemColors.ActiveCaption;
            this.textBoxIDResult.BorderRadius = 5;
            this.textBoxIDResult.BorderSize = 1;
            this.textBoxIDResult.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBoxIDResult.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(62)))), ((int)(((byte)(120)))), ((int)(((byte)(138)))));
            this.textBoxIDResult.Location = new System.Drawing.Point(37, 47);
            this.textBoxIDResult.Multiline = false;
            this.textBoxIDResult.Name = "textBoxIDResult";
            this.textBoxIDResult.Padding = new System.Windows.Forms.Padding(7);
            this.textBoxIDResult.PasswordChar = false;
            this.textBoxIDResult.PlaceholderColor = System.Drawing.Color.DarkGray;
            this.textBoxIDResult.PlaceholderText = "Nhập mã mẻ . . .";
            this.textBoxIDResult.Size = new System.Drawing.Size(202, 35);
            this.textBoxIDResult.TabIndex = 51;
            this.textBoxIDResult.Texts = "Nhập mã mẻ . . .";
            this.textBoxIDResult.UnderlinedStyle = false;
            // 
            // buttonViewDetsil
            // 
            this.buttonViewDetsil.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.buttonViewDetsil.BackColor = System.Drawing.Color.LightSkyBlue;
            this.buttonViewDetsil.BackgroundColor = System.Drawing.Color.LightSkyBlue;
            this.buttonViewDetsil.BorderColor = System.Drawing.Color.PaleVioletRed;
            this.buttonViewDetsil.BorderRadius = 3;
            this.buttonViewDetsil.BorderSize = 0;
            this.buttonViewDetsil.Cursor = System.Windows.Forms.Cursors.Hand;
            this.buttonViewDetsil.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonViewDetsil.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Bold);
            this.buttonViewDetsil.ForeColor = System.Drawing.Color.Black;
            this.buttonViewDetsil.Image = ((System.Drawing.Image)(resources.GetObject("buttonViewDetsil.Image")));
            this.buttonViewDetsil.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.buttonViewDetsil.Location = new System.Drawing.Point(72, 98);
            this.buttonViewDetsil.Name = "buttonViewDetsil";
            this.buttonViewDetsil.Size = new System.Drawing.Size(132, 40);
            this.buttonViewDetsil.TabIndex = 52;
            this.buttonViewDetsil.Text = "Xem chi tiết";
            this.buttonViewDetsil.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.buttonViewDetsil.TextColor = System.Drawing.Color.Black;
            this.buttonViewDetsil.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.buttonViewDetsil.UseVisualStyleBackColor = false;
            // 
            // groupBox1
            // 
            this.groupBox1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(41)))), ((int)(((byte)(44)))), ((int)(((byte)(51)))));
            this.groupBox1.Controls.Add(this.labelLuuLuongTB);
            this.groupBox1.Controls.Add(this.labelTheTichTB);
            this.groupBox1.Controls.Add(this.labelApSuatTB);
            this.groupBox1.Controls.Add(this.labelStatus);
            this.groupBox1.Controls.Add(this.labelMaMe);
            this.groupBox1.Controls.Add(this.labelFullNameUser);
            this.groupBox1.Controls.Add(this.labelMachine);
            this.groupBox1.Controls.Add(this.labelNgayKetThuc);
            this.groupBox1.Controls.Add(this.labelNgayBatDau);
            this.groupBox1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.groupBox1.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox1.ForeColor = System.Drawing.Color.LightGray;
            this.groupBox1.Location = new System.Drawing.Point(4, 4);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(269, 333);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Thông tin";
            // 
            // labelLuuLuongTB
            // 
            this.labelLuuLuongTB.AutoSize = true;
            this.labelLuuLuongTB.Font = new System.Drawing.Font("Segoe UI Semibold", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelLuuLuongTB.ForeColor = System.Drawing.Color.LightGray;
            this.labelLuuLuongTB.Location = new System.Drawing.Point(5, 235);
            this.labelLuuLuongTB.Name = "labelLuuLuongTB";
            this.labelLuuLuongTB.Size = new System.Drawing.Size(158, 17);
            this.labelLuuLuongTB.TabIndex = 9;
            this.labelLuuLuongTB.Text = "- Lưu lượng trung bình : ";
            // 
            // labelTheTichTB
            // 
            this.labelTheTichTB.AutoSize = true;
            this.labelTheTichTB.Font = new System.Drawing.Font("Segoe UI Semibold", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelTheTichTB.ForeColor = System.Drawing.Color.LightGray;
            this.labelTheTichTB.Location = new System.Drawing.Point(5, 205);
            this.labelTheTichTB.Name = "labelTheTichTB";
            this.labelTheTichTB.Size = new System.Drawing.Size(145, 17);
            this.labelTheTichTB.TabIndex = 8;
            this.labelTheTichTB.Text = "- Thể tích trung bình : ";
            // 
            // labelApSuatTB
            // 
            this.labelApSuatTB.AutoSize = true;
            this.labelApSuatTB.Font = new System.Drawing.Font("Segoe UI Semibold", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelApSuatTB.ForeColor = System.Drawing.Color.LightGray;
            this.labelApSuatTB.Location = new System.Drawing.Point(5, 175);
            this.labelApSuatTB.Name = "labelApSuatTB";
            this.labelApSuatTB.Size = new System.Drawing.Size(144, 17);
            this.labelApSuatTB.TabIndex = 7;
            this.labelApSuatTB.Text = "- Áp suất trung bình : ";
            // 
            // labelStatus
            // 
            this.labelStatus.AutoSize = true;
            this.labelStatus.Font = new System.Drawing.Font("Segoe UI Semibold", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelStatus.ForeColor = System.Drawing.Color.LightGray;
            this.labelStatus.Location = new System.Drawing.Point(5, 265);
            this.labelStatus.Name = "labelStatus";
            this.labelStatus.Size = new System.Drawing.Size(89, 17);
            this.labelStatus.TabIndex = 6;
            this.labelStatus.Text = "- Trạng thái : ";
            // 
            // labelMaMe
            // 
            this.labelMaMe.AutoSize = true;
            this.labelMaMe.Font = new System.Drawing.Font("Segoe UI Semibold", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelMaMe.ForeColor = System.Drawing.Color.LightGray;
            this.labelMaMe.Location = new System.Drawing.Point(5, 25);
            this.labelMaMe.Name = "labelMaMe";
            this.labelMaMe.Size = new System.Drawing.Size(70, 17);
            this.labelMaMe.TabIndex = 5;
            this.labelMaMe.Text = "- Mã mẻ : ";
            // 
            // labelFullNameUser
            // 
            this.labelFullNameUser.AutoSize = true;
            this.labelFullNameUser.Font = new System.Drawing.Font("Segoe UI Semibold", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelFullNameUser.ForeColor = System.Drawing.Color.LightGray;
            this.labelFullNameUser.Location = new System.Drawing.Point(5, 85);
            this.labelFullNameUser.Name = "labelFullNameUser";
            this.labelFullNameUser.Size = new System.Drawing.Size(126, 17);
            this.labelFullNameUser.TabIndex = 4;
            this.labelFullNameUser.Text = "- Người thực hiện : ";
            // 
            // labelMachine
            // 
            this.labelMachine.AutoSize = true;
            this.labelMachine.Font = new System.Drawing.Font("Segoe UI Semibold", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelMachine.ForeColor = System.Drawing.Color.LightGray;
            this.labelMachine.Location = new System.Drawing.Point(5, 55);
            this.labelMachine.Name = "labelMachine";
            this.labelMachine.Size = new System.Drawing.Size(115, 17);
            this.labelMachine.TabIndex = 3;
            this.labelMachine.Text = "- Máy thực hiện : ";
            // 
            // labelNgayKetThuc
            // 
            this.labelNgayKetThuc.AutoSize = true;
            this.labelNgayKetThuc.Font = new System.Drawing.Font("Segoe UI Semibold", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelNgayKetThuc.ForeColor = System.Drawing.Color.LightGray;
            this.labelNgayKetThuc.Location = new System.Drawing.Point(5, 145);
            this.labelNgayKetThuc.Name = "labelNgayKetThuc";
            this.labelNgayKetThuc.Size = new System.Drawing.Size(138, 17);
            this.labelNgayKetThuc.TabIndex = 2;
            this.labelNgayKetThuc.Text = "- Thời gian kết thúc : ";
            // 
            // labelNgayBatDau
            // 
            this.labelNgayBatDau.AutoSize = true;
            this.labelNgayBatDau.Font = new System.Drawing.Font("Segoe UI Semibold", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelNgayBatDau.ForeColor = System.Drawing.Color.LightGray;
            this.labelNgayBatDau.Location = new System.Drawing.Point(5, 115);
            this.labelNgayBatDau.Name = "labelNgayBatDau";
            this.labelNgayBatDau.Size = new System.Drawing.Size(135, 17);
            this.labelNgayBatDau.TabIndex = 0;
            this.labelNgayBatDau.Text = "- Thời gian bắt đầu : ";
            // 
            // dataGridViewSearchData
            // 
            this.dataGridViewSearchData.AllowUserToAddRows = false;
            this.dataGridViewSearchData.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGridViewSearchData.BackgroundColor = System.Drawing.SystemColors.ActiveCaption;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Bahnschrift", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dataGridViewSearchData.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.dataGridViewSearchData.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewSearchData.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dataGridViewSearchData.Location = new System.Drawing.Point(0, 0);
            this.dataGridViewSearchData.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.dataGridViewSearchData.Name = "dataGridViewSearchData";
            this.dataGridViewSearchData.ReadOnly = true;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Segoe UI Semibold", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dataGridViewSearchData.RowHeadersDefaultCellStyle = dataGridViewCellStyle2;
            this.dataGridViewSearchData.RowHeadersVisible = false;
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            this.dataGridViewSearchData.RowsDefaultCellStyle = dataGridViewCellStyle3;
            this.dataGridViewSearchData.RowTemplate.Height = 25;
            this.dataGridViewSearchData.Size = new System.Drawing.Size(802, 612);
            this.dataGridViewSearchData.TabIndex = 3;
            // 
            // toolTip1
            // 
            this.toolTip1.AutoPopDelay = 6000;
            this.toolTip1.InitialDelay = 200;
            this.toolTip1.ReshowDelay = 100;
            // 
            // FormData
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(41)))), ((int)(((byte)(44)))), ((int)(((byte)(51)))));
            this.ClientSize = new System.Drawing.Size(1079, 612);
            this.Controls.Add(this.dataGridViewSearchData);
            this.Controls.Add(this.panelSearchData);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "FormData";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Dữ liệu mẻ nạp chi tiết";
            this.panelSearchData.ResumeLayout(false);
            this.tableLayoutPanel1.ResumeLayout(false);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewSearchData)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Panel panelSearchData;
        private System.Windows.Forms.DataGridView dataGridViewSearchData;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.Panel panel1;
        private LW_PhanMemBaoGia.MyControls.TextBoxT textBoxIDResult;
        private LW_PhanMemBaoGia.MyControls.ButtonCustom buttonViewDetsil;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label labelMachine;
        private System.Windows.Forms.Label labelNgayKetThuc;
        private System.Windows.Forms.Label labelNgayBatDau;
        private System.Windows.Forms.Label labelFullNameUser;
        private System.Windows.Forms.Label labelMaMe;
        private System.Windows.Forms.Label labelStatus;
        private System.Windows.Forms.Label label1;
        private LW_PhanMemBaoGia.MyControls.ButtonCustom buttonUpdate;
        private System.Windows.Forms.Label labelLuuLuongTB;
        private System.Windows.Forms.Label labelTheTichTB;
        private System.Windows.Forms.Label labelApSuatTB;
        private System.Windows.Forms.ToolTip toolTip1;
    }
}