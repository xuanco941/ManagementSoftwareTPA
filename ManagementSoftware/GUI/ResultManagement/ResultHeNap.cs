using ManagementSoftware.DAL;
using ManagementSoftware.GUI.Section;
using ManagementSoftware.Models;
using Syncfusion.Drawing;
using Syncfusion.Windows.Forms.Chart;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using TwinCAT.PlcOpen;

namespace ManagementSoftware.GUI.ResultManagement
{
    public partial class ResultHeNap : Form
    {
        Chart chartGian1;
        Chart chartGian2;

        DALMachine dalMachine = new DALMachine();


        List<DataDoThi> dataDoThiASTong1 = new List<DataDoThi>();
        List<DataDoThi> dataDoThiAS1 = new List<DataDoThi>();
        List<DataDoThi> dataDoThiTT1 = new List<DataDoThi>();

        List<DataDoThi> dataDoThiASTong2 = new List<DataDoThi>();
        List<DataDoThi> dataDoThiAS2 = new List<DataDoThi>();
        List<DataDoThi> dataDoThiTT2 = new List<DataDoThi>();

        List<Machine> listDataMachine = new List<Machine>();

        async Task GetData()
        {
            dataDoThiASTong1.Clear();
            dataDoThiAS1.Clear();
            dataDoThiTT1.Clear();
            dataDoThiASTong2.Clear();
            dataDoThiAS2.Clear();
            dataDoThiTT2.Clear();



            listDataMachine = await Task.Run(() => dalMachine.GetAllMachinesByResultID(result.ResultID));

            foreach (var item in listDataMachine)
            {
                if (item.NameMachine == Common.GianNap1)
                {
                    dataDoThiASTong1.Add(new DataDoThi() { date = item.CreateAt, value = item.ApSuatTong ?? 0 });
                    dataDoThiAS1.Add(new DataDoThi() { date = item.CreateAt, value = item.ApSuat ?? 0 });
                    dataDoThiTT1.Add(new DataDoThi() { date = item.CreateAt, value = item.TheTich ?? 0 });
                }
                else if (item.NameMachine == Common.GianNap2)
                {
                    dataDoThiASTong2.Add(new DataDoThi() { date = item.CreateAt, value = item.ApSuatTong ?? 0 });
                    dataDoThiAS2.Add(new DataDoThi() { date = item.CreateAt, value = item.ApSuat ?? 0 });
                    dataDoThiTT2.Add(new DataDoThi() { date = item.CreateAt, value = item.TheTich ?? 0 });
                }
            }
        }

        void UpdateCharGian1()
        {
            ChartSeries seriesApSuatTong = new ChartSeries("Áp suất tổng", ChartSeriesType.Line);
            ChartSeries seriesApSuat = new ChartSeries("Áp suất", ChartSeriesType.Line);
            ChartSeries seriesTheTich = new ChartSeries("Thể tích", ChartSeriesType.Line);


            seriesApSuatTong.Style.Border.Width = 3;
            seriesApSuatTong.Style.Interior = new BrushInfo(PatternStyle.None, Color.Red, Color.SeaGreen);

            seriesApSuat.Style.Border.Width = 3;
            seriesApSuat.Style.Interior = new BrushInfo(PatternStyle.None, Color.Red, Color.Crimson);

            seriesTheTich.Style.Border.Width = 3;
            seriesTheTich.Style.Interior = new BrushInfo(PatternStyle.None, Color.Red, Color.DarkGoldenrod);

            Dictionary<ChartSeries, List<DataDoThi>> dic = new Dictionary<ChartSeries, List<DataDoThi>>();



            dic.Add(seriesApSuatTong, dataDoThiASTong1);
            dic.Add(seriesApSuat, dataDoThiAS1);
            dic.Add(seriesTheTich, dataDoThiTT2);



            chartGian1.UpdateChart(dic);
        }


