namespace ManagementSoftware.GUI
{
    partial class FormConnectTwincat
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
            textBox2 = new TextBox();
            label2 = new Label();
            textBox3 = new TextBox();
            label3 = new Label();
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
            button1.Location = new Point(149, 299);
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
            label1.Size = new Size(58, 20);
            label1.TabIndex = 17;
            label1.Text = "Ams Id:";
            // 
            // textBox1
            // 
            textBox1.Font = new Font("Segoe UI", 14.25F, FontStyle.Regular, GraphicsUnit.Point);
            textBox1.Location = new Point(96, 96);
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(217, 33);
            textBox1.TabIndex = 18;
            // 
            // textBox2
            // 
            textBox2.Font = new Font("Segoe UI", 14.25F, FontStyle.Regular, GraphicsUnit.Point);
            textBox2.Location = new Point(96, 162);
            textBox2.Name = "textBox2";
            textBox2.Size = new Size(217, 33);
            textBox2.TabIndex = 20;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 11.25F, FontStyle.Regular, GraphicsUnit.Point);
            label2.ForeColor = SystemColors.Control;
            label2.Location = new Point(96, 142);
            label2.Name = "label2";
            label2.Size = new Size(38, 20);
            label2.TabIndex = 19;
            label2.Text = "Port:";
            // 
            // textBox3
            // 
            textBox3.Font = new Font("Segoe UI", 14.25F, FontStyle.Regular, GraphicsUnit.Point);
            textBox3.Location = new Point(96, 235);
            textBox3.Name = "textBox3";
            textBox3.Size = new Size(217, 33);
            textBox3.TabIndex = 22;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI", 11.25F, FontStyle.Regular, GraphicsUnit.Point);
            label3.ForeColor = SystemColors.Control;
            label3.Location = new Point(96, 215);
            label3.Name = "label3";
            label3.Size = new Size(63, 20);
            label3.TabIndex = 21;
            label3.Text = "Loại khí:";
            // 
            // FormConnectTwincat
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(32, 32, 32);
            ClientSize = new Size(404, 397);
            Controls.Add(textBox3);
            Controls.Add(label3);
            Controls.Add(textBox2);
            Controls.Add(label2);
            Controls.Add(textBox1);
            Controls.Add(label1);
            Controls.Add(button1);
            MaximizeBox = false;
            Name = "FormConnectTwincat";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Cài đặt kết nối Twincat";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
        private LW_PhanMemBaoGia.MyControls.ButtonCustom button1;
        private Label label1;
        private TextBox textBox1;
        private TextBox textBox2;
        private Label label2;
        private TextBox textBox3;
        private Label label3;
    }
}