using ManagementSoftware.BUS;
using ManagementSoftware.DAL;
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
        }


        List<Product> listProduct = new List<Product>();
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

            new MethodCommonGUI().CloseFormInPanel(panelProducts);

            for (int i = 0; i < listProduct.Count; i++)
            {
                FormItemFormViewDetailPO form = new FormItemFormViewDetailPO(listProduct[i]);
                form.deleteProductDelegate = new FormItemFormViewDetailPO.DeleteProductDelegate(Delete);
                form.TopLevel = false;
                panelProducts.Controls.Add(form);
                form.FormBorderStyle = FormBorderStyle.None;
                form.Dock = DockStyle.Top;
                form.Show();
            }
        }


        void Delete(Product f)
        {
            if (listProduct != null && listProduct.Count > 0)
            {
                Product? userToDelete = listProduct.FirstOrDefault(u => u.ProductID == f.ProductID);
                if (userToDelete != null)
                {
                    listProduct.Remove(userToDelete);
                    LoadForm();
                }
            }


        }

        private void buttonXoaPO_Click(object sender, EventArgs e)
        {
            DialogResult dialogResult = MessageBox.Show($"Bạn có chắc muốn xóa đơn hàng {Common.PURCHASEORDER + purchaseOrder.PurchaseOrderID}?", "Thông báo", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (dialogResult == DialogResult.Yes)
            {
                if (BUSPurchaseOrder.Delete(purchaseOrder.PurchaseOrderID).Status == true)
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

        private void FormViewDetailPurchaseOrder_Load(object sender, EventArgs e)
        {
            listProduct = BUSProduct.GetProductOfPO(purchaseOrder.PurchaseOrderID);
            LoadForm();
        }


        void AddProductToList(Product pr)
        {
            pr.PurchaseOrderID = purchaseOrder.PurchaseOrderID;
            if (DALProduct.Add(pr) > 0)
            {
                listProduct.Add(pr);
                LoadForm();
            }

        }

        private void buttonAddProduct_Click(object sender, EventArgs e)
        {
            FormAddProductOnPO form = new FormAddProductOnPO();
            form.addProductDelegate = new FormAddProductOnPO.AddProductDelegate(AddProductToList);
            form.ShowDialog();
        }
    }
}
