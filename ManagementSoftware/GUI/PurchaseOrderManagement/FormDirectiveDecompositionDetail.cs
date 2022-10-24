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
    public partial class FormDirectiveDecompositionDetail : Form
    {
        public delegate void ChangeData();
        public ChangeData changeData;

        Product product;
        public FormDirectiveDecompositionDetail(Product p)
        {
            InitializeComponent();
            this.product = p;
            LoadForm();
        }

        void LoadForm()
        {
            labelHeader.Text = "Chỉ thị sản xuất của sản phẩm " + Common.PURCHASEORDER + product.ProductID;
        }
    }
}
