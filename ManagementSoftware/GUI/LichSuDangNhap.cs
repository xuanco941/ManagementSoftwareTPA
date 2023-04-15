using ManagementSoftware.DAL.DALPagination;
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
    public partial class LichSuDangNhap : Form
    {
        // ngày để query 
        private DateTime? timeStart = null;
        private DateTime? timeEnd = null;
        // trang hiện tại
        private int page = 1;

        // tổng số trang
        private int TotalPages = 0;
        //Data
        List<Models.UserWorking> ListResults = new List<Models.UserWorking>();

        PaginationUserWorking pagination = new PaginationUserWorking();
        public LichSuDangNhap()
        {
            InitializeComponent();
            LoadDGV();
        }
        void LoadDGV()
        {
            dataGridView1.Columns.Add(new DataGridViewTextBoxColumn() { HeaderText = "STT", SortMode = DataGridViewColumnSortMode.NotSortable });
            dataGridView1.Columns.Add(new DataGridViewTextBoxColumn() { HeaderText = "TÊN ĐĂNG NHẬP", SortMode = DataGridViewColumnSortMode.NotSortable });
            dataGridView1.Columns.Add(new DataGridViewTextBoxColumn() { HeaderText = "TÊN NHÂN VIÊN", SortMode = DataGridViewColumnSortMode.NotSortable });
            dataGridView1.Columns.Add(new DataGridViewTextBoxColumn() { HeaderText = "NGÀY GIỜ ĐĂNG NHẬP", SortMode = DataGridViewColumnSortMode.NotSortable });
            dataGridView1.Columns.Add(new DataGridViewTextBoxColumn() { HeaderText = "HOẠT ĐỘNG ĐẾN", SortMode = DataGridViewColumnSortMode.NotSortable });






            dataGridView1.ColumnHeadersDefaultCellStyle.BackColor = Color.DarkOrange;
            dataGridView1.EnableHeadersVisualStyles = false;
            dataGridView1.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dataGridView1.ColumnHeadersDefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;
            dataGridView1.ColumnHeadersDefaultCellStyle.Font = new Font("Segoe UI", 16, FontStyle.Bold);


            dataGridView1.RowTemplate.Height = 50;
            dataGridView1.DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;
            dataGridView1.DefaultCellStyle.ForeColor = Color.White;
            dataGridView1.DefaultCellStyle.Font = new Font("Segoe UI", 15, FontStyle.Regular);
            dataGridView1.AllowUserToAddRows = false;
            dataGridView1.AllowUserToDeleteRows = false;
            dataGridView1.ReadOnly = true;
            dataGridView1.RowHeadersVisible = false;
            dataGridView1.ColumnHeadersHeight = 50;
            dataGridView1.DefaultCellStyle.BackColor = Color.FromArgb(41, 44, 51);


        }

        async void LoadFormThongKe()
        {
            panelPagination.Enabled = false;

            dataGridView1.Rows.Clear();


            await Task.Run(() => pagination.Set(page, timeStart, timeEnd));

            this.ListResults = pagination.ListResults;
            this.TotalPages = pagination.TotalPages;
            lbTotalPages.Text = this.TotalPages.ToString();

            buttonPreviousPage.Enabled = this.page > 1;
            buttonNextPage.Enabled = this.page < this.TotalPages;
            buttonPage.Text = this.page.ToString();

            pageNumberGoto.MinValue = 1;
            pageNumberGoto.MaxValue = this.TotalPages != 0 ? this.TotalPages : 1;



            int i = 1;

            if (ListResults != null && ListResults.Count > 0)
            {
                foreach (var item in this.ListResults)
                {
                    int rowId = dataGridView1.Rows.Add();
                    DataGridViewRow row = dataGridView1.Rows[rowId];

                    row.Cells[0].Value = i;
                    row.Cells[1].Value = item.Username;
                    row.Cells[2].Value = item.Fullname;
                    row.Cells[3].Value = item.CreateAt.ToString("HH:mm:ss dd/MM/yyyy");
                    row.Cells[4].Value = item.EndAt.ToString("HH:mm:ss dd/MM/yyyy");


                    //dataGridView1.Rows[rowId].DefaultCellStyle.BackColor = Color.FromArgb(41, 44, 51);
                    i++;
                }
            }

            panelPagination.Enabled = true;

        }



        private void LichSuDangNhap_Load(object sender, EventArgs e)
        {
            LoadFormThongKe();
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
