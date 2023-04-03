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

namespace ManagementSoftware.GUI
{
    public partial class SettingDashboard : Form
    {

        PLCBeckhOff plc = new PLCBeckhOff();
        public SettingDashboard()
        {
            InitializeComponent();
        }

        private void SettingDashboard_Load(object sender, EventArgs e)
        {
            plc.Connect();
            LoadData();
        }


        public async void LoadData()
        {
            float theTichCanNap = 0;
            float thetichTieuChuan = 0;
            float apSuatTieuChuan = 0;
            float heSoTieuChuan = 0;
            TimeSpan thoiGianTrichMau = new TimeSpan(0);
            int soLuongBinhCanNapCHoHe1 = 0;
            int soLuongBinhCanNapCHoHe2 = 0;

            try
            {
                theTichCanNap = await Task.Run(() => plc.ReadAVariableNumber<float>("DATA_SETUP.V_Nap"));
                thetichTieuChuan = await Task.Run(() => plc.ReadAVariableNumber<float>("DATA_SETUP.V_Tieu_Chuan"));
                apSuatTieuChuan = await Task.Run(() => plc.ReadAVariableNumber<float>("DATA_SETUP.P_Tieu_Chuan"));
                heSoTieuChuan = await Task.Run(() => plc.ReadAVariableNumber<float>("DATA_SETUP.DATA_SetupHS_Nhiet_do"));
                thoiGianTrichMau = await Task.Run(() => plc.ReadAVariableNumber_ReadAny<TimeSpan>("DATA_SETUP.Time_trich_mau"));
                soLuongBinhCanNapCHoHe1 = await Task.Run(() => plc.ReadAVariableNumber<int>("DATA_SETUP.SL_Binh_Nap_H1"));
                soLuongBinhCanNapCHoHe2 = await Task.Run(() => plc.ReadAVariableNumber<int>("DATA_SETUP.SL_Binh_Nap_H2"));

            }
            catch
            {
                MessageBox.Show("Không thể đọc được dữ liệu.", "Lỗi kết nối", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }



            if (IsHandleCreated && InvokeRequired)
            {
                BeginInvoke(new Action(() =>
                {
                    labelTheTichCanNap.Text = String.Format("{0:0.00}", theTichCanNap);
                    labelTheTichTieuChuan.Text = String.Format("{0:0.00}", thetichTieuChuan);
                    labelApSuatTieuChuan.Text = String.Format("{0:0.00}", apSuatTieuChuan);
                    label1HeSoTieuChuan.Text = String.Format("{0:0.00}", heSoTieuChuan);
                    labelThoiGianTrichMau.Text = thoiGianTrichMau.TotalSeconds.ToString();
                    labelSoLuongBinhHe1.Text = soLuongBinhCanNapCHoHe1.ToString();
                    labelSoLuongBinhHe2.Text = soLuongBinhCanNapCHoHe2.ToString();
                }));
                return;
            }

        }

        private void SettingDashboard_FormClosing(object sender, FormClosingEventArgs e)
        {
            try
            {
                plc.Disconnect();
            }
            catch
            {

            }
            if (IsHandleCreated && InvokeRequired)
            {
                this.BeginInvoke(new Action(() =>
                {
                    this.Close();
                }));
            }
            else
            {
                this.Close();
            }
        }
    }
}
