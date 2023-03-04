using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using ManagementSoftware.GUI.Section;

namespace ManagementSoftware.GUI
{
    public partial class WareHouse : Form
    {
        // Aleart
        public delegate void CallAlert(string msg, FormAlert.enmType type);
        public CallAlert callAlert;

        public WareHouse()
        {
            InitializeComponent();
            //dataGridView1.ColumnHeadersDefaultCellStyle.BackColor = Color.DarkOrange;
            dataGridView1.EnableHeadersVisualStyles = false;
            dataGridView1.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dataGridView1.ColumnHeadersDefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;
            dataGridView1.ColumnHeadersDefaultCellStyle.Font = new Font("Segoe UI", 14, FontStyle.Bold);


            dataGridView1.RowTemplate.Height = 40;
            dataGridView1.DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;
            //dataGridView1.DefaultCellStyle.ForeColor = Color.White;
            dataGridView1.DefaultCellStyle.Font = new Font("Segoe UI", 14, FontStyle.Regular);
            dataGridView1.AllowUserToAddRows = false;
            dataGridView1.AllowUserToDeleteRows = false;
            dataGridView1.ReadOnly = true;
            dataGridView1.RowHeadersVisible = false;

            dataGridView1.ReadOnly = true;


            LoadForm();

        }

        private void LoadForm()
        {
            DataTable dt = new DataTable();
            dt.Columns.Add("Stt");
            dt.Columns.Add("Tên hàng");
            dt.Columns.Add("Mã hàng");
            dt.Columns.Add("Thể tích bình");

            dt.Columns.Add("Áp suất nạp");
            dt.Columns.Add("Loại khí");
            dt.Columns.Add("Chất lượng khí");

            dt.Columns.Add("DVT");
            dt.Columns.Add("Số lượng");
            dt.Columns.Add("Đơn giá");
            dt.Columns.Add("Người thực thi");

            dt.Columns.Add("Thành tiền");

            dataGridView1.DataSource = dt;



        }

    }
}
