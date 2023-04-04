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
    public partial class ErrorDashboard : Form
    {
        // ngày để query 
        private DateTime? timeStart = null;
        private DateTime? timeEnd = null;
        // trang hiện tại
        private int page = 1;

        // tổng số trang
        private int TotalPages = 0;
        //Data
        List<Models.ResultWarning> ListResults = new List<Models.ResultWarning>();

        PaginationResultWarning pagination = new PaginationResultWarning();

        public ErrorDashboard()
        {
            InitializeComponent();
            LoadDGV();
        }
        void LoadDGV()
        {
            dataGridView1.Columns.Add(new DataGridViewTextBoxColumn() { HeaderText = "STT", SortMode = DataGridViewColumnSortMode.NotSortable });
            dataGridView1.Columns.Add(new DataGridViewTextBoxColumn() { HeaderText = "MÃ LỖI", SortMode = DataGridViewColumnSortMode.NotSortable });
            dataGridView1.Columns.Add(new DataGridViewTextBoxColumn() { HeaderText = "MÔ TẢ", SortMode = DataGridViewColumnSortMode.NotSortable });
            dataGridView1.Columns.Add(new DataGridViewTextBoxColumn() { HeaderText = "THUỘC MẺ NẠP", SortMode = DataGridViewColumnSortMode.NotSortable });
            dataGridView1.Columns.Add(new DataGridViewTextBoxColumn() { HeaderText = "THỜI GIAN", SortMode = DataGridViewColumnSortMode.NotSortable });






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


        void LoadFormThongKe()
        {
            panelPagination.Enabled = false;

            dataGridView1.Rows.Clear();


            pagination.Set(page, timeStart, timeEnd);

            this.ListResults = pagination.ListResults;
            this.TotalPages = pagination.TotalPages;
            lbTotalPages.Text = this.TotalPages.ToString();

            buttonPreviousPage.Enabled = this.page > 1;
            buttonNextPage.Enabled = this.page < this.TotalPages;
            buttonPage.Text = this.page.ToString();

            pageNumberGoto.MinValue = 1;
            pageNumberGoto.MaxValue = this.TotalPages != 0 ? this.TotalPages : 1;



            if (ListResults != null && ListResults.Count > 0)
            {

                int idSpace = 0;

                for (int i = 0; i < ListResults.Count; i++)
                {
                    if (idSpace != 0 && idSpace != ListResults[i].ResultID)
                    {
                        dataGridView1.Rows.Add();
                    }

                    int rowId = dataGridView1.Rows.Add();
                    DataGridViewRow row = dataGridView1.Rows[rowId];
                    row.Cells[0].Value = i + 1;

                    row.Cells[1].Value = ListResults[i].Title;
                    row.Cells[2].Value = ListResults[i].Description;
                    row.Cells[3].Value = Common.RESULT + ListResults[i].ResultID;
                    row.Cells[4].Value = ListResults[i].CreateAt.ToString("HH:mm:ss dd/MM/yyyy");

                    idSpace = ListResults[i].ResultID;
                }

            }

            panelPagination.Enabled = true;
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

        private void ErrorDashboard_Load(object sender, EventArgs e)
        {
            LoadFormThongKe();
        }
    }
}
