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

namespace ManagementSoftware.GUI.ActivityManagement
{
    public partial class FormChangeNumElmOnPage : Form
    {
        // Define delegate
        public delegate void ChangeData(string msg, FormAlert.enmType enmType);

        // Create instance (null)
        public ChangeData changeData;

        public FormChangeNumElmOnPage()
        {
            InitializeComponent();
        }
    }
}