        void UpdateCharGian2()
        {
            ChartSeries seriesApSuatTong = new ChartSeries("Áp suất tổng", ChartSeriesType.Line);
            ChartSeries seriesApSuat = new ChartSeries("Áp suất", ChartSeriesType.Line);
            ChartSeries seriesTheTich = new ChartSeries("Thể tích", ChartSeriesType.Line);



            seriesApSuatTong.Style.Border.Width = 3;
            seriesApSuatTong.Style.Interior = new BrushInfo(PatternStyle.None, Color.Red, Color.SeaGreen);

            seriesApSuat.Style.Border.Width = 3;
            seriesApSuat.Style.Interior = new BrushInfo(PatternStyle.None, Color.Red, Color.Crimson);

            seriesTheTich.Style.Border.Width = 3;
            seriesTheTich.Style.Interior = new BrushInfo(PatternStyle.None, Color.Red, Color.DarkGoldenrod);

            Dictionary<ChartSeries, List<DataDoThi>> dic = new Dictionary<ChartSeries, List<DataDoThi>>();



            dic.Add(seriesApSuatTong, dataDoThiASTong2);
            dic.Add(seriesApSuat, dataDoThiAS2);
            dic.Add(seriesTheTich, dataDoThiTT2);



            chartGian2.UpdateChart(dic);
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





        Result result;

        public ResultHeNap(Result result)
        {
            InitializeComponent();

            LoadDGV();

            this.result = result;

            this.Text = "Dữ liệu bản ghi " + Common.RESULT + result.ResultID;


            chartGian1 = new Chart("BIỂU ĐỒ DỮ LIỆU GIÀN 1");
            chartGian2 = new Chart("BIỂU ĐỒ DỮ LIỆU GIÀN 2");


        }


        void LoadFormThongKe()
        {
            int i = 1;

            foreach (var item in this.listDataMachine)
            {
                int rowId = dataGridView1.Rows.Add();
                DataGridViewRow row = dataGridView1.Rows[rowId];

                row.Cells[0].Value = i;

                row.Cells[1].Value = item.NameMachine;
                row.Cells[2].Value = string.Format("{0:0.00}", item.ApSuatTong ?? 0);
                row.Cells[3].Value = string.Format("{0:0.00}", item.ApSuat ?? 0);
                row.Cells[4].Value = string.Format("{0:0.00}", item.TheTich ?? 0);
                row.Cells[5].Value = item.CreateAt.ToString("HH:mm:ss dd/MM/yyyy");

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

        private async void ResultHeNap_Load(object sender, EventArgs e)
        {
            //
            labelTitle.Text = $"THÔNG TIN CÀI ĐẶT (MẺ NẠP ID-{Common.RESULT + result.ResultID})";

            labelNguoiVanHanh.Text = "Người vận hành : " + result.Username;
            labelLoaiKhi.Text = "Loại khí : " + result.LoaiKhi;
            labelThoiGianBatDau.Text = "Thời gian bắt đầu : " + result.TimeStart.ToString("HH:mm:ss dd/MM/yyyy");
            if (result.TimeStart < result.TimeEnd)
            {
                labelThoiGianKetThuc.Text = "Thời gian kết thúc : " + result.TimeEnd.ToString("HH:mm:ss dd/MM/yyyy");
            }
            else
            {
                labelThoiGianKetThuc.Text = "Thời gian kết thúc : ";
            }
            labelApSuatTieuChuan.Text = "Áp suất tiêu chuẩn : " + (result.ApSuatTieuChuan ?? 0) + " Bar";
            labelTheTichTieuChuan.Text = "Thể tích tiêu chuẩn : " + (result.TheTichTieuChuan ?? 0).ToString() + " L";
            labelTheTichCanNap.Text = "Thể tích cần nạp : " + (result.TheTichCanNap ?? 0).ToString() + " L";
            labelHeSoTieuChuan.Text = "Hệ số tiêu chuẩn : " + (result.HeSoTieuChuan ?? 0).ToString();
            labelThoiGianTrichMau.Text = "Thời gian trích mẫu : " + result.ThoiGianTrichMau?.ToString("HH:mm:ss") ?? "00:00:00";
            labelSoLuongBinhNapGian1.Text = "Số lượng bình nạp giàn 1 : " + (result.SoLuongBinhCanNapHe1 ?? 0).ToString();
            labelSoLuongBinhNapGian2.Text = "Số lượng bình nạp giàn 2 : " + (result.SoLuongBinhCanNapHe2 ?? 0).ToString();

            MethodCommonGUI commonGUI = new MethodCommonGUI();
            commonGUI.ShowFormOnPanel(panelApSuatChart, chartGian1);
            commonGUI.ShowFormOnPanel(panelTheTichChart, chartGian2);


            await GetData();

            LoadFormThongKe();

            UpdateCharGian1();
            UpdateCharGian2();
        }


        ExportData exportData = new ExportData();
        private void buttonExcel_Click(object sender, EventArgs e)
        {
            exportData.ExportMachineOnAResultToExcel(listDataMachine, result);
        }

        private void buttonPrint_Click(object sender, EventArgs e)
        {
            exportData.ExportMachineOnAResultToPdf(listDataMachine, result);
        }
    }
}
