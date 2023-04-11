using ManagementSoftware.BUS;
using ManagementSoftware.DAL;
using ManagementSoftware.GUI.Section;
using ManagementSoftware.Models;
using ManagementSoftware.ViewModels;

namespace ManagementSoftware.GUI.EmployeeManagement
{
    public partial class FormAddUser : Form
    {
        // Define delegate
        public delegate void ChangeData(string msg, FormAlert.enmType enmType);

        // Create instance (null)
        public ChangeData changeData;

        public List<Group> listAllGroup = new List<Group>();
        public FormAddUser()
        {
            InitializeComponent();

        }

        private void buttonThem_Click(object sender, EventArgs e)
        {
            string fullname = textBoxFullName.Texts;
            string username = textBoxUsername.Texts.Trim();
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
                User user = new User();
                int idGroup = listAllGroup.Where(a => a.GroupName == groupName).First().GroupID;
                user.FullName = fullname;
                user.Username = username;
                user.Password = password;
                user.Email = email;
                user.PhoneNumber = sdt;
                user.GroupID = idGroup;

                try
                {
                    new DALUser().Add(user);
                    new DALActivity().Add(new Activity { Title = "Tạo mới tài khoản", Description = $"Username : {user.Username}, Fullname : {user.FullName}" , Username = Common.USERSESSION?.Username ?? "Hệ thống", UserID = Common.USERSESSION?.UserID ?? 0});
                    changeData?.Invoke($"Thêm thành công tài khoản {username}.", FormAlert.enmType.Success);
                    this.Close();
                }
                catch
                {
                    MessageBox.Show($"Thêm tài khoản {username} thất bại, tên tài khoản phải là duy nhất.", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }


            }




        }

        private void FormAddUser_Load(object sender, EventArgs e)
        {
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
    }
}
