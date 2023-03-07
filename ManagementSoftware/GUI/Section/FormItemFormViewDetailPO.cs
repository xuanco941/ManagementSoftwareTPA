using ManagementSoftware.DAL;
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
using static System.Windows.Forms.VisualStyles.VisualStyleElement.StartPanel;

namespace ManagementSoftware.GUI.Section
{
    public partial class FormItemFormViewDetailPO : Form
    {
        Product p;
        public delegate void DeleteProductDelegate(Product prod);
        public DeleteProductDelegate deleteProductDelegate;
        public FormItemFormViewDetailPO(Product product)
        {
            InitializeComponent();
            p = product;
            labelProductName.Text = "Tên sản phẩm : " + product.ProductName;
            labelApSuatNap.Text = "Áp suất nạp : " + product.ApSuatNap;
            labelLoaiKhi.Text = "Loại khí : " + product.LoaiKhi;
            labelChatLuongKhi.Text = "Chất lượng khí : " + product.ChatLuongKhi + "%";
            labelSoLuongSx.Text = "Số lượng sản xuất : " + product.SoLuongSanXuat;
            labelTheTichBinh.Text = "Thể tích bình : " + product.TheTichBinh;

            labelNum.Text = Common.PRODUCT + product.ProductID;
        }

        private void buttonClose_Click(object sender, EventArgs e)
        {
            DialogResult dialogResult = MessageBox.Show($"Bạn có chắc muốn xóa sản phẩm {Common.PRODUCT+p.ProductID}", "Thông báo", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (dialogResult == DialogResult.Yes)
            {
                DALProduct.Delete(p.ProductID);
                deleteProductDelegate?.Invoke(p);
                this.Close();
            }

        }

    }
}
