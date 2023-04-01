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
using ManagementSoftware.GUI.ResultManagement;
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
            dataGridView1.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;

            dataGridView1.Columns.Add(new DataGridViewTextBoxColumn() { HeaderText = "ID" });
            dataGridView1.Columns.Add(new DataGridViewTextBoxColumn() { HeaderText = "Áp Suất Tổng", SortMode = DataGridViewColumnSortMode.NotSortable });
            dataGridView1.Columns.Add(new DataGridViewTextBoxColumn()
            {
                HeaderText = "Time Start",
                SortMode = DataGridViewColumnSortMode.NotSortable,
                DefaultCellStyle = new DataGridViewCellStyle()
                {
                    Font = new Font("Segoe UI", 11, FontStyle.Regular),
                }
            });
            dataGridView1.Columns.Add(new DataGridViewTextBoxColumn()
            {
                HeaderText = "Time End",
                SortMode = DataGridViewColumnSortMode.NotSortable,
                DefaultCellStyle = new DataGridViewCellStyle()
                {
                    Font = new Font("Segoe UI", 11, FontStyle.Regular),
                }
            });
            dataGridView1.Columns.Add(new DataGridViewTextBoxColumn() { HeaderText = "Số lượng sản xuất", SortMode = DataGridViewColumnSortMode.NotSortable });
            dataGridView1.Columns.Add(new DataGridViewTextBoxColumn() { HeaderText = "Trạng thái", SortMode = DataGridViewColumnSortMode.NotSortable });
            dataGridView1.Columns.Add(new DataGridViewTextBoxColumn() { HeaderText = "Người giám sát", SortMode = DataGridViewColumnSortMode.NotSortable });
            dataGridView1.Columns.Add(new DataGridViewButtonColumn()
            {
                HeaderText = "",
                SortMode = DataGridViewColumnSortMode.NotSortable,
                UseColumnTextForButtonValue = true,
                Text = "Hệ Nạp 1",
                Name = "HN1",
                AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells,
                DefaultCellStyle = new DataGridViewCellStyle()
                {
                    Font = new Font("Segoe UI", 12, FontStyle.Regular),
                }
            });
            dataGridView1.Columns.Add(new DataGridViewButtonColumn()
            {
                HeaderText = "",
                SortMode = DataGridViewColumnSortMode.NotSortable,
                UseColumnTextForButtonValue = true,
                Text = "Hệ Nạp 2",
                Name = "HN2",
                AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells,
                DefaultCellStyle = new DataGridViewCellStyle()
                {
                    Font = new Font("Segoe UI", 12, FontStyle.Regular),
                }
            });
            dataGridView1.Columns.Add(new DataGridViewButtonColumn()
            {
                HeaderText = "",
                SortMode = DataGridViewColumnSortMode.NotSortable,
                UseColumnTextForButtonValue = true,
                Text = "Tình Trạng Lỗi",
                Name = "Error",
                AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells,
                DefaultCellStyle = new DataGridViewCellStyle()
                {
                    Font = new Font("Segoe UI", 12, FontStyle.Regular),
                }
            });
            dataGridView1.Columns.Add(new DataGridViewButtonColumn()
            {
                HeaderText = "",
                SortMode = DataGridViewColumnSortMode.NotSortable,
                UseColumnTextForButtonValue = true,
                Text = "Thông Số Cài Đặt",
                Name = "Setting",
                AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells,
                DefaultCellStyle = new DataGridViewCellStyle()
                {
                    Font = new Font("Segoe UI", 12, FontStyle.Regular),
                }
            });



            dataGridView1.ColumnHeadersDefaultCellStyle.BackColor = Color.DarkOrange;
            dataGridView1.EnableHeadersVisualStyles = false;
            dataGridView1.ColumnHeadersDefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;
            dataGridView1.ColumnHeadersDefaultCellStyle.Font = new Font("Segoe UI", 14, FontStyle.Regular);

            //dataGridView1.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.AllCells;


            dataGridView1.RowTemplate.Height = 50;
            dataGridView1.DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;
            //dataGridView1.DefaultCellStyle.ForeColor = Color.White;
            dataGridView1.DefaultCellStyle.Font = new Font("Segoe UI", 13, FontStyle.Regular);
            dataGridView1.AllowUserToAddRows = false;
            dataGridView1.AllowUserToDeleteRows = false;
            dataGridView1.ReadOnly = true;
            dataGridView1.RowHeadersVisible = false;

            //dataGridView1.SelectionMode = DataGridViewSelectionMode.FullRowSelect;


            dataGridView1.CellClick += dataGridViewSoftware_CellClick;
        }

        private void dataGridViewSoftware_CellClick(object sender, DataGridViewCellEventArgs e)
        {

            try
            {
                string id = dataGridView1.Rows[e.RowIndex].Cells[0].Value.ToString();
                if (e.ColumnIndex == dataGridView1.Columns["HN1"].Index)
                {

                    ResultHeNap u = new ResultHeNap();
                    u.ShowDialog();
                }
                if (e.ColumnIndex == dataGridView1.Columns["HN2"].Index)
                {

                    ResultHeNap u = new ResultHeNap();
                    u.ShowDialog();
                }
                if (e.ColumnIndex == dataGridView1.Columns["Error"].Index)
                {

                    ResultError u = new ResultError();
                    u.ShowDialog();
                }
                if (e.ColumnIndex == dataGridView1.Columns["Setting"].Index)
                {

                    ResultSetting u = new ResultSetting();
                    u.ShowDialog();
                }
            }
            catch
            {

            }


        }







        void LoadFormThongKe()
        {
            dataGridView1.Rows.Clear();


            bool color = false;

            for (int i = 1; i < 25; i++)
            {
                int rowId = dataGridView1.Rows.Add();
                DataGridViewRow row = dataGridView1.Rows[rowId];
                row.Cells[0].Value = i;

                //Product? p = dALProduct.GetProductFromID(item.ProductID);

                row.Cells[1].Value = new Random().Next(0, 101);
                row.Cells[2].Value = DateTime.Now.ToString("HH:mm:ss dd/MM/yyyy");
                row.Cells[3].Value = DateTime.Now.AddHours(3).ToString("HH:mm:ss dd/MM/yyyy");
                row.Cells[4].Value = new Random().Next(0, 20);
                row.Cells[5].Value = "Done";
                row.Cells[6].Value = "admin";


                if (color)
                {
                    row.DefaultCellStyle.BackColor = Color.LightSeaGreen;
                    row.DefaultCellStyle.ForeColor = Color.Black;
                }
                else
                {
                    row.DefaultCellStyle.BackColor = Color.YellowGreen;
                    row.DefaultCellStyle.ForeColor = Color.Black;
                }
                color = !color;
            }

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

        private void ResultHistory_Load(object sender, EventArgs e)
        {
            LoadDGV();
            LoadFormThongKe();
            comboBoxNguoiVanHanh.DataSource = new List<string>() { "Tất cả" };
        }
    }




}
