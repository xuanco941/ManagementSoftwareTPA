using ManagementSoftware.BUS;
using ManagementSoftware.DAL;
using ManagementSoftware.GUI.Section;
using ManagementSoftware.Models;
using ManagementSoftware.ViewModels;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ManagementSoftware.GUI.EmployeeManagement
{
    public partial class FormChangeGroup : Form
    {
        // tạo 1 delegate có 2 biến để call alert ở main
        public delegate void ChangeData(string msg, FormAlert.enmType enmType);
        // Create instance (null)
        public ChangeData changeData;


        public List<Group> listAllGroup = new List<Group>();

        public FormChangeGroup()
        {
            InitializeComponent();
        }

        private void LoadComboBox()
        {
            //lấy tất cả tên các quyền cho vào combobox
            try
            {
                listAllGroup = new DALGroup().GetAll();
                //lấy tất cả tên các quyền cho vào combobox
                comboBoxSelectGroup.DataSource = listAllGroup.Select(a => a.GroupName).ToList();
            }
            catch
            {
                comboBoxSelectGroup.DataSource = null;
            }
        }

        private void comboBoxSelectGroup_SelectedIndexChanged(object sender, EventArgs e)
        {
            //vô hiệu hóa nút xóa khi đây là quyền admin mặc định
            if (comboBoxSelectGroup.Text != Common.GroupAdmin.GroupName)
            {
                buttonUpdateGroup.Enabled = true;
                buttonDeleteGroup.Enabled = true;
            }
            else
            {
                buttonUpdateGroup.Enabled = false;
                buttonDeleteGroup.Enabled = false;
            }

            // lấy ra thông tin group có name group là text trên combobox

            Group group = listAllGroup.Where(e => e.GroupName == comboBoxSelectGroup.Text).First();

            checkBoxIsManagementUser.Checked = group.IsManagementUser;
            checkBoxIsManagementGroup.Checked = group.IsManagementMachine;
            //checkBoxIsControlMachine.Checked = group.IsControlMachine;
            //checkBoxIsSettingMachine.Checked = group.IsSettingMachine;
            //checkBoxIsSettingShift.Checked = group.IsSettingShift;
            //checkBoxIsSettingTemplateMachine.Checked = group.IsSettingTemplateMachine;
            //checkBoxIsViewResult.Checked = group.IsViewResult;
            //checkBoxIsViewActivity.Checked = group.IsViewActivity;
            //checkBoxIsDeleteResult.Checked = group.IsDeleteResult;
            //checkBoxIsDeleteActivity.Checked = group.IsDeleteActivity;



        }

        private void buttonUpdateGroup_Click(object sender, EventArgs e)
        {
            Group group = new Group();
            group.GroupName = comboBoxSelectGroup.Text;
            group.IsManagementUser = checkBoxIsManagementUser.Checked;
            group.IsManagementMachine = checkBoxIsManagementGroup.Checked;

            if (String.IsNullOrEmpty(comboBoxSelectGroup.Text))
            {
                MessageBox.Show("Vui lòng điền đủ thông tin.", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                try
                {
                    new DALGroup().Update(group);
                    changeData?.Invoke("Cập nhật thành công.", FormAlert.enmType.Success);
                }
                catch
                {
                    changeData?.Invoke("Cập nhật thất bại", FormAlert.enmType.Error);
                }

            }

            LoadComboBox();
            comboBoxSelectGroup.Text = group.GroupName;
        }

        private void buttonDeleteGroup_Click(object sender, EventArgs e)
        {
            string nameGroup = comboBoxSelectGroup.Text;

            DialogResult dialogResult = MessageBox.Show($"Bạn có chắc muốn xóa nhóm quyền {nameGroup}", "Thông báo", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (dialogResult == DialogResult.Yes)
            {
                DialogResult dialogResult2 = MessageBox.Show($"Xác nhận xóa đồng nghĩa với việc mọi tài khoản trong nhóm quyền này không còn quyền.", "Cảnh báo quan trọng", MessageBoxButtons.YesNo, MessageBoxIcon.Error);

                if (dialogResult2 == DialogResult.Yes)
                {
                    //Xóa nhóm quyền, xóa xong sẽ load lại danh sách group của form

                    int grId = listAllGroup.Where(e => e.GroupName == nameGroup).First().GroupID;

                    //nếu quyền bị xóa là quyền hiện tại của hệ thống thì báo lỗi
                    if (Common.USERSESSION != null && (grId == Common.USERSESSION.GroupID))
                    {
                        changeData?.Invoke($"Xóa không thành công, nhóm quyền {nameGroup} là nhóm quyền tài khoản của bạn.", FormAlert.enmType.Error);
                    }
                    else
                    {
                        try
                        {
                            new DALGroup().Delete(grId);
                            changeData?.Invoke($"Xóa thành công nhóm quyền {nameGroup}.", FormAlert.enmType.Success);
                        }
                        catch
                        {
                            changeData?.Invoke($"Xóa nhóm quyền {nameGroup} không thành công.", FormAlert.enmType.Error);

                        }
                    }
                    LoadComboBox();
                }

            }
        }

        private void FormChangeGroup_Load(object sender, EventArgs e)
        {
            LoadComboBox();

        }
    }
}
