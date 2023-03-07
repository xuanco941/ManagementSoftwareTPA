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

namespace ManagementSoftware.GUI.ImportWareHouseManagement
{
    public partial class FormNhapKho : Form
    {
        Directive directive;
        public FormNhapKho(Directive d)
        {
            InitializeComponent();
            this.directive = d;

            labelHeader.Text = "Chỉ thị " + Common.DIRECTIVE + directive.DirectiveID;
            labelMaChiThi.Text = "Mã chỉ thị : " + Common.DIRECTIVE + directive.DirectiveID;
            labelMaSanPham.Text = "Thuộc mã sản phẩm : " + Common.PRODUCT + directive.Product.ProductID;
            labelNguoiVanHanh.Text = "Người thực hiện : " + BUSUser.GetUserFromUsername(directive.Worker)?.FullName + $"({directive.Worker})";
            labelSoLuongCanSX.Text = "Số lượng cần sản xuất : " + directive.SoLuongCanSanXuat;
            labelSoLuongDaSX.Text = "Số lượng đã sản xuất : " + directive.SoLuongDaSanXuat;
            labelBatDauNgay.Text = "Bắt đầu ngày : " + directive.BeginAt.ToString("dd/MM/yyyy");
            labelKetThucNgay.Text = "Kết thúc ngày : " + directive.EndAt.ToString("dd/MM/yyyy");
            labelSoLuongDaNhapKho.Text = "Số lượng đã nhập kho : " + BUSImportedWareHouse.GetImportedWareHouseOfDirective(directive.DirectiveID) + "/" + directive.SoLuongDaSanXuat;

        }


        void LoadComboBox()
        {

            List<string> strings = new List<string>() { "Tạo đơn mới" };
            List<ImportedWarehouse>? l = new DALImportedWareHouse().GetAllImportedWareHousesFromIDDirective(directive.DirectiveID);
            if (l != null && l.Count>0)
            {
                List<string> st = l.Select(a => Common.IMPORTED_WAREHOUSE + a.ImportedWarehouseID).ToList();
                strings.AddRange(st);
            }

            comboBoxDonNhapKho.DataSource = strings;
        }

        private void FormNhapKho_Load(object sender, EventArgs e)
        {

        }
    }
}
