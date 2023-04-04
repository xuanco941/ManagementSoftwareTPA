using ManagementSoftware.GUI.Dashboard_Management;
using ManagementSoftware.GUI.Section;
using Syncfusion.Drawing;
using Syncfusion.Windows.Forms.Chart;
using Syncfusion.XlsIO.Implementation;
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
    public partial class Dashboard : Form
    {

        ErrorDashboard errorDashboard;
        SettingDashboard settingDashboard;




        Chart chartApSuat;
        Chart chartTheTich;



        void UpdateChartApSuat()
        {
            ChartSeries seriesApSuatTong = new ChartSeries("Áp suất tổng", ChartSeriesType.Line);
            ChartSeries seriesApSuatHe1 = new ChartSeries("Áp suất hệ 1", ChartSeriesType.Line);
            ChartSeries seriesApSuatHe2 = new ChartSeries("Áp suất hệ 2", ChartSeriesType.Line);

            seriesApSuatTong.Style.Border.Width = 3;
            seriesApSuatTong.Style.Interior = new BrushInfo(PatternStyle.None, Color.Red, Color.SeaGreen);

            seriesApSuatHe1.Style.Border.Width = 3;
            seriesApSuatHe1.Style.Interior = new BrushInfo(PatternStyle.None, Color.Red, Color.YellowGreen);

            seriesApSuatHe2.Style.Border.Width = 3;
            seriesApSuatHe2.Style.Interior = new BrushInfo(PatternStyle.None, Color.Red, Color.Purple);

            Dictionary<ChartSeries, List<DataDoThi>> dic = new Dictionary<ChartSeries, List<DataDoThi>>();

            DateTime now = DateTime.Now;

            List<DataDoThi> dataDoThiASTong = new List<DataDoThi>();
            List<DataDoThi> dataDoThiAS1 = new List<DataDoThi>();
            List<DataDoThi> dataDoThiAS2 = new List<DataDoThi>();


            for (int i = 0; i < 30; i++)
            {
                dataDoThiASTong.Add(new DataDoThi() { date = now, value = new Random().Next(0, 101) });
                dataDoThiAS1.Add(new DataDoThi() { date = now, value = new Random().Next(0, 101) });
                dataDoThiAS2.Add(new DataDoThi() { date = now, value = new Random().Next(0, 101) });

                now = now.AddMinutes(5);

            }

            dic.Add(seriesApSuatTong, dataDoThiASTong);
            dic.Add(seriesApSuatHe1, dataDoThiAS1);
            dic.Add(seriesApSuatHe2, dataDoThiAS2);


            chartApSuat.UpdateChart(dic);
        }


        void UpdateChartTheTich()
        {
            ChartSeries seriesApSuatTheTich1 = new ChartSeries("THỂ TÍCH HỆ 1", ChartSeriesType.Line);
            ChartSeries seriesApSuatTheTich2 = new ChartSeries("THỂ TÍCH HỆ 2", ChartSeriesType.Line);

            seriesApSuatTheTich1.Style.Border.Width = 3;
            seriesApSuatTheTich1.Style.Interior = new BrushInfo(PatternStyle.None, Color.Red, Color.DarkGoldenrod);

            seriesApSuatTheTich2.Style.Border.Width = 3;
            seriesApSuatTheTich2.Style.Interior = new BrushInfo(PatternStyle.None, Color.Red, Color.LightBlue);


            Dictionary<ChartSeries, List<DataDoThi>> dic = new Dictionary<ChartSeries, List<DataDoThi>>();

            DateTime now = DateTime.Now;

            List<DataDoThi> dataDoThiAS1 = new List<DataDoThi>();
            List<DataDoThi> dataDoThiAS2 = new List<DataDoThi>();


            for (int i = 0; i < 30; i++)
            {
                dataDoThiAS1.Add(new DataDoThi() { date = now, value = new Random().Next(0, 101) });
                dataDoThiAS2.Add(new DataDoThi() { date = now, value = new Random().Next(0, 101) });

                now = now.AddMinutes(5);
            }

            dic.Add(seriesApSuatTheTich1, dataDoThiAS1);
            dic.Add(seriesApSuatTheTich2, dataDoThiAS2);


            chartTheTich.UpdateChart(dic);
        }

        public Dashboard()
        {
            InitializeComponent();

            errorDashboard = new ErrorDashboard();
            settingDashboard = new SettingDashboard();


            chartApSuat = new Chart("BIỂU ĐỒ ÁP SUẤT");
            chartTheTich = new Chart("BIỂU ĐỒ THỂ TÍCH");
        }

        private async void Dashboard_Load(object sender, EventArgs e)
        {
            MethodCommonGUI commonGUI = new MethodCommonGUI();

            commonGUI.ShowFormOnPanel(panelMainThongSoCaiDat, settingDashboard);

            commonGUI.ShowFormOnPanel(panelChartApSuat, chartApSuat);

            commonGUI.ShowFormOnPanel(panelChartTheTich, chartTheTich);



            UpdateChartApSuat();
            UpdateChartTheTich();


        }

        private void Dashboard_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (IsHandleCreated && InvokeRequired)
            {
                BeginInvoke(new Action(() =>
                {
                    errorDashboard.Close();
                    settingDashboard.Close();
                    chartApSuat.Close();
                    chartTheTich.Close();
                }));

            }
            else
            {
                errorDashboard.Close();
                settingDashboard.Close();
                chartApSuat.Close();
                chartTheTich.Close();
            }
        }

        private void button57_Click_1(object sender, EventArgs e)
        {
            errorDashboard.ShowDialog();
        }


        private void buttonShowHeNap_Click(object sender, EventArgs e)
        {
            if (Application.OpenForms.OfType<HeNap>().Count() == 0)
            {
                HeNap f = new HeNap();
                f.Show();
            }
            else
            {
                Application.OpenForms.OfType<HeNap>().First().Activate();
            }
        }

        private void tabControl1_Selected(object sender, TabControlEventArgs e)
        {
            if (tabControl1.SelectedTab == tabPage2)
            {
                settingDashboard.LoadData();
            }
        }
    }
}
