using ManagementSoftware.GUI.Dashboard_Management;
using ManagementSoftware.GUI.Section;
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
        SettingDashboard settingDashboard;

        Chart chartApSuat;
        Chart chartTheTich;

        PLCBeckhOff plc = new PLCBeckhOff();

        MethodUpdateDataFormDashboard methodUpdateDataFormDashboard;
        MethodUpdateChartFormDashboard methodUpdateChartFormDashboard;
        public Dashboard()
        {
            InitializeComponent();
            chartApSuat = new Chart("BIỂU ĐỒ ÁP SUẤT");
            chartTheTich = new Chart("BIỂU ĐỒ THỂ TÍCH");

            methodUpdateDataFormDashboard = new MethodUpdateDataFormDashboard(this, label1ApSuatHeNap1, labelApSuatHeNap2, labelTheTichHeNap1, labelTheTichHeNap2, labelApSuatTong, labelSanSangNapHe1, labelSanSangNapHe2, labelDangNapHe1, labelDangNapHe2, labelDungNapHe1, labelDungNapHe2, listBoxError, labelNguoiVanHanh, labelTimeStart, labelSoLuongNapHe1, SoLuongNapHe2, label1LoaiKhi);
            methodUpdateChartFormDashboard = new MethodUpdateChartFormDashboard(this, chartApSuat, chartTheTich);

            settingDashboard = new SettingDashboard(plc);
        }

        private void DashboardRepair_Load(object sender, EventArgs e)
        {
            plc.Connect();

            MethodCommonGUI commonGUI = new MethodCommonGUI();

            commonGUI.ShowFormOnPanel(panelMainThongSoCaiDat, settingDashboard);

            commonGUI.ShowFormOnPanel(panelChartApSuat, chartApSuat);

            commonGUI.ShowFormOnPanel(panelChartTheTich, chartTheTich);



            methodUpdateDataFormDashboard.StartUpdate();
            methodUpdateChartFormDashboard.StartUpdate();
        }

        private void DashboardRepair_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (IsHandleCreated && InvokeRequired)
            {
                BeginInvoke(new Action(() =>
                {
                    settingDashboard.Close();
                    chartApSuat.Close();
                    chartTheTich.Close();
                }));

            }
            else
            {
                settingDashboard.Close();
                chartApSuat.Close();
                chartTheTich.Close();
            }
            methodUpdateDataFormDashboard.StopUpdate();
            methodUpdateChartFormDashboard.StopUpdate();
            plc.Disconnect();
        }

        private void buttonShowBangLoi_Click(object sender, EventArgs e)
        {
            ErrorDashboard errorDashboard = new ErrorDashboard();
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
    }
}
