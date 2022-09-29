using ManagementSoftware.GUI.Section;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ManagementSoftware.GUI.EmployeeManagement
{
    public partial class FormAddGroup : Form
    {
        public FormAddGroup()
        {

            InitializeComponent();
        }
        // Define delegate
        public delegate void ChangeData(string msg, FormAlert.enmType enmType);

        // Create instance (null)
        public ChangeData changeData;


        //validate checkbox
        private void checkBoxIsViewResult_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBoxIsViewResult.Checked == false)
            {
                checkBoxIsDeleteResult.Checked = false;
            }
        }

        private void checkBoxIsViewActivity_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBoxIsViewActivity.Checked == false)
            {
                checkBoxIsDeleteActivity.Checked = false;
            }
        }

        private void checkBoxIsDeleteResult_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBoxIsDeleteResult.Checked == true)
            {
                checkBoxIsViewResult.Checked = true;
            }
        }

        private void checkBoxIsDeleteActivity_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBoxIsDeleteActivity.Checked == true)
            {
                checkBoxIsViewActivity.Checked = true;
            }
        }
    }
}
