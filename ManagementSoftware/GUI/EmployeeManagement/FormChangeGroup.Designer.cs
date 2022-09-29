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
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.buttonDeleteGroup = new LW_PhanMemBaoGia.MyControls.ButtonCustom();
            this.buttonUpdateGroup = new LW_PhanMemBaoGia.MyControls.ButtonCustom();
            this.comboBoxSelectGroup = new System.Windows.Forms.ComboBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.checkBoxIsDeleteActivity = new System.Windows.Forms.CheckBox();
            this.checkBoxIsDeleteResult = new System.Windows.Forms.CheckBox();
            this.checkBoxIsViewActivity = new System.Windows.Forms.CheckBox();
            this.checkBoxIsViewResult = new System.Windows.Forms.CheckBox();
            this.checkBoxIsSettingTemplateMachine = new System.Windows.Forms.CheckBox();
            this.checkBoxIsSettingShift = new System.Windows.Forms.CheckBox();
            this.checkBoxIsSettingMachine = new System.Windows.Forms.CheckBox();
            this.checkBoxIsControlMachine = new System.Windows.Forms.CheckBox();
            this.checkBoxIsManagementUser = new System.Windows.Forms.CheckBox();
            this.checkBoxIsManagementGroup = new System.Windows.Forms.CheckBox();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.ForeColor = System.Drawing.Color.Transparent;
            this.label7.Location = new System.Drawing.Point(124, 87);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(193, 21);
            this.label7.TabIndex = 27;
            this.label7.Text = "Chọn nhóm quyền hiện có";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Showcard Gothic", 18F, System.Drawing.FontStyle.Bold);
            this.label8.ForeColor = System.Drawing.Color.Goldenrod;
            this.label8.Location = new System.Drawing.Point(192, 36);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(223, 30);
            this.label8.TabIndex = 33;
            this.label8.Text = "Cập Nhật Quyền";
            // 
            // buttonDeleteGroup
            // 
            this.buttonDeleteGroup.BackColor = System.Drawing.Color.Brown;
            this.buttonDeleteGroup.BackgroundColor = System.Drawing.Color.Brown;
            this.buttonDeleteGroup.BorderColor = System.Drawing.Color.PaleVioletRed;
            this.buttonDeleteGroup.BorderRadius = 3;
            this.buttonDeleteGroup.BorderSize = 0;
            this.buttonDeleteGroup.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonDeleteGroup.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonDeleteGroup.ForeColor = System.Drawing.Color.White;
            this.buttonDeleteGroup.Image = ((System.Drawing.Image)(resources.GetObject("buttonDeleteGroup.Image")));
            this.buttonDeleteGroup.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.buttonDeleteGroup.Location = new System.Drawing.Point(306, 529);
            this.buttonDeleteGroup.Name = "buttonDeleteGroup";
            this.buttonDeleteGroup.Size = new System.Drawing.Size(178, 36);
            this.buttonDeleteGroup.TabIndex = 74;
            this.buttonDeleteGroup.Text = "Xóa quyền này";
            this.buttonDeleteGroup.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.buttonDeleteGroup.TextColor = System.Drawing.Color.White;
            this.buttonDeleteGroup.TextImageRelation = System.Windows.Forms.TextImageRelation.TextBeforeImage;
            this.buttonDeleteGroup.UseVisualStyleBackColor = false;
            // 
            // buttonUpdateGroup
            // 
            this.buttonUpdateGroup.BackColor = System.Drawing.Color.DarkGoldenrod;
            this.buttonUpdateGroup.BackgroundColor = System.Drawing.Color.DarkGoldenrod;
            this.buttonUpdateGroup.BorderColor = System.Drawing.Color.PaleVioletRed;
            this.buttonUpdateGroup.BorderRadius = 3;
            this.buttonUpdateGroup.BorderSize = 0;
            this.buttonUpdateGroup.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonUpdateGroup.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonUpdateGroup.ForeColor = System.Drawing.Color.White;
            this.buttonUpdateGroup.Image = global::ManagementSoftware.Properties.Resources.iconfinder_Synchronize_278832;
            this.buttonUpdateGroup.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.buttonUpdateGroup.Location = new System.Drawing.Point(128, 529);
            this.buttonUpdateGroup.Name = "buttonUpdateGroup";
            this.buttonUpdateGroup.Size = new System.Drawing.Size(172, 36);
            this.buttonUpdateGroup.TabIndex = 73;
            this.buttonUpdateGroup.Text = "Cập nhật";
            this.buttonUpdateGroup.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.buttonUpdateGroup.TextColor = System.Drawing.Color.White;
            this.buttonUpdateGroup.TextImageRelation = System.Windows.Forms.TextImageRelation.TextBeforeImage;
            this.buttonUpdateGroup.UseVisualStyleBackColor = false;
            // 
            // comboBoxSelectGroup
            // 
            this.comboBoxSelectGroup.BackColor = System.Drawing.SystemColors.Window;
            this.comboBoxSelectGroup.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBoxSelectGroup.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.comboBoxSelectGroup.FormattingEnabled = true;
            this.comboBoxSelectGroup.IntegralHeight = false;
            this.comboBoxSelectGroup.Location = new System.Drawing.Point(128, 111);
            this.comboBoxSelectGroup.MaxDropDownItems = 9;
            this.comboBoxSelectGroup.Name = "comboBoxSelectGroup";
            this.comboBoxSelectGroup.Size = new System.Drawing.Size(356, 33);
            this.comboBoxSelectGroup.TabIndex = 75;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.checkBoxIsDeleteActivity);
            this.groupBox1.Controls.Add(this.checkBoxIsDeleteResult);
            this.groupBox1.Controls.Add(this.checkBoxIsViewActivity);
            this.groupBox1.Controls.Add(this.checkBoxIsViewResult);
            this.groupBox1.Controls.Add(this.checkBoxIsSettingTemplateMachine);
            this.groupBox1.Controls.Add(this.checkBoxIsSettingShift);
            this.groupBox1.Controls.Add(this.checkBoxIsSettingMachine);
            this.groupBox1.Controls.Add(this.checkBoxIsControlMachine);
            this.groupBox1.Controls.Add(this.checkBoxIsManagementUser);
            this.groupBox1.Controls.Add(this.checkBoxIsManagementGroup);
            this.groupBox1.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox1.ForeColor = System.Drawing.Color.White;
            this.groupBox1.Location = new System.Drawing.Point(128, 164);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(356, 348);
            this.groupBox1.TabIndex = 76;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Cho phép";
            // 
            // checkBoxIsDeleteActivity
            // 
            this.checkBoxIsDeleteActivity.AutoSize = true;
            this.checkBoxIsDeleteActivity.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.checkBoxIsDeleteActivity.ForeColor = System.Drawing.Color.White;
            this.checkBoxIsDeleteActivity.Location = new System.Drawing.Point(21, 296);
            this.checkBoxIsDeleteActivity.Name = "checkBoxIsDeleteActivity";
            this.checkBoxIsDeleteActivity.Size = new System.Drawing.Size(214, 29);
            this.checkBoxIsDeleteActivity.TabIndex = 22;
            this.checkBoxIsDeleteActivity.Text = "Xóa lịch sử hoạt động";
            this.checkBoxIsDeleteActivity.UseVisualStyleBackColor = true;
            // 
            // checkBoxIsDeleteResult
            // 
            this.checkBoxIsDeleteResult.AutoSize = true;
            this.checkBoxIsDeleteResult.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.checkBoxIsDeleteResult.ForeColor = System.Drawing.Color.White;
            this.checkBoxIsDeleteResult.Location = new System.Drawing.Point(21, 266);
            this.checkBoxIsDeleteResult.Name = "checkBoxIsDeleteResult";
            this.checkBoxIsDeleteResult.Size = new System.Drawing.Size(159, 29);
            this.checkBoxIsDeleteResult.TabIndex = 21;
            this.checkBoxIsDeleteResult.Text = "Xóa lịch sử nạp";
            this.checkBoxIsDeleteResult.UseVisualStyleBackColor = true;
            // 
            // checkBoxIsViewActivity
            // 
            this.checkBoxIsViewActivity.AutoSize = true;
            this.checkBoxIsViewActivity.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.checkBoxIsViewActivity.ForeColor = System.Drawing.Color.White;
            this.checkBoxIsViewActivity.Location = new System.Drawing.Point(21, 236);
            this.checkBoxIsViewActivity.Name = "checkBoxIsViewActivity";
            this.checkBoxIsViewActivity.Size = new System.Drawing.Size(219, 29);
            this.checkBoxIsViewActivity.TabIndex = 20;
            this.checkBoxIsViewActivity.Text = "Xem lịch sử hoạt động";
            this.checkBoxIsViewActivity.UseVisualStyleBackColor = true;
            // 
            // checkBoxIsViewResult
            // 
            this.checkBoxIsViewResult.AutoSize = true;
            this.checkBoxIsViewResult.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.checkBoxIsViewResult.ForeColor = System.Drawing.Color.White;
            this.checkBoxIsViewResult.Location = new System.Drawing.Point(21, 206);
            this.checkBoxIsViewResult.Name = "checkBoxIsViewResult";
            this.checkBoxIsViewResult.Size = new System.Drawing.Size(164, 29);
            this.checkBoxIsViewResult.TabIndex = 19;
            this.checkBoxIsViewResult.Text = "Xem lịch sử nạp";
            this.checkBoxIsViewResult.UseVisualStyleBackColor = true;
            // 
            // checkBoxIsSettingTemplateMachine
            // 
            this.checkBoxIsSettingTemplateMachine.AutoSize = true;
            this.checkBoxIsSettingTemplateMachine.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.checkBoxIsSettingTemplateMachine.ForeColor = System.Drawing.Color.White;
            this.checkBoxIsSettingTemplateMachine.Location = new System.Drawing.Point(21, 176);
            this.checkBoxIsSettingTemplateMachine.Name = "checkBoxIsSettingTemplateMachine";
            this.checkBoxIsSettingTemplateMachine.Size = new System.Drawing.Size(147, 29);
            this.checkBoxIsSettingTemplateMachine.TabIndex = 17;
            this.checkBoxIsSettingTemplateMachine.Text = "Thiết lập bình";
            this.checkBoxIsSettingTemplateMachine.UseVisualStyleBackColor = true;
            // 
            // checkBoxIsSettingShift
            // 
            this.checkBoxIsSettingShift.AutoSize = true;
            this.checkBoxIsSettingShift.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.checkBoxIsSettingShift.ForeColor = System.Drawing.Color.White;
            this.checkBoxIsSettingShift.Location = new System.Drawing.Point(21, 146);
            this.checkBoxIsSettingShift.Name = "checkBoxIsSettingShift";
            this.checkBoxIsSettingShift.Size = new System.Drawing.Size(164, 29);
            this.checkBoxIsSettingShift.TabIndex = 16;
            this.checkBoxIsSettingShift.Text = "Thiết lập ca làm";
            this.checkBoxIsSettingShift.UseVisualStyleBackColor = true;
            // 
            // checkBoxIsSettingMachine
            // 
            this.checkBoxIsSettingMachine.AutoSize = true;
            this.checkBoxIsSettingMachine.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.checkBoxIsSettingMachine.ForeColor = System.Drawing.Color.White;
            this.checkBoxIsSettingMachine.Location = new System.Drawing.Point(21, 116);
            this.checkBoxIsSettingMachine.Name = "checkBoxIsSettingMachine";
            this.checkBoxIsSettingMachine.Size = new System.Drawing.Size(209, 29);
            this.checkBoxIsSettingMachine.TabIndex = 15;
            this.checkBoxIsSettingMachine.Text = "Cài đặt thông số máy";
            this.checkBoxIsSettingMachine.UseVisualStyleBackColor = true;
            // 
            // checkBoxIsControlMachine
            // 
            this.checkBoxIsControlMachine.AutoSize = true;
            this.checkBoxIsControlMachine.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.checkBoxIsControlMachine.ForeColor = System.Drawing.Color.White;
            this.checkBoxIsControlMachine.Location = new System.Drawing.Point(21, 86);
            this.checkBoxIsControlMachine.Name = "checkBoxIsControlMachine";
            this.checkBoxIsControlMachine.Size = new System.Drawing.Size(161, 29);
            this.checkBoxIsControlMachine.TabIndex = 14;
            this.checkBoxIsControlMachine.Text = "Điều khiển máy";
            this.checkBoxIsControlMachine.UseVisualStyleBackColor = true;
            // 
            // checkBoxIsManagementUser
            // 
            this.checkBoxIsManagementUser.AutoSize = true;
            this.checkBoxIsManagementUser.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.checkBoxIsManagementUser.ForeColor = System.Drawing.Color.White;
            this.checkBoxIsManagementUser.Location = new System.Drawing.Point(21, 26);
            this.checkBoxIsManagementUser.Name = "checkBoxIsManagementUser";
            this.checkBoxIsManagementUser.Size = new System.Drawing.Size(188, 29);
            this.checkBoxIsManagementUser.TabIndex = 12;
            this.checkBoxIsManagementUser.Text = "Quản trị nhân viên";
            this.checkBoxIsManagementUser.UseVisualStyleBackColor = true;
            // 
            // checkBoxIsManagementGroup
            // 
            this.checkBoxIsManagementGroup.AutoSize = true;
            this.checkBoxIsManagementGroup.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.checkBoxIsManagementGroup.ForeColor = System.Drawing.Color.White;
            this.checkBoxIsManagementGroup.Location = new System.Drawing.Point(21, 56);
            this.checkBoxIsManagementGroup.Name = "checkBoxIsManagementGroup";
            this.checkBoxIsManagementGroup.Size = new System.Drawing.Size(211, 29);
            this.checkBoxIsManagementGroup.TabIndex = 13;
            this.checkBoxIsManagementGroup.Text = "Quản trị nhóm quyền";
            this.checkBoxIsManagementGroup.UseVisualStyleBackColor = true;
            // 
            // FormChangeGroup
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(41)))), ((int)(((byte)(44)))), ((int)(((byte)(51)))));
            this.ClientSize = new System.Drawing.Size(623, 630);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.comboBoxSelectGroup);
            this.Controls.Add(this.buttonDeleteGroup);
            this.Controls.Add(this.buttonUpdateGroup);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.label7);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "FormChangeGroup";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Cập nhật quyền";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private Label label7;
        private Label label8;
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
    }
}