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
        // Define delegate
        public delegate void ChangeData(string msg, FormAlert.enmType enmType);
        public ChangeData changeData;

        public delegate void ChangeFormMain(Form form, string header);
        public ChangeFormMain changeFormMain;

        PurchaseOrder purchase = new PurchaseOrder();
        public FormItemPO(PurchaseOrder po)
        {
            InitializeComponent();
            this.purchase = po;

            labelMaPO.Text = "Số PO : " + Common.PURCHASEORDER + purchase.PurchaseOrderID;
            labelDiaDiem.Text = "Địa điểm : " + purchase.DiaChi;
            labelNgayGiao.Text = "Ngày giao : " + purchase.NgayGiaoHang?.ToString("dd/MM/yyyy");
            labelMaKhachHang.Text = "Mã khách hàng : " + purchase.MaKhachHang;
            labelTenKhachHang.Text = "Tên khách hàng : " + purchase.TenKhachHang;
            labelTrangThai.Text =purchase.Status == false ? "Trạng thái : Đang sản xuất" : "Trạng thái : Đã hoàn thành";

            try
            {
                progressBarTienTrinh.Value = Convert.ToInt32(Math.Round((double)purchase.SoSanPhamDaSX / (double)purchase.SoSanPhamCanSX, 2, MidpointRounding.AwayFromZero) * 100);
            }
            catch
            {
                progressBarTienTrinh.Value = 0;
            }

            if (purchase.Status == true)
            {
                progressBarTienTrinh.BackColor = Color.Green;
            }
        }

        void ActiveAlert(string msg, FormAlert.enmType enmType)
        {
            this.changeData.Invoke(msg, enmType);
        }

        void ChangeForm(Form form, string header)
        {
            changeFormMain.Invoke(form, header);
        }

        private void buttonViewDetail_Click(object sender, EventArgs e)
        {
            FormViewDetailPurchaseOrder form = new FormViewDetailPurchaseOrder(purchase);
            form.changeData = new FormViewDetailPurchaseOrder.ChangeData(ActiveAlert);
            form.changeFormMain = new FormViewDetailPurchaseOrder.ChangeFormMain(ChangeForm);

            this.changeFormMain.Invoke(form, "Đơn hàng " + Common.PURCHASEORDER+ this.purchase.PurchaseOrderID);
        }
    }
}
