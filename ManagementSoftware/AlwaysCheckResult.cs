using ManagementSoftware.DAL;
using ManagementSoftware.GUI;
using ManagementSoftware.Models;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ManagementSoftware
{
    public class AlwaysCheckResult
    {
        public System.Threading.Timer? timer = null;
        public PLCBeckhOff plc = new PLCBeckhOff();
        private DALResult dalResult = new DALResult();
        private DALResultWarning dalResultWarning = new DALResultWarning();



        public void StartTimer()
        {
            if (timer == null)
            {
                timer = new System.Threading.Timer(Callback, null, 1000, Timeout.Infinite);
            }
        }

        public void StopTimer()
        {
            if (timer != null)
            {
                this.timer.Change(Timeout.Infinite, Timeout.Infinite);
                timer.Dispose();
                timer = null;
            }
        }

        public void ConnectPLC()
        {
            plc.Connect();
        }
        public void DisconnectPLC()
        {
            plc.Disconnect();
        }

        bool isPalletRunning = false;
        private async void Callback(Object state)
        {
            Stopwatch watch = new Stopwatch();

            watch.Start();

            // update data
            // Long running operation
            //trạng thái quy trinh

            if (plc.CheckState())
            {

                int? pallet1 = await Task.Run(() => plc.ReadAVariableNumber<int>(AddressPLC.DATA_PC_PALLET1));
                int? pallet2 = await Task.Run(() => plc.ReadAVariableNumber<int>(AddressPLC.DATA_PC_PALLET2));


                if (((pallet1 != null && pallet1 == 1) || (pallet2 != null && pallet2 == 1)))
                {
                    isPalletRunning = true;
                }
                else
                {
                    isPalletRunning = false;
                }

            }
            else
            {
                isPalletRunning = false;
            }








            await Run();













            if (timer != null)
            {
                timer.Change(Math.Max(0, 1000 - watch.ElapsedMilliseconds), Timeout.Infinite);
            }
        }



        bool? canhBaoLoiDongCoOHeHoaHoi_Before = false;
        bool? canhBaoChuaMoHeHoaHoi_Before = false;
        bool? loiQuaTrinhXaKhiHe1_Before = false;
        bool? loiQuaTrinhXaKhiHe2_Before = false;
        bool? loiQuaTrinhNapKhiHe1_Before = false;
        bool? loiQuaTrinhNapKhiHe2_Before = false;
        bool? Lockup_Temp_High_Before = false;
        bool? Cavi_Temp_High_Before = false;
        bool? Seal_Leak_Temp_Low_Before = false;
        bool? Apter_Vapolization_Before = false;
        bool? Discharge_PRS_High_Before = false;

        async Task Run()
        {

            if (isPalletRunning == false && Common.ResultCurrent == null)
            {
                //nothing
                return;
            }

            else if (isPalletRunning == false && Common.ResultCurrent != null)
            {
                Common.ResultCurrent.Status = true;
                Common.ResultCurrent.TimeEnd = DateTime.Now;
                dalResult.Update(Common.ResultCurrent);
                Common.ResultCurrent = null;
            }
            else if (isPalletRunning == true && Common.ResultCurrent != null)
            {
                // err
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

                if (canhBaoLoiDongCoOHeHoaHoi != null && canhBaoLoiDongCoOHeHoaHoi == true && (canhBaoLoiDongCoOHeHoaHoi_Before == null || canhBaoLoiDongCoOHeHoaHoi_Before == false))
                {
                    dalResultWarning.Add(new ResultWarning() { ResultID = Common.ResultCurrent.ResultID, Title = "Cảnh báo", Description = "Cảnh báo lỗi động cơ ở hệ hóa hơi." });
                }
                if (canhBaoChuaMoHeHoaHoi != null && canhBaoChuaMoHeHoaHoi == true && (canhBaoChuaMoHeHoaHoi_Before == null || canhBaoChuaMoHeHoaHoi_Before == false))
                {
                    dalResultWarning.Add(new ResultWarning() { ResultID = Common.ResultCurrent.ResultID, Title = "Cảnh báo", Description = "Cảnh báo chưa mở hệ hóa hơi." });
                }
                if (loiQuaTrinhXaKhiHe1 != null && loiQuaTrinhXaKhiHe1 == true && (loiQuaTrinhXaKhiHe1_Before == null || loiQuaTrinhXaKhiHe1_Before == false))
                {
                    dalResultWarning.Add(new ResultWarning() { ResultID = Common.ResultCurrent.ResultID, Title = "Lỗi", Description = "Lỗi quá trình xả khí giàn 1." });
                }
                if (loiQuaTrinhXaKhiHe2 != null && loiQuaTrinhXaKhiHe2 == true && (loiQuaTrinhXaKhiHe2_Before == null || loiQuaTrinhXaKhiHe2_Before == false))
                {
                    dalResultWarning.Add(new ResultWarning() { ResultID = Common.ResultCurrent.ResultID, Title = "Lỗi", Description = "Lỗi quá trình xả khí giàn 2." });
                }
                if (loiQuaTrinhNapKhiHe1 != null && loiQuaTrinhNapKhiHe1 == true && (loiQuaTrinhNapKhiHe1_Before == null || loiQuaTrinhNapKhiHe1_Before == false))
                {
                    dalResultWarning.Add(new ResultWarning() { ResultID = Common.ResultCurrent.ResultID, Title = "Lỗi", Description = "Lỗi quá trình nạp khí giàn 1." });
                }
                if (loiQuaTrinhNapKhiHe2 != null && loiQuaTrinhNapKhiHe2 == true && (loiQuaTrinhNapKhiHe2_Before == null || loiQuaTrinhNapKhiHe2_Before == false))
                {
                    dalResultWarning.Add(new ResultWarning() { ResultID = Common.ResultCurrent.ResultID, Title = "Lỗi", Description = "Lỗi quá trình nạp khí giàn 2." });
                }

                //
                if (Lockup_Temp_High != null && Lockup_Temp_High == true && (Lockup_Temp_High_Before == null || Lockup_Temp_High_Before == false))
                {
                    dalResultWarning.Add(new ResultWarning() { ResultID = Common.ResultCurrent.ResultID, Title = "Lỗi", Description = "Lockup Temp High." });
                }
                if (Cavi_Temp_High != null && Cavi_Temp_High == true && (Cavi_Temp_High_Before == null || Cavi_Temp_High_Before == false))
                {
                    dalResultWarning.Add(new ResultWarning() { ResultID = Common.ResultCurrent.ResultID, Title = "Lỗi", Description = "Cavi Temp High." });
                }
                if (Seal_Leak_Temp_Low != null && Seal_Leak_Temp_Low == true && (Seal_Leak_Temp_Low_Before == null || Seal_Leak_Temp_Low_Before == false))
                {
                    dalResultWarning.Add(new ResultWarning() { ResultID = Common.ResultCurrent.ResultID, Title = "Lỗi", Description = "Seal Leak Temp Low." });
                }
                if (Apter_Vapolization != null && Apter_Vapolization == true && (Apter_Vapolization_Before == null || Apter_Vapolization_Before == false))
                {
                    dalResultWarning.Add(new ResultWarning() { ResultID = Common.ResultCurrent.ResultID, Title = "Lỗi", Description = "Apter Vapolization." });
                }
                if (Discharge_PRS_High != null && Discharge_PRS_High == true && (Discharge_PRS_High_Before == null || Discharge_PRS_High_Before == false))
                {
                    dalResultWarning.Add(new ResultWarning() { ResultID = Common.ResultCurrent.ResultID, Title = "Lỗi", Description = "Discharge PRS High." });
                }



                canhBaoLoiDongCoOHeHoaHoi_Before = canhBaoLoiDongCoOHeHoaHoi;
                canhBaoChuaMoHeHoaHoi_Before = canhBaoChuaMoHeHoaHoi;
                loiQuaTrinhXaKhiHe1_Before = loiQuaTrinhXaKhiHe1;
                loiQuaTrinhXaKhiHe2_Before = loiQuaTrinhXaKhiHe2;
                loiQuaTrinhNapKhiHe1_Before = loiQuaTrinhNapKhiHe1;
                loiQuaTrinhNapKhiHe2_Before = loiQuaTrinhNapKhiHe2;

                Lockup_Temp_High_Before = Lockup_Temp_High;
                Cavi_Temp_High_Before = Cavi_Temp_High;
                Seal_Leak_Temp_Low_Before = Seal_Leak_Temp_Low;
                Apter_Vapolization_Before = Apter_Vapolization;
                Discharge_PRS_High_Before = Discharge_PRS_High;


            }
            else if (isPalletRunning == true && Common.ResultCurrent == null && Common.UserCurrent != null)
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



                Common.ResultCurrent = dalResult.Add(new Result()
                {
                    LoaiKhi = Common.TenHeNap,
                    ApSuatTieuChuan = (apSuatTieuChuan != null && apSuatTieuChuan != float.PositiveInfinity) ? apSuatTieuChuan : 0,
                    TheTichCanNap = (theTichCanNap != null && theTichCanNap != float.PositiveInfinity) ? theTichCanNap : 0,
                    TheTichTieuChuan = (thetichTieuChuan != null && thetichTieuChuan != float.PositiveInfinity) ? thetichTieuChuan : 0,
                    HeSoTieuChuan = (heSoTieuChuan != null && heSoTieuChuan != float.PositiveInfinity) ? heSoTieuChuan : 0,
                    ThoiGianTrichMau = thoiGianTrichMau != null ? thoiGianTrichMau : new DateTime(0),
                    SoLuongBinhCanNapHe1 = soLuongBinhCanNapCHoHe1 != null ? soLuongBinhCanNapCHoHe1 : 0,
                    SoLuongBinhCanNapHe2 = soLuongBinhCanNapCHoHe2 != null ? soLuongBinhCanNapCHoHe2 : 0,
                    Username = Common.UserCurrent.Username,
                    Status = false,
                    UserID = Common.UserCurrent.UserWorkingID,
                });

            }




        }
    }
}

