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
using ManagementSoftware.BUS;
using ManagementSoftware.DAL;
using ManagementSoftware.DAL.DALPagination;
using ManagementSoftware.GUI.Section;
using ManagementSoftware.GUI.WorkingListManagement;
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

        private bool? status = null;

        List<Directive> ListResults = new List<Directive>();

        DALProduct dALProduct;
        public WorkingList()
        {
            InitializeComponent();
            dALProduct = new DALProduct();
            labelHeader.Text = labelHeader.Text + $" ({Common.USERSESSION?.Username})";
        }

        private void LoadDGV()
        {

            dataGridView1.Columns.Add(new DataGridViewTextBoxColumn() { HeaderText = "ID", SortMode = DataGridViewColumnSortMode.NotSortable, AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells });

            dataGridView1.Columns.Add(new DataGridViewTextBoxColumn() { HeaderText = "Tên sản phẩm", SortMode = DataGridViewColumnSortMode.NotSortable });
            dataGridView1.Columns.Add(new DataGridViewTextBoxColumn() { HeaderText = "Áp suất nạp", SortMode = DataGridViewColumnSortMode.NotSortable });
            dataGridView1.Columns.Add(new DataGridViewTextBoxColumn() { HeaderText = "Thể tích bình", SortMode = DataGridViewColumnSortMode.NotSortable });
            dataGridView1.Columns.Add(new DataGridViewTextBoxColumn() { HeaderText = "Chất lượng khí", SortMode = DataGridViewColumnSortMode.NotSortable });

            dataGridView1.Columns.Add(new DataGridViewTextBoxColumn() { HeaderText = "Số lượng cần sản xuất", SortMode = DataGridViewColumnSortMode.NotSortable, AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells });
            dataGridView1.Columns.Add(new DataGridViewTextBoxColumn() { HeaderText = "Số lượng đã sản xuất", SortMode = DataGridViewColumnSortMode.NotSortable, AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells });
            dataGridView1.Columns.Add(new DataGridViewTextBoxColumn() { HeaderText = "Ngày bắt đầu", SortMode = DataGridViewColumnSortMode.NotSortable, AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells });
            dataGridView1.Columns.Add(new DataGridViewTextBoxColumn() { HeaderText = "Ngày kết thúc", SortMode = DataGridViewColumnSortMode.NotSortable, AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells });

            dataGridView1.Columns.Add(new DataGridViewTextBoxColumn() { HeaderText = "Trạng thái", SortMode = DataGridViewColumnSortMode.NotSortable, AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells });
            dataGridView1.Columns.Add(new DataGridViewButtonColumn() { HeaderText = "Tùy chọn", SortMode = DataGridViewColumnSortMode.NotSortable, UseColumnTextForButtonValue = true, Text = "Cập nhật", Name = "Update", AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells });




            //dataGridView1.ColumnHeadersDefaultCellStyle.BackColor = Color.DarkOrange;
            dataGridView1.EnableHeadersVisualStyles = false;
            dataGridView1.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dataGridView1.ColumnHeadersDefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;
            dataGridView1.ColumnHeadersDefaultCellStyle.Font = new Font("Segoe UI", 14, FontStyle.Bold);

            //dataGridView1.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.AllCells;


            dataGridView1.RowTemplate.Height = 50;
            dataGridView1.DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;
            //dataGridView1.DefaultCellStyle.ForeColor = Color.White;
            dataGridView1.DefaultCellStyle.Font = new Font("Segoe UI", 14, FontStyle.Regular);
            dataGridView1.AllowUserToAddRows = false;
            dataGridView1.AllowUserToDeleteRows = false;
            dataGridView1.ReadOnly = true;
            dataGridView1.RowHeadersVisible = false;

            dataGridView1.ReadOnly = true;

            //dataGridView1.SelectionMode = DataGridViewSelectionMode.FullRowSelect;


            //update
            dataGridView1.CellClick += dataGridViewSoftware_CellClick;



        }

        private void dataGridViewSoftware_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.ColumnIndex == dataGridView1.Columns["Update"].Index)
            {
                try
                {
                    string id = dataGridView1.Rows[e.RowIndex].Cells[0].Value.ToString().Replace(Common.DIRECTIVE, "");
                    new UpdateWorkingList(int.Parse(id)).ShowDialog();
                }
                catch
                {

                }

            }

        }


        private void WorkingList_Load(object sender, EventArgs e)
        {
            LoadDGV();
            LoadFormThongKe();
        }


        void CheckBtnStt()
        {
            if (this.status == false)
            {
                buttonAll.ForeColor = Color.Black;
                buttonDone.ForeColor = Color.Black;
                buttonNotDone.ForeColor = Color.White;
            }
            else if (this.status == true)
            {
                buttonAll.ForeColor = Color.Black;
                buttonDone.ForeColor = Color.White;
                buttonNotDone.ForeColor = Color.Black;
            }
            else
            {
                buttonAll.ForeColor = Color.White;
                buttonDone.ForeColor = Color.Black;
                buttonNotDone.ForeColor = Color.Black;
            }
        }

        void LoadFormThongKe()
        {
            panelBoxSearch.Enabled = false;
            dataGridView1.Rows.Clear();


            CheckBtnStt();


            PaginationWorkingList pagination = new PaginationWorkingList();
            pagination.Set(page, timeStart, timeEnd, status);
            this.ListResults = pagination.ListResults;


            this.TotalPages = pagination.TotalPages;
            lbTotalPages.Text = this.TotalPages.ToString();

            buttonPreviousPage.Enabled = this.page > 1;
            buttonNextPage.Enabled = this.page < this.TotalPages;
            buttonPage.Text = this.page.ToString();

            pageNumberGoto.MinValue = 1;
            pageNumberGoto.MaxValue = this.TotalPages != 0 ? this.TotalPages : 1;

            bool count = false;

            foreach (var item in this.ListResults)
            {
                int rowId = dataGridView1.Rows.Add();
                DataGridViewRow row = dataGridView1.Rows[rowId];
                row.Cells[0].Value = Common.DIRECTIVE + item.DirectiveID;

                Product? p = dALProduct.GetProductFromID(item.ProductID);

                if (p != null)
                {
                    row.Cells[1].Value = p.ProductName;
                    row.Cells[2].Value = p.ApSuatNap;
                    row.Cells[3].Value = p.TheTichBinh;
                    row.Cells[4].Value = p.ChatLuongKhi;
                }

                row.Cells[5].Value = item.SoLuongCanSanXuat;
                row.Cells[6].Value = item.SoLuongDaSanXuat;
                row.Cells[7].Value = item.BeginAt.ToString($"HH:mm:ss dd/MM/yyyy", CultureInfo.InvariantCulture);
                row.Cells[8].Value = item.EndAt.ToString($"HH:mm:ss dd/MM/yyyy", CultureInfo.InvariantCulture); ;
                row.Cells[9].Value = item.Status == true ? "Đã hoàn thành" : "Chưa hoàn thành";




                if (count == true)
                {
                    row.DefaultCellStyle.BackColor = Color.PaleGreen;
                }
                count = !count;

            }

            panelBoxSearch.Enabled = true;
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
            status = null;
            timeStart = TimeStart.Value;
            timeEnd = TimeEnd.Value;
            LoadFormThongKe();
        }

        private void buttonGoto_Click(object sender, EventArgs e)
        {
            this.page = int.Parse(pageNumberGoto.Text);
            LoadFormThongKe();
        }

        private void buttonAll_Click(object sender, EventArgs e)
        {
            this.status = null;
            LoadFormThongKe();
        }

        private void buttonDone_Click(object sender, EventArgs e)
        {
            this.status = true;
            LoadFormThongKe();
        }

        private void buttonNotDone_Click(object sender, EventArgs e)
        {
            this.status = false;
            LoadFormThongKe();
        }
    }
}
