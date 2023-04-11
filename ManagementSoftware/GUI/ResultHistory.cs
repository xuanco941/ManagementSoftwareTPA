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
using System.Xml.Linq;
using ManagementSoftware.DAL;
using ManagementSoftware.DAL.DALPagination;
using ManagementSoftware.GUI.ResultManagement;
using ManagementSoftware.GUI.Section;
using ManagementSoftware.Models;
using Syncfusion.Windows.Forms.Chart;

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

        string nguoiVanHanhDefaul = "Tất cả";
        string loaiKhiDefaul = "Tất cả";


        //Data
        List<Models.Result> ListResults = new List<Models.Result>();

        PaginationResult pagination = new PaginationResult();

        DALResult dalResult = new DALResult();
        public ResultHistory()
        {
            InitializeComponent();

            LoadDGV();

        }



        void LoadDGV()
        {
            dataGridView1.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;

            dataGridView1.Columns.Add(new DataGridViewTextBoxColumn() { HeaderText = "ID" });
            dataGridView1.Columns.Add(new DataGridViewTextBoxColumn() { HeaderText = "Loại khí", SortMode = DataGridViewColumnSortMode.NotSortable });
            dataGridView1.Columns.Add(new DataGridViewTextBoxColumn()
            {
                HeaderText = "Time Start",
                SortMode = DataGridViewColumnSortMode.NotSortable,
                DefaultCellStyle = new DataGridViewCellStyle()
                {
                    Font = new Font("Segoe UI", 13, FontStyle.Regular),
                }
            });
            dataGridView1.Columns.Add(new DataGridViewTextBoxColumn()
            {
                HeaderText = "Time End",
                SortMode = DataGridViewColumnSortMode.NotSortable,
                DefaultCellStyle = new DataGridViewCellStyle()
                {
                    Font = new Font("Segoe UI", 13, FontStyle.Regular),
                }
            });
            dataGridView1.Columns.Add(new DataGridViewTextBoxColumn() { HeaderText = "Người giám sát", SortMode = DataGridViewColumnSortMode.NotSortable });
            dataGridView1.Columns.Add(new DataGridViewTextBoxColumn() { HeaderText = "Trạng thái", SortMode = DataGridViewColumnSortMode.NotSortable });
            dataGridView1.Columns.Add(new DataGridViewButtonColumn()
            {
                HeaderText = "",
                SortMode = DataGridViewColumnSortMode.NotSortable,
                UseColumnTextForButtonValue = true,
                Text = "Giàn Nạp 1",
                Name = "HN1",
                AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells,
                DefaultCellStyle = new DataGridViewCellStyle()
                {
                    Font = new Font("Segoe UI", 13, FontStyle.Regular),
                }
            });
            dataGridView1.Columns.Add(new DataGridViewButtonColumn()
            {
                HeaderText = "",
                SortMode = DataGridViewColumnSortMode.NotSortable,
                UseColumnTextForButtonValue = true,
                Text = "Giàn Nạp 2",
                Name = "HN2",
                AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells,
                DefaultCellStyle = new DataGridViewCellStyle()
                {
                    Font = new Font("Segoe UI", 13, FontStyle.Regular),
                }
            });
            dataGridView1.Columns.Add(new DataGridViewButtonColumn()
            {
                HeaderText = "",
                SortMode = DataGridViewColumnSortMode.NotSortable,
                UseColumnTextForButtonValue = true,
                Text = "Báo Lỗi",
                Name = "Error",
                AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells,
                DefaultCellStyle = new DataGridViewCellStyle()
                {
                    Font = new Font("Segoe UI", 13, FontStyle.Regular),
                }
            });


            dataGridView1.ColumnHeadersDefaultCellStyle.BackColor = Color.DarkOrange;
            dataGridView1.EnableHeadersVisualStyles = false;
            dataGridView1.ColumnHeadersDefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;
            dataGridView1.ColumnHeadersDefaultCellStyle.Font = new Font("Segoe UI", 15, FontStyle.Bold);

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
            if (e.RowIndex == -1)
            {
                // Đây là sự kiện click vào header column
                return;
            }
            try
            {
                DataGridViewRow row = dataGridView1.Rows[e.RowIndex];
                if (row != null && row.Tag != null)
                {
                    Result obj = (Result)row.Tag;
                    if (e.ColumnIndex == dataGridView1.Columns["HN1"].Index)
                    {

                        ResultHeNap u = new ResultHeNap(obj, Common.GianNap1);
                        u.ShowDialog();
                    }
                    if (e.ColumnIndex == dataGridView1.Columns["HN2"].Index)
                    {

                        ResultHeNap u = new ResultHeNap(obj, Common.GianNap2);
                        u.ShowDialog();
                    }
                    if (e.ColumnIndex == dataGridView1.Columns["Error"].Index)
                    {

                        ErrorDashboard u = new ErrorDashboard(obj);
                        u.ShowDialog();
                    }

                }
                else
                {
                    MessageBox.Show("Không tìm thấy ID của bản ghi này.", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }


            }
            catch
            {
                MessageBox.Show("Không tìm thấy dữ liệu bản ghi này.", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }


        }




        private void UpdateGUI(List<Result> list)
        {

            if (this.IsHandleCreated && this.InvokeRequired)
            {
                this.BeginInvoke(new Action<List<Result>>(UpdateGUI), list);
                return;
            }


            //update gui

            panelPagination.Enabled = false;
            panelLoc.Enabled = false;

            dataGridView1.Rows.Clear();

            lbTotalPages.Text = this.TotalPages.ToString();

            buttonPreviousPage.Enabled = this.page > 1;
            buttonNextPage.Enabled = this.page < this.TotalPages;
            buttonPage.Text = this.page.ToString();

            pageNumberGoto.MinValue = 1;
            pageNumberGoto.MaxValue = this.TotalPages != 0 ? this.TotalPages : 1;

            bool color = false;

            foreach (var item in this.ListResults)
            {
                int rowId = dataGridView1.Rows.Add();
                DataGridViewRow row = dataGridView1.Rows[rowId];
                row.Tag = item;

                row.Cells[0].Value = Common.RESULT + item.ResultID;

                //Product? p = dALProduct.GetProductFromID(item.ProductID);
                row.Cells[1].Value = item.LoaiKhi;
                row.Cells[2].Value = item.TimeStart.ToString("HH:mm:ss dd/MM/yyyy");
                row.Cells[3].Value = item.TimeEnd.ToString("HH:mm:ss dd/MM/yyyy");
                row.Cells[4].Value = item.Username;
                row.Cells[5].Value = item.Status == true ? "OK" : "NG";

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


            panelPagination.Enabled = true;
            panelLoc.Enabled = true;

        }


        void LoadFormThongKe()
        {
            pagination.Set(page, timeStart, timeEnd, loaiKhiDefaul, nguoiVanHanhDefaul);

            this.ListResults = pagination.ListResults;
            this.TotalPages = pagination.TotalPages;



            UpdateGUI(pagination.ListResults);
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

        private async void ResultHistory_Load(object sender, EventArgs e)
        {

            List<string> nguoiVanHanh = new List<string> { nguoiVanHanhDefaul };
            List<string> loaiKhi = new List<string> { loaiKhiDefaul };

            List<string> lk = await Task.Run(() => dalResult.GetListNameLoaiKhi());
            if (lk != null && lk.Count > 0)
            {
                loaiKhi.AddRange(lk);
            }

            List<string> nvh = await Task.Run(() => dalResult.GetListNameNguoiVanHanh());
            if (nvh != null && nvh.Count > 0)
            {
                nguoiVanHanh.AddRange(nvh);
            }

            comboBoxNguoiVanHanh.DataSource = nguoiVanHanh;
            comboBoxLoaiKhi.DataSource = loaiKhi;

            LoadFormThongKe();
        }

        private void buttonCustomLoc_Click(object sender, EventArgs e)
        {
            loaiKhiDefaul = comboBoxLoaiKhi.Text;
            nguoiVanHanhDefaul = comboBoxNguoiVanHanh.Text;
            page = 1;
            timeStart = null;
            TimeEnd = null;
            TotalPages = 0;

            LoadFormThongKe();
        }
    }




}
