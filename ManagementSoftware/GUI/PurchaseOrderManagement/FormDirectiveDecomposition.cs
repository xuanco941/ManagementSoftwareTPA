using ManagementSoftware.BUS;
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
    public partial class FormDirectiveDecomposition : Form
    {
        public FormDirectiveDecomposition(PurchaseOrder purchase)
        {
            InitializeComponent();
            labelHeader.Text = "Phân chia chỉ thị sản xuất cho mỗi sản phẩm đơn hàng " + Common.PURCHASEORDER + purchase.PurchaseOrderID;

            panelMain.Controls.Clear();
            List<Product> list = BUSProduct.GetProductOfPO(purchase.PurchaseOrderID);
            for (int i = 0; i < list.Count; i++)
            {
                FormItemProductOfListDirective form = new FormItemProductOfListDirective(list[i]);
                form.TopLevel = false;
                panelMain.Controls.Add(form);
                form.FormBorderStyle = FormBorderStyle.None;
                form.Dock = DockStyle.Top;
                form.Show();
            }
        }
    }
}
