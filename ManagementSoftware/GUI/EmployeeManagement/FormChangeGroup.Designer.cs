using System.Windows.Forms;

namespace ManagementSoftware.GUI.EmployeeManagement
{
    partial class FormChangeGroup
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormChangeGroup));
            label7 = new Label();
            buttonDeleteGroup = new LW_PhanMemBaoGia.MyControls.ButtonCustom();
            buttonUpdateGroup = new LW_PhanMemBaoGia.MyControls.ButtonCustom();
            comboBoxSelectGroup = new ComboBox();
            groupBox1 = new GroupBox();
            checkBoxIsDeleteActivity = new CheckBox();
            checkBoxIsDeleteResult = new CheckBox();
            checkBoxIsViewActivity = new CheckBox();
            checkBoxIsViewResult = new CheckBox();
            checkBoxIsSettingTemplateMachine = new CheckBox();
            checkBoxIsSettingShift = new CheckBox();
            checkBoxIsSettingMachine = new CheckBox();
            checkBoxIsControlMachine = new CheckBox();
            checkBoxIsManagementUser = new CheckBox();
            checkBoxIsManagementGroup = new CheckBox();
            panel1 = new Panel();
            label8 = new Label();
            groupBox1.SuspendLayout();
            panel1.SuspendLayout();
            SuspendLayout();
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            label7.ForeColor = Color.Transparent;
            label7.Location = new Point(145, 100);
            label7.Margin = new Padding(4, 0, 4, 0);
            label7.Name = "label7";
            label7.Size = new Size(193, 21);
            label7.TabIndex = 27;
            label7.Text = "Chọn nhóm quyền hiện có";
            // 
            // buttonDeleteGroup
            // 
            buttonDeleteGroup.BackColor = Color.Brown;
            buttonDeleteGroup.BackgroundColor = Color.Brown;
            buttonDeleteGroup.BorderColor = Color.PaleVioletRed;
            buttonDeleteGroup.BorderRadius = 3;
            buttonDeleteGroup.BorderSize = 0;
            buttonDeleteGroup.FlatStyle = FlatStyle.Flat;
            buttonDeleteGroup.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold, GraphicsUnit.Point);
            buttonDeleteGroup.ForeColor = Color.White;
            buttonDeleteGroup.Image = (Image)resources.GetObject("buttonDeleteGroup.Image");
            buttonDeleteGroup.ImageAlign = ContentAlignment.MiddleLeft;
            buttonDeleteGroup.Location = new Point(357, 610);
            buttonDeleteGroup.Margin = new Padding(4, 3, 4, 3);
            buttonDeleteGroup.Name = "buttonDeleteGroup";
            buttonDeleteGroup.Size = new Size(208, 42);
            buttonDeleteGroup.TabIndex = 74;
            buttonDeleteGroup.Text = "Xóa quyền này";
            buttonDeleteGroup.TextAlign = ContentAlignment.MiddleRight;
            buttonDeleteGroup.TextColor = Color.White;
            buttonDeleteGroup.TextImageRelation = TextImageRelation.TextBeforeImage;
            buttonDeleteGroup.UseVisualStyleBackColor = false;
            buttonDeleteGroup.Click += buttonDeleteGroup_Click;
            // 
            // buttonUpdateGroup
            // 
            buttonUpdateGroup.BackColor = Color.DarkGoldenrod;
            buttonUpdateGroup.BackgroundColor = Color.DarkGoldenrod;
            buttonUpdateGroup.BorderColor = Color.PaleVioletRed;
            buttonUpdateGroup.BorderRadius = 3;
            buttonUpdateGroup.BorderSize = 0;
            buttonUpdateGroup.FlatStyle = FlatStyle.Flat;
            buttonUpdateGroup.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold, GraphicsUnit.Point);
            buttonUpdateGroup.ForeColor = Color.White;
            buttonUpdateGroup.Image = Properties.Resources.iconfinder_Synchronize_278832;
            buttonUpdateGroup.ImageAlign = ContentAlignment.MiddleLeft;
            buttonUpdateGroup.Location = new Point(149, 610);
            buttonUpdateGroup.Margin = new Padding(4, 3, 4, 3);
            buttonUpdateGroup.Name = "buttonUpdateGroup";
            buttonUpdateGroup.Size = new Size(201, 42);
            buttonUpdateGroup.TabIndex = 73;
            buttonUpdateGroup.Text = "Cập nhật";
            buttonUpdateGroup.TextAlign = ContentAlignment.MiddleRight;
            buttonUpdateGroup.TextColor = Color.White;
            buttonUpdateGroup.TextImageRelation = TextImageRelation.TextBeforeImage;
            buttonUpdateGroup.UseVisualStyleBackColor = false;
            buttonUpdateGroup.Click += buttonUpdateGroup_Click;
            // 
            // comboBoxSelectGroup
            // 
            comboBoxSelectGroup.BackColor = SystemColors.Window;
            comboBoxSelectGroup.DropDownStyle = ComboBoxStyle.DropDownList;
            comboBoxSelectGroup.Font = new Font("Segoe UI", 14.25F, FontStyle.Regular, GraphicsUnit.Point);
            comboBoxSelectGroup.FormattingEnabled = true;
            comboBoxSelectGroup.IntegralHeight = false;
            comboBoxSelectGroup.Location = new Point(149, 128);
            comboBoxSelectGroup.Margin = new Padding(4, 3, 4, 3);
            comboBoxSelectGroup.MaxDropDownItems = 9;
            comboBoxSelectGroup.Name = "comboBoxSelectGroup";
            comboBoxSelectGroup.Size = new Size(415, 33);
            comboBoxSelectGroup.TabIndex = 75;
            comboBoxSelectGroup.SelectedIndexChanged += comboBoxSelectGroup_SelectedIndexChanged;
            // 
            // groupBox1
            // 
            groupBox1.Controls.Add(checkBoxIsDeleteActivity);
            groupBox1.Controls.Add(checkBoxIsDeleteResult);
            groupBox1.Controls.Add(checkBoxIsViewActivity);
            groupBox1.Controls.Add(checkBoxIsViewResult);
            groupBox1.Controls.Add(checkBoxIsSettingTemplateMachine);
            groupBox1.Controls.Add(checkBoxIsSettingShift);
            groupBox1.Controls.Add(checkBoxIsSettingMachine);
            groupBox1.Controls.Add(checkBoxIsControlMachine);
            groupBox1.Controls.Add(checkBoxIsManagementUser);
            groupBox1.Controls.Add(checkBoxIsManagementGroup);
            groupBox1.Font = new Font("Segoe UI", 11.25F, FontStyle.Regular, GraphicsUnit.Point);
            groupBox1.ForeColor = Color.White;
            groupBox1.Location = new Point(149, 189);
            groupBox1.Margin = new Padding(4, 3, 4, 3);
            groupBox1.Name = "groupBox1";
            groupBox1.Padding = new Padding(4, 3, 4, 3);
            groupBox1.Size = new Size(415, 402);
            groupBox1.TabIndex = 76;
            groupBox1.TabStop = false;
            groupBox1.Text = "Cho phép";
            // 
            // checkBoxIsDeleteActivity
            // 
            checkBoxIsDeleteActivity.AutoSize = true;
            checkBoxIsDeleteActivity.Font = new Font("Segoe UI", 14.25F, FontStyle.Regular, GraphicsUnit.Point);
            checkBoxIsDeleteActivity.ForeColor = Color.White;
            checkBoxIsDeleteActivity.Location = new Point(24, 342);
            checkBoxIsDeleteActivity.Margin = new Padding(4, 3, 4, 3);
            checkBoxIsDeleteActivity.Name = "checkBoxIsDeleteActivity";
            checkBoxIsDeleteActivity.Size = new Size(214, 29);
            checkBoxIsDeleteActivity.TabIndex = 22;
            checkBoxIsDeleteActivity.Text = "Xóa lịch sử hoạt động";
            checkBoxIsDeleteActivity.UseVisualStyleBackColor = true;
            // 
            // checkBoxIsDeleteResult
            // 
            checkBoxIsDeleteResult.AutoSize = true;
            checkBoxIsDeleteResult.Font = new Font("Segoe UI", 14.25F, FontStyle.Regular, GraphicsUnit.Point);
            checkBoxIsDeleteResult.ForeColor = Color.White;
            checkBoxIsDeleteResult.Location = new Point(24, 307);
            checkBoxIsDeleteResult.Margin = new Padding(4, 3, 4, 3);
            checkBoxIsDeleteResult.Name = "checkBoxIsDeleteResult";
            checkBoxIsDeleteResult.Size = new Size(159, 29);
            checkBoxIsDeleteResult.TabIndex = 21;
            checkBoxIsDeleteResult.Text = "Xóa lịch sử nạp";
            checkBoxIsDeleteResult.UseVisualStyleBackColor = true;
            // 
            // checkBoxIsViewActivity
            // 
            checkBoxIsViewActivity.AutoSize = true;
            checkBoxIsViewActivity.Font = new Font("Segoe UI", 14.25F, FontStyle.Regular, GraphicsUnit.Point);
            checkBoxIsViewActivity.ForeColor = Color.White;
            checkBoxIsViewActivity.Location = new Point(24, 272);
            checkBoxIsViewActivity.Margin = new Padding(4, 3, 4, 3);
            checkBoxIsViewActivity.Name = "checkBoxIsViewActivity";
            checkBoxIsViewActivity.Size = new Size(219, 29);
            checkBoxIsViewActivity.TabIndex = 20;
            checkBoxIsViewActivity.Text = "Xem lịch sử hoạt động";
            checkBoxIsViewActivity.UseVisualStyleBackColor = true;
            // 
            // checkBoxIsViewResult
            // 
            checkBoxIsViewResult.AutoSize = true;
            checkBoxIsViewResult.Font = new Font("Segoe UI", 14.25F, FontStyle.Regular, GraphicsUnit.Point);
            checkBoxIsViewResult.ForeColor = Color.White;
            checkBoxIsViewResult.Location = new Point(24, 238);
            checkBoxIsViewResult.Margin = new Padding(4, 3, 4, 3);
            checkBoxIsViewResult.Name = "checkBoxIsViewResult";
            checkBoxIsViewResult.Size = new Size(164, 29);
            checkBoxIsViewResult.TabIndex = 19;
            checkBoxIsViewResult.Text = "Xem lịch sử nạp";
            checkBoxIsViewResult.UseVisualStyleBackColor = true;
            // 
            // checkBoxIsSettingTemplateMachine
            // 
            checkBoxIsSettingTemplateMachine.AutoSize = true;
            checkBoxIsSettingTemplateMachine.Font = new Font("Segoe UI", 14.25F, FontStyle.Regular, GraphicsUnit.Point);
            checkBoxIsSettingTemplateMachine.ForeColor = Color.White;
            checkBoxIsSettingTemplateMachine.Location = new Point(24, 203);
            checkBoxIsSettingTemplateMachine.Margin = new Padding(4, 3, 4, 3);
            checkBoxIsSettingTemplateMachine.Name = "checkBoxIsSettingTemplateMachine";
            checkBoxIsSettingTemplateMachine.Size = new Size(147, 29);
            checkBoxIsSettingTemplateMachine.TabIndex = 17;
            checkBoxIsSettingTemplateMachine.Text = "Thiết lập bình";
            checkBoxIsSettingTemplateMachine.UseVisualStyleBackColor = true;
            // 
            // checkBoxIsSettingShift
            // 
            checkBoxIsSettingShift.AutoSize = true;
            checkBoxIsSettingShift.Font = new Font("Segoe UI", 14.25F, FontStyle.Regular, GraphicsUnit.Point);
            checkBoxIsSettingShift.ForeColor = Color.White;
            checkBoxIsSettingShift.Location = new Point(24, 168);
            checkBoxIsSettingShift.Margin = new Padding(4, 3, 4, 3);
            checkBoxIsSettingShift.Name = "checkBoxIsSettingShift";
            checkBoxIsSettingShift.Size = new Size(164, 29);
            checkBoxIsSettingShift.TabIndex = 16;
            checkBoxIsSettingShift.Text = "Thiết lập ca làm";
            checkBoxIsSettingShift.UseVisualStyleBackColor = true;
            // 
            // checkBoxIsSettingMachine
            // 
            checkBoxIsSettingMachine.AutoSize = true;
            checkBoxIsSettingMachine.Font = new Font("Segoe UI", 14.25F, FontStyle.Regular, GraphicsUnit.Point);
            checkBoxIsSettingMachine.ForeColor = Color.White;
            checkBoxIsSettingMachine.Location = new Point(24, 134);
            checkBoxIsSettingMachine.Margin = new Padding(4, 3, 4, 3);
            checkBoxIsSettingMachine.Name = "checkBoxIsSettingMachine";
            checkBoxIsSettingMachine.Size = new Size(209, 29);
            checkBoxIsSettingMachine.TabIndex = 15;
            checkBoxIsSettingMachine.Text = "Cài đặt thông số máy";
            checkBoxIsSettingMachine.UseVisualStyleBackColor = true;
            // 
            // checkBoxIsControlMachine
            // 
            checkBoxIsControlMachine.AutoSize = true;
            checkBoxIsControlMachine.Font = new Font("Segoe UI", 14.25F, FontStyle.Regular, GraphicsUnit.Point);
            checkBoxIsControlMachine.ForeColor = Color.White;
            checkBoxIsControlMachine.Location = new Point(24, 99);
            checkBoxIsControlMachine.Margin = new Padding(4, 3, 4, 3);
            checkBoxIsControlMachine.Name = "checkBoxIsControlMachine";
            checkBoxIsControlMachine.Size = new Size(161, 29);
            checkBoxIsControlMachine.TabIndex = 14;
            checkBoxIsControlMachine.Text = "Điều khiển máy";
            checkBoxIsControlMachine.UseVisualStyleBackColor = true;
            // 
            // checkBoxIsManagementUser
            // 
            checkBoxIsManagementUser.AutoSize = true;
            checkBoxIsManagementUser.Font = new Font("Segoe UI", 14.25F, FontStyle.Regular, GraphicsUnit.Point);
            checkBoxIsManagementUser.ForeColor = Color.White;
            checkBoxIsManagementUser.Location = new Point(24, 30);
            checkBoxIsManagementUser.Margin = new Padding(4, 3, 4, 3);
            checkBoxIsManagementUser.Name = "checkBoxIsManagementUser";
            checkBoxIsManagementUser.Size = new Size(188, 29);
            checkBoxIsManagementUser.TabIndex = 12;
            checkBoxIsManagementUser.Text = "Quản trị nhân viên";
            checkBoxIsManagementUser.UseVisualStyleBackColor = true;
            // 
            // checkBoxIsManagementGroup
            // 
            checkBoxIsManagementGroup.AutoSize = true;
            checkBoxIsManagementGroup.Font = new Font("Segoe UI", 14.25F, FontStyle.Regular, GraphicsUnit.Point);
            checkBoxIsManagementGroup.ForeColor = Color.White;
            checkBoxIsManagementGroup.Location = new Point(24, 65);
            checkBoxIsManagementGroup.Margin = new Padding(4, 3, 4, 3);
            checkBoxIsManagementGroup.Name = "checkBoxIsManagementGroup";
            checkBoxIsManagementGroup.Size = new Size(211, 29);
            checkBoxIsManagementGroup.TabIndex = 13;
            checkBoxIsManagementGroup.Text = "Quản trị nhóm quyền";
            checkBoxIsManagementGroup.UseVisualStyleBackColor = true;
            // 
            // panel1
            // 
            panel1.Controls.Add(label8);
            panel1.Dock = DockStyle.Top;
            panel1.Location = new Point(0, 0);
            panel1.Name = "panel1";
            panel1.Size = new Size(727, 97);
            panel1.TabIndex = 77;
            // 
            // label8
            // 
            label8.Dock = DockStyle.Fill;
            label8.Font = new Font("Segoe UI Semibold", 18F, FontStyle.Bold, GraphicsUnit.Point);
            label8.ForeColor = Color.Goldenrod;
            label8.Location = new Point(0, 0);
            label8.Margin = new Padding(4, 0, 4, 0);
            label8.Name = "label8";
            label8.Size = new Size(727, 97);
            label8.TabIndex = 32;
            label8.Text = "Cập nhật Quyền";
            label8.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // FormChangeGroup
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(41, 44, 51);
            ClientSize = new Size(727, 727);
            Controls.Add(panel1);
            Controls.Add(groupBox1);
            Controls.Add(comboBoxSelectGroup);
            Controls.Add(buttonDeleteGroup);
            Controls.Add(buttonUpdateGroup);
            Controls.Add(label7);
            Icon = (Icon)resources.GetObject("$this.Icon");
            Margin = new Padding(4, 3, 4, 3);
            MaximizeBox = false;
            MinimizeBox = false;
            Name = "FormChangeGroup";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Cập nhật quyền";
            Load += FormChangeGroup_Load;
            groupBox1.ResumeLayout(false);
            groupBox1.PerformLayout();
            panel1.ResumeLayout(false);
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
        private Label label7;
        private LW_PhanMemBaoGia.MyControls.ButtonCustom buttonDeleteGroup;
        private LW_PhanMemBaoGia.MyControls.ButtonCustom buttonUpdateGroup;
        private ComboBox comboBoxSelectGroup;
        private GroupBox groupBox1;
        private CheckBox checkBoxIsDeleteActivity;
        private CheckBox checkBoxIsDeleteResult;
        private CheckBox checkBoxIsViewActivity;
        private CheckBox checkBoxIsViewResult;
        private CheckBox checkBoxIsSettingTemplateMachine;
        private CheckBox checkBoxIsSettingShift;
        private CheckBox checkBoxIsSettingMachine;
        private CheckBox checkBoxIsControlMachine;
        private CheckBox checkBoxIsManagementUser;
        private CheckBox checkBoxIsManagementGroup;
        private Panel panel1;
        private Label label8;
    }
}