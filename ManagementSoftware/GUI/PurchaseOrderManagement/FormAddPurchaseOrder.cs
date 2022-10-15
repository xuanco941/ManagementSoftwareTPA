using ManagementSoftware.GUI.Section;
using ManagementSoftware.Models;
using Syncfusion.Pdf.Parsing;
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
    public partial class FormAddPurchaseOrder : Form
    {
        Dictionary<int, Product> productDictionary = new Dictionary<int, Product>();
        PurchaseOrder purchaseOrder = new PurchaseOrder();

        int key = 1;
        public FormAddPurchaseOrder()
        {
            InitializeComponent();
        }

        void RemoveProductOnList(int position)
        {
            productDictionary.Remove(position);
        }

        void LoadProducts()
        {
            panelProducts.Controls.Clear();
            if (productDictionary.Count > 0)
            {
                foreach (var pr in productDictionary)
                {
                    FormItemProductOfPO form = new FormItemProductOfPO(pr.Value, pr.Key);
                    form.deleteProductDelegate = new FormItemProductOfPO.DeleteProductDelegate(RemoveProductOnList);
                    form.TopLevel = false;
                    panelProducts.Controls.Add(form);
                    form.FormBorderStyle = FormBorderStyle.None;
                    form.Dock = DockStyle.Top;
                    form.Show();
                }
            }
        }

        private void AddProductToList(Product product)
        {
            productDictionary.Add(this.key,product);
            this.key++;
            LoadProducts();
        }

        private void buttonAddProduct_Click(object sender, EventArgs e)
        {
            FormAddProductOnPO form = new FormAddProductOnPO();
            form.addProductDelegate = new FormAddProductOnPO.AddProductDelegate(AddProductToList);
            form.ShowDialog();
        }

        private void buttonAddPO_Click(object sender, EventArgs e)
        {
            purchaseOrder.SoPRPQ = txtPRPQ.Text.Trim();
            purchaseOrder.TenKhachHang = txtOrdererName.Text.Trim();
            purchaseOrder.MaKhachHang = txtCodeOrderer.Text.Trim();
            purchaseOrder.DiaChi = txtAddress.Text.Trim();
            purchaseOrder.NguoiLienHe = txtContactPerson.Text.Trim();
            purchaseOrder.NgayGiaoHang = txtDeliveryDate.Value;
            purchaseOrder.ThamChieu = txtReference.Text.Trim();
            purchaseOrder.NhanVienMuaHang = txtBuyer.Text.Trim();

            purchaseOrder.ChiPhiVanChuyen = txtChiPhiVanChuyen.IntegerValue;
            purchaseOrder.ChiPhiChuyenGiao = txtChiPhiChuyenGiao.IntegerValue;
            purchaseOrder.ChiPhiKyThuat = txtChiPhiKyThuat.IntegerValue;
            purchaseOrder.ChiPhiKhac = txtChiPhiKhac.IntegerValue;
            purchaseOrder.Vuot = (int)txtVuot.IntegerValue;
            purchaseOrder.TongTienHang = (int)txtTongTienHang.IntegerValue;
            purchaseOrder.VAT = txtVAT.IntegerValue;
            purchaseOrder.TongTienThanhToan = txtTongTienThanhToan.IntegerValue;

            purchaseOrder.DiaDiemGiaoHang = txtDiaDiemGiaoHang.Text.Trim();
            purchaseOrder.ThanhToan = txtThanhToan.Text.Trim();
            purchaseOrder.ThongTinNganHang = txtBankInfo.Text.Trim();
            purchaseOrder.GhiChu = txtNote.Text.Trim();
            purchaseOrder.OrderCreator = Common.USERSESSION?.Username ?? Common.UserAdmin.Username;
            purchaseOrder.Status = false;

        }
    }
}
