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

        private void Dashboard_Load(object sender, EventArgs e)
        {
            new MethodCommonGUI().ShowFormOnPanel(panelMainThongSoCaiDat, settingDashboard);

            SettingChart(chartControlApSuat, "BIỂU ĐỒ ÁP SUẤT");
            SettingChart(chartControlTheTich, "BIỂU ĐỒ THỂ TÍCH");





            ChartSeries seriesApSuat = new ChartSeries("Áp suất", ChartSeriesType.Line);
            seriesApSuat.Style.Border.Width = 3;
            DateTime now = DateTime.Now.Date;

            for (int i = 0; i < 300; i++)
            {
                seriesApSuat.Points.Add(now, new Random().Next(0, 101));
                now = now.AddMinutes(1);
            }
            chartControlApSuat.Series.Add(seriesApSuat);

            ChartSeries seriesTheTich = new ChartSeries("Thể tích", ChartSeriesType.Line);
            seriesTheTich.Style.Border.Width = 3;

            for (int i = 0; i < 300; i++)
            {
                seriesApSuat.Points.Add(now, new Random().Next(0, 101));
                now = now.AddMinutes(1);
            }
            chartControlTheTich.Series.Add(seriesTheTich);



            chartControlApSuat.PrimaryXAxis.DateTimeRange = new ChartDateTimeRange(now, now.AddMinutes(300), 50, ChartDateTimeIntervalType.Minutes);
            chartControlTheTich.PrimaryXAxis.DateTimeRange = new ChartDateTimeRange(now, now.AddMinutes(300), 50, ChartDateTimeIntervalType.Minutes);


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







        void SettingChart(ChartControl chartControl, string title)
        {
            chartControl.Title.Text = title;
            chartControl.Title.Font = new System.Drawing.Font("Candara", 20F, System.Drawing.FontStyle.Bold);

            //this.chartControl1.Crosshair.Visible = true;

            chartControl.PrimaryYAxis.RoundingPlaces = 2;

            chartControl.ShowToolbar = true;
            //this.chartControl1.PrimaryXAxis.TickLabelsDrawingMode = ChartAxisTickLabelDrawingMode.UserMode;





            chartControl.PrimaryXAxis.IntervalType = ChartDateTimeIntervalType.Minutes;

            chartControl.PrimaryXAxis.LabelIntersectAction = ChartLabelIntersectAction.Wrap;

            chartControl.PrimaryXAxis.ValueType = ChartValueType.DateTime;

            chartControl.PrimaryXAxis.RangeType = ChartAxisRangeType.Set;

            chartControl.PrimaryXAxis.DateTimeInterval.Type = ChartDateTimeIntervalType.Minutes;
            DateTime end = DateTime.Now;
            DateTime start = end.AddHours(-1);
            chartControl.PrimaryXAxis.DateTimeRange = new ChartDateTimeRange(start, end, 6, ChartDateTimeIntervalType.Minutes);

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
            if (Application.OpenForms.OfType<HeNapXam>().Count() == 0)
            {
                HeNapXam f2 = new HeNapXam();
                f2.Show();
            }
            else
            {
                Application.OpenForms.OfType<HeNapXam>().First().Activate();
            }
        }
    }
}
