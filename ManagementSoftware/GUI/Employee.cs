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


namespace ManagementSoftware.GUI
{
    public partial class Employee : Form
    {
        // Aleart Delegate từ FormMain
        public delegate void CallAlert(string msg, FormAlert.enmType type);
        public CallAlert callAlert;


        public Employee()
        {
            InitializeComponent();
            // set chieu cao cua row datagridview la 50px
            dataGridViewUser.RowTemplate.Height = 50;
            dataGridViewGroup.RowTemplate.Height = 50;

        }

        //method gọi Alert ở Main từ form khác thông qua form hiện tại, delegate
        public void AlertActive(string msg, FormAlert.enmType enmType)
        {
            callAlert?.Invoke(msg, enmType);
        }




        //METHOD
    }
}
