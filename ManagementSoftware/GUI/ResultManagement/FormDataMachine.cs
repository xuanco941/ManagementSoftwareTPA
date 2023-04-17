using DocumentFormat.OpenXml.InkML;
using ManagementSoftware.DAL.DALPagination;
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

namespace ManagementSoftware.GUI.ResultManagement
{
    public partial class FormDataMachine : Form
    {

        public FormDataMachine()
        {
            InitializeComponent();
            integerTextBoxSoLuongDong.MinValue = 1;
            integerTextBoxSoLuongDong.MaxValue = 1000;
            LoadDGV();
        }

        void LoadDGV()
        {
            dataGridView1.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;

            dataGridView1.Columns.Add(new DataGridViewTextBoxColumn() { HeaderText = "No.", AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells });
            dataGridView1.Columns.Add(new DataGridViewTextBoxColumn() { HeaderText = "TÊN GIÀN", SortMode = DataGridViewColumnSortMode.NotSortable });
            dataGridView1.Columns.Add(new DataGridViewTextBoxColumn() { HeaderText = "ÁP SUẤT TỔNG", SortMode = DataGridViewColumnSortMode.NotSortable });
            dataGridView1.Columns.Add(new DataGridViewTextBoxColumn() { HeaderText = "ÁP SUẤT", SortMode = DataGridViewColumnSortMode.NotSortable });
            dataGridView1.Columns.Add(new DataGridViewTextBoxColumn() { HeaderText = "THỂ TÍCH", SortMode = DataGridViewColumnSortMode.NotSortable });
            dataGridView1.Columns.Add(new DataGridViewTextBoxColumn() { HeaderText = "THỜI ĐIỂM", SortMode = DataGridViewColumnSortMode.NotSortable });
            dataGridView1.Columns.Add(new DataGridViewTextBoxColumn() { HeaderText = "MẺ NẠP", SortMode = DataGridViewColumnSortMode.NotSortable });




            dataGridView1.ColumnHeadersDefaultCellStyle.BackColor = Color.DarkOrange;
            dataGridView1.EnableHeadersVisualStyles = false;
            dataGridView1.ColumnHeadersDefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;
            dataGridView1.ColumnHeadersDefaultCellStyle.Font = new Font("Segoe UI", 13, FontStyle.Bold);

            //dataGridView1.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.AllCells;


            dataGridView1.RowTemplate.Height = 50;
            dataGridView1.DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;
            //dataGridView1.DefaultCellStyle.ForeColor = Color.White;
            dataGridView1.DefaultCellStyle.Font = new Font("Segoe UI", 12, FontStyle.Regular);
            dataGridView1.AllowUserToAddRows = false;
            dataGridView1.AllowUserToDeleteRows = false;
            dataGridView1.ReadOnly = true;
            dataGridView1.RowHeadersVisible = false;

            //dataGridView1.SelectionMode = DataGridViewSelectionMode.FullRowSelect;


        }

        // ngày để query 
        private DateTime? timeStart = null;
        private DateTime? timeEnd = null;
        // trang hiện tại
        private int page = 1;

        // tổng số trang
        private int TotalPages = 0;

        // số dòng hiển thị
        long numRow = 40;

        string? keyIDSearch = "";
        //Data
        List<Models.Machine> ListResults = new List<Models.Machine>();

        PaginationMachine pagination = new PaginationMachine();
        async Task LoadFormThongKe()
        {
            panelPagination.Enabled = false;
            dataGridView1.Rows.Clear();


            await Task.Run(() => pagination.Set(page, timeStart, timeEnd, keyIDSearch));

            this.ListResults = pagination.ListResults;
            this.TotalPages = pagination.TotalPages;
            lbTotalPages.Text = this.TotalPages.ToString();

            buttonPreviousPage.Enabled = this.page > 1;
            buttonNextPage.Enabled = this.page < this.TotalPages;
            buttonPage.Text = this.page.ToString();

            pageNumberGoto.MinValue = 1;
            pageNumberGoto.MaxValue = this.TotalPages != 0 ? this.TotalPages : 1;

            integerTextBoxSoLuongDong.IntegerValue = pagination.NumberRows;


            if (ListResults != null && ListResults.Count > 0)
            {
                int i = 1;
                foreach (var item in this.ListResults)
                {
                    int rowId = dataGridView1.Rows.Add();
                    DataGridViewRow row = dataGridView1.Rows[rowId];

                    row.Cells[0].Value = i;

                    row.Cells[1].Value = item.NameMachine;
                    row.Cells[2].Value = string.Format("{0:0.00}", item.ApSuatTong ?? 0);
                    row.Cells[3].Value = string.Format("{0:0.00}", item.ApSuat ?? 0);
                    row.Cells[4].Value = string.Format("{0:0.00}", item.TheTich ?? 0);
                    row.Cells[5].Value = item.CreateAt.ToString("HH:mm:ss dd/MM/yyyy");
                    row.Cells[6].Value = Common.RESULT + item.ResultID;

                    if (i % 2 == 0)
                    {
                        row.DefaultCellStyle.BackColor = Color.LightSeaGreen;
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

        private async void buttonPreviousPage_Click(object sender, EventArgs e)
        {
            if (this.page > 1)
            {
                this.page = this.page - 1;
                await LoadFormThongKe();
            }
        }

        private async void buttonNextPage_Click(object sender, EventArgs e)
        {
            if (this.page < this.TotalPages)
            {
                this.page = this.page + 1;
                await LoadFormThongKe();
            }
        }

        private async void buttonSearch_Click(object sender, EventArgs e)
        {
            timeStart = TimeStart.Value;
            timeEnd = TimeEnd.Value;
            await LoadFormThongKe();
        }

        private async void buttonGoto_Click(object sender, EventArgs e)
        {
            this.page = Convert.ToInt32(pageNumberGoto.IntegerValue);
            await LoadFormThongKe();
        }

        private async void FormDataMachine_Load(object sender, EventArgs e)
        {
            await LoadFormThongKe();
        }

        private async void buttonViewDetsil_Click(object sender, EventArgs e)
        {
            buttonViewDetsil.Enabled = false;

            numRow = integerTextBoxSoLuongDong.IntegerValue;

            if (textBoxIDResult.Texts != textBoxIDResult.PlaceholderText)
            {
                keyIDSearch = textBoxIDResult.Texts;

                page = 1;
                timeStart = null;
                timeEnd = null;
                TotalPages = 0;

            }
            pagination.SetNumRow(Convert.ToInt32(numRow));
            await LoadFormThongKe();
            buttonViewDetsil.Enabled = true;
        }

        ExportData exportData = new ExportData();

        private void buttonExcel_Click(object sender, EventArgs e)
        {
            exportData.ExportManyMachineToExcel(ListResults);
        }

        private void buttonPrint_Click(object sender, EventArgs e)
        {
            exportData.ExportManyMachineToPdf(ListResults);
        }
    }
}
