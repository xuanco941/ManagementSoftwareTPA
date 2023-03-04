using ManagementSoftware.BUS;
using ManagementSoftware.GUI.Section;
using ManagementSoftware.Models;
using Syncfusion.XPS;
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
        PurchaseOrder purchaseOrder;
        public FormDirectiveDecomposition(PurchaseOrder purchase)
        {
            InitializeComponent();
            this.purchaseOrder = purchase;
            LoadForm();
        }
        void LoadForm()
        {
            labelHeader.Text = "Danh sách sản phẩm của đơn hàng " + Common.PURCHASEORDER + purchaseOrder.PurchaseOrderID;

            List<Form> oldForms = new List<Form>();
            foreach (Form oldForm in panelMain.Controls)
            {
                oldForms.Add(oldForm);
            }
            foreach (Form oldForm in oldForms)
            {
                oldForm.Close();
                oldForm.Dispose();
            }


            List<Product> list = BUSProduct.GetProductOfPO(purchaseOrder.PurchaseOrderID);
            for (int i = 0; i < list.Count; i++)
            {
                FormItemProductOfListDirective form = new FormItemProductOfListDirective(list[i], purchaseOrder);
                form.changeData = new FormItemProductOfListDirective.ChangeData(ChangeForm);
                form.TopLevel = false;
                panelMain.Controls.Add(form);
                form.FormBorderStyle = FormBorderStyle.None;
                form.Dock = DockStyle.Top;
                form.Show();
            }
        }
        private void ChangeForm(Form form)
        {
            //remove controls in panel
            this.Controls.Clear();
            //set new content
            form.TopLevel = false;
            this.Controls.Add(form);
            form.FormBorderStyle = FormBorderStyle.None;
            form.Dock = DockStyle.Fill;
            form.Show();
            this.Font = Common.FontForm;
        }
    }
}
