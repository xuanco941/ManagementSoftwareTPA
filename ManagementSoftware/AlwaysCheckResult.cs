﻿using ManagementSoftware.DAL;
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

        int trangThaiOld1 = 0;
        int trangThaiOld = 0;
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

                if(pallet1 !=null || pallet2 != null)
                {

                    if (((pallet1 != null && pallet1 == 1) || (pallet2 != null && pallet2 == 1)) && Common.ResultCurrent == null)
                    {


                    }
                }
                else
                {

                }


            }






















            if (timer != null)
            {
                timer.Change(Math.Max(0, 2000 - watch.ElapsedMilliseconds), Timeout.Infinite);
            }
        }



        async Task Run()
        {
            if ((statusGian1Run == true || statusGian2Run == true) == false && Common.ResultCurrent != null)
            {
                Common.ResultCurrent.Status = true;
                Common.ResultCurrent.TimeEnd = DateTime.Now;
                dalResult.Update(Common.ResultCurrent);
                Common.ResultCurrent = null;
            }
            else if ((statusGian1Run == true || statusGian2Run == true) == true && Common.ResultCurrent == null)
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
                    ApSuatTieuChuan = apSuatTieuChuan,
                    TheTichCanNap = theTichCanNap,
                    TheTichTieuChuan = thetichTieuChuan,
                    HeSoTieuChuan = heSoTieuChuan,
                    ThoiGianTrichMau = thoiGianTrichMau,
                    SoLuongBinhCanNapHe1 = soLuongBinhCanNapCHoHe1,
                    SoLuongBinhCanNapHe2 = soLuongBinhCanNapCHoHe2,
                    Username = Common.UserCurrent.Username,
                    Status = false,
                    UserID = Common.UserCurrent.UserWorkingID,
                });
            }
            else if ((statusGian1Run == true || statusGian2Run == true) == true && Common.ResultCurrent != null)
            {
                float? apSuatTong = 0;
                apSuatTong = await Task.Run(() => plc.ReadAVariableNumber<float>(AddressPLC.DATA_PC_GT_AS_Tong));

                DateTime now = DateTime.Now;
                if (statusGian1Run == true)
                {
                    float? apSuatHe1 = 0;
                    float? theTichHe1 = 0;


                    apSuatHe1 = await Task.Run(() => plc.ReadAVariableNumber<float>(AddressPLC.DATA_PC_GT_AS_ST_H1));
                    theTichHe1 = await Task.Run(() => plc.ReadAVariableNumber<float>(AddressPLC.DATA_PC_GT_V_ST_H1));


                    dalMachine.Add(new Machine() { CreateAt = now, NameMachine = Common.GianNap1, ApSuat = apSuatHe1, TheTich = theTichHe1, ApSuatTong = apSuatTong, ResultID = Common.ResultCurrent.ResultID });
                }

                if (statusGian2Run == true)
                {
                    float? apSuatHe2 = 0;
                    float? theTichHe2 = 0;


                    apSuatHe2 = await Task.Run(() => plc.ReadAVariableNumber<float>(AddressPLC.DATA_PC_GT_AS_ST_H2));
                    theTichHe2 = await Task.Run(() => plc.ReadAVariableNumber<float>(AddressPLC.DATA_PC_GT_V_ST_H2));


                    dalMachine.Add(new Machine() { CreateAt = now, NameMachine = Common.GianNap2, ApSuat = apSuatHe2, TheTich = theTichHe2, ApSuatTong = apSuatTong, ResultID = Common.ResultCurrent.ResultID });
                }


                // err
                bool? canhBaoLoiDongCoOHeHoaHoi = false;
                bool? canhBaoChuaMoHeHoaHoi = false;
                bool? loiQuaTrinhXaKhiHe1 = false;
                bool? loiQuaTrinhXaKhiHe2 = false;
                bool? loiQuaTrinhNapKhiHe1 = false;
                bool? loiQuaTrinhNapKhiHe2 = false;

                canhBaoLoiDongCoOHeHoaHoi = await Task.Run(() => plc.ReadAVariableNumber<bool>(AddressPLC.DATA_PC_VFP_Trip));
                canhBaoChuaMoHeHoaHoi = await Task.Run(() => plc.ReadAVariableNumber<bool>(AddressPLC.DATA_PC_OFF_Hoa_Hoi));
                loiQuaTrinhXaKhiHe1 = await Task.Run(() => plc.ReadAVariableNumber<bool>(AddressPLC.DATA_PC_Loi_TT_XA_KHI_H1));
                loiQuaTrinhXaKhiHe2 = await Task.Run(() => plc.ReadAVariableNumber<bool>(AddressPLC.DATA_PC_Loi_TT_XA_KHI_H2));
                loiQuaTrinhNapKhiHe1 = await Task.Run(() => plc.ReadAVariableNumber<bool>(AddressPLC.DATA_PC_Loi_TT_NAP_KHI_H1));
                loiQuaTrinhNapKhiHe2 = await Task.Run(() => plc.ReadAVariableNumber<bool>(AddressPLC.DATA_PC_Loi_TT_NAP_KHI_H2));

                if (canhBaoLoiDongCoOHeHoaHoi != null && canhBaoLoiDongCoOHeHoaHoi == true)
                {
                    dalResultWarning.Add(new ResultWarning() { ResultID = Common.ResultCurrent.ResultID, Title = "Cảnh báo", Description = "Cảnh báo lỗi động cơ ở hệ hóa hơi." });
                }
                if (canhBaoChuaMoHeHoaHoi != null && canhBaoChuaMoHeHoaHoi == true)
                {
                    dalResultWarning.Add(new ResultWarning() { ResultID = Common.ResultCurrent.ResultID, Title = "Cảnh báo", Description = "Cảnh báo chưa mở hệ hóa hơi." });
                }
                if (loiQuaTrinhXaKhiHe1 != null && loiQuaTrinhXaKhiHe1 == true)
                {
                    dalResultWarning.Add(new ResultWarning() { ResultID = Common.ResultCurrent.ResultID, Title = "Lỗi", Description = "Lỗi quá trình xả khí giàn 1." });
                }
                if (loiQuaTrinhXaKhiHe2 != null && loiQuaTrinhXaKhiHe2 == true)
                {
                    dalResultWarning.Add(new ResultWarning() { ResultID = Common.ResultCurrent.ResultID, Title = "Lỗi", Description = "Lỗi quá trình xả khí giàn 2." });
                }
                if (loiQuaTrinhNapKhiHe1 != null && loiQuaTrinhNapKhiHe1 == true)
                {
                    dalResultWarning.Add(new ResultWarning() { ResultID = Common.ResultCurrent.ResultID, Title = "Lỗi", Description = "Lỗi quá trình nạp khí giàn 1." });
                }
                if (loiQuaTrinhNapKhiHe2 != null && loiQuaTrinhNapKhiHe2 == true)
                {
                    dalResultWarning.Add(new ResultWarning() { ResultID = Common.ResultCurrent.ResultID, Title = "Lỗi", Description = "Lỗi quá trình nạp khí giàn 2." });
                }


            }
            else if ((statusGian1Run == true || statusGian2Run == true) == false && Common.ResultCurrent == null)
            {
                //nothing
            }



        }
    }
}

