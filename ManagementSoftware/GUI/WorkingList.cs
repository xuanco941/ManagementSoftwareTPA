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

            dataGridView1.Columns.Add(new DataGridViewTextBoxColumn() { HeaderText = "ID", SortMode = DataGridViewColumnSortMode.NotSortable });

            dataGridView1.Columns.Add(new DataGridViewTextBoxColumn() { HeaderText = "Tên sản phẩm", SortMode = DataGridViewColumnSortMode.NotSortable });
            dataGridView1.Columns.Add(new DataGridViewTextBoxColumn() { HeaderText = "Áp suất nạp", SortMode = DataGridViewColumnSortMode.NotSortable });
            dataGridView1.Columns.Add(new DataGridViewTextBoxColumn() { HeaderText = "Thể tích bình", SortMode = DataGridViewColumnSortMode.NotSortable });
            dataGridView1.Columns.Add(new DataGridViewTextBoxColumn() { HeaderText = "Chất lượng khí", SortMode = DataGridViewColumnSortMode.NotSortable });

            dataGridView1.Columns.Add(new DataGridViewTextBoxColumn() { HeaderText = "Số lượng cần sản xuất", SortMode = DataGridViewColumnSortMode.NotSortable });
            dataGridView1.Columns.Add(new DataGridViewTextBoxColumn() { HeaderText = "Số lượng đã sản xuất", SortMode = DataGridViewColumnSortMode.NotSortable });
            dataGridView1.Columns.Add(new DataGridViewTextBoxColumn() { HeaderText = "Ngày bắt đầu", SortMode = DataGridViewColumnSortMode.NotSortable });
            dataGridView1.Columns.Add(new DataGridViewTextBoxColumn() { HeaderText = "Ngày kết thúc", SortMode = DataGridViewColumnSortMode.NotSortable });

            dataGridView1.Columns.Add(new DataGridViewTextBoxColumn() { HeaderText = "Trạng thái", SortMode = DataGridViewColumnSortMode.NotSortable });
            dataGridView1.Columns.Add(new DataGridViewButtonColumn() { HeaderText = "", SortMode = DataGridViewColumnSortMode.NotSortable, UseColumnTextForButtonValue = true, Text = "Cập nhật", Name = "Update", AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells, DefaultCellStyle = new DataGridViewCellStyle() { Font = new Font("Segoe UI", 14, FontStyle.Bold) } });




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
                    UpdateWorkingList u =new UpdateWorkingList(dataGridView1.Rows[e.RowIndex].Cells[0].Value.ToString());
                    u.changeData = new UpdateWorkingList.ChangeData(ToogleAlert);
                    u.ShowDialog();
                }
                catch
                {

                }

            }

        }

        void ToogleAlert(string msg, FormAlert.enmType type)
        {
            
            callAlert?.Invoke(msg, type);
            LoadFormThongKe();
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


            foreach (var item in this.ListResults)
            {
                int rowId = dataGridView1.Rows.Add();
                DataGridViewRow row = dataGridView1.Rows[rowId];
                row.Cells[0].Value = Common.DIRECTIVE + item.DirectiveID;

                //Product? p = dALProduct.GetProductFromID(item.ProductID);

                if (item.Product != null)
                {
                    row.Cells[1].Value = item.Product.ProductName;
                    row.Cells[2].Value = item.Product.ApSuatNap;
                    row.Cells[3].Value = item.Product.TheTichBinh;
                    row.Cells[4].Value = item.Product.ChatLuongKhi;
                }

                row.Cells[5].Value = item.SoLuongCanSanXuat;
                row.Cells[6].Value = item.SoLuongDaSanXuat;
                //row.Cells[7].Value = item.BeginAt.ToString($"HH:mm:ss dd/MM/yyyy", CultureInfo.InvariantCulture);
                //row.Cells[8].Value = item.EndAt.ToString($"HH:mm:ss dd/MM/yyyy", CultureInfo.InvariantCulture); ;

                row.Cells[7].Value = item.BeginAt.ToString($"dd/MM/yyyy", CultureInfo.InvariantCulture);
                row.Cells[8].Value = item.EndAt.ToString($"dd/MM/yyyy", CultureInfo.InvariantCulture); ;
                row.Cells[9].Value = item.Status == true ? "Đã hoàn thành" : "Chưa hoàn thành";




                if (item.Status == true)
                {
                    row.DefaultCellStyle.BackColor = Color.LightGreen;
                }

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
