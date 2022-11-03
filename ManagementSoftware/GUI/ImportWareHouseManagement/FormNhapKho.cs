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

namespace ManagementSoftware.GUI.ImportWareHouseManagement
{
    public partial class FormNhapKho : Form
    {
        Product product;
        Directive directive;
        public FormNhapKho(Directive d, Product p)
        {
            InitializeComponent();
            this.product = p;
            this.directive = d;

            labelHeader.Text = "Chỉ thị " + Common.DIRECTIVE + directive.DirectiveID;
            labelMaChiThi.Text = "Mã chỉ thị : " + Common.DIRECTIVE + directive.DirectiveID;
            labelMaSanPham.Text = "Thuộc mã sản phẩm : " + Common.PRODUCT + directive.ProductID;
            labelNguoiVanHanh.Text = "Người thực hiện : " + BUSUser.GetUserFromUsername(directive.Worker)?.FullName + $"({directive.Worker})";
            labelSoLuongCanSX.Text = "Số lượng cần sản xuất : " + directive.SoLuongCanSanXuat;
            labelSoLuongDaSX.Text = "Số lượng đã sản xuất : " + directive.SoLuongDaSanXuat;
            labelBatDauNgay.Text = "Bắt đầu ngày : " + directive.BeginAt.ToString("dd/MM/yyyy");
            labelKetThucNgay.Text = "Kết thúc ngày : " + directive.EndAt.ToString("dd/MM/yyyy");
            labelSoLuongDaNhapKho.Text = "Số lượng đã nhập kho : " + BUSImportedWareHouse.GetImportedWareHouseOfDirective(directive.DirectiveID) + "/" + directive.SoLuongDaSanXuat;

        }
    }
}
