using ManagementSoftware.BUS;
using ManagementSoftware.Models;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ManagementSoftware.GUI.Section
{
    public partial class FormItemWorkingList : Form
    {
        Directive directive;
        public FormItemWorkingList(Directive d)
        {
            InitializeComponent();
            this.directive = d;

            LoadForm();
        }
        void LoadForm()
        {
            labelNguoiThucHien.Text = "Người thực hiện : " + BUSUser.GetUserFromUsername(directive.Worker).FullName + $"({directive.Worker})";
            labelSoLuongCanSanXuat.Text = "Số lượng cần sản xuất : " + directive.SoLuongCanSanXuat;
            labelNgayBatDau.Text = "Ngày bắt đầu : " + directive.BeginAt.ToString("dd/MM/yyyy");
            labelNgayKetThuc.Text = "Ngày kết thúc : " + directive.EndAt.ToString("dd/MM/yyyy");
            labelSoLuongDaSanXuat.Text = "Số lượng đã sản xuất : " + directive.SoLuongDaSanXuat;

        }

        private void buttonDashboard_Click(object sender, EventArgs e)
        {

        }
    }
}
