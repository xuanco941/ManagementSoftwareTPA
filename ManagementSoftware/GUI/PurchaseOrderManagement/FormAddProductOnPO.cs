using ManagementSoftware.GUI.Section;
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
    public partial class FormAddProductOnPO : Form
    {
        public delegate void AddProductDelegate(Product pr);
        public AddProductDelegate addProductDelegate;
        public FormAddProductOnPO()
        {
            InitializeComponent();
        }

        private void buttonThem_Click(object sender, EventArgs e)
        {
            if (String.IsNullOrEmpty(txtProductName.Text) || String.IsNullOrEmpty(txtLoaiKhi.Text) || String.IsNullOrEmpty(txtTheTichBinh.Text) ||
                String.IsNullOrEmpty(txtChatLuongKhi.Text) || String.IsNullOrEmpty(txtApSuatNap.Text) || String.IsNullOrEmpty(txtSlsx.Text))
            {
                MessageBox.Show("Vui lòng nhập đủ thông tin của sản phẩm.", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            else
            {
                Product product = new Product();
                product.ProductName = txtProductName.Text.Trim();
                product.LoaiKhi = txtLoaiKhi.Text.Trim();
                product.TheTichBinh = txtTheTichBinh.DoubleValue;
                product.ChatLuongKhi = (int)txtChatLuongKhi.IntegerValue;
                product.ApSuatNap = txtApSuatNap.DoubleValue;
                product.SoLuongSanXuat = (int)txtSlsx.IntegerValue;
                addProductDelegate?.Invoke(product);
                this.Close();
            }

        }
    }
}
