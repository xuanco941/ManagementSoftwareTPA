namespace ManagementSoftware.GUI.ActivityManagement
{
    partial class FormChangeNumElmOnPage
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormChangeNumElmOnPage));
            this.textBoxNumElm = new LW_PhanMemBaoGia.MyControls.TextBoxT();
            this.label1 = new System.Windows.Forms.Label();
            this.buttonSaveSetting = new LW_PhanMemBaoGia.MyControls.ButtonCustom();
            this.SuspendLayout();
            // 
            // textBoxNumElm
            // 
            this.textBoxNumElm.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.textBoxNumElm.BackColor = System.Drawing.SystemColors.Window;
            this.textBoxNumElm.BorderColor = System.Drawing.Color.CornflowerBlue;
            this.textBoxNumElm.BorderFocusColor = System.Drawing.SystemColors.ActiveCaption;
            this.textBoxNumElm.BorderRadius = 5;
            this.textBoxNumElm.BorderSize = 1;
            this.textBoxNumElm.Font = new System.Drawing.Font("Segoe UI Semibold", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBoxNumElm.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(62)))), ((int)(((byte)(120)))), ((int)(((byte)(138)))));
            this.textBoxNumElm.Location = new System.Drawing.Point(82, 72);
            this.textBoxNumElm.Multiline = false;
            this.textBoxNumElm.Name = "textBoxNumElm";
            this.textBoxNumElm.Padding = new System.Windows.Forms.Padding(7);
            this.textBoxNumElm.PasswordChar = false;
            this.textBoxNumElm.PlaceholderColor = System.Drawing.Color.DarkGray;
            this.textBoxNumElm.PlaceholderText = "Nhập số . . .";
            this.textBoxNumElm.Size = new System.Drawing.Size(200, 35);
            this.textBoxNumElm.TabIndex = 51;
            this.textBoxNumElm.Texts = "Nhập số . . .";
            this.textBoxNumElm.UnderlinedStyle = false;

            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.LightGray;
            this.label1.Location = new System.Drawing.Point(79, 53);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(111, 17);
            this.label1.TabIndex = 53;
            this.label1.Text = "Số dòng hiển thị :";
            // 
            // buttonSaveSetting
            // 
            this.buttonSaveSetting.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.buttonSaveSetting.BackColor = System.Drawing.SystemColors.GradientInactiveCaption;
            this.buttonSaveSetting.BackgroundColor = System.Drawing.SystemColors.GradientInactiveCaption;
            this.buttonSaveSetting.BorderColor = System.Drawing.Color.PaleVioletRed;
            this.buttonSaveSetting.BorderRadius = 6;
            this.buttonSaveSetting.BorderSize = 0;
            this.buttonSaveSetting.Cursor = System.Windows.Forms.Cursors.Hand;
            this.buttonSaveSetting.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonSaveSetting.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonSaveSetting.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(62)))), ((int)(((byte)(120)))), ((int)(((byte)(138)))));
            this.buttonSaveSetting.Image = ((System.Drawing.Image)(resources.GetObject("buttonSaveSetting.Image")));
            this.buttonSaveSetting.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.buttonSaveSetting.Location = new System.Drawing.Point(288, 72);
            this.buttonSaveSetting.Name = "buttonSaveSetting";
            this.buttonSaveSetting.Size = new System.Drawing.Size(74, 35);
            this.buttonSaveSetting.TabIndex = 52;
            this.buttonSaveSetting.Text = "Lưu";
            this.buttonSaveSetting.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.buttonSaveSetting.TextColor = System.Drawing.Color.FromArgb(((int)(((byte)(62)))), ((int)(((byte)(120)))), ((int)(((byte)(138)))));
            this.buttonSaveSetting.TextImageRelation = System.Windows.Forms.TextImageRelation.TextBeforeImage;
            this.buttonSaveSetting.UseVisualStyleBackColor = false;
            // 
            // FormChangeNumElmOnPage
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(41)))), ((int)(((byte)(44)))), ((int)(((byte)(51)))));
            this.ClientSize = new System.Drawing.Size(435, 185);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.buttonSaveSetting);
            this.Controls.Add(this.textBoxNumElm);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "FormChangeNumElmOnPage";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Thay đổi số dòng hiển thị trên trang hoạt động";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private LW_PhanMemBaoGia.MyControls.TextBoxT textBoxNumElm;
        private LW_PhanMemBaoGia.MyControls.ButtonCustom buttonSaveSetting;
        private System.Windows.Forms.Label label1;
    }
}