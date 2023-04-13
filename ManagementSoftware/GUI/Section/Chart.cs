using Syncfusion.Windows.Forms.Chart;
using Syncfusion.XPS;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using TwinCAT.PlcOpen;

namespace ManagementSoftware.GUI.Section
{
    public partial class Chart : Form
    {
        public Chart(string title)
        {
            InitializeComponent();

            chartControl1.Title.Text = title;
            this.chartControl1.Title.Font = new System.Drawing.Font("Segoe UI", 11, FontStyle.Bold);
            this.chartControl1.Crosshair.Visible = true;
            this.chartControl1.PrimaryYAxis.RoundingPlaces = 2;


            chartControl1.ShowToolbar = true;

            this.chartControl1.PrimaryXAxis.IntervalType = ChartDateTimeIntervalType.Minutes;

            this.chartControl1.PrimaryXAxis.LabelIntersectAction = ChartLabelIntersectAction.Wrap;

            this.chartControl1.PrimaryXAxis.ValueType = ChartValueType.DateTime;

            this.chartControl1.PrimaryXAxis.RangeType = ChartAxisRangeType.Set;

            this.chartControl1.PrimaryXAxis.DateTimeInterval.Type = ChartDateTimeIntervalType.Minutes;
            DateTime end = DateTime.Now;
            DateTime start = end.AddHours(-1);
            this.chartControl1.PrimaryXAxis.DateTimeRange = new ChartDateTimeRange(start, end, 12, ChartDateTimeIntervalType.Minutes);

            this.chartControl1.PrimaryXAxis.DateTimeFormat = "HH:mm:ss dd/MM/yy";











            this.chartControl1.Trackball.Visible = true;
            this.chartControl1.Trackball.DisplayMode = TrackballTooltipDisplayMode.Float;

            this.chartControl1.Trackball.Line.Color = Color.FromArgb(128, 0, 0);

            this.chartControl1.Trackball.Line.Width = 2;

            this.chartControl1.Trackball.Symbol.Shape = ChartSymbolShape.Circle;


            this.chartControl1.Trackball.Symbol.Border.Width = 1;

            this.chartControl1.Trackball.Symbol.Border.Color = Color.White;

            this.chartControl1.Trackball.Symbol.Size = new Size(7, 7);

            this.chartControl1.Trackball.Tooltip.YValueFormat = "0.00";


            ChartFontInfo c = new ChartFontInfo();
            c.FontFamilyTemplate = FontFamily.GenericSerif;
            c.FontStyle = FontStyle.Regular;
            c.Size = 10;

            this.chartControl1.Trackball.Tooltip.Font = c;



        }



        public void UpdateChart(Dictionary<ChartSeries, List<DataDoThi>> dic)
        {
            chartControl1.Series.Clear();
            if (dic != null && dic.Count > 0 && dic.Values != null && dic.Values.Count > 0)
            {
                var valuesAll = dic.Values.SelectMany(v => v);
                if (valuesAll.Any())
                {
                    DateTime start = valuesAll.Min(x => x.date);
                    DateTime end = valuesAll.Max(x => x.date);



                    foreach (var item in dic)
                    {
                        foreach (DataDoThi l in item.Value)
                        {
                            if (l.value != null)
                            {
                                item.Key.Points.Add(l.date, l.value ?? 0);
                            }
                        }
                        chartControl1.Series.Add(item.Key);
                    }
                    this.chartControl1.PrimaryXAxis.DateTimeRange = new ChartDateTimeRange(start, end, dic.Values.Count / 6, ChartDateTimeIntervalType.Minutes);

                }



            }
        }
    }
}
