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

namespace ManagementSoftware.GUI.ActivityManagement
{
    public partial class FormEmployeeActivities : Form
    {
        public FormEmployeeActivities()
        {
            InitializeComponent();
           
            dataGridViewUserActivity.ColumnHeadersDefaultCellStyle.Font = Common.FontHeaderColumnDGV;
            dataGridViewUserActivity.RowTemplate.Height = 35;
        }

      
    }
}
