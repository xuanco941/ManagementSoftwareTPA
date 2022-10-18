using ManagementSoftware.GUI.PurchaseOrderManagement;
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
    public partial class FormItemPO : Form
    {
        PurchaseOrder purchase;
        public FormItemPO(PurchaseOrder po)
        {
            InitializeComponent();
            this.purchase = po;

            labelMaPO.Text = "Số PO : " + Common.PURCHASEORDER + purchase.PurchaseOrderID;
            labelDiaDiem.Text = "Địa điểm : " + purchase.DiaDiemGiaoHang;
            labelNgayGiao.Text = "Ngày giao : " + purchase.NgayGiaoHang?.ToString("dd/MM/yyyy");
            labelMaKhachHang.Text = "Mã khách hàng : " + purchase.MaKhachHang;
            labelTenKhachHang.Text = "Tên khách hàng : " + purchase.TenKhachHang;
            labelTrangThai.Text =purchase.Status == false ? "Trạng thái : Đang sản xuất" : "Trạng thái : Đã hoàn thành";

            progressBarTienTrinh.Value = Convert.ToInt32( Math.Round((double)purchase.SoSanPhamDaSX / (double)purchase.SoSanPhamCanSX,2,MidpointRounding.AwayFromZero) * 100);

            if(purchase.Status == true)
            {
                progressBarTienTrinh.BackColor = Color.Green;
            }
        }

        private void buttonViewDetail_Click(object sender, EventArgs e)
        {
            new FormViewDetailPurchaseOrder().Show();
        }
    }
}
