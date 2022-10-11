using ManagementSoftware.GUI.PurchaseOrderManagement;
using ManagementSoftware.GUI.Section;
using Syncfusion.Windows.Forms.Tools;
using Syncfusion.XPS;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ManagementSoftware.GUI
{
    public partial class FormPurchaseOrder : Form
    {
        public delegate void CallAlert(string msg, FormAlert.enmType type);
        public CallAlert callAlert;

        private void GetItemPO()
        {
            for(int i = 0; i<10; i++)
            {
                FormItemPO form = new FormItemPO();
                form.TopLevel = false;
                panelMain.Controls.Add(form);
                form.FormBorderStyle = FormBorderStyle.None;
                form.Dock = DockStyle.Top;
                form.Show();
            }
        }



        public FormPurchaseOrder()
        {
            InitializeComponent();
            GetItemPO();
            
        }

        private void addPO_Click(object sender, EventArgs e)
        {
            new FormAddPurchaseOrder().ShowDialog();
        }

    }
}
