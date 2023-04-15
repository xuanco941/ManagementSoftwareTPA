using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ManagementSoftware.GUI.ResultManagement
{
    public partial class FormDataMachine : Form
    {

        public FormDataMachine()
        {
            InitializeComponent();
            dataGridViewSearchData.RowTemplate.Height = 45;
        }


    }
}
