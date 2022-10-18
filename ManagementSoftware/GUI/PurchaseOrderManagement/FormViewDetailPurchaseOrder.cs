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

namespace ManagementSoftware.GUI.PurchaseOrderManagement
{
    public partial class FormViewDetailPurchaseOrder : Form
    {
        PurchaseOrder purchaseOrder;
        public FormViewDetailPurchaseOrder(PurchaseOrder po)
        {
            InitializeComponent();
            this.purchaseOrder = po;

            labelMaPO.Text = "Đơn Hàng : " + Common.PURCHASEORDER +purchaseOrder.PurchaseOrderID;
            labelSoPRPQ.Text = "Số PR,PQ : " + purchaseOrder.SoPRPQ;
            labelTenKhachHang.Text = "Tên khách hàng : " + purchaseOrder.TenKhachHang;
            labelMaKhachHang.Text = "Mã khách hàng : " + purchaseOrder.MaKhachHang;
            labelDiaChi.Text = "Địa chỉ : " + purchaseOrder.DiaChi;
            labelNguoiLienHe.Text = "Người liên hệ : " + purchaseOrder.NguoiLienHe;
            labelNgayGiaoHang.Text = "Ngày giao hàng : " + purchaseOrder.NgayGiaoHang?.ToString("dd/MM/yyyy");
            labelThamChieu.Text = "Tham chiếu : " + purchaseOrder.ThamChieu;
            labelNgayDatHang.Text = "Ngày đặt hàng : " + purchaseOrder.CreateAt.ToString("dd/MM/yyyy");

            labelChiPhiVanChuyen.Text = "Chi phí vận chuyển : " + purchaseOrder.ChiPhiVanChuyen;
            labelChiPhiChuyenGiao.Text = "Chi phí chuyển giao : " + purchaseOrder.ChiPhiChuyenGiao;
            labelChiPhiKyThuat.Text = "Chi phí kỹ thuật : " + purchaseOrder.ChiPhiKyThuat;
            labelChiPhiKhac.Text = "Chi phí khác : " + purchaseOrder.ChiPhiKhac;

            labelVuot.Text = "Vượt : " + purchaseOrder.Vuot + "%";
            labelTongTienHang.Text = "Tổng tiền hàng (chưa VAT) : " + purchaseOrder.TongTienHang;
            labelVAT.Text = "VAT : " + purchaseOrder.VAT;

        }
    }
}
