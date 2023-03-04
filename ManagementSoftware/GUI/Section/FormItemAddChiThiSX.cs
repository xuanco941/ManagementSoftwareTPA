using ManagementSoftware.BUS;
using ManagementSoftware.DAL;
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
    public partial class FormItemAddChiThiSX : Form
    {
        public delegate void DeleteChiThiSXDelegate(int position);
        public DeleteChiThiSXDelegate deleteChiThiSXDelegate;

        int position = -1;
        Directive d;
        public FormItemAddChiThiSX(Directive directive, int p)
        {
            InitializeComponent();
            this.position = p;
            this.d = directive;

            labelMaChiThi.Text = "Mã chỉ thị : " + Common.DIRECTIVE + directive.DirectiveID;
            labelSoLuongDaSX.Text = "Số lượng đã sản xuất : " + directive.SoLuongDaSanXuat;
            labelNgayBatDau.Text = "Ngày bắt đầu : " + directive.BeginAt.ToString("dd/MM/yyyy");
            labelNgayKetThuc.Text = "Ngày kết thúc : " + directive.EndAt.ToString("dd/MM/yyyy");
            labelNguoiLam.Text = "Người làm : " + BUSUser.GetUserFromUsername(directive.Worker).FullName + $"({directive.Worker})";
            labelSoLuongSX.Text = "Số lượng sản xuất : " + directive.SoLuongCanSanXuat;
        }

        private void buttonClose_Click(object sender, EventArgs e)
        {
            if (d.SoLuongDaSanXuat != 0)
            {
                MessageBox.Show($"Không thể xóa! Chỉ thị này đang được thực hiện với tiến trình {d.SoLuongDaSanXuat}/{d.SoLuongCanSanXuat}.", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            else
            {
                if (d.DirectiveID != 0)
                {
                    int result = DALDirective.Delete(d.DirectiveID);
                    if (result < 1)
                    {
                        MessageBox.Show("Gặp lỗi khi loại bỏ chỉ thị này.", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                        return;
                    }
                }
                deleteChiThiSXDelegate.Invoke(this.position);
                this.Close();
            }
        }
    }
}
