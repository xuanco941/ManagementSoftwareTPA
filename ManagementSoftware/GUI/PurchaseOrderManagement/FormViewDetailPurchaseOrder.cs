using ManagementSoftware.BUS;
using ManagementSoftware.GUI.Section;
using ManagementSoftware.Models;
using Syncfusion.XPS;
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
        public delegate void ChangeData(string msg, FormAlert.enmType enmType);
        public ChangeData changeData;


        PurchaseOrder purchaseOrder;
        public FormViewDetailPurchaseOrder(PurchaseOrder po)
        {
            InitializeComponent();
            this.purchaseOrder = po;
            LoadForm();
        }

        void LoadForm()
        {

            labelMaPO.Text = "Đơn Hàng : " + Common.PURCHASEORDER + purchaseOrder.PurchaseOrderID;
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
            labelThanhToan.Text = "Thanh toán : " + purchaseOrder.ThanhToan;
            labelThongTinBank.Text = "Ngân hàng : " + purchaseOrder.ThongTinNganHang;
            labelNote.Text = "Ghi chú : " + purchaseOrder.GhiChu;

            labelTongTien.Text = purchaseOrder.TongTienThanhToan + "đ";

            panelProducts.Controls.Clear();
            List<Product> list = BUSProduct.GetProductOfPO(purchaseOrder.PurchaseOrderID);
            for (int i = 0; i < list.Count; i++)
            {
                FormItemFormViewDetailPO form = new FormItemFormViewDetailPO(list[i]);
                form.TopLevel = false;
                panelProducts.Controls.Add(form);
                form.FormBorderStyle = FormBorderStyle.None;
                form.Dock = DockStyle.Top;
                form.Show();
            }
        }

        private void buttonXoaPO_Click(object sender, EventArgs e)
        {
            DialogResult dialogResult = MessageBox.Show($"Bạn có chắc muốn xóa đơn hàng {Common.PURCHASEORDER+purchaseOrder.PurchaseOrderID}?", "Thông báo", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (dialogResult == DialogResult.Yes)
            {
                if(BUSPurchaseOrder.Delete(purchaseOrder.PurchaseOrderID).Status == true)
                {
                    this.Close();
                    changeData?.Invoke("Xóa thành công.", FormAlert.enmType.Success);
                }
                else
                {
                    MessageBox.Show("Không thể xóa đơn hàng này.", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }

        }

        private void buttonChiThiSX_Click(object sender, EventArgs e)
        {
            new FormDirectiveDecomposition(purchaseOrder).ShowDialog();
        }

    }
}
