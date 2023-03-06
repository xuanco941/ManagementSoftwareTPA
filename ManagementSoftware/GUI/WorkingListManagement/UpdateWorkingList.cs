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

namespace ManagementSoftware.GUI.WorkingListManagement
{
    public partial class UpdateWorkingList : Form
    {
        int id = 0;
        public UpdateWorkingList(string idDirective)
        {
            InitializeComponent();
            id = int.Parse(idDirective.Replace(Common.DIRECTIVE, ""));
            labelCT.Text = idDirective;
        }

        private void UpdateWorkingList_Load(object sender, EventArgs e)
        {
            if(id != 0)
            {
                Directive? directive = new DALDirective().GetDirectiveFromID(id);
                if (directive != null)
                {
                }
            }
        }
    }
}
