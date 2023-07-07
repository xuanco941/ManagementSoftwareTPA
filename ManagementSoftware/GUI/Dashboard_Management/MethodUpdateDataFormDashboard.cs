using LW_PhanMemBaoGia.MyControls;
using Microsoft.Extensions.Caching.Memory;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ManagementSoftware.GUI.Dashboard_Management
{
    public class MethodUpdateDataFormDashboard
    {
        TimerUpdateGUI timerUpdateGUILabel1;
        PLCBeckhOff plc;
        Dashboard dashboard;

        ButtonCustom label1ApSuatHeNap1;
        ButtonCustom labelApSuatHeNap2;
        ButtonCustom labelTheTichHeNap1;
        ButtonCustom labelTheTichHeNap2;
        ButtonCustom labelApSuatTong;


        Label labelSanSangNapHe1;
        Label labelSanSangNapHe2;
        Label labelDangNapHe1;
        Label labelDangNapHe2;
        Label labelDungNapHe1;
        Label labelDungNapHe2;


        Label labelNguoiVanHanh;
        Label labelTimeStart;
        Label labelTimeStart2;
        Label labelSoLuongNapGian1;
        Label labelSoLuongNapGian2;
        Label labelLoaiKhi;



        ListBox listBoxError;

        public MethodUpdateDataFormDashboard(Dashboard dashboard, ButtonCustom label1ApSuatHeNap1, ButtonCustom labelApSuatHeNap2, ButtonCustom labelTheTichHeNap1, ButtonCustom labelTheTichHeNap2, ButtonCustom labelApSuatTong, Label labelSanSangNapHe1, Label labelSanSangNapHe2, Label labelDangNapHe1, Label labelDangNapHe2, Label labelDungNapHe1, Label labelDungNapHe2, ListBox listBoxError, Label labelNguoiVanHanh, Label labelTimeStart, Label labelSoLuongNapGian1, Label labelSoLuongNapGian2, Label labelLoaiKhi)
        {
            plc = new PLCBeckhOff();
            cache = new MemoryCache(new MemoryCacheOptions());
            timerUpdateGUILabel1 = new TimerUpdateGUI(500, 900, UpdateData);

            this.dashboard = dashboard;
            this.label1ApSuatHeNap1 = label1ApSuatHeNap1;
            this.labelApSuatHeNap2 = labelApSuatHeNap2;
            this.labelTheTichHeNap1 = labelTheTichHeNap1;
            this.labelTheTichHeNap2 = labelTheTichHeNap2;
            this.labelApSuatTong = labelApSuatTong;
            this.labelSanSangNapHe1 = labelSanSangNapHe1;
            this.labelSanSangNapHe2 = labelSanSangNapHe2;
            this.labelDangNapHe1 = labelDangNapHe1;
            this.labelDangNapHe2 = labelDangNapHe2;

            this.labelDungNapHe1 = labelDungNapHe1;
            this.labelDungNapHe2 = labelDungNapHe2;


            this.labelNguoiVanHanh = labelNguoiVanHanh;
            this.labelTimeStart = labelTimeStart;
            this.labelSoLuongNapGian1 = labelSoLuongNapGian1;
            this.labelSoLuongNapGian2 = labelSoLuongNapGian2;
            this.labelLoaiKhi = labelLoaiKhi;



            this.listBoxError = listBoxError;
        }

        public void StartUpdate()
        {
            if (plc.Connect() == true)
            {
                timerUpdateGUILabel1.StartTimer(false);
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




            //dữ liệu hiển thị
            float? apSuatHe1 = 0;
            float? apSuatHe2 = 0;
            float? theTichHe1 = 0;
            float? theTichHe2 = 0;
            float? apSuatTong = 0;

            //trạng thái quy trinh
            bool? sanSangNapHe1 = false;
            bool? sanSangNapHe2 = false;
            //bool? ketThucNapHe1 = false;
            //bool? ketThucNapHe2 = false;

            //bool? batDauNapHe1 = false;
            //bool? batDauNapHe2 = false;

            int? pallet1 = -1;
            int? pallet2 = -1;


            bool? canhBaoLoiDongCoOHeHoaHoi = false;
            bool? canhBaoChuaMoHeHoaHoi = false;
            bool? loiQuaTrinhXaKhiHe1 = false;
            bool? loiQuaTrinhXaKhiHe2 = false;
            bool? loiQuaTrinhNapKhiHe1 = false;
            bool? loiQuaTrinhNapKhiHe2 = false;

            bool? Lockup_Temp_High = false;
            bool? Cavi_Temp_High = false;
            bool? Seal_Leak_Temp_Low = false;
            bool? Apter_Vapolization = false;
            bool? Discharge_PRS_High = false;

            bool? run_nap_h1 = false;
            bool? run_nap_h2 = false;

            run_nap_h1 = await Task.Run(() => plc.ReadAVariableNumber<bool>(AddressPLC.DATA_PC_Run_Nap_H1));
            run_nap_h2 = await Task.Run(() => plc.ReadAVariableNumber<bool>(AddressPLC.DATA_PC_Run_Nap_H2));



            apSuatHe1 = await Task.Run(() => plc.ReadAVariableNumber<float>(AddressPLC.DATA_PC_GT_AS_ST_H1));
            apSuatHe2 = await Task.Run(() => plc.ReadAVariableNumber<float>(AddressPLC.DATA_PC_GT_AS_ST_H2));
            theTichHe1 = await Task.Run(() => plc.ReadAVariableNumber<float>(AddressPLC.DATA_PC_GT_V_ST_H1));
            theTichHe2 = await Task.Run(() => plc.ReadAVariableNumber<float>(AddressPLC.DATA_PC_GT_V_ST_H2));
            apSuatTong = await Task.Run(() => plc.ReadAVariableNumber<float>(AddressPLC.DATA_PC_GT_AS_Tong));

            sanSangNapHe1 = await Task.Run(() => plc.ReadAVariableNumber<bool>(AddressPLC.DATA_PC_Enable_H1));
            sanSangNapHe2 = await Task.Run(() => plc.ReadAVariableNumber<bool>(AddressPLC.DATA_PC_Enable_H2));

            //ketThucNapHe1 = await Task.Run(() => plc.ReadAVariableNumber<bool>(AddressPLC.DATA_PC_KetThuc_QT_NAP_H1));
            //ketThucNapHe2 = await Task.Run(() => plc.ReadAVariableNumber<bool>(AddressPLC.DATA_PC_KetThuc_QT_NAP_H2));
            //xaKhiHe1 = await Task.Run(() => plc.ReadAVariableNumber<bool>(AddressPLC.DATA_PC_ST_Xa_Khi_H1));
            //xaKhiHe2 = await Task.Run(() => plc.ReadAVariableNumber<bool>(AddressPLC.DATA_PC_ST_Xa_Khi_H2));
            //batDauNapHe1 = await Task.Run(() => plc.ReadAVariableNumber<bool>(AddressPLC.DATA_PC_ST_Run_Nap_H1));
            //batDauNapHe2 = await Task.Run(() => plc.ReadAVariableNumber<bool>(AddressPLC.DATA_PC_ST_Run_Nap_H2));

            pallet1 = await Task.Run(() => plc.ReadAVariableNumber<int>(AddressPLC.DATA_PC_PALLET1));
            pallet2 = await Task.Run(() => plc.ReadAVariableNumber<int>(AddressPLC.DATA_PC_PALLET2));




            canhBaoLoiDongCoOHeHoaHoi = await Task.Run(() => plc.ReadAVariableNumber<bool>(AddressPLC.DATA_PC_VFP_Trip));
            canhBaoChuaMoHeHoaHoi = await Task.Run(() => plc.ReadAVariableNumber<bool>(AddressPLC.DATA_PC_OFF_Hoa_Hoi));
            loiQuaTrinhXaKhiHe1 = await Task.Run(() => plc.ReadAVariableNumber<bool>(AddressPLC.DATA_PC_Loi_TT_XA_KHI_H1));
            loiQuaTrinhXaKhiHe2 = await Task.Run(() => plc.ReadAVariableNumber<bool>(AddressPLC.DATA_PC_Loi_TT_XA_KHI_H2));
            loiQuaTrinhNapKhiHe1 = await Task.Run(() => plc.ReadAVariableNumber<bool>(AddressPLC.DATA_PC_Loi_TT_NAP_KHI_H1));
            loiQuaTrinhNapKhiHe2 = await Task.Run(() => plc.ReadAVariableNumber<bool>(AddressPLC.DATA_PC_Loi_TT_NAP_KHI_H2));

            Lockup_Temp_High = await Task.Run(() => plc.ReadAVariableNumber<bool>(AddressPLC.DATA_PC_Lockup_Temp_High));
            Cavi_Temp_High = await Task.Run(() => plc.ReadAVariableNumber<bool>(AddressPLC.DATA_PC_Cavi_Temp_High));
            Seal_Leak_Temp_Low = await Task.Run(() => plc.ReadAVariableNumber<bool>(AddressPLC.DATA_PC_Seal_Leak_Temp_Low));
            Apter_Vapolization = await Task.Run(() => plc.ReadAVariableNumber<bool>(AddressPLC.DATA_PC_Apter_Vapolization));
            Discharge_PRS_High = await Task.Run(() => plc.ReadAVariableNumber<bool>(AddressPLC.DATA_PC_Discharge_PRS_High));





            DataAlwaysUpdate data = new DataAlwaysUpdate();
            data.apSuatHe1 = apSuatHe1;
            data.apSuatHe2 = apSuatHe2;
            data.apSuatTong = apSuatTong;
            data.theTichHe1 = theTichHe1;
            data.theTichHe2 = theTichHe2;
            data.sanSangNapHe1 = sanSangNapHe1;
            data.sanSangNapHe2 = sanSangNapHe2;


            //error
            data.canhBaoLoiDongCoOHeHoaHoi = canhBaoLoiDongCoOHeHoaHoi;
            data.canhBaoChuaMoHeHoaHoi = canhBaoChuaMoHeHoaHoi;
            data.loiQuaTrinhXaKhiHe1 = loiQuaTrinhXaKhiHe1;
            data.loiQuaTrinhXaKhiHe2 = loiQuaTrinhXaKhiHe2;
            data.loiQuaTrinhNapKhiHe1 = loiQuaTrinhNapKhiHe1;
            data.loiQuaTrinhNapKhiHe2 = loiQuaTrinhNapKhiHe2;

            data.Lockup_Temp_High = Lockup_Temp_High;
            data.Cavi_Temp_High = Cavi_Temp_High;
            data.Seal_Leak_Temp_Low = Seal_Leak_Temp_Low;
            data.Apter_Vapolization = Apter_Vapolization;
            data.Discharge_PRS_High = Discharge_PRS_High;


            data.pallet1 = pallet1;
            data.pallet2 = pallet2;


            //method update gui
            UpdateGUI(data,run_nap_h1,run_nap_h2);

        }

        IMemoryCache cache;

        List<string> listDataErrbefore = new List<string>();
        private void UpdateGUI(DataAlwaysUpdate data,bool? run_nap_h1, bool? run_nap_h2)
        {
            //update gui

            if (dashboard.IsHandleCreated && dashboard.InvokeRequired)
            {
                dashboard.BeginInvoke(() =>
                {
                    if (run_nap_h1 == null || run_nap_h1 == false)
                    {
                        labelTimeStart.Text = "Thời gian bắt đầu hệ 1 : Chưa có";
                    }
                    else
                    {
                        if (cache.Get<bool>("run_nap_h1") == false && run_nap_h1 == true)
                        {
                            DateTime now = DateTime.Now;
                            labelTimeStart.Text = "Thời gian bắt đầu hệ 1 : " + now.ToString("HH:mm:ss dd/MM/yyyy");
                        }
                        cache.Set<bool?>("run_nap_h1", run_nap_h1);
                    }

                    if (run_nap_h2 == null || run_nap_h2 == false)
                    {
                        labelTimeStart2.Text = "Thời gian bắt đầu hệ 2 : Chưa có";
                    }
                    else
                    {
                        if (cache.Get<bool>("run_nap_h2") == false && run_nap_h2 == true)
                        {
                            DateTime now = DateTime.Now;
                            labelTimeStart2.Text = "Thời gian bắt đầu hệ 2 : " + now.ToString("HH:mm:ss dd/MM/yyyy");
                        }
                        cache.Set<bool?>("run_nap_h2", run_nap_h2);
                    }


                    //quy trình

                    labelSanSangNapHe1.BackColor = data.pallet1 != null && data.pallet1 == 0 && data.sanSangNapHe1 != null && data.sanSangNapHe1 == true ? Color.LimeGreen : Color.DimGray;
                    labelSanSangNapHe2.BackColor = data.pallet2 != null && data.pallet2 == 0 && data.sanSangNapHe2 != null && data.sanSangNapHe2 == true ? Color.LimeGreen : Color.DimGray;
                    labelDangNapHe1.BackColor = data.pallet1 != null && data.pallet1 == 1 ? Color.LimeGreen : Color.DimGray;
                    labelDangNapHe2.BackColor = data.pallet2 != null && data.pallet2 == 1 ? Color.LimeGreen : Color.DimGray;
                    //kết thúc
                    labelDungNapHe1.BackColor = data.pallet1 != null && data.pallet1 == 2 ? Color.LimeGreen : Color.DimGray;
                    labelDungNapHe2.BackColor = data.pallet2 != null && data.pallet2 == 2 ? Color.LimeGreen : Color.DimGray;








                    //err
                    List<string> strsErr = new List<string>();
                    foreach (var item in this.listBoxError.Items)
                    {
                        if (item != null)
                        {
                            strsErr.Add((string)item);
                        }
                    }

                    if (strsErr.SequenceEqual(listDataErrbefore) == false)
                    {
                        listDataErrbefore = new List<string>();

                        this.listBoxError.Items.Clear();

                        if (data.canhBaoLoiDongCoOHeHoaHoi == true)
                        {
                            this.listBoxError.Items.Add("- Cảnh báo lỗi động cơ ở hệ hóa hơi.");
                            listDataErrbefore.Add("- Cảnh báo lỗi động cơ ở hệ hóa hơi.");
                        }
                        if (data.canhBaoChuaMoHeHoaHoi == true)
                        {
                            this.listBoxError.Items.Add("- Cảnh báo chưa mở hệ hóa hơi.");
                            listDataErrbefore.Add("- Cảnh báo chưa mở hệ hóa hơi.");
                        }
                        if (data.loiQuaTrinhXaKhiHe1 == true)
                        {
                            this.listBoxError.Items.Add("- Lỗi quá trình xả khí giàn 1.");
                            listDataErrbefore.Add("- Lỗi quá trình xả khí giàn 1.");
                        }
                        if (data.loiQuaTrinhXaKhiHe2 == true)
                        {
                            this.listBoxError.Items.Add("- Lỗi quá trình xả khí giàn 2.");
                            listDataErrbefore.Add("- Lỗi quá trình xả khí giàn 2.");
                        }
                        if (data.loiQuaTrinhNapKhiHe1 == true)
                        {
                            this.listBoxError.Items.Add("- Lỗi quá trình nạp khí giàn 1.");
                            listDataErrbefore.Add("- Lỗi quá trình nạp khí giàn 1.");
                        }
                        if (data.loiQuaTrinhNapKhiHe2 == true)
                        {
                            this.listBoxError.Items.Add("- Lỗi quá trình nạp khí giàn 2.");
                            listDataErrbefore.Add("- Lỗi quá trình nạp khí giàn 2.");
                        }
                        //
                        if (data.Lockup_Temp_High == true)
                        {
                            this.listBoxError.Items.Add("- Lockup Temp High.");
                            listDataErrbefore.Add("- Lockup Temp High.");
                        }
                        if (data.Cavi_Temp_High == true)
                        {
                            this.listBoxError.Items.Add("- Cavi Temp High.");
                            listDataErrbefore.Add("- Cavi Temp High.");
                        }
                        if (data.Seal_Leak_Temp_Low == true)
                        {
                            this.listBoxError.Items.Add("- Seal Leak Temp Low.");
                            listDataErrbefore.Add("- Seal Leak Temp Low.");
                        }
                        if (data.Apter_Vapolization == true)
                        {
                            this.listBoxError.Items.Add("- Apter Vapolization.");
                            listDataErrbefore.Add("- Apter Vapolization.");
                        }
                        if (data.Discharge_PRS_High == true)
                        {
                            this.listBoxError.Items.Add("- Discharge PRS High.");
                            listDataErrbefore.Add("- Discharge PRS High.");
                        }
                    }









                    if (Common.ResultCurrent != null)
                    {
                        //value
                        label1ApSuatHeNap1.Text = data.apSuatHe1 != null ? string.Format("{0:0.00}", data.apSuatHe1) : Common.ERR;
                        labelApSuatHeNap2.Text = data.apSuatHe2 != null ? string.Format("{0:0.00}", data.apSuatHe2) : Common.ERR;
                        labelApSuatTong.Text = data.apSuatTong != null ? string.Format("{0:0.00}", data.apSuatTong) : Common.ERR;
                        labelTheTichHeNap1.Text = data.theTichHe1 != null ? string.Format("{0:0.00}", data.theTichHe1) : Common.ERR;
                        labelTheTichHeNap2.Text = data.theTichHe2 != null ? string.Format("{0:0.00}", data.theTichHe2) : Common.ERR;



                        //thong tin

                        labelNguoiVanHanh.Text = "Người vận hành : " + Common.ResultCurrent.Username;
                        labelSoLuongNapGian1.Text = "Số lượng nạp giàn 1 : " + Common.ResultCurrent.SoLuongBinhCanNapHe1.ToString();
                        labelSoLuongNapGian2.Text = "Số lượng nạp giàn 2 : " + Common.ResultCurrent.SoLuongBinhCanNapHe2.ToString();
                        labelLoaiKhi.Text = "Loại khí : " + Common.ResultCurrent.LoaiKhi;
                    }
                    else
                    {
                        //value
                        label1ApSuatHeNap1.Text = "0.00";
                        labelApSuatHeNap2.Text = "0.00";
                        labelApSuatTong.Text = "0.00";
                        labelTheTichHeNap1.Text = "0.00";
                        labelTheTichHeNap2.Text = "0.00";

                        labelNguoiVanHanh.Text = "Người vận hành : Chưa có";
                        labelSoLuongNapGian1.Text = "Số lượng nạp giàn 1 : Chưa có";
                        labelSoLuongNapGian2.Text = "Số lượng nạp giàn 2 : Chưa có";
                        labelLoaiKhi.Text = "Loại khí : Chưa có";

                    }

                });
            }




        }
    }
}
