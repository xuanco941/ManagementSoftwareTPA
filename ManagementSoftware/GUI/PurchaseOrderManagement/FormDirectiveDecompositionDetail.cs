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
        public delegate void ChangeData(Form form);
        public ChangeData changeData;

        Product product;
        PurchaseOrder purchaseOrder;
        public FormDirectiveDecompositionDetail(Product p,PurchaseOrder po)
        {
            InitializeComponent();
            this.product = p;
            this.purchaseOrder = po;
            LoadForm();
        }

        void LoadForm()
        {
            labelHeader.Text = "Chỉ thị sản xuất của sản phẩm " + Common.PURCHASEORDER + product.ProductID;
        }

        private void buttonBack_Click(object sender, EventArgs e)
        {
            changeData.Invoke(new FormDirectiveDecomposition(purchaseOrder));
        }

        private void buttonConfirm_Click(object sender, EventArgs e)
        {
            changeData.Invoke(new FormDirectiveDecomposition(purchaseOrder));
        }
    }
}
