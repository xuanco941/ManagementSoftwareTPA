using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using ManagementSoftware.BUS;
using ManagementSoftware.GUI.Section;
using ManagementSoftware.Models;

namespace ManagementSoftware.GUI
{
    public partial class WorkingList : Form
    {
        // Aleart
        public delegate void CallAlert(string msg, FormAlert.enmType type);
        public CallAlert callAlert;

        //change form
        public delegate void ChangeForm(Form form);
        public ChangeForm changeForm;


        // trang hiện tại
        private int page = 1;
        // tổng số trang
        private int TotalPages = 1;

        // ngày để query 
        private DateTime? timeStart = null;
        private DateTime? timeEnd = null;


        public WorkingList()
        {
            InitializeComponent();
            LoadFormThongKe();
        }

        private void LoadDGV()
        {

            dataGridView1.Columns.Add(new DataGridViewTextBoxColumn() { HeaderText = "STT", SortMode = DataGridViewColumnSortMode.NotSortable });
            dataGridView1.Columns.Add(new DataGridViewTextBoxColumn() { HeaderText = "Người thực hiện", SortMode = DataGridViewColumnSortMode.NotSortable });
            dataGridView1.Columns.Add(new DataGridViewTextBoxColumn() { HeaderText = "Số lượng cần sản xuất", SortMode = DataGridViewColumnSortMode.NotSortable });
            dataGridView1.Columns.Add(new DataGridViewTextBoxColumn() { HeaderText = "Số lượng đã sản xuất", SortMode = DataGridViewColumnSortMode.NotSortable });
            dataGridView1.Columns.Add(new DataGridViewTextBoxColumn() { HeaderText = "Ngày bắt đầu", SortMode = DataGridViewColumnSortMode.NotSortable });
            dataGridView1.Columns.Add(new DataGridViewTextBoxColumn() { HeaderText = "Ngày kết thúc", SortMode = DataGridViewColumnSortMode.NotSortable });


            dataGridView1.ColumnHeadersDefaultCellStyle.BackColor = Color.DarkOrange;
            dataGridView1.EnableHeadersVisualStyles = false;
            dataGridView1.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dataGridView1.ColumnHeadersDefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;
            dataGridView1.ColumnHeadersDefaultCellStyle.Font = new Font("Segoe UI", 13, FontStyle.Bold);


            dataGridView1.RowTemplate.Height = 40;
            dataGridView1.DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;
            dataGridView1.DefaultCellStyle.ForeColor = Color.White;
            dataGridView1.DefaultCellStyle.Font = new Font("Segoe UI", 12, FontStyle.Regular);
            dataGridView1.AllowUserToAddRows = false;
            dataGridView1.AllowUserToDeleteRows = false;
            dataGridView1.ReadOnly = true;
            dataGridView1.RowHeadersVisible = false;

            dataGridView1.ReadOnly = true;


        }
        private void WorkingList_Load(object sender, EventArgs e)
        {
            LoadDGV();
            LoadFormThongKe();
        }

        private void LoadFormThongKe()
        {
            //List<Directive> list = BUSDirective.GetAllDirectiveOfUser(Common.USERSESSION.UserID);
            //foreach (Directive i in list)
            //{
            //    FormItemWorkingList form = new FormItemWorkingList(i);
            //    form.TopLevel = false;
            //    panelMain.Controls.Add(form);
            //    form.FormBorderStyle = FormBorderStyle.None;
            //    form.Dock = DockStyle.Top;
            //    form.Show();
            //}


            //foreach (var i in l)
            //{
            //    int rowId = dataGridView1.Rows.Add();
            //    DataGridViewRow row = dataGridView1.Rows[rowId];

            //    row.Cells[0].Value = date;
            //    row.Cells[1].Value = i.CongTacName + " - " + i.JigCongTac;
            //    row.Cells[2].Value = i.TrangThai == true ? "ON" : "OFF";
            //    row.Cells[3].Value = i.LanTestThu;
            //    row.Cells[4].Value = i.Error;

            //    if (i.Error != Common.NOT_ERROR_STR)
            //    {
            //        row.DefaultCellStyle.BackColor = Color.Crimson;
            //    }
            //    else
            //    {
            //        row.DefaultCellStyle.BackColor = Color.PaleGreen;
            //    }
            //}
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
