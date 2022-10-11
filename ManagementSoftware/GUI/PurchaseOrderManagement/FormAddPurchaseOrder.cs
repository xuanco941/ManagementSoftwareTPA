using ManagementSoftware.GUI.Section;
using Syncfusion.Pdf.Parsing;
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
    public partial class FormAddPurchaseOrder : Form
    {
        public FormAddPurchaseOrder()
        {
            InitializeComponent();
            LoadProducts();
        }

        void LoadProducts()
        {
            for (int i = 0; i < 10; i++)
            {
                FormItemProductOfPO form = new FormItemProductOfPO();
                form.TopLevel = false;
                panelProducts.Controls.Add(form);
                form.FormBorderStyle = FormBorderStyle.None;
                form.Dock = DockStyle.Top;
                form.Show();
            }
        }

        private void LoadForm()
        {
            DataTable dt = new DataTable();
            dt.Columns.Add("Stt");
            dt.Columns.Add("Tên hàng");
            dt.Columns.Add("Mã hàng");
            dt.Columns.Add("Thể tích bình");

            dt.Columns.Add("Áp suất nạp");
            dt.Columns.Add("Loại khí");
            dt.Columns.Add("Chất lượng khí");

            dt.Columns.Add("DVT");
            dt.Columns.Add("Số lượng");
            dt.Columns.Add("Đơn giá");

            dt.Columns.Add("Thành tiền");
        }
    }
}
