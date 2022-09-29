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
    public partial class FormChangeGroup : Form
    {
        // tạo 1 delegate có 2 biến để call alert ở main
        public delegate void ChangeData(string msg, FormAlert.enmType enmType);
        // Create instance (null)
        public ChangeData changeData;
        public FormChangeGroup()
        {
            InitializeComponent();
        }
    }
}
