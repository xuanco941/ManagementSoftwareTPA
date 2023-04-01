using ManagementSoftware.GUI.Dashboard_Management;
using Syncfusion.Windows.Forms.Chart;
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
        public Dashboard()
        {
            InitializeComponent();

            errorDashboard = new ErrorDashboard();
            settingDashboard = new SettingDashboard();
        }

        private async void Dashboard_Load(object sender, EventArgs e)
        {
            new MethodCommonGUI().ShowFormOnPanel(panelMainThongSoCaiDat, settingDashboard);

            SettingChart(chartControlApSuat, "BIỂU ĐỒ ÁP SUẤT");
            SettingChart(chartControlTheTich, "BIỂU ĐỒ THỂ TÍCH");




            chartControlApSuat.Series.Clear();


            ChartSeries seriesApSuatTong = new ChartSeries("Áp suất tổng", ChartSeriesType.Line);
            seriesApSuatTong.Style.Border.Width = 3;
            ChartSeries seriesApSuatHe1 = new ChartSeries("Áp suất hệ 1", ChartSeriesType.Line);
            seriesApSuatHe1.Style.Border.Width = 3;
            ChartSeries seriesApSuatHe2 = new ChartSeries("Áp suất hệ 2", ChartSeriesType.Line);
            seriesApSuatHe2.Style.Border.Width = 3;


            ChartSeries seriesTheTichHe1 = new ChartSeries("Thể tích hệ 1", ChartSeriesType.Line);
            seriesApSuatHe1.Style.Border.Width = 3;
            ChartSeries seriesTheTichHe2 = new ChartSeries("Thể tích hệ 2", ChartSeriesType.Line);
            seriesApSuatHe2.Style.Border.Width = 3;


            DateTime start = DateTime.Now;

            await SetValueSeries(seriesApSuatTong,start);
            await SetValueSeries(seriesApSuatHe1,start);
            await SetValueSeries(seriesApSuatHe2,start);



            //chartControlApSuat.Series.Add(seriesApSuatTong);
            //chartControlApSuat.Series.Add();
            //chartControlApSuat.Series.Add();



            //chartControlTheTich.Series.Add(seriesTheTichHe1);
            //chartControlTheTich.Series.Add(seriesTheTichHe2);



            DateTime end = start.AddHours(1);
            chartControlApSuat.PrimaryXAxis.DateTimeRange = new ChartDateTimeRange(start, end, 6, ChartDateTimeIntervalType.Minutes);


        }

        private void Dashboard_FormClosing(object sender, FormClosingEventArgs e)
        {
            errorDashboard.Close();
            settingDashboard.Close();
        }

        private void button57_Click_1(object sender, EventArgs e)
        {
            errorDashboard.ShowDialog();
        }




        async Task SetValueSeries(ChartSeries series, DateTime now)
        {
            for (int i = 0; i < 10; i++)
            {
                series.Points.Add(now, new Random().Next(0, 10));

                now = now.AddMinutes(1);
            }
            chartControlApSuat.Series.Add(series);

        }


        void SettingChart(ChartControl chartControl, string title)
        {
            chartControl.Title.Text = title;
            chartControl.Title.Font = new System.Drawing.Font("Candara", 12F, System.Drawing.FontStyle.Bold);

            //this.chartControl1.Crosshair.Visible = true;

            //chartControl.PrimaryYAxis.RoundingPlaces = 2;

            chartControl.ShowToolbar = true;
            //this.chartControl1.PrimaryXAxis.TickLabelsDrawingMode = ChartAxisTickLabelDrawingMode.UserMode;





            chartControl.PrimaryXAxis.IntervalType = ChartDateTimeIntervalType.Minutes;

            chartControl.PrimaryXAxis.LabelIntersectAction = ChartLabelIntersectAction.Wrap;

            chartControl.PrimaryXAxis.ValueType = ChartValueType.DateTime;

            chartControl.PrimaryXAxis.RangeType = ChartAxisRangeType.Set;

            chartControl.PrimaryXAxis.DateTimeInterval.Type = ChartDateTimeIntervalType.Minutes;

            chartControl.PrimaryXAxis.DateTimeFormat = "HH:mm:ss dd/MM/yyyy";


            chartControl.Trackball.Visible = true;
            chartControl.Trackball.DisplayMode = TrackballTooltipDisplayMode.Float;

            chartControl.Trackball.Line.Color = Color.FromArgb(128, 0, 0);

            chartControl.Trackball.Line.Width = 3;

            chartControl.Trackball.Symbol.Shape = ChartSymbolShape.Circle;


            chartControl.Trackball.Symbol.Border.Width = 1;

            chartControl.Trackball.Symbol.Border.Color = Color.White;

            chartControl.Trackball.Symbol.Size = new Size(5, 5);

            chartControl.Trackball.Tooltip.YValueFormat = "0.00";

            ChartFontInfo c = new ChartFontInfo();
            c.FontFamilyTemplate = FontFamily.GenericSerif;
            c.FontStyle = FontStyle.Regular;
            c.Size = 8;

            chartControl.Trackball.Tooltip.Font = c;
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
    }
}
