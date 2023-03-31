using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ManagementSoftware.GUI.Dashboard_Management
{
    public partial class HeNap : Form
    {
        public HeNap()
        {
            InitializeComponent();
            heNap1 = new HeNapXam();
            heNap2 = new HeNapXam();
        }

        HeNapXam heNap1;
        HeNapXam heNap2;

        private void HeNap_Load(object sender, EventArgs e)
        {

            new MethodCommonGUI().ShowFormOnTabPage(tabPage1, heNap1);
            new MethodCommonGUI().ShowFormOnTabPage(tabPage2, heNap2);

        }
    }
}
