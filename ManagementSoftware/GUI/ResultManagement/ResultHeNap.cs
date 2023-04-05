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
        Chart chartApSuat;
        Chart chartTheTich;



        void UpdateChartApSuat()
        {
            ChartSeries seriesApSuatTong = new ChartSeries("Áp suất tổng", ChartSeriesType.Line);
            ChartSeries seriesApSuatHe1 = new ChartSeries("Áp suất hệ 1", ChartSeriesType.Line);

            seriesApSuatTong.Style.Border.Width = 3;
            seriesApSuatTong.Style.Interior = new BrushInfo(PatternStyle.None, Color.Red, Color.SeaGreen);

            seriesApSuatHe1.Style.Border.Width = 3;
            seriesApSuatHe1.Style.Interior = new BrushInfo(PatternStyle.None, Color.Red, Color.YellowGreen);

            Dictionary<ChartSeries, List<DataDoThi>> dic = new Dictionary<ChartSeries, List<DataDoThi>>();

            DateTime now = DateTime.Now;

            List<DataDoThi> dataDoThiASTong = new List<DataDoThi>();
            List<DataDoThi> dataDoThiAS1 = new List<DataDoThi>();


            for (int i = 0; i < 30; i++)
            {
                dataDoThiASTong.Add(new DataDoThi() { date = now, value = new Random().Next(0, 101) });
                dataDoThiAS1.Add(new DataDoThi() { date = now, value = new Random().Next(0, 101) });

                now = now.AddMinutes(5);

            }

            dic.Add(seriesApSuatTong, dataDoThiASTong);
            dic.Add(seriesApSuatHe1, dataDoThiAS1);


            chartApSuat.UpdateChart(dic);
        }


        void UpdateChartTheTich()
        {
            ChartSeries seriesApSuatTheTich1 = new ChartSeries("THỂ TÍCH HỆ 1", ChartSeriesType.Line);

            seriesApSuatTheTich1.Style.Border.Width = 3;
            seriesApSuatTheTich1.Style.Interior = new BrushInfo(PatternStyle.None, Color.Red, Color.DarkGoldenrod);



            Dictionary<ChartSeries, List<DataDoThi>> dic = new Dictionary<ChartSeries, List<DataDoThi>>();

            DateTime now = DateTime.Now;

            List<DataDoThi> dataDoThiAS1 = new List<DataDoThi>();
            List<DataDoThi> dataDoThiAS2 = new List<DataDoThi>();


            for (int i = 0; i < 30; i++)
            {
                dataDoThiAS1.Add(new DataDoThi() { date = now, value = new Random().Next(0, 101) });

                now = now.AddMinutes(5);
            }

            dic.Add(seriesApSuatTheTich1, dataDoThiAS1);


            chartTheTich.UpdateChart(dic);
        }

        string heNap;
        Result result;
        
        public ResultHeNap(Result result, string heNap)
        {
            InitializeComponent();

            this.result = result;
            this.heNap = heNap;

            chartApSuat = new Chart("BIỂU ĐỒ ÁP SUẤT");
            chartTheTich = new Chart("BIỂU ĐỒ THỂ TÍCH");
        }


        private void ResultHeNap_Load(object sender, EventArgs e)
        {
            MethodCommonGUI commonGUI = new MethodCommonGUI();


            commonGUI.ShowFormOnPanel(panelApSuatChart, chartApSuat);

            commonGUI.ShowFormOnPanel(panelTheTichChart, chartTheTich);



            UpdateChartApSuat();
            UpdateChartTheTich();
        }
    }
}
