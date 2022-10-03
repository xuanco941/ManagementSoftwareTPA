using ManagementSoftware.BUS;
using ManagementSoftware.DALPagination;
using ManagementSoftware.GUI.EmployeeManagement;
using ManagementSoftware.GUI.Section;
using ManagementSoftware.Models;
using ManagementSoftware.ViewModels;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;


namespace ManagementSoftware.GUI
{
    public partial class Employee : Form
    {
        // Aleart Delegate từ FormMain
        public delegate void CallAlert(string msg, FormAlert.enmType type);
        public CallAlert callAlert;

        //page
        private int pageUser = 1;
        private int pageGroup = 1;
        public Employee()
        {
            InitializeComponent();
            // set chieu cao cua row datagridview la 50px
            dataGridViewUser.RowTemplate.Height = 50;
            dataGridViewGroup.RowTemplate.Height = 50;


            LoadDataUser(pageUser, null);
            LoadDataGroup(pageGroup, null);
        }

        //method gọi Alert ở Main từ form khác thông qua form hiện tại, delegate
        public void AlertActive(string msg, FormAlert.enmType enmType)
        {
            callAlert?.Invoke(msg, enmType);
            //load lai 2 datagridview
            LoadDataUser(pageUser,null);
            LoadDataGroup(pageGroup,null);
        }

        public void LoadDataUser(int page, int? rows)
        {
            // get all user from model
            DataTable dtUser = new DataTable();
            dtUser.Columns.Add("Mã NV");
            dtUser.Columns.Add("Họ tên");
            dtUser.Columns.Add("Tài khoản");
            dtUser.Columns.Add("Mật khẩu");
            dtUser.Columns.Add("Quyền");
            PaginationUser paginationUser = BUSUser.GetData(page, rows);

            paginationUser.ListResults?.ForEach(delegate (UserHasGroupName user)
            {
                dtUser.Rows.Add(Common.USERS+user.UserID,user.FullName, user.Username, user.Password, user.GroupName);
            });
            dataGridViewUser.DataSource = dtUser;

        }
        public void LoadDataGroup(int page, int? rows)
        {
            DataTable dtGroup = new DataTable();
            dtGroup.Columns.Add("Mã nhóm quyền");
            dtGroup.Columns.Add("Tên nhóm quyền");
            dtGroup.Columns.Add("Quản trị nhân viên");
            dtGroup.Columns.Add("Quản trị nhóm quyền");
            BUSGroup.GetData(page, rows).ListResults?.ForEach(delegate (Group group)
            {
                string IsManagementUser = group.IsManagementUser == true ? "Có" : "Không";
                string IsManagementGroup = group.IsManagementGroup == true ? "Có" : "Không";


                dtGroup.Rows.Add(Common.GROUPS+group.GroupID, group.GroupName, IsManagementUser, IsManagementGroup
                    );
            });
            dataGridViewGroup.DataSource = dtGroup;

        }


        private void buttonAddUser_Click(object sender, EventArgs e)
        {
            FormAddUser formAddUser = new FormAddUser();
            formAddUser.changeData = new FormAddUser.ChangeData(AlertActive);
            formAddUser.ShowDialog();
        }

        private void buttonChangeUser_Click(object sender, EventArgs e)
        {
            FormChangeUser formChangeUser = new FormChangeUser();
            formChangeUser.changeData = new FormChangeUser.ChangeData(AlertActive);
            formChangeUser.ShowDialog();
        }

        private void buttonAddGroup_Click(object sender, EventArgs e)
        {
            FormAddGroup formAddGroup = new FormAddGroup();
            formAddGroup.changeData = new FormAddGroup.ChangeData(AlertActive);
            formAddGroup.ShowDialog();
        }

        private void buttonChangeGroup_Click(object sender, EventArgs e)
        {
            FormChangeGroup formChangeGroup = new FormChangeGroup();
            formChangeGroup.changeData = new FormChangeGroup.ChangeData(AlertActive);
            formChangeGroup.ShowDialog();
        }
    }
}
