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

        PLCBeckhOff plc;
        public SettingDashboard(PLCBeckhOff plc)
        {
            InitializeComponent();
            this.plc = plc;
        }

        private void SettingDashboard_Load(object sender, EventArgs e)
        {
            LoadData();
        }


        public async Task LoadData()
        {
            float? theTichCanNap = 0;
            float? thetichTieuChuan = 0;
            float? apSuatTieuChuan = 0;
            float? heSoTieuChuan = 0;
            DateTime? thoiGianTrichMau = new DateTime(0);
            int? soLuongBinhCanNapCHoHe1 = 0;
            int? soLuongBinhCanNapCHoHe2 = 0;


            theTichCanNap = await Task.Run(() => plc.ReadAVariableNumber<float>(AddressPLC.DATA_SETUP_V_Nap));
            thetichTieuChuan = await Task.Run(() => plc.ReadAVariableNumber<float>(AddressPLC.DATA_SETUP_V_Tieu_Chuan));
            apSuatTieuChuan = await Task.Run(() => plc.ReadAVariableNumber<float>(AddressPLC.DATA_SETUP_P_Tieu_Chuan));
            heSoTieuChuan = await Task.Run(() => plc.ReadAVariableNumber<float>(AddressPLC.DATA_SETUP_DATA_HS_Nhiet_do));
            thoiGianTrichMau = await Task.Run(() => plc.ReadAVariableNumber_ReadAny<DateTime>(AddressPLC.DATA_SETUP_Time_trich_mau_V));
            soLuongBinhCanNapCHoHe1 = await Task.Run(() => plc.ReadAVariableNumber<int>(AddressPLC.DATA_SETUP_SL_Binh_Nap_H1));
            soLuongBinhCanNapCHoHe2 = await Task.Run(() => plc.ReadAVariableNumber<int>(AddressPLC.DATA_SETUP_SL_Binh_Nap_H2));


            //if (IsHandleCreated && InvokeRequired)
            //{
            //    BeginInvoke(new Action(() =>
            //    {
            labelTheTichCanNap.Text = theTichCanNap != null ? String.Format("{0:0.00}", theTichCanNap) : Common.ERR;
            labelTheTichTieuChuan.Text = thetichTieuChuan != null ? String.Format("{0:0.00}", thetichTieuChuan) : Common.ERR;
            labelApSuatTieuChuan.Text = apSuatTieuChuan != null ? String.Format("{0:0.00}", apSuatTieuChuan) : Common.ERR;
            label1HeSoTieuChuan.Text = heSoTieuChuan != null ? String.Format("{0:0.00}", heSoTieuChuan) : Common.ERR;
            labelThoiGianTrichMau.Text = thoiGianTrichMau != null ? thoiGianTrichMau?.ToString("HH:mm:ss") : Common.ERR;
            labelSoLuongBinhHe1.Text = soLuongBinhCanNapCHoHe1 != null ? soLuongBinhCanNapCHoHe1.ToString() : Common.ERR;
            labelSoLuongBinhHe2.Text = soLuongBinhCanNapCHoHe2 != null ? soLuongBinhCanNapCHoHe2.ToString() : Common.ERR;
            //    }));
            //}

        }

    }
}
