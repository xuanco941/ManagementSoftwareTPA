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
            heNap1 = new TheoDoiHeNap();
            heNap2 = new TheoDoiHeNap();
            this.FormBorderStyle = FormBorderStyle.FixedSingle;
        }

        TheoDoiHeNap heNap1;
        TheoDoiHeNap heNap2;

        private void HeNap_Load(object sender, EventArgs e)
        {

            new MethodCommonGUI().ShowFormOnTabPage(tabPage1, heNap1);
            new MethodCommonGUI().ShowFormOnTabPage(tabPage2, heNap2);

        }

        private void HeNap_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (IsHandleCreated && InvokeRequired)
            {
                BeginInvoke(new Action(() =>
                {
                    heNap1.Close();
                    heNap2.Close();
                }));

            }
            else
            {
                heNap1.Close();
                heNap2.Close();
            }

        }
    }
}
