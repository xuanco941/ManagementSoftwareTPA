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
using ManagementSoftware.GUI.Section;
using ManagementSoftware.GUI.ActivityManagement;

namespace ManagementSoftware.GUI
{
    public partial class ActivityHistory : Form
    {
        // Aleart
        public delegate void CallAlert(string msg, FormAlert.enmType type);
        public CallAlert callAlert;


        // ngày để query 
        private string strDatimeTuNgay = null;
        private string strDatimeToiNgay = null;
        // trang hiện tại
        private int page = 1;
        // tổng số trang
        private int pageSize = 1;

        public ActivityHistory()
        {
            InitializeComponent();

            //setting header column
            dataGridViewActivity.ColumnHeadersDefaultCellStyle.Font = Common.FontHeaderColumnDGV;
            dataGridViewActivity.RowTemplate.Height = 35;
        }




    }
}
