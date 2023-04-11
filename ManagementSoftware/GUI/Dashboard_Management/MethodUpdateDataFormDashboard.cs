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

        Label label1ApSuatHeNap1;
        Label labelApSuatHeNap2;
        Label labelTheTichHeNap1;
        Label labelTheTichHeNap2;
        Label labelApSuatTong;


        Label labelSanSangNapHe1;
        Label labelSanSangNapHe2;
        Label labelDangNapHe1;
        Label labelDangNapHe2;
        Label labelXaKhiHe1;
        Label labelXaKhiHe2;
        Label labelDungNapHe1;
        Label labelDungNapHe2;


        Label labelNguoiVanHanh;
        Label labelTimeStart;
        Label labelSoLuongNapGian1;
        Label labelSoLuongNapGian2;
        Label labelLoaiKhi;



        ListBox listBoxError;

        public MethodUpdateDataFormDashboard(Dashboard dashboard, Label label1ApSuatHeNap1, Label labelApSuatHeNap2, Label labelTheTichHeNap1, Label labelTheTichHeNap2, Label labelApSuatTong, Label labelSanSangNapHe1, Label labelSanSangNapHe2, Label labelDangNapHe1, Label labelDangNapHe2, Label labelXaKhiHe1, Label labelXaKhiHe2, Label labelDungNapHe1, Label labelDungNapHe2, ListBox listBoxError, Label labelNguoiVanHanh, Label labelTimeStart, Label labelSoLuongNapGian1, Label labelSoLuongNapGian2, Label labelLoaiKhi)
        {
            plc = new PLCBeckhOff();
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
            this.labelXaKhiHe1 = labelXaKhiHe1;
            this.labelXaKhiHe2 = labelXaKhiHe2;
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




            //dữ liệu hiển thị
            float? apSuatHe1 = 0;
            float? apSuatHe2 = 0;
            float? theTichHe1 = 0;
            float? theTichHe2 = 0;
            float? apSuatTong = 0;

            //trạng thái quy trinh
            bool? sanSangNapHe1 = false;
            bool? sanSangNapHe2 = false;
            bool? ketThucNapHe1 = false;
            bool? ketThucNapHe2 = false;
            bool? xaKhiHe1 = false;
            bool? xaKhiHe2 = false;
            bool? batDauNapHe1 = false;
            bool? batDauNapHe2 = false;


            bool? canhBaoLoiDongCoOHeHoaHoi = false;
            bool? canhBaoChuaMoHeHoaHoi = false;
            bool? loiQuaTrinhXaKhiHe1 = false;
            bool? loiQuaTrinhXaKhiHe2 = false;
            bool? loiQuaTrinhNapKhiHe1 = false;
            bool? loiQuaTrinhNapKhiHe2 = false;



            apSuatHe1 = await Task.Run(() => plc.ReadAVariableNumber<float>(AddressPLC.DATA_PC_GT_AS_ST_H1));
            apSuatHe2 = await Task.Run(() => plc.ReadAVariableNumber<float>(AddressPLC.DATA_PC_GT_AS_ST_H2));
            theTichHe1 = await Task.Run(() => plc.ReadAVariableNumber<float>(AddressPLC.DATA_PC_GT_V_ST_H1));
            theTichHe2 = await Task.Run(() => plc.ReadAVariableNumber<float>(AddressPLC.DATA_PC_GT_V_ST_H2));
            apSuatTong = await Task.Run(() => plc.ReadAVariableNumber<float>(AddressPLC.DATA_PC_GT_AS_Tong));

            sanSangNapHe1 = await Task.Run(() => plc.ReadAVariableNumber<bool>(AddressPLC.DATA_PC_Enable_H1));
            sanSangNapHe2 = await Task.Run(() => plc.ReadAVariableNumber<bool>(AddressPLC.DATA_PC_Enable_H2));
            ketThucNapHe1 = await Task.Run(() => plc.ReadAVariableNumber<bool>(AddressPLC.DATA_PC_KetThuc_QT_NAP_H1));
            ketThucNapHe2 = await Task.Run(() => plc.ReadAVariableNumber<bool>(AddressPLC.DATA_PC_KetThuc_QT_NAP_H2));
            xaKhiHe1 = await Task.Run(() => plc.ReadAVariableNumber<bool>(AddressPLC.DATA_PC_ST_Xa_Khi_H1));
            xaKhiHe2 = await Task.Run(() => plc.ReadAVariableNumber<bool>(AddressPLC.DATA_PC_ST_Xa_Khi_H2));
            batDauNapHe1 = await Task.Run(() => plc.ReadAVariableNumber<bool>(AddressPLC.DATA_PC_ST_Run_Nap_H1));
            batDauNapHe2 = await Task.Run(() => plc.ReadAVariableNumber<bool>(AddressPLC.DATA_PC_ST_Run_Nap_H2));

            canhBaoLoiDongCoOHeHoaHoi = await Task.Run(() => plc.ReadAVariableNumber<bool>(AddressPLC.DATA_PC_VFP_Trip));
            canhBaoChuaMoHeHoaHoi = await Task.Run(() => plc.ReadAVariableNumber<bool>(AddressPLC.DATA_PC_OFF_Hoa_Hoi));
            loiQuaTrinhXaKhiHe1 = await Task.Run(() => plc.ReadAVariableNumber<bool>(AddressPLC.DATA_PC_Loi_TT_XA_KHI_H1));
            loiQuaTrinhXaKhiHe2 = await Task.Run(() => plc.ReadAVariableNumber<bool>(AddressPLC.DATA_PC_Loi_TT_XA_KHI_H2));
            loiQuaTrinhNapKhiHe1 = await Task.Run(() => plc.ReadAVariableNumber<bool>(AddressPLC.DATA_PC_Loi_TT_NAP_KHI_H1));
            loiQuaTrinhNapKhiHe2 = await Task.Run(() => plc.ReadAVariableNumber<bool>(AddressPLC.DATA_PC_Loi_TT_NAP_KHI_H2));




            DataAlwaysUpdate data = new DataAlwaysUpdate();
            data.apSuatHe1 = apSuatHe1;
            data.apSuatHe2 = apSuatHe2;
            data.apSuatTong = apSuatTong;
            data.theTichHe1 = theTichHe1;
            data.theTichHe2 = theTichHe2;
            data.sanSangNapHe1 = sanSangNapHe1;
            data.sanSangNapHe2 = sanSangNapHe2;
            data.ketThucNapHe1 = ketThucNapHe1;
            data.ketThucNapHe2 = ketThucNapHe2;
            data.xaKhiHe1 = xaKhiHe1;
            data.xaKhiHe2 = xaKhiHe2;
            data.batDauNapHe1 = batDauNapHe1;
            data.batDauNapHe2 = batDauNapHe2;


            //error
            data.canhBaoLoiDongCoOHeHoaHoi = canhBaoLoiDongCoOHeHoaHoi;
            data.canhBaoChuaMoHeHoaHoi = canhBaoChuaMoHeHoaHoi;
            data.loiQuaTrinhXaKhiHe1 = loiQuaTrinhXaKhiHe1;
            data.loiQuaTrinhXaKhiHe2 = loiQuaTrinhXaKhiHe2;
            data.loiQuaTrinhNapKhiHe1 = loiQuaTrinhNapKhiHe1;
            data.loiQuaTrinhNapKhiHe2 = loiQuaTrinhNapKhiHe2;




            //method update gui
            UpdateGUI(data);

        }


        private void UpdateGUI(DataAlwaysUpdate data)
        {
            //update gui

            if (dashboard.IsHandleCreated && dashboard.InvokeRequired)
            {
                dashboard.BeginInvoke(() =>
                {
                    label1ApSuatHeNap1.Text = data.apSuatHe1 != null ? string.Format("{0:0.00}", data.apSuatHe1) : Common.ERR;
                    labelApSuatHeNap2.Text = data.apSuatHe2 != null ? string.Format("{0:0.00}", data.apSuatHe2) : Common.ERR;
                    labelApSuatTong.Text = data.apSuatTong != null ? string.Format("{0:0.00}", data.apSuatTong) : Common.ERR;
                    labelTheTichHeNap1.Text = data.theTichHe1 != null ? string.Format("{0:0.00}", data.theTichHe1) : Common.ERR;
                    labelTheTichHeNap2.Text = data.theTichHe2 != null ? string.Format("{0:0.00}", data.theTichHe2) : Common.ERR;



                    //quy trình

                    labelSanSangNapHe1.BackColor = data.sanSangNapHe1 != null && data.sanSangNapHe1 == true ? Color.LimeGreen : Color.DimGray;
                    labelSanSangNapHe2.BackColor = data.sanSangNapHe2 != null && data.sanSangNapHe2 == true ? Color.LimeGreen : Color.DimGray;
                    labelDangNapHe1.BackColor = data.batDauNapHe1 != null && data.batDauNapHe1 == true ? Color.LimeGreen : Color.DimGray;
                    labelDangNapHe2.BackColor = data.batDauNapHe2 != null && data.batDauNapHe2 == true ? Color.LimeGreen : Color.DimGray;
                    labelXaKhiHe1.BackColor = data.xaKhiHe1 != null && data.xaKhiHe1 == true ? Color.LimeGreen : Color.DimGray;
                    labelXaKhiHe2.BackColor = data.xaKhiHe2 != null && data.xaKhiHe2 == true ? Color.LimeGreen : Color.DimGray;
                    labelDungNapHe1.BackColor = data.ketThucNapHe1 != null && data.ketThucNapHe1 == true ? Color.LimeGreen : Color.DimGray;
                    labelDungNapHe2.BackColor = data.ketThucNapHe2 != null && data.ketThucNapHe2 == true ? Color.LimeGreen : Color.DimGray;



                    labelNguoiVanHanh.Text = "Người vận hành : " + Common.ResultCurrent.Username;
                    labelTimeStart.Text = "Thời gian bắt đầu : " + Common.ResultCurrent.TimeStart.ToString("HH:mm:ss dd/MM/yyyy");
                    labelSoLuongNapGian1.Text = "Số lượng nạp giàn 1 : " + Common.ResultCurrent.SoLuongBinhCanNapHe1.ToString();
                    labelSoLuongNapGian2.Text = "Số lượng nạp giàn 1 : " + Common.ResultCurrent.SoLuongBinhCanNapHe2.ToString();
                    labelLoaiKhi.Text = "Loại khí : " + Common.ResultCurrent.LoaiKhi;




                    //err
                    if (this.listBoxError.Items.Count > 0)
                    {
                        this.listBoxError.Items.Clear();
                    }
                    if (data.canhBaoLoiDongCoOHeHoaHoi == true)
                    {
                        this.listBoxError.Items.Add("Cảnh báo lỗi động cơ ở hệ hóa hơi.");
                    }
                    if (data.canhBaoChuaMoHeHoaHoi == true)
                    {
                        this.listBoxError.Items.Add("Cảnh báo chưa mở hệ hóa hơi.");
                    }
                    if (data.loiQuaTrinhXaKhiHe1 == true)
                    {
                        this.listBoxError.Items.Add("Lỗi quá trình xả khí giàn 1.");
                    }
                    if (data.loiQuaTrinhXaKhiHe2 == true)
                    {
                        this.listBoxError.Items.Add("Lỗi quá trình xả khí giàn 2.");
                    }
                    if (data.loiQuaTrinhNapKhiHe1 == true)
                    {
                        this.listBoxError.Items.Add("Lỗi quá trình nạp khí giàn 1.");
                    }
                    if (data.loiQuaTrinhNapKhiHe2 == true)
                    {
                        this.listBoxError.Items.Add("Lỗi quá trình nạp khí giàn 2.");
                    }




                    if (Common.ResultCurrent == null)
                    {
                        //labelSanSangNapHe1.BackColor = Color.DimGray;
                        //labelSanSangNapHe2.BackColor = Color.DimGray;
                        //labelDangNapHe1.BackColor = Color.DimGray;
                        //labelDangNapHe2.BackColor = Color.DimGray;
                        //labelXaKhiHe1.BackColor = Color.DimGray;
                        //labelXaKhiHe2.BackColor = Color.DimGray;
                        //labelDungNapHe1.BackColor = Color.DimGray;
                        //labelDungNapHe2.BackColor = Color.DimGray;

                        labelNguoiVanHanh.Text = "Người vận hành : Chưa có";
                        labelTimeStart.Text = "Thời gian bắt đầu : Chưa có";
                        labelSoLuongNapGian1.Text = "Số lượng nạp giàn 1 : Chưa có";
                        labelSoLuongNapGian2.Text = "Số lượng nạp giàn 1 : Chưa có";
                        labelLoaiKhi.Text = "Loại khí : Chưa có";


                    }

                });
            }




        }
    }
}
