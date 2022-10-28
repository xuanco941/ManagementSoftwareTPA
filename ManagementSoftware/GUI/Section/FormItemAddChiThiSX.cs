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

        public FormItemAddChiThiSX(Directive directive, int p)
        {
            InitializeComponent();
            this.position = p;

            labelMaChiThi.Text = "Mã chỉ thị : " + (directive.DirectiveID != 0 ? Common.DIRECTIVE + directive.DirectiveID : Common.DIRECTIVE);
            labelSoLuongDaSX.Text = "Số lượng đã sản xuất : " + directive.SoLuongDaSanXuat;
            labelNgayBatDau.Text = "Ngày bắt đầu : " + directive.BeginAt.ToString("dd/MM/yyyy");
            labelNgayKetThuc.Text = "Ngày kết thúc : " + directive.EndAt.ToString("dd/MM/yyyy");
            labelNguoiLam.Text = "Người làm : " + directive.Worker;
            labelSoLuongSX.Text = "Số lượng sản xuất : " + directive.SoLuongCanSanXuat;
        }

        private void buttonClose_Click(object sender, EventArgs e)
        {
            deleteChiThiSXDelegate.Invoke(this.position);
            this.Close();
        }
    }
}
