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
    public partial class FormItemProductOfPO : Form
    {
        public delegate void DeleteProductDelegate(int position);
        public DeleteProductDelegate deleteProductDelegate;

        int position = -1;
        Product p;
        public FormItemProductOfPO(Product product, int position)
        {
            InitializeComponent();
            this.position = position;
            p = product;
            labelProductName.Text = "Tên sản phẩm : " + product.ProductName;
            labelApSuatNap.Text = "Áp suất nạp : " + product.ApSuatNap;
            labelLoaiKhi.Text = "Loại khí : " + product.LoaiKhi;
            labelChatLuongKhi.Text = "Chất lượng khí : " + product.ChatLuongKhi + "%";
            labelSoLuongSx.Text = "Số lượng sx : " + product.SoLuongSanXuat;
            labelTheTichBinh.Text = "Thể tích bình : " + product.TheTichBinh;
            labelQuyCach.Text = "Quy cách : " + product.QuyCach + "L";
        }

        private void buttonViewDetail_Click(object sender, EventArgs e)
        {
            DialogResult dialogResult = MessageBox.Show($"Bạn có chắc muốn xóa sản phẩm {Common.PRODUCT + p.ProductID}", "Thông báo", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (dialogResult == DialogResult.Yes)
            {
                deleteProductDelegate.Invoke(this.position);
                this.Close();
            }

        }
    }
}
