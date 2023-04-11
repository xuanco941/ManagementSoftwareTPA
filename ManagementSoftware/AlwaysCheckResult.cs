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
        private DALMachine dalMachine = new DALMachine();
        private DALResultWarning dalResultWarning = new DALResultWarning();
        public AlwaysCheckResult()
        {
        }


        public void StartTimer()
        {
            if (timer == null)
            {
                timer = new System.Threading.Timer(Callback, null, 5000, Timeout.Infinite);
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

        int statusGian1 = 0;
        int statusGian2 = 0;



        private async void Callback(Object state)
        {
            Stopwatch watch = new Stopwatch();

            watch.Start();

            // update data
            // Long running operation
            //trạng thái quy trinh


            bool? sanSangNapHe1 = false;
            bool? sanSangNapHe2 = false;
            bool? ketThucNapHe1 = false;
            bool? ketThucNapHe2 = false;
            bool? xaKhiHe1 = false;
            bool? xaKhiHe2 = false;
            bool? batDauNapHe1 = false;
            bool? batDauNapHe2 = false;





            if (Common.UserCurrent != null)
            {
                //sanSangNapHe1 = await Task.Run(() => plc.ReadAVariableNumber<bool>(AddressPLC.DATA_PC_Enable_H1));
                //sanSangNapHe2 = await Task.Run(() => plc.ReadAVariableNumber<bool>(AddressPLC.DATA_PC_Enable_H2));
                ketThucNapHe1 = await Task.Run(() => plc.ReadAVariableNumber<bool>(AddressPLC.DATA_PC_KetThuc_QT_NAP_H1));
                ketThucNapHe2 = await Task.Run(() => plc.ReadAVariableNumber<bool>(AddressPLC.DATA_PC_KetThuc_QT_NAP_H2));
                xaKhiHe1 = await Task.Run(() => plc.ReadAVariableNumber<bool>(AddressPLC.DATA_PC_ST_Xa_Khi_H1));
                xaKhiHe2 = await Task.Run(() => plc.ReadAVariableNumber<bool>(AddressPLC.DATA_PC_ST_Xa_Khi_H2));
                batDauNapHe1 = await Task.Run(() => plc.ReadAVariableNumber<bool>(AddressPLC.DATA_PC_ST_Run_Nap_H1));
                batDauNapHe2 = await Task.Run(() => plc.ReadAVariableNumber<bool>(AddressPLC.DATA_PC_ST_Run_Nap_H2));

                if ((sanSangNapHe1 != null && sanSangNapHe1 == true))
                {
                    statusGian1 = 1;
                }
                else if ((batDauNapHe1 != null && batDauNapHe1 == true))
                {
                    statusGian1 = 2;
                }
                else if ((xaKhiHe1 != null && xaKhiHe1 == true))
                {
                    statusGian1 = 3;
                }
                else if ((ketThucNapHe1 != null && ketThucNapHe1 == true))
                {
                    statusGian1 = 4;
                }
                else
                {
                    statusGian1 = 0;
                }


                if ((sanSangNapHe2 != null && sanSangNapHe2 == true))
                {
                    statusGian2 = 1;
                }
                else if ((batDauNapHe2 != null && batDauNapHe2 == true))
                {
                    statusGian2 = 2;
                }
                else if ((xaKhiHe2 != null && xaKhiHe2 == true))
                {
                    statusGian2 = 3;
                }
                else if ((ketThucNapHe2 != null && ketThucNapHe2 == true))
                {
                    statusGian2 = 4;
                }
                else
                {
                    statusGian2 = 0;
                }

                // action

                if (plc.CheckState())
                {
                    ActionSTT4();

                    await ActionSTT2();
                }




            }
            if (timer != null)
            {
                timer.Change(Math.Max(0, 600000 - watch.ElapsedMilliseconds), Timeout.Infinite);
            }
        }



        async Task ActionSTT2()
        {
            if ((statusGian1 == 2 || statusGian2 == 2) && Common.ResultCurrent == null)
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

            if (Common.ResultCurrent != null)
            {
                float? apSuatTong = 0;
                apSuatTong = await Task.Run(() => plc.ReadAVariableNumber<float>(AddressPLC.DATA_PC_GT_AS_Tong));


                if (statusGian1 == 2 || statusGian1 == 3)
                {
                    float? apSuatHe1 = 0;
                    float? theTichHe1 = 0;


                    apSuatHe1 = await Task.Run(() => plc.ReadAVariableNumber<float>(AddressPLC.DATA_PC_GT_AS_ST_H1));
                    theTichHe1 = await Task.Run(() => plc.ReadAVariableNumber<float>(AddressPLC.DATA_PC_GT_V_ST_H1));


                    dalMachine.Add(new Machine() { NameMachine = Common.GianNap1, ApSuat = apSuatHe1, TheTich = theTichHe1, ApSuatTong = apSuatTong });
                }

                if (statusGian1 == 2 || statusGian1 == 3)
                {
                    float? apSuatHe2 = 0;
                    float? theTichHe2 = 0;


                    apSuatHe2 = await Task.Run(() => plc.ReadAVariableNumber<float>(AddressPLC.DATA_PC_GT_AS_ST_H2));
                    theTichHe2 = await Task.Run(() => plc.ReadAVariableNumber<float>(AddressPLC.DATA_PC_GT_V_ST_H2));


                    dalMachine.Add(new Machine() { NameMachine = Common.GianNap2, ApSuat = apSuatHe2, TheTich = theTichHe2, ApSuatTong = apSuatTong });
                }





                if (statusGian1 == 2 || statusGian1 == 3 || statusGian2 == 2 || statusGian2 == 3)
                {
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
            }

        }
        void ActionSTT4()
        {
            if (statusGian1 != 2 && statusGian1 != 3 && statusGian2 != 2 && statusGian2 != 3 && Common.ResultCurrent != null)
            {
                Common.ResultCurrent.TimeEnd = DateTime.Now;
                dalResult.Update(Common.ResultCurrent);
                Common.ResultCurrent = null;
            }
        }
    }
}

