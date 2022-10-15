using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using ManagementSoftware.GUI.Section;


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

        private void GetItemPO()
        {
            for (int i = 0; i < 9; i++)
            {
                FormItemWorkingList form = new FormItemWorkingList();
                form.TopLevel = false;
                panelMain.Controls.Add(form);
                form.FormBorderStyle = FormBorderStyle.None;
                form.Dock = DockStyle.Top;
                form.Show();
            }
        }

        public WorkingList()
        {
            InitializeComponent();
            GetItemPO();
        }

    }
}
