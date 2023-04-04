using ManagementSoftware.GUI.Dashboard_Management;
using ManagementSoftware.GUI.Section;
using Syncfusion.Drawing;
using Syncfusion.Windows.Forms.Chart;
using Syncfusion.XlsIO.Implementation;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
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

        System.Threading.Timer? timer1 = null;
        int TIME_INTERVAL_IN_MILLISECONDS = 100;

        PLCBeckhOff plc = new PLCBeckhOff();





        DataAlwaysUpdate dataAlwaysUpdateBefore = new DataAlwaysUpdate();
        private async void Callback1(Object state)
        {
            Stopwatch watch = new Stopwatch();

            watch.Start();



            // call data
            // Long running operation

            //dữ liệu hiển thị
            float? apSuatHe1 = 0;
            float? apSuatHe2 = 0;
            float? theTichHe1 = 0;
            float? theTichHe2 = 0;
            float? apSuatTong = 0;
            int? soLuongNapHe1 = 0;
            int? soLuongNapHe2 = 0;

            apSuatHe1 = await Task.Run(() => plc.ReadAVariableNumber<float>(AddressPLC.DATA_PC_GT_AS_ST_H1));
            apSuatHe2 = await Task.Run(() => plc.ReadAVariableNumber<float>(AddressPLC.DATA_PC_GT_AS_ST_H2));
            theTichHe1 = await Task.Run(() => plc.ReadAVariableNumber<float>(AddressPLC.DATA_PC_GT_V_ST_H1));
            theTichHe2 = await Task.Run(() => plc.ReadAVariableNumber<float>(AddressPLC.DATA_PC_GT_V_ST_H2));
            apSuatTong = await Task.Run(() => plc.ReadAVariableNumber<float>(AddressPLC.DATA_PC_GT_AS_Tong));

            soLuongNapHe1 = await Task.Run(() => plc.ReadAVariableNumber<int>(AddressPLC.DATA_SETUP_SL_Binh_Nap_H1));
            soLuongNapHe2 = await Task.Run(() => plc.ReadAVariableNumber<int>(AddressPLC.DATA_SETUP_SL_Binh_Nap_H2));



            //trạng thái quy trinh
            bool? sanSangNapHe1 = false;
            bool? sanSangNapHe2 = false;
            bool? ketThucNapHe1 = false;
            bool? ketThucNapHe2 = false;
            bool? xaKhiHe1 = false;
            bool? xaKhiHe2 = false;
            bool? batDauNapHe1 = false;
            bool? batDauNapHe2 = false;

            sanSangNapHe1 = await Task.Run(() => plc.ReadAVariableNumber<bool>(AddressPLC.DATA_PC_D_Run_1));
            sanSangNapHe2 = await Task.Run(() => plc.ReadAVariableNumber<bool>(AddressPLC.DATA_PC_D_Run_2));
            ketThucNapHe1 = await Task.Run(() => plc.ReadAVariableNumber<bool>(AddressPLC.DATA_PC_KetThuc_QT_NAP_H1));
            ketThucNapHe2 = await Task.Run(() => plc.ReadAVariableNumber<bool>(AddressPLC.DATA_PC_KetThuc_QT_NAP_H2));
            xaKhiHe1 = await Task.Run(() => plc.ReadAVariableNumber<bool>(AddressPLC.DATA_PC_ST_Xa_Khi_H1));
            xaKhiHe2 = await Task.Run(() => plc.ReadAVariableNumber<bool>(AddressPLC.DATA_PC_ST_Xa_Khi_H2));
            batDauNapHe1 = await Task.Run(() => plc.ReadAVariableNumber<bool>(AddressPLC.DATA_PC_ST_Run_Nap_H1));
            batDauNapHe2 = await Task.Run(() => plc.ReadAVariableNumber<bool>(AddressPLC.DATA_PC_ST_Run_Nap_H2));


            DataAlwaysUpdate data = new DataAlwaysUpdate();


            //method update gui
            UpdateData(data);

            if (timer1 != null)
            {
                timer1.Change(Math.Max(0, TIME_INTERVAL_IN_MILLISECONDS - watch.ElapsedMilliseconds), Timeout.Infinite);
            }
        }


        private void UpdateData(DataAlwaysUpdate dataAlwaysUpdate)
        {

            if (IsHandleCreated && InvokeRequired)
            {
                //BeginInvoke(new Action<>(UpdateDataAnalog);
                return;
            }


            //update gui

        }



        public Dashboard()
        {
            InitializeComponent();

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


            plc.Connect();



            UpdateChartApSuat();
            UpdateChartTheTich();


        }

        private void Dashboard_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (timer1 != null)
            {
                this.timer1.Change(Timeout.Infinite, Timeout.Infinite);
                timer1.Dispose();
                timer1 = null;
            }


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
            plc.Disconnect();
        }

        private void button57_Click_1(object sender, EventArgs e)
        {
            if (Common.ResultCurrent != null)
            {
                errorDashboard = new ErrorDashboard(Common.ResultCurrent.ResultID);
                errorDashboard.ShowDialog();
            }
            else
            {
                MessageBox.Show("Hiện tại không trong chu trình nạp.", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }

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































        //method 
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
    }
}
