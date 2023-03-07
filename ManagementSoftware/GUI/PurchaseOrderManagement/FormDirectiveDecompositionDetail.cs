using ManagementSoftware.BUS;
using ManagementSoftware.GUI.Section;
using ManagementSoftware.Models;
using ManagementSoftware.ViewModels;
using Syncfusion.Windows.Forms.PivotAnalysis;
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
    public partial class FormDirectiveDecompositionDetail : Form
    {
        public delegate void ChangeData(Form form);
        public ChangeData changeData;

        Product product;
        PurchaseOrder purchaseOrder;

        Dictionary<int, Directive> productDictionary = new Dictionary<int, Directive>();
        int key = 1;
        public FormDirectiveDecompositionDetail(Product p, PurchaseOrder po)
        {
            InitializeComponent();
            this.product = p;
            this.purchaseOrder = po;


            labelHeader.Text = "Chỉ thị sản xuất của sản phẩm " + Common.PRODUCT + product.ProductID + $" ({Common.PURCHASEORDER + this.purchaseOrder.PurchaseOrderID})";
            labelMaSanPham.Text = "Mã sản phẩm : " + Common.PRODUCT + this.product.ProductID;
            labelTenSanPham.Text = "Tên sản phẩm : " + this.product.ProductName;
            labelLoaiKhi.Text = "Loại khí : " + this.product.LoaiKhi;
            labelApSuatNap.Text = "Áp suất nạp : " + this.product.ApSuatNap;
            labelTheTichBinh.Text = "Thể tích bình : " + this.product.TheTichBinh;
            labelChatLuongKhi.Text = "Chất lượng khí : " + this.product.ChatLuongKhi;
            labelSoLuongSanXuat.Text = "Số lượng sản xuất : " + this.product.SoLuongSanXuat;

            LoadForm();
        }

        void LoadForm()
        {
            productDictionary.Clear();
            List<Directive> list = BUSDirective.GetAllDirectiveOfProduct(this.product.ProductID);
            if (list.Count > 0)
            {
                foreach (var d in list)
                {
                    productDictionary.Add(this.key, d);
                    this.key++;
                }
                LoadDirectives();
            }
        }


        void RemoveDirectiveOnList(int position)
        {
            productDictionary.Remove(position);
        }

        void LoadDirectives()
        {
            new MethodCommonGUI().CloseFormInPanel(panelChiThiSX);

            if (productDictionary.Count > 0)
            {
                foreach (var pr in productDictionary)
                {
                    FormItemAddChiThiSX form = new FormItemAddChiThiSX(pr.Value, pr.Key);
                    form.deleteChiThiSXDelegate = new FormItemAddChiThiSX.DeleteChiThiSXDelegate(RemoveDirectiveOnList);
                    form.TopLevel = false;
                    panelChiThiSX.Controls.Add(form);
                    form.FormBorderStyle = FormBorderStyle.None;
                    form.Dock = DockStyle.Top;
                    form.Show();
                }
            }
        }

        private void AddDirectiveToList(Directive directive)
        {
            productDictionary.Add(this.key, directive);
            this.key++;
            LoadDirectives();
        }


        private void buttonBack_Click(object sender, EventArgs e)
        {
            changeData.Invoke(new FormDirectiveDecomposition(purchaseOrder));
        }

        private void buttonConfirm_Click(object sender, EventArgs e)
        {
            changeData.Invoke(new FormDirectiveDecomposition(purchaseOrder));
        }

        private void buttonAddProduct_Click_1(object sender, EventArgs e)
        {
            FormAddDirective form = new FormAddDirective(this.product.ProductID);
            form.addDirectiveDelegate = new FormAddDirective.AddDirectiveDelegate(AddDirectiveToList);
            form.ShowDialog();
        }

        private void FormDirectiveDecompositionDetail_FormClosing(object sender, FormClosingEventArgs e)
        {
            changeData.Invoke(new FormDirectiveDecomposition(purchaseOrder));
        }
    }
}
