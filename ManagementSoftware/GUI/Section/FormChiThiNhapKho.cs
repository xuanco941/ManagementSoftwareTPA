using ManagementSoftware.BUS;
using ManagementSoftware.GUI.ImportWareHouseManagement;
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
    public partial class FormChiThiNhapKho : Form
    {
        Directive directive;
        public FormChiThiNhapKho(Directive d)
        {
            InitializeComponent();
            this.directive = d;
            LoadForm();
        }

        void LoadForm()
        {
            labelMaChiThi.Text = "Mã chỉ thị : " + (directive.DirectiveID != 0 ? Common.DIRECTIVE + directive.DirectiveID : Common.DIRECTIVE);
            labelSoLuongDaSX.Text = "Số lượng đã sản xuất : " + directive.SoLuongDaSanXuat;
            labelNgayBatDau.Text = "Ngày bắt đầu : " + directive.BeginAt.ToString("dd/MM/yyyy");
            labelNgayKetThuc.Text = "Ngày kết thúc : " + directive.EndAt.ToString("dd/MM/yyyy");
            labelNguoiLam.Text = "Người thực hiện : " + BUSUser.GetUserFromUsername(directive.Worker)?.FullName + $"({directive.Worker})";
            labelSoLuongSX.Text = "Số lượng sản xuất : " + directive.SoLuongCanSanXuat;
            labelMaSanPham.Text = "Thuộc mã sản phẩm : " + Common.PRODUCT + directive.Product.ProductID;
            labelDonHang.Text = "Thuộc mã đơn hàng : " + Common.PURCHASEORDER + directive.Product.PurchaseOrderID;
        }

        private void buttonNhapKho_Click(object sender, EventArgs e)
        {
            new FormNhapKho(this.directive).ShowDialog();
        }
    }
}
