using ManagementSoftware.DAL;
using ManagementSoftware.GUI.Section;
using ManagementSoftware.Models;
using Microsoft.Extensions.Caching.Memory;
using Syncfusion.Drawing;
using Syncfusion.Windows.Forms.Chart;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ManagementSoftware.GUI.Dashboard_Management
{
    public class MethodUpdateChartFormDashboard
    {
        TimerUpdateGUI timerUpdateGUILabel1;
        PLCBeckhOff plc;
        Dashboard dashboard;
        Chart chartApSuat;
        Chart chartTheTich;
        DALMachine dalMachine;
        public MethodUpdateChartFormDashboard(Dashboard dashboard, Chart chartApSuat, Chart chartTheTich)
        {
            plc = new PLCBeckhOff();
            dalMachine = new DALMachine();
            timerUpdateGUILabel1 = new TimerUpdateGUI(3000, 60000, UpdateData);

            this.dashboard = dashboard;
            this.chartApSuat = chartApSuat;
            this.chartTheTich = chartTheTich;

        }

        public void StartUpdate()
        {
            if (plc.Connect() == true)
            {
                timerUpdateGUILabel1.StartTimer();
            }
        }
        public void StopUpdate()
        {
            timerUpdateGUILabel1.StopTimer();
            plc.Disconnect();
        }

        private async Task UpdateData()
        {
            if (plc.CheckState() == false)
            {
                StopUpdate();
                return;
            }

            // call data
            // Long running operation

            ChartSeries seriesApSuatTong = new ChartSeries("ÁP SUẤT TỔNG", ChartSeriesType.Line);
            ChartSeries seriesApSuatHe1 = new ChartSeries("ÁP SUẤT GIÀN 1", ChartSeriesType.Line);
            ChartSeries seriesApSuatHe2 = new ChartSeries("ÁP SUẤT GIÀN 2", ChartSeriesType.Line);
            ChartSeries seriesTheTich1 = new ChartSeries("THỂ TÍCH GIÀN 1", ChartSeriesType.Line);
            ChartSeries seriesTheTich2 = new ChartSeries("THỂ TÍCH GIÀN 2", ChartSeriesType.Line);

            seriesApSuatTong.Style.Border.Width = 3;
            seriesApSuatTong.Style.Interior = new BrushInfo(PatternStyle.None, Color.Red, Color.SeaGreen);

            seriesApSuatHe1.Style.Border.Width = 3;
            seriesApSuatHe1.Style.Interior = new BrushInfo(PatternStyle.None, Color.Red, Color.YellowGreen);

            seriesApSuatHe2.Style.Border.Width = 3;
            seriesApSuatHe2.Style.Interior = new BrushInfo(PatternStyle.None, Color.Red, Color.Purple);

            seriesTheTich1.Style.Border.Width = 3;
            seriesTheTich1.Style.Interior = new BrushInfo(PatternStyle.None, Color.Red, Color.DarkGoldenrod);

            seriesTheTich2.Style.Border.Width = 3;
            seriesTheTich2.Style.Interior = new BrushInfo(PatternStyle.None, Color.Red, Color.LightBlue);


            Dictionary<ChartSeries, List<DataDoThi>> dicApSuat = new Dictionary<ChartSeries, List<DataDoThi>>();
            Dictionary<ChartSeries, List<DataDoThi>> dicTheTich = new Dictionary<ChartSeries, List<DataDoThi>>();

            if (Common.ResultCurrent != null)
            {
                List<Machine> listData = dalMachine.GetAllMachinesByResultID(Common.ResultCurrent.ResultID);

                List<DataDoThi> dataDoThiASTong = new List<DataDoThi>();
                List<DataDoThi> dataDoThiAS1 = new List<DataDoThi>();
                List<DataDoThi> dataDoThiAS2 = new List<DataDoThi>();
                List<DataDoThi> dataDoThiTT1 = new List<DataDoThi>();
                List<DataDoThi> dataDoThiTT2 = new List<DataDoThi>();

                foreach (var item in listData)
                {
                    if (item.NameMachine == Common.GianNap1)
                    {
                        dataDoThiASTong.Add(new DataDoThi() { date = item.CreateAt, value = item.ApSuatTong ?? 0 });
                        dataDoThiAS1.Add(new DataDoThi() { date = item.CreateAt, value = item.ApSuat ?? 0 });
                        dataDoThiTT1.Add(new DataDoThi() { date = item.CreateAt, value = item.TheTich ?? 0 });
                    }
                    else
                    {
                        dataDoThiAS2.Add(new DataDoThi() { date = item.CreateAt, value = item.ApSuat ?? 0 });
                        dataDoThiTT2.Add(new DataDoThi() { date = item.CreateAt, value = item.TheTich ?? 0 });
                    }
                }

                dicApSuat.Add(seriesApSuatTong, dataDoThiASTong);
                dicApSuat.Add(seriesApSuatHe1, dataDoThiAS1);
                dicApSuat.Add(seriesApSuatHe2, dataDoThiAS2);

                dicTheTich.Add(seriesTheTich1, dataDoThiTT1);
                dicTheTich.Add(seriesTheTich2, dataDoThiTT2);


            }

            //method update gui
            UpdateGUI(dicApSuat, dicTheTich);



        }


        private void UpdateGUI(Dictionary<ChartSeries, List<DataDoThi>> dicApSuat, Dictionary<ChartSeries, List<DataDoThi>> dicTheTich)
        {

            //if (dashboard.IsHandleCreated && dashboard.InvokeRequired)
            //{
            //    dashboard.BeginInvoke(new Action<Dictionary<ChartSeries, List<DataDoThi>>, Dictionary<ChartSeries, List<DataDoThi>>>(UpdateGUI), dicApSuat, dicTheTich);
            //    return;
            //}
            //chartApSuat.UpdateChart(dicApSuat);
            //chartTheTich.UpdateChart(dicTheTich);

            //update gui
            if (dashboard.IsHandleCreated && dashboard.InvokeRequired)
            {
                dashboard.BeginInvoke(() =>
                {
                    chartApSuat.UpdateChart(dicApSuat);
                    chartTheTich.UpdateChart(dicTheTich);
                });
            }



        }


        //update theo  cache

        //MemoryCache cache = new MemoryCache(new MemoryCacheOptions());

        //private void UpdateGUI(Dictionary<ChartSeries, List<DataDoThi>> dicApSuat, Dictionary<ChartSeries, List<DataDoThi>> dicTheTich)
        //{
        //    // Check cache for previous data
        //    Dictionary<ChartSeries, List<DataDoThi>>? cachedApSuat = cache.Get("dicApSuat") as Dictionary<ChartSeries, List<DataDoThi>>;
        //    Dictionary<ChartSeries, List<DataDoThi>>? cachedTheTich = cache.Get("dicTheTich") as Dictionary<ChartSeries, List<DataDoThi>>;


        //    bool apSuatChanged = cachedApSuat == null || !dicApSuat.SequenceEqual(cachedApSuat);
        //    bool theTichChanged = cachedTheTich == null || !dicTheTich.SequenceEqual(cachedTheTich);

        //    if (!apSuatChanged && !theTichChanged)
        //    {
        //        return;
        //    }

        //    // Save new data to cache
        //    cache.Set("dicApSuat", dicApSuat);
        //    cache.Set("dicTheTich", dicTheTich);

        //    // Update gui
        //    if (dashboard.IsHandleCreated && dashboard.InvokeRequired)
        //    {
        //        dashboard.BeginInvoke(() =>
        //        {
        //            if (apSuatChanged)
        //            {
        //                chartApSuat.UpdateChart(dicApSuat);
        //            }
        //            if (theTichChanged)
        //            {
        //                chartTheTich.UpdateChart(dicTheTich);
        //            }
        //        });
        //    }
        //}



    }
}
