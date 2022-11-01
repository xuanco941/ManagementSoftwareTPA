using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using ManagementSoftware.BUS;
using ManagementSoftware.GUI.Section;
using ManagementSoftware.Models;

namespace ManagementSoftware.GUI
{
    public partial class WorkingList : Form
    {
        // Aleart
        public delegate void CallAlert(string msg, FormAlert.enmType type);
        public CallAlert callAlert;

        //change form
        public delegate void ChangeForm(Form form);
        public ChangeForm changeForm;

        public WorkingList()
        {
            InitializeComponent();
            LoadForm();
            label1.Text = Common.USERSESSION.UserID.ToString();
        }

        private void LoadForm()
        {
            List<Directive> list = BUSDirective.GetAllDirectiveOfUser(Common.USERSESSION.UserID);
            foreach (Directive i in list)
            {
                FormItemWorkingList form = new FormItemWorkingList(i);
                form.TopLevel = false;
                panelMain.Controls.Add(form);
                form.FormBorderStyle = FormBorderStyle.None;
                form.Dock = DockStyle.Top;
                form.Show();
            }
        }

    }
}
