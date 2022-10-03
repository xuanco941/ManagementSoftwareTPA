using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using ManagementSoftware.BUS;
using ManagementSoftware.GUI.Section;
using ManagementSoftware.Models;

namespace ManagementSoftware.GUI.EmployeeManagement
{
    public partial class FormChangeUser : Form
    {
        // Define delegate
        public delegate void ChangeData(string msg, FormAlert.enmType enmType);

        // Create instance (null)
        public ChangeData changeData;
        public FormChangeUser()
        {
            InitializeComponent();
            comboBoxSelectGroup.DataSource = BUSGroup.GetListGroupName();
        }
        void LoadComboBoxUser()
        {
            comboBoxSelectUsername.DataSource = BUSUser.GetListUsername();
        }
        private void buttonUpdate_Click(object sender, EventArgs e)
        {
            string usernameOld = comboBoxSelectUsername.Text;
            string fullname = textBoxFullName.Texts;
            string username = textBoxUsername.Texts.Trim();
            string password = textBoxPassword.Texts.Trim();
            string groupName = comboBoxSelectGroup.Text;

            if (String.IsNullOrEmpty(fullname) || String.IsNullOrEmpty(username) || String.IsNullOrEmpty(password) || String.IsNullOrEmpty(groupName))
            {
                MessageBox.Show("Vui lòng điền đủ thông tin.", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            //else
            //{
            //    User user = new User();
            //    try
            //    {
            //        Group? gr = BUSGroup.GetGroupFromGroupName(groupName);
            //        if (gr != null)
            //        {
            //            user = new User(fullname, username, password, gr.GroupID);
            //        }
            //    }
            //    catch
            //    {

            //    }
            //    try
            //    {
            //        UserBusiness.UpdateUser(usernameOld, user);
            //        //nếu username cũ là username current , biến tĩnh của program thì cập nhật lại usercurrent
            //        if (usernameOld == Common.USERSESSION.Username)
            //        {
            //            // cập nhật lại quyền hiện tại
            //            Common.USERSESSION = user;
            //            Common.GROUPSESSION = GroupBusiness.GetGroupFromID(Common.USERSESSION.ID_Group);

            //        }
            //        //thông báo
            //        changeData?.Invoke("Cập nhật thành công.", FormAlert.enmType.Success);
            //    }
            //    catch (Exception ex)
            //    {
            //        changeData?.Invoke(ex.Message, FormAlert.enmType.Error);
            //    }

            //}

            //LoadForm();
            //comboBoxSelectUsername.Text = username;
        }
    }
}
