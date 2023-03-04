using ManagementSoftware.BUS;
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
using static ManagementSoftware.GUI.PurchaseOrderManagement.FormAddProductOnPO;

namespace ManagementSoftware.GUI.PurchaseOrderManagement
{
    public partial class FormAddDirective : Form
    {
        public delegate void AddDirectiveDelegate(Directive d);
        public AddDirectiveDelegate addDirectiveDelegate;
        int IDProduct;
        public FormAddDirective(int idProduct)
        {
            InitializeComponent();
            IDProduct = idProduct;
            comboBoxTenNguoiLam.DataSource = BUSUser.GetListUsername();
            
        }

        private void buttonThem_Click(object sender, EventArgs e)
        {
            if (String.IsNullOrEmpty(comboBoxTenNguoiLam.Text) || NgayBatDau.Value == null || NgayKetThuc.Text == null ||
    String.IsNullOrEmpty(txtSoLuongSX.Text))
            {
                MessageBox.Show("Vui lòng nhập đủ thông tin của chỉ thị.", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            else
            {
                Directive directive = new Directive();
                directive.Worker = comboBoxTenNguoiLam.Text;
                directive.BeginAt = NgayBatDau.Value ?? DateTime.Now;
                directive.EndAt = NgayKetThuc.Value ?? DateTime.Now;
                directive.SoLuongCanSanXuat = (int)txtSoLuongSX.IntegerValue;
                directive.UserID = BUSUser.GetUserFromUsername(comboBoxTenNguoiLam.Text).UserID;
                directive.ProductID = IDProduct;
                try
                {
                    int result = DALDirective.Add(directive);
                    if (result > 0)
                    {
                        addDirectiveDelegate?.Invoke(directive);
                        this.Close();
                    }
                    else
                    {
                        MessageBox.Show("Thêm không thành công", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
                catch
                {
                    MessageBox.Show("Thêm không thành công", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }

            }
        }
    }
}
