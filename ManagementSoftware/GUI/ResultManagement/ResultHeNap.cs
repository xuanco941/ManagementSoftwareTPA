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

        void GetData()
        {
            dataDoThiASTong1.Clear();
            dataDoThiAS1.Clear();
            dataDoThiTT1.Clear();
            dataDoThiASTong2.Clear();
            dataDoThiAS2.Clear();
            dataDoThiTT2.Clear();




            List<Machine> listData = dalMachine.GetAllMachinesByResultID(result.ResultID);

            foreach (var item in listData)
            {
                if (item.NameMachine == Common.GianNap1)
                {
                    dataDoThiASTong1.Add(new DataDoThi() { date = item.CreateAt, value = item.ApSuatTong });
                    dataDoThiAS1.Add(new DataDoThi() { date = item.CreateAt, value = item.ApSuat });
                    dataDoThiTT1.Add(new DataDoThi() { date = item.CreateAt, value = item.TheTich });
                }
                else if (item.NameMachine == Common.GianNap2)
                {
                    dataDoThiASTong2.Add(new DataDoThi() { date = item.CreateAt, value = item.ApSuatTong });
                    dataDoThiAS2.Add(new DataDoThi() { date = item.CreateAt, value = item.ApSuat });
                    dataDoThiTT2.Add(new DataDoThi() { date = item.CreateAt, value = item.TheTich });
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
            seriesApSuat.Style.Interior = new BrushInfo(PatternStyle.None, Color.Red, Color.YellowGreen);

            seriesTheTich.Style.Border.Width = 3;
            seriesTheTich.Style.Interior = new BrushInfo(PatternStyle.None, Color.Red, Color.YellowGreen);

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
            seriesApSuat.Style.Interior = new BrushInfo(PatternStyle.None, Color.Red, Color.YellowGreen);

            seriesTheTich.Style.Border.Width = 3;
            seriesTheTich.Style.Interior = new BrushInfo(PatternStyle.None, Color.Red, Color.YellowGreen);

            Dictionary<ChartSeries, List<DataDoThi>> dic = new Dictionary<ChartSeries, List<DataDoThi>>();



            dic.Add(seriesApSuatTong, dataDoThiASTong2);
            dic.Add(seriesApSuat, dataDoThiAS2);
            dic.Add(seriesTheTich, dataDoThiTT2);



            chartGian2.UpdateChart(dic);
        }






        Result result;

        public ResultHeNap(Result result)
        {
            InitializeComponent();

            this.result = result;

            this.Text = "Dữ liệu bản ghi " + Common.RESULT + result.ResultID;


            chartGian1 = new Chart("BIỂU ĐỒ DỮ LIỆU GIÀN 1");
            chartGian2 = new Chart("BIỂU ĐỒ DỮ LIỆU GIÀN 2");


        }


        private void ResultHeNap_Load(object sender, EventArgs e)
        {
            //
            labelNguoiVanHanh.Text = "Người vận hành : " + result.Username;
            labelLoaiKhi.Text = "Loại khí : " + result.LoaiKhi;
            labelThoiGianBatDau.Text = "Thời gian bắt đầu : " + result.TimeStart.ToString("HH:mm:ss dd/MM/yyyy");


            MethodCommonGUI commonGUI = new MethodCommonGUI();
            commonGUI.ShowFormOnPanel(panelApSuatChart, chartGian1);
            commonGUI.ShowFormOnPanel(panelTheTichChart, chartGian2);


            GetData();
            UpdateCharGian1();
            UpdateCharGian2();
        }
    }
}
