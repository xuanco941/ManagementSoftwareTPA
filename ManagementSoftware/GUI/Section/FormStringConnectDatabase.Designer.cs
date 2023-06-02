namespace ManagementSoftware.GUI.Section
{
    partial class FormStringConnectDatabase
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
            button1 = new LW_PhanMemBaoGia.MyControls.ButtonCustom();
            label1 = new Label();
            textBox1 = new TextBox();
            label2 = new Label();
            label3 = new Label();
            label4 = new Label();
            label5 = new Label();
            SuspendLayout();
            // 
            // button1
            // 
            button1.BackColor = Color.SteelBlue;
            button1.BackgroundColor = Color.SteelBlue;
            button1.BorderColor = Color.PaleVioletRed;
            button1.BorderRadius = 15;
            button1.BorderSize = 0;
            button1.Cursor = Cursors.Hand;
            button1.FlatStyle = FlatStyle.Flat;
            button1.Font = new Font("Segoe UI Semibold", 9.75F, FontStyle.Bold, GraphicsUnit.Point);
            button1.ForeColor = Color.White;
            button1.ImageAlign = ContentAlignment.MiddleLeft;
            button1.Location = new Point(506, 88);
            button1.Margin = new Padding(4, 3, 4, 3);
            button1.Name = "button1";
            button1.Size = new Size(106, 41);
            button1.TabIndex = 16;
            button1.Text = "Xác nhận";
            button1.TextColor = Color.White;
            button1.UseVisualStyleBackColor = false;
            button1.Click += button1_Click_1;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 11.25F, FontStyle.Regular, GraphicsUnit.Point);
            label1.ForeColor = SystemColors.Control;
            label1.Location = new Point(96, 73);
            label1.Name = "label1";
            label1.Size = new Size(188, 20);
            label1.TabIndex = 17;
            label1.Text = "Chuỗi kết nối (SQL Server) :";
            // 
            // textBox1
            // 
            textBox1.Font = new Font("Segoe UI", 14.25F, FontStyle.Regular, GraphicsUnit.Point);
            textBox1.Location = new Point(96, 93);
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(403, 33);
            textBox1.TabIndex = 18;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point);
            label2.ForeColor = SystemColors.Control;
            label2.Location = new Point(96, 134);
            label2.Name = "label2";
            label2.Size = new Size(406, 15);
            label2.TabIndex = 19;
            label2.Text = "VD : Data Source=DESKTOP-P4IC2M8\\SQLEXPRESS;Initial Catalog=TenCSDL;";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point);
            label3.ForeColor = SystemColors.Control;
            label3.Location = new Point(96, 147);
            label3.Name = "label3";
            label3.Size = new Size(142, 15);
            label3.TabIndex = 20;
            label3.Text = "User ID=sa;Password=123";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Segoe UI", 8.25F, FontStyle.Regular, GraphicsUnit.Point);
            label4.ForeColor = Color.LawnGreen;
            label4.Location = new Point(96, 170);
            label4.Name = "label4";
            label4.Size = new Size(373, 13);
            label4.TabIndex = 21;
            label4.Text = "Nếu lỗi permission denied hãy mở Notepad bằng quyền administrator, ";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Segoe UI", 8.25F, FontStyle.Regular, GraphicsUnit.Point);
            label5.ForeColor = Color.LawnGreen;
            label5.Location = new Point(96, 183);
            label5.Name = "label5";
            label5.Size = new Size(436, 13);
            label5.TabIndex = 22;
            label5.Text = "open file ConnectStringDB.txt trong folder chứa ứng dụng và thay chuỗi kết nối ấy.";
            // 
            // FormStringConnectDatabase
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(32, 32, 32);
            ClientSize = new Size(711, 259);
            Controls.Add(label5);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(textBox1);
            Controls.Add(label1);
            Controls.Add(button1);
            MaximizeBox = false;
            Name = "FormStringConnectDatabase";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Thay đổi cơ sở dữ liệu";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
        private LW_PhanMemBaoGia.MyControls.ButtonCustom button1;
        private Label label1;
        private TextBox textBox1;
        private Label label2;
        private Label label3;
        private Label label4;
        private Label label5;
    }
}