using ManagementSoftware.BUS;
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
    public partial class FormItemProductOfListDirective : Form
    {
        public delegate void ChangeData(Form form);
        public ChangeData changeData;

        Product product;
        PurchaseOrder purchaseOrder;
        public FormItemProductOfListDirective(Product p, PurchaseOrder po)
        {
            InitializeComponent();
            this.product = p;
            this.purchaseOrder = po;

            labelProductName.Text = "Tên sản phẩm : " + product.ProductName;
            labelApSuatNap.Text = "Áp suất nạp : " + product.ApSuatNap;
            labelLoaiKhi.Text = "Loại khí : " + product.LoaiKhi;
            labelChatLuongKhi.Text = "Chất lượng khí : " + product.ChatLuongKhi + "%";
            labelSoLuongSx.Text = "Số lượng sản xuất : " + product.SoLuongSanXuat;
            labelTheTichBinh.Text = "Thể tích bình : " + product.TheTichBinh;

            labelNum.Text = Common.PRODUCT + product.ProductID;
            LoadStatusChiThi();
        }

        void LoadStatusChiThi()
        {
            labelStatus.Text = BUSProduct.GetSoLuongSanXuatDaPhanChiThiOnProduct(product.ProductID) + "/" + product.SoLuongSanXuat;
        }
        void LoadForm(Form form)
        {
            changeData.Invoke(form);
        }
        private void buttonPhanTi_Click(object sender, EventArgs e)
        {
            FormDirectiveDecompositionDetail form = new FormDirectiveDecompositionDetail(this.product, this.purchaseOrder);
            form.changeData = new FormDirectiveDecompositionDetail.ChangeData(LoadForm);
            this.changeData.Invoke(form);
        }
    }
}
