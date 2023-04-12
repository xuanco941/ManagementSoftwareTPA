using ManagementSoftware.DAL;
using ManagementSoftware.Models;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ManagementSoftware.GUI.ResultManagement
{
    public partial class ResultError : Form
    {
        //Data
        List<Models.ResultWarning> ListResults = new List<Models.ResultWarning>();

        Result result;
        public ResultError(Result result)
        {
            InitializeComponent();
            this.result = result;
            LoadDGV();
        }


        void LoadDGV()
        {
            dataGridView1.Columns.Add(new DataGridViewTextBoxColumn() { HeaderText = "STT", SortMode = DataGridViewColumnSortMode.NotSortable });
            dataGridView1.Columns.Add(new DataGridViewTextBoxColumn() { HeaderText = "MÃ LỖI", SortMode = DataGridViewColumnSortMode.NotSortable });
            dataGridView1.Columns.Add(new DataGridViewTextBoxColumn() { HeaderText = "MÔ TẢ", SortMode = DataGridViewColumnSortMode.NotSortable });
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

            //dataGridView1.Rows.Clear();


            ListResults = new DALResultWarning().GetAllResultWarningsByResultID(result.ResultID);

            if (ListResults != null && ListResults.Count > 0)
            {
                int i = 1;
                foreach (var item in ListResults)
                {
                    int rowId = dataGridView1.Rows.Add();
                    DataGridViewRow row = dataGridView1.Rows[rowId];
                    row.Cells[0].Value = i;

                    row.Cells[1].Value = item.Title;
                    row.Cells[2].Value = item.Description;
                    row.Cells[3].Value = item.CreateAt.ToString("HH:mm:ss dd/MM/yyyy");
                    i++;
                }

            }

        }

        private void ResultError_Load(object sender, EventArgs e)
        {
            labelBangLoi.Text = "BẢNG LỖI MẺ NẠP " + Common.RESULT + result.ResultID;
            LoadFormThongKe();
        }
    }
}
