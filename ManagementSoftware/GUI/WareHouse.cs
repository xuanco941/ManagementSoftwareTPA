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
using ManagementSoftware.DAL.DALPagination;
using ManagementSoftware.GUI.ExportWareHouseManagement;
using ManagementSoftware.GUI.Section;
using ManagementSoftware.GUI.WorkingListManagement;
using ManagementSoftware.Models;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace ManagementSoftware.GUI
{
    public partial class WareHouse : Form
    {
        // Aleart
        public delegate void CallAlert(string msg, FormAlert.enmType type);
        public CallAlert callAlert;


        private int page = 1;
        // tổng số trang
        private int TotalPages = 1;

        private string poID = "";
        private string productID = "";


        List<Product> ListResults = new List<Product>();

        public WareHouse()
        {
            InitializeComponent();

            LoadDGV();
            LoadFormThongKe();
        }

        private void LoadDGV()
        {

            dataGridView1.Columns.Add(new DataGridViewTextBoxColumn() { HeaderText = "ID", SortMode = DataGridViewColumnSortMode.NotSortable });

            dataGridView1.Columns.Add(new DataGridViewTextBoxColumn() { HeaderText = "Tên SP", SortMode = DataGridViewColumnSortMode.NotSortable });
            dataGridView1.Columns.Add(new DataGridViewTextBoxColumn() { HeaderText = "Số lượng sản xuất", SortMode = DataGridViewColumnSortMode.NotSortable });
            dataGridView1.Columns.Add(new DataGridViewTextBoxColumn() { HeaderText = "Số lượng đã nhập kho", SortMode = DataGridViewColumnSortMode.NotSortable });
            dataGridView1.Columns.Add(new DataGridViewTextBoxColumn() { HeaderText = "Số lượng đã xuất kho", SortMode = DataGridViewColumnSortMode.NotSortable });
            dataGridView1.Columns.Add(new DataGridViewTextBoxColumn() { HeaderText = "Chất lượng(%)", SortMode = DataGridViewColumnSortMode.NotSortable });
            dataGridView1.Columns.Add(new DataGridViewTextBoxColumn() { HeaderText = "Quy cách(L)", SortMode = DataGridViewColumnSortMode.NotSortable });
            dataGridView1.Columns.Add(new DataGridViewButtonColumn()
            {
                HeaderText = "",
                SortMode = DataGridViewColumnSortMode.NotSortable,
                UseColumnTextForButtonValue = true,
                Text = "Xuất kho",
                Name = "XK",
                AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells,
                DefaultCellStyle = new DataGridViewCellStyle()
                {
                    Font = new Font("Segoe UI", 14, FontStyle.Bold),
                }
            });





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


            dataGridView1.CellClick += dataGridViewSoftware_CellClick;



        }
        private void dataGridViewSoftware_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.ColumnIndex == dataGridView1.Columns["XK"].Index)
            {
                try
                {
                    XuatKho u = new XuatKho(dataGridView1.Rows[e.RowIndex].Cells[0].Value.ToString());
                    u.ShowDialog();
                }
                catch
                {

                }

            }

        }
        string strIDPO = "";
        string strIDProduct = "";
        void LoadFormThongKe()
        {
            panel1.Enabled = false;
            dataGridView1.Rows.Clear();

            PaginationProductCanBeExportWarehouse pagination = new PaginationProductCanBeExportWarehouse();
            pagination.Set(page, strIDProduct);
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
                row.Cells[0].Value = Common.PRODUCT + item.ProductID;

                //Product? p = dALProduct.GetProductFromID(item.ProductID);

                row.Cells[1].Value = item.ProductName;
                row.Cells[2].Value = item.SoLuongSanXuat;
                row.Cells[3].Value = item.SoLuongDaNhapKho;
                row.Cells[4].Value = item.SoLuongDaXuatKho;
                row.Cells[5].Value = item.ChatLuongKhi;
                row.Cells[6].Value = item.QuyCach;


                if (item.SoLuongDaNhapKho == 0)
                {
                    row.DefaultCellStyle.BackColor = Color.Crimson;
                }

            }

            panel1.Enabled = true;
        }


        void LoadFormThongKe2()
        {
            panel1.Enabled = false;
            dataGridView1.Rows.Clear();

            PaginationProductCanBeExportWarehouse pagination = new PaginationProductCanBeExportWarehouse();
            pagination.Set(page, strIDPO);
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
                row.Cells[0].Value = Common.PRODUCT + item.ProductID;

                //Product? p = dALProduct.GetProductFromID(item.ProductID);

                row.Cells[1].Value = item.ProductName;
                row.Cells[2].Value = item.SoLuongSanXuat;
                row.Cells[3].Value = item.SoLuongDaNhapKho;
                row.Cells[4].Value = item.SoLuongDaXuatKho;
                row.Cells[5].Value = item.ChatLuongKhi;
                row.Cells[6].Value = item.QuyCach;


                if (item.SoLuongDaNhapKho == 0)
                {
                    row.DefaultCellStyle.BackColor = Color.Crimson;
                }

            }

            panel1.Enabled = true;
        }


        private void WareHouse_Load(object sender, EventArgs e)
        {
            checkbtnAndReload();
        }

        private void buttonCustomLoc_Click(object sender, EventArgs e)
        {
            check = true;
            if (String.IsNullOrEmpty(textBoxSearchPO.Texts) == false && textBoxSearchPO.Texts != textBoxSearchPO.PlaceholderText)
            {
                strIDPO = textBoxSearchPO.Texts;
            }
            else
            {
                strIDPO = "";
            }
        }
        private void buttonCustom1_Click(object sender, EventArgs e)
        {
            check = false;
            if (String.IsNullOrEmpty(textBoxSearchProduct.Texts) == false && textBoxSearchProduct.Texts != textBoxSearchProduct.PlaceholderText)
            {
                strIDProduct = textBoxSearchProduct.Texts;
            }
            else
            {
                strIDProduct = "";
            }
        }

        bool check = false;
        void checkbtnAndReload()
        {
            if (check == false)
            {
                LoadFormThongKe();
            }
            else
            {
                LoadFormThongKe2();
            }
        }

        private void buttonPreviousPage_Click_1(object sender, EventArgs e)
        {
            if (this.page > 1)
            {
                this.page = this.page - 1;
                checkbtnAndReload();
            }
        }

        private void buttonNextPage_Click_1(object sender, EventArgs e)
        {
            if (this.page < this.TotalPages)
            {
                this.page = this.page + 1;
                checkbtnAndReload();
            }
        }

        private void buttonCustom2_Click(object sender, EventArgs e)
        {
            this.page = int.Parse(pageNumberGoto.Text);
            checkbtnAndReload();
        }
    }
}
