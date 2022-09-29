namespace ManagementSoftware.GUI
{
    partial class PurchaseOrder
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(PurchaseOrder));
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.panel2 = new System.Windows.Forms.Panel();
            this.panel1 = new System.Windows.Forms.Panel();
            this.buttonProcess = new LW_PhanMemBaoGia.MyControls.ButtonCustom();
            this.buttonPurchaseOrder = new LW_PhanMemBaoGia.MyControls.ButtonCustom();
            this.tableLayoutPanel1.SuspendLayout();
            this.panel2.SuspendLayout();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.ColumnCount = 2;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 49.99999F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50.00001F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tableLayoutPanel1.Controls.Add(this.panel2, 1, 0);
            this.tableLayoutPanel1.Controls.Add(this.panel1, 0, 0);
            this.tableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel1.Location = new System.Drawing.Point(0, 0);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 1;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(1299, 566);
            this.tableLayoutPanel1.TabIndex = 16;
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.buttonProcess);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel2.Location = new System.Drawing.Point(652, 3);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(644, 560);
            this.panel2.TabIndex = 1;
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.buttonPurchaseOrder);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel1.Location = new System.Drawing.Point(3, 3);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(643, 560);
            this.panel1.TabIndex = 0;
            // 
            // buttonProcess
            // 
            this.buttonProcess.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(41)))), ((int)(((byte)(44)))), ((int)(((byte)(51)))));
            this.buttonProcess.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(41)))), ((int)(((byte)(44)))), ((int)(((byte)(51)))));
            this.buttonProcess.BorderColor = System.Drawing.Color.PaleVioletRed;
            this.buttonProcess.BorderRadius = 15;
            this.buttonProcess.BorderSize = 0;
            this.buttonProcess.Cursor = System.Windows.Forms.Cursors.Hand;
            this.buttonProcess.Dock = System.Windows.Forms.DockStyle.Fill;
            this.buttonProcess.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonProcess.Font = new System.Drawing.Font("Segoe UI Semibold", 21.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonProcess.ForeColor = System.Drawing.Color.White;
            this.buttonProcess.Image = ((System.Drawing.Image)(resources.GetObject("buttonProcess.Image")));
            this.buttonProcess.ImageAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.buttonProcess.Location = new System.Drawing.Point(0, 0);
            this.buttonProcess.Name = "buttonProcess";
            this.buttonProcess.Size = new System.Drawing.Size(644, 560);
            this.buttonProcess.TabIndex = 21;
            this.buttonProcess.Text = "Tiến trình sản xuất";
            this.buttonProcess.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            this.buttonProcess.TextColor = System.Drawing.Color.White;
            this.buttonProcess.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.buttonProcess.UseVisualStyleBackColor = false;
            // 
            // buttonPurchaseOrder
            // 
            this.buttonPurchaseOrder.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(41)))), ((int)(((byte)(44)))), ((int)(((byte)(51)))));
            this.buttonPurchaseOrder.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(41)))), ((int)(((byte)(44)))), ((int)(((byte)(51)))));
            this.buttonPurchaseOrder.BorderColor = System.Drawing.Color.PaleVioletRed;
            this.buttonPurchaseOrder.BorderRadius = 15;
            this.buttonPurchaseOrder.BorderSize = 0;
            this.buttonPurchaseOrder.Cursor = System.Windows.Forms.Cursors.Hand;
            this.buttonPurchaseOrder.Dock = System.Windows.Forms.DockStyle.Fill;
            this.buttonPurchaseOrder.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonPurchaseOrder.Font = new System.Drawing.Font("Segoe UI Semibold", 21.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonPurchaseOrder.ForeColor = System.Drawing.Color.White;
            this.buttonPurchaseOrder.Image = ((System.Drawing.Image)(resources.GetObject("buttonPurchaseOrder.Image")));
            this.buttonPurchaseOrder.ImageAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.buttonPurchaseOrder.Location = new System.Drawing.Point(0, 0);
            this.buttonPurchaseOrder.Name = "buttonPurchaseOrder";
            this.buttonPurchaseOrder.Size = new System.Drawing.Size(643, 560);
            this.buttonPurchaseOrder.TabIndex = 19;
            this.buttonPurchaseOrder.Text = "Đơn hàng";
            this.buttonPurchaseOrder.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            this.buttonPurchaseOrder.TextColor = System.Drawing.Color.White;
            this.buttonPurchaseOrder.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.buttonPurchaseOrder.UseVisualStyleBackColor = false;
            // 
            // FormOrderPurchaseManagement
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1299, 566);
            this.Controls.Add(this.tableLayoutPanel1);
            this.Name = "FormOrderPurchaseManagement";
            this.Text = "FormOrderPurchaseManagement";
            this.tableLayoutPanel1.ResumeLayout(false);
            this.panel2.ResumeLayout(false);
            this.panel1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.Panel panel2;
        private LW_PhanMemBaoGia.MyControls.ButtonCustom buttonProcess;
        private System.Windows.Forms.Panel panel1;
        private LW_PhanMemBaoGia.MyControls.ButtonCustom buttonPurchaseOrder;
    }
}