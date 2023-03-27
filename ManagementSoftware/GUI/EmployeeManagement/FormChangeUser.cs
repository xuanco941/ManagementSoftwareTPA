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
using ManagementSoftware.DAL;
using ManagementSoftware.GUI.Section;
using ManagementSoftware.Models;
using ManagementSoftware.ViewModels;

namespace ManagementSoftware.GUI.EmployeeManagement
{
    public partial class FormChangeUser : Form
    {
        // Define delegate
        public delegate void ChangeData(string msg, FormAlert.enmType enmType);
        public ChangeData changeData;

        public List<Group> listAllGroup = new List<Group>();
        public List<User> listAllUser = new List<User>();

        public FormChangeUser()
        {
            InitializeComponent();
        }
        void LoadComboBoxUser()
        {
            //lấy tất cả tên các quyền cho vào combobox
            try
            {
                listAllUser = new DALUser().GetAll();
                //lấy tất cả tên các quyền cho vào combobox
                comboBoxSelectUsername.DataSource = listAllUser.Select(a => a.Username).ToList();
            }
            catch
            {
                comboBoxSelectUsername.DataSource = null;
            }
        }
        private void buttonUpdate_Click(object sender, EventArgs e)
        {
            string username = comboBoxSelectUsername.Text;
            string fullname = textBoxFullName.Texts;
            string password = textBoxPassword.Texts.Trim();
            string groupName = comboBoxSelectGroup.Text;
            string email = textBoxtEmail.Texts;
            string sdt = textBoxtSDT.Texts;

            if (String.IsNullOrEmpty(fullname) || String.IsNullOrEmpty(username) || String.IsNullOrEmpty(password) || String.IsNullOrEmpty(groupName))
            {
                MessageBox.Show("Vui lòng điền đủ thông tin thiết yếu.", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {

                User user = listAllUser.Where(a => a.Username == username).First();
                int idGroup = listAllGroup.Where(a => a.GroupName == groupName).First().GroupID;

                user.FullName = fullname;
                user.Password = password;
                user.GroupID = idGroup;
                user.Email = email;
                user.PhoneNumber = sdt;

                try
                {
                    new DALUser().Update(user);
                    changeData?.Invoke($"Cập nhật thành công tài khoản {username}.", FormAlert.enmType.Success);
                    this.Close();
                }
                catch
                {
                    MessageBox.Show($"Cập nhật tài khoản {username} thất bại.", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }

            }

            LoadComboBoxUser();
            comboBoxSelectUsername.Text = username;
        }

        private void buttonDelete_Click(object sender, EventArgs e)
        {
            string username = comboBoxSelectUsername.Text;

            DialogResult dialogResult = MessageBox.Show($"Bạn có chắc muốn xóa tài khoản {username}", "Thông báo", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (dialogResult == DialogResult.Yes)
            {
                //Xóa tài khoản, xóa xong sẽ load lại danh sách username của form
                if (username == Common.UserAdmin.Username)
                {
                    MessageBox.Show("Đây là tài khoản mặc định của hệ thống, bạn không thể xóa.", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Question);
                }
                else
                {
                    try
                    {
                        int idUser = listAllUser.Where(a => a.Username == username).First().UserID;
                        new DALUser().Delete(idUser);

                        changeData?.Invoke($"Xóa thành công tài khoản {username}.", FormAlert.enmType.Success);

                    }
                    catch
                    {
                        MessageBox.Show($"Xóa tài khoản {username} thất bại.", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }

                LoadComboBoxUser();
            }
        }

        private void comboBoxSelectUsername_SelectedIndexChanged(object sender, EventArgs e)
        {
            //vô hiệu hóa nút xóa khi đây là tài khoản hiện tại
            if ((Common.USERSESSION != null && comboBoxSelectUsername.Text != Common.USERSESSION.Username) || string.IsNullOrEmpty(comboBoxSelectUsername.Text))
            {
                buttonDelete.Enabled = true;
            }
            else
            {
                buttonDelete.Enabled = false;
            }
            //neu la tai khoan admin thi khong the xoa, khong the thay doi ten user
            if (comboBoxSelectUsername.Text == Common.UserAdmin.Username && Common.USERSESSION != null && Common.USERSESSION.Username != Common.UserAdmin.Username)
            {
                textBoxFullName.Enabled = false;
                textBoxPassword.PasswordChar = true;
                textBoxPassword.Enabled = false;
                comboBoxSelectGroup.Enabled = false;
                buttonUpdate.Enabled = false;
            }
            else
            {
                textBoxFullName.Enabled = true;
                textBoxPassword.PasswordChar = false;
                textBoxPassword.Enabled = true;
                comboBoxSelectGroup.Enabled = true;
                buttonUpdate.Enabled = true;

                // lấy ra thông tin user có username là username trên combobox
                try
                {
                    User user = listAllUser.Where(e => e.Username == comboBoxSelectUsername.Text).First();

                    //show trên textbox

                    textBoxFullName.Texts = user.FullName;
                    textBoxPassword.Texts = user.Password;
                    comboBoxSelectGroup.Text = user.Group?.GroupName ?? "";
                    textBoxtEmail.Texts = user.Email;
                    textBoxtSDT.Texts = user.PhoneNumber;

                }
                catch
                {
                    changeData?.Invoke($"Không thể lấy thông tin người dùng này.", FormAlert.enmType.Error);
                }
            }

            if (comboBoxSelectUsername.Text == Common.UserAdmin.Username || (Common.USERSESSION != null && comboBoxSelectUsername.Text == Common.USERSESSION.Username))
            {
                buttonDelete.Enabled = false;
                comboBoxSelectGroup.Enabled = false;
            }
            else
            {
                buttonDelete.Enabled = true;
                comboBoxSelectGroup.Enabled = true;
            }
        }

        private void FormChangeUser_Load(object sender, EventArgs e)
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


            LoadComboBoxUser();
        }
    }
}
