using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Drawing.Printing;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using ManagementSoftware.GUI.Section;

namespace ManagementSoftware.GUI
{
    public partial class ResultHistory : Form
    {
        // ngày để query 
        private DateTime? timeStart = null;
        private DateTime? timeEnd = null;
        // trang hiện tại
        private int page = 1;

        // tổng số trang
        private int TotalPages = 0;
        //Data
        List<Models.Result> ListResults = new List<Models.Result>();
        public ResultHistory()
        {
            InitializeComponent();
        }



        void LoadDGV()
        {
            DataGridViewColumn STT = new DataGridViewTextBoxColumn();
            STT.HeaderText = "ID-Date";
            DataGridViewColumn name = new DataGridViewTextBoxColumn();
            name.HeaderText = "Lõi lọc";
            DataGridViewColumn lanTest = new DataGridViewTextBoxColumn();
            lanTest.HeaderText = "Lần test thứ";
            DataGridViewColumn dienAp = new DataGridViewTextBoxColumn();
            dienAp.HeaderText = "Áp suất test (bar)";
            DataGridViewColumn dongDC = new DataGridViewTextBoxColumn();
            dongDC.HeaderText = "Thời gian cấp (giây)";
            DataGridViewColumn congSuat = new DataGridViewTextBoxColumn();
            congSuat.HeaderText = "Thời gian giữ (giây)";
            DataGridViewColumn ThoiGian = new DataGridViewTextBoxColumn();
            ThoiGian.HeaderText = "Thời gian xả (giây)";
            DataGridViewColumn Loi = new DataGridViewTextBoxColumn();
            Loi.HeaderText = "Tình trạng";



            dataGridViewResult.Columns.Add(STT);
            dataGridViewResult.Columns.Add(name);
            dataGridViewResult.Columns.Add(lanTest);
            dataGridViewResult.Columns.Add(dienAp);
            dataGridViewResult.Columns.Add(dongDC);
            dataGridViewResult.Columns.Add(congSuat);
            dataGridViewResult.Columns.Add(ThoiGian);
            dataGridViewResult.Columns.Add(Loi);



            dataGridViewResult.RowTemplate.Height = 40;

        }





        void LoadFormThongKe()
        {

        }


        private void buttonPreviousPage_Click(object sender, EventArgs e)
        {
            if (this.page > 1)
            {
                this.page = this.page - 1;
                LoadFormThongKe();
            }
        }

        private void buttonNextPage_Click(object sender, EventArgs e)
        {
            if (this.page < this.TotalPages)
            {
                this.page = this.page + 1;
                LoadFormThongKe();
            }
        }

        private void buttonSearch_Click(object sender, EventArgs e)
        {
            timeStart = TimeStart.Value;
            timeEnd = TimeEnd.Value;
            LoadFormThongKe();
        }

        private void buttonGoto_Click(object sender, EventArgs e)
        {
            this.page = int.Parse(pageNumberGoto.Text);
            LoadFormThongKe();
        }
    }




}
