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
        public LichSuDangNhap()
        {
            InitializeComponent();
            LoadDGV();
        }
        void LoadDGV()
        {
            dataGridView1.Columns.Add(new DataGridViewTextBoxColumn() { HeaderText = "MÃ NHÂN VIÊN", SortMode = DataGridViewColumnSortMode.NotSortable });
            dataGridView1.Columns.Add(new DataGridViewTextBoxColumn() { HeaderText = "TÊN NHÂN VIÊN", SortMode = DataGridViewColumnSortMode.NotSortable });
            dataGridView1.Columns.Add(new DataGridViewTextBoxColumn() { HeaderText = "NGÀY GIỜ ĐĂNG NHẬP", SortMode = DataGridViewColumnSortMode.NotSortable });
            dataGridView1.Columns.Add(new DataGridViewTextBoxColumn() { HeaderText = "THỜI GIAN HOẠT ĐỘNG ĐẾN", SortMode = DataGridViewColumnSortMode.NotSortable });






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




            for (int i = 1; i < 7; i++)
            {
                int rowId = dataGridView1.Rows.Add();
                DataGridViewRow row = dataGridView1.Rows[rowId];

                row.Cells[0].Value = Common.USERS + new Random().Next(0, 101);
                row.Cells[1].Value = DateTime.Now.ToString("HH:mm:ss dd/MM/yyyy");
                row.Cells[2].Value = DateTime.Now.AddHours(3).ToString("HH:mm:ss dd/MM/yyyy");
                row.Cells[3].Value = "Đỗ Văn A";


                dataGridView1.Rows[rowId].DefaultCellStyle.BackColor = Color.FromArgb(41, 44, 51);

            }



        }
    }
}
