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

        SettingDashboard settingDashboard;

        Chart chartApSuat;
        Chart chartTheTich;

        PLCBeckhOff plc = new PLCBeckhOff();

        MethodUpdateDataFormDashboard methodUpdateDataFormDashboard;
        MethodUpdateChartFormDashboard methodUpdateChartFormDashboard;
        public Dashboard()
        {
            InitializeComponent();

            methodUpdateDataFormDashboard = new MethodUpdateDataFormDashboard(this, label1ApSuatHeNap1, labelApSuatHeNap2, labelTheTichHeNap1, labelTheTichHeNap2, labelApSuatTong, labelSanSangNapHe1, labelSanSangNapHe2, labelDangNapHe1, labelDangNapHe2, labelXaKhiHe1, labelXaKhiHe2, labelDungNapHe1, labelDungNapHe2);
            

            settingDashboard = new SettingDashboard(plc);

            chartApSuat = new Chart("BIỂU ĐỒ ÁP SUẤT");
            chartTheTich = new Chart("BIỂU ĐỒ THỂ TÍCH");
        }







        private void Dashboard_Load(object sender, EventArgs e)
        {
            plc.Connect();

            MethodCommonGUI commonGUI = new MethodCommonGUI();

            commonGUI.ShowFormOnPanel(panelMainThongSoCaiDat, settingDashboard);

            commonGUI.ShowFormOnPanel(panelChartApSuat, chartApSuat);

            commonGUI.ShowFormOnPanel(panelChartTheTich, chartTheTich);



            methodUpdateDataFormDashboard.StartUpdate();

        }

        private void Dashboard_FormClosing(object sender, FormClosingEventArgs e)
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

            plc.Disconnect();
            methodUpdateDataFormDashboard.StopUpdate();
        }

        private void button57_Click_1(object sender, EventArgs e)
        {
            if (Common.ResultCurrent != null)
            {
                ErrorDashboard errorDashboard = new ErrorDashboard(Common.ResultCurrent.ResultID);
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
























    }
}
