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
using ManagementSoftware.Models;
using ManagementSoftware.BUS;
using ManagementSoftware.DAL.DALPagination;
using ManagementSoftware.DAL;

namespace ManagementSoftware.GUI
{
    public partial class ActivityHistory : Form
    {
        // Aleart
        public delegate void CallAlert(string msg, FormAlert.enmType type);
        public CallAlert callAlert;


        // ngày để query 
        private DateTime? timeStart = null;
        private DateTime? timeEnd = null;
        // trang hiện tại
        private int page = 1;

        // tổng số trang
        private int TotalPages = 0;
        //Data
        List<Models.Activity> ListResults = new List<Models.Activity>();

        PaginationActivity pagination = new PaginationActivity();
        public ActivityHistory()
        {
            InitializeComponent();
            LoadDGV();


        }
        void LoadDGV()
        {
            dataGridView1.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;

            dataGridView1.Columns.Add(new DataGridViewTextBoxColumn() { HeaderText = "STT" });
            dataGridView1.Columns.Add(new DataGridViewTextBoxColumn() { HeaderText = "Tiêu đề", SortMode = DataGridViewColumnSortMode.NotSortable });
            dataGridView1.Columns.Add(new DataGridViewTextBoxColumn() { HeaderText = "Mô tả", SortMode = DataGridViewColumnSortMode.NotSortable });
            dataGridView1.Columns.Add(new DataGridViewTextBoxColumn() { HeaderText = "Ngày", SortMode = DataGridViewColumnSortMode.NotSortable });
            dataGridView1.Columns.Add(new DataGridViewTextBoxColumn() { HeaderText = "Tài khoản thao tác", SortMode = DataGridViewColumnSortMode.NotSortable });



            dataGridView1.ColumnHeadersDefaultCellStyle.BackColor = Color.DarkOrange;
            dataGridView1.EnableHeadersVisualStyles = false;
            dataGridView1.ColumnHeadersDefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;
            dataGridView1.ColumnHeadersDefaultCellStyle.Font = new Font("Segoe UI", 16, FontStyle.Bold);

            //dataGridView1.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.AllCells;


            dataGridView1.RowTemplate.Height = 50;
            dataGridView1.DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;
            //dataGridView1.DefaultCellStyle.ForeColor = Color.White;
            dataGridView1.DefaultCellStyle.Font = new Font("Segoe UI", 15, FontStyle.Regular);
            dataGridView1.AllowUserToAddRows = false;
            dataGridView1.AllowUserToDeleteRows = false;
            dataGridView1.ReadOnly = true;
            dataGridView1.RowHeadersVisible = false;

            //dataGridView1.SelectionMode = DataGridViewSelectionMode.FullRowSelect;


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



            int i = 1;

            if (ListResults != null && ListResults.Count > 0)
            {
                foreach (var item in this.ListResults)
                {
                    int rowId = dataGridView1.Rows.Add();
                    DataGridViewRow row = dataGridView1.Rows[rowId];
                    row.Cells[0].Value = i;

                    //Product? p = dALProduct.GetProductFromID(item.ProductID);
                    row.Cells[1].Value = item.Title;
                    row.Cells[2].Value = item.Description;
                    row.Cells[3].Value = item.CreateAt.ToString("HH:mm:ss dd/MM/yyyy");
                    row.Cells[4].Value = item.Username;


                    if (i%2==0)
                    {
                        row.DefaultCellStyle.BackColor = Color.LightGreen;
                        row.DefaultCellStyle.ForeColor = Color.Black;
                    }
                    else
                    {
                        row.DefaultCellStyle.BackColor = Color.YellowGreen;
                        row.DefaultCellStyle.ForeColor = Color.Black;
                    }
                    i++;
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

        private void ActivityHistory_Load(object sender, EventArgs e)
        {
            LoadFormThongKe();
        }
    }
}
