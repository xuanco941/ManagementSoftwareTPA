using ManagementSoftware.Properties;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ManagementSoftware.GUI.Dashboard_Management
{
    public class MethodUpdateStatusTheoDoiHeNap
    {
        TimerUpdateGUI timerUpdateGUILabel1;
        PLCBeckhOff plc;
        TheoDoiHeNap formTheoDoiHeNap;

        PictureBox ong1;
        PictureBox ong2;
        PictureBox RunNap;
        PictureBox VanCap;
        PictureBox VanXa;


        PictureBox OngXa;
        PictureBox BangTai1;
        PictureBox Motor1;
        PictureBox BangTai2;
        PictureBox Motor2;
        PictureBox BangTai3;
        PictureBox Motor3;
        PictureBox BangTai4;
        PictureBox Motor4;

        PictureBox CB1;
        PictureBox CB2;
        PictureBox CB3;
        PictureBox CB4;
        PictureBox CB5;
        PictureBox CB6;
        PictureBox CB7;
        PictureBox CB8;
        PictureBox CB9;
        PictureBox CB10;


        // adrress
        string DATA_PCPC_ong_H1; string DATA_PCST_Run_Nap_H1; string DATA_PCVan_Cap_H1; string DATA_PCVan_Xa_H1;
        string DATA_PCST_Xa_Khi_H1; string DATA_PCMotor_BT1_Vao; string DATA_PCMotor_BT1_Nap1; string DATA_PCMotor_BT1_Nap2;
        string DATA_PCMotor_BT1_Ra; string DATA_PCCB_PL_VT_Cap1; string DATA_PCCB_PL_qua_Vtcap1; string DATA_PCCB_PL_cuoi_Btvao1; string DATA_PCCB_RunBT_Nap1_1;
        string DATA_PCCB_StopBT_Nap1_1; string DATA_PCCB_RunBT_Nap1_2; string DATA_PCCB_StopBT_Nap1_2; string DATA_PCCB_co_PL_Ra1; string DATA_PCCB_PL_den_VTRa1; string DATA_PCCB_CB_PL_VT_Lay1;

        public MethodUpdateStatusTheoDoiHeNap(TheoDoiHeNap theoDoiHeNap, PictureBox ong1,
        PictureBox ong2,
        PictureBox RunNap,
        PictureBox VanCap,
        PictureBox VanXa,
        PictureBox OngXa,
        PictureBox BangTai1,
        PictureBox Motor1,
        PictureBox BangTai2,
        PictureBox Motor2,
        PictureBox BangTai3,
        PictureBox Motor3,
        PictureBox BangTai4,
        PictureBox Motor4,
        PictureBox CB1,
        PictureBox CB2,
        PictureBox CB3,
        PictureBox CB4,
        PictureBox CB5,
        PictureBox CB6,
        PictureBox CB7,
        PictureBox CB8,
        PictureBox CB9,
        PictureBox CB10,
        string DATA_PCPC_ong_H1, string DATA_PCST_Run_Nap_H1, string DATA_PCVan_Cap_H1, string DATA_PCVan_Xa_H1,
        string DATA_PCST_Xa_Khi_H1, string DATA_PCMotor_BT1_Vao, string DATA_PCMotor_BT1_Nap1, string DATA_PCMotor_BT1_Nap2,
        string DATA_PCMotor_BT1_Ra, string DATA_PCCB_PL_VT_Cap1, string DATA_PCCB_PL_qua_Vtcap1, string DATA_PCCB_PL_cuoi_Btvao1, string DATA_PCCB_RunBT_Nap1_1,
        string DATA_PCCB_StopBT_Nap1_1, string DATA_PCCB_RunBT_Nap1_2, string DATA_PCCB_StopBT_Nap1_2, string DATA_PCCB_co_PL_Ra1, string DATA_PCCB_PL_den_VTRa1, string DATA_PCCB_CB_PL_VT_Lay1)
        {
            plc = new PLCBeckhOff();
            timerUpdateGUILabel1 = new TimerUpdateGUI(300, 1000, UpdateData);
            this.formTheoDoiHeNap = theoDoiHeNap;
            this.ong1 = ong1;
            this.ong2 = ong2;
            this.RunNap = RunNap;
            this.VanCap = VanCap;
            this.VanXa = VanXa;
            this.OngXa = OngXa;
            this.BangTai1 = BangTai1;
            this.Motor1 = Motor1;
            this.BangTai2 = BangTai2;
            this.Motor2 = Motor2;
            this.BangTai3 = BangTai3;
            this.Motor3 = Motor3;
            this.BangTai4 = BangTai4;
            this.Motor4 = Motor4;

            this.CB1 = CB1;
            this.CB2 = CB2;
            this.CB3 = CB3;
            this.CB4 = CB4;
            this.CB5 = CB5;
            this.CB6 = CB6;
            this.CB7 = CB7;
            this.CB8 = CB8;
            this.CB9 = CB9;
            this.CB10 = CB10;


            //adress
            this.DATA_PCPC_ong_H1 = DATA_PCPC_ong_H1;
            this.DATA_PCST_Run_Nap_H1 = DATA_PCST_Run_Nap_H1;
            this.DATA_PCVan_Cap_H1 = DATA_PCVan_Cap_H1;
            this.DATA_PCVan_Xa_H1 = DATA_PCVan_Xa_H1;

            this.DATA_PCST_Xa_Khi_H1 = DATA_PCST_Xa_Khi_H1;
            this.DATA_PCMotor_BT1_Vao = DATA_PCMotor_BT1_Vao;
            this.DATA_PCMotor_BT1_Nap1 = DATA_PCMotor_BT1_Nap1;
            this.DATA_PCMotor_BT1_Nap2 = DATA_PCMotor_BT1_Nap2;
            this.DATA_PCMotor_BT1_Ra = DATA_PCMotor_BT1_Ra;
            this.DATA_PCCB_PL_VT_Cap1 = DATA_PCCB_PL_VT_Cap1;
            this.DATA_PCCB_PL_qua_Vtcap1 = DATA_PCCB_PL_qua_Vtcap1;
            this.DATA_PCCB_PL_cuoi_Btvao1 = DATA_PCCB_PL_cuoi_Btvao1;
            this.DATA_PCCB_RunBT_Nap1_1 = DATA_PCCB_RunBT_Nap1_1;

            this.DATA_PCCB_StopBT_Nap1_1 = DATA_PCCB_StopBT_Nap1_1;
            this.DATA_PCCB_RunBT_Nap1_2 = DATA_PCCB_RunBT_Nap1_2;
            this.DATA_PCCB_StopBT_Nap1_2 = DATA_PCCB_StopBT_Nap1_2;
            this.DATA_PCCB_co_PL_Ra1 = DATA_PCCB_co_PL_Ra1;
            this.DATA_PCCB_PL_den_VTRa1 = DATA_PCCB_PL_den_VTRa1;
            this.DATA_PCCB_CB_PL_VT_Lay1 = DATA_PCCB_CB_PL_VT_Lay1;






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

            // adrress
            bool? DATA_PCPC_ong_H1_BOOL = false;
            bool? DATA_PCST_Run_Nap_H1_BOOL = false;
            bool? DATA_PCVan_Cap_H1_BOOL = false;
            bool? DATA_PCVan_Xa_H1_BOOL = false;
            bool? DATA_PCST_Xa_Khi_H1_BOOL = false;
            bool? DATA_PCMotor_BT1_Vao_BOOL = false;
            bool? DATA_PCMotor_BT1_Nap1_BOOL = false;
            bool? DATA_PCMotor_BT1_Nap2_BOOL = false;
            bool? DATA_PCMotor_BT1_Ra_BOOL = false;
            bool? DATA_PCCB_PL_VT_Cap1_BOOL = false;
            bool? DATA_PCCB_PL_qua_Vtcap1_BOOL = false;
            bool? DATA_PCCB_PL_cuoi_Btvao1_BOOL = false;
            bool? DATA_PCCB_RunBT_Nap1_1_BOOL = false;
            bool? DATA_PCCB_StopBT_Nap1_1_BOOL = false;
            bool? DATA_PCCB_RunBT_Nap1_2_BOOL = false;
            bool? DATA_PCCB_StopBT_Nap1_2_BOOL = false;
            bool? DATA_PCCB_co_PL_Ra1_BOOL = false;
            bool? DATA_PCCB_PL_den_VTRa1_BOOL = false;
            bool? DATA_PCCB_CB_PL_VT_Lay1_BOOL = false;


            DATA_PCPC_ong_H1_BOOL = await Task.Run(() => plc.ReadAVariableNumber<bool>(this.DATA_PCPC_ong_H1));
            DATA_PCST_Run_Nap_H1_BOOL = await Task.Run(() => plc.ReadAVariableNumber<bool>(this.DATA_PCST_Run_Nap_H1));
            DATA_PCVan_Cap_H1_BOOL = await Task.Run(() => plc.ReadAVariableNumber<bool>(this.DATA_PCVan_Cap_H1));
            DATA_PCVan_Xa_H1_BOOL = await Task.Run(() => plc.ReadAVariableNumber<bool>(this.DATA_PCVan_Xa_H1));
            DATA_PCST_Xa_Khi_H1_BOOL = await Task.Run(() => plc.ReadAVariableNumber<bool>(this.DATA_PCST_Xa_Khi_H1));
            DATA_PCMotor_BT1_Vao_BOOL = await Task.Run(() => plc.ReadAVariableNumber<bool>(this.DATA_PCMotor_BT1_Vao));
            DATA_PCMotor_BT1_Nap1_BOOL = await Task.Run(() => plc.ReadAVariableNumber<bool>(this.DATA_PCMotor_BT1_Nap1));
            DATA_PCMotor_BT1_Nap2_BOOL = await Task.Run(() => plc.ReadAVariableNumber<bool>(this.DATA_PCMotor_BT1_Nap2));
            DATA_PCMotor_BT1_Ra_BOOL = await Task.Run(() => plc.ReadAVariableNumber<bool>(this.DATA_PCMotor_BT1_Ra));
            DATA_PCCB_PL_VT_Cap1_BOOL = await Task.Run(() => plc.ReadAVariableNumber<bool>(this.DATA_PCCB_PL_VT_Cap1));
            DATA_PCCB_PL_qua_Vtcap1_BOOL = await Task.Run(() => plc.ReadAVariableNumber<bool>(this.DATA_PCCB_PL_qua_Vtcap1));
            DATA_PCCB_PL_cuoi_Btvao1_BOOL = await Task.Run(() => plc.ReadAVariableNumber<bool>(this.DATA_PCCB_PL_cuoi_Btvao1));
            DATA_PCCB_RunBT_Nap1_1_BOOL = await Task.Run(() => plc.ReadAVariableNumber<bool>(this.DATA_PCCB_RunBT_Nap1_1));
            DATA_PCCB_StopBT_Nap1_1_BOOL = await Task.Run(() => plc.ReadAVariableNumber<bool>(this.DATA_PCCB_StopBT_Nap1_1));
            DATA_PCCB_RunBT_Nap1_2_BOOL = await Task.Run(() => plc.ReadAVariableNumber<bool>(this.DATA_PCCB_RunBT_Nap1_2));
            DATA_PCCB_StopBT_Nap1_2_BOOL = await Task.Run(() => plc.ReadAVariableNumber<bool>(this.DATA_PCCB_StopBT_Nap1_2));

            DATA_PCCB_co_PL_Ra1_BOOL = await Task.Run(() => plc.ReadAVariableNumber<bool>(this.DATA_PCCB_co_PL_Ra1));
            DATA_PCCB_PL_den_VTRa1_BOOL = await Task.Run(() => plc.ReadAVariableNumber<bool>(this.DATA_PCCB_PL_den_VTRa1));
            DATA_PCCB_CB_PL_VT_Lay1_BOOL = await Task.Run(() => plc.ReadAVariableNumber<bool>(this.DATA_PCCB_CB_PL_VT_Lay1));



            //method update gui
            UpdateGUI(DATA_PCPC_ong_H1_BOOL,
        DATA_PCST_Run_Nap_H1_BOOL,
        DATA_PCVan_Cap_H1_BOOL,
      DATA_PCVan_Xa_H1_BOOL,
        DATA_PCST_Xa_Khi_H1_BOOL,
        DATA_PCMotor_BT1_Vao_BOOL,
        DATA_PCMotor_BT1_Nap1_BOOL,
       DATA_PCMotor_BT1_Nap2_BOOL,
        DATA_PCMotor_BT1_Ra_BOOL,
        DATA_PCCB_PL_VT_Cap1_BOOL,
         DATA_PCCB_PL_qua_Vtcap1_BOOL,
         DATA_PCCB_PL_cuoi_Btvao1_BOOL,

         DATA_PCCB_RunBT_Nap1_1_BOOL,
         DATA_PCCB_StopBT_Nap1_1_BOOL,
         DATA_PCCB_RunBT_Nap1_2_BOOL,
        DATA_PCCB_StopBT_Nap1_2_BOOL,
        DATA_PCCB_co_PL_Ra1_BOOL,
         DATA_PCCB_PL_den_VTRa1_BOOL,
         DATA_PCCB_CB_PL_VT_Lay1_BOOL);

        }


        private void UpdateGUI(bool? DATA_PCPC_ong_H1_BOOL,
        bool? DATA_PCST_Run_Nap_H1_BOOL,
        bool? DATA_PCVan_Cap_H1_BOOL,
        bool? DATA_PCVan_Xa_H1_BOOL,
        bool? DATA_PCST_Xa_Khi_H1_BOOL,
        bool? DATA_PCMotor_BT1_Vao_BOOL,
        bool? DATA_PCMotor_BT1_Nap1_BOOL,
        bool? DATA_PCMotor_BT1_Nap2_BOOL,
        bool? DATA_PCMotor_BT1_Ra_BOOL,
        bool? DATA_PCCB_PL_VT_Cap1_BOOL,
        bool? DATA_PCCB_PL_qua_Vtcap1_BOOL,
        bool? DATA_PCCB_PL_cuoi_Btvao1_BOOL,

        bool? DATA_PCCB_RunBT_Nap1_1_BOOL,
        bool? DATA_PCCB_StopBT_Nap1_1_BOOL,
        bool? DATA_PCCB_RunBT_Nap1_2_BOOL,
        bool? DATA_PCCB_StopBT_Nap1_2_BOOL,
        bool? DATA_PCCB_co_PL_Ra1_BOOL,
        bool? DATA_PCCB_PL_den_VTRa1_BOOL,
        bool? DATA_PCCB_CB_PL_VT_Lay1_BOOL)
        {
            //update gui

            if (formTheoDoiHeNap.IsHandleCreated && formTheoDoiHeNap.InvokeRequired)
            {
                formTheoDoiHeNap.BeginInvoke(() =>
                {
                    this.ong1.Image = (DATA_PCPC_ong_H1_BOOL != null && DATA_PCPC_ong_H1_BOOL == true) ? Resources.Ong1Xanh : Resources.Ong1Xam;
                    this.ong2.Image = (DATA_PCPC_ong_H1_BOOL != null && DATA_PCPC_ong_H1_BOOL == true) ? Resources.Ong2Xanh : Resources.Ong2Xam;

                    this.RunNap.Image = (DATA_PCST_Run_Nap_H1_BOOL != null && DATA_PCST_Run_Nap_H1_BOOL == true) ? Resources.RunNapXanh : Resources.RunNapXam;

                    this.VanCap.Image = (DATA_PCVan_Cap_H1_BOOL != null && DATA_PCVan_Cap_H1_BOOL == true) ? Resources.VanCapXanh : Resources.VanCapXam;
                    this.VanXa.Image = (DATA_PCVan_Xa_H1_BOOL != null && DATA_PCVan_Xa_H1_BOOL == true) ? Resources.VanXaXanh : Resources.VanXaXam;

                    this.OngXa.Image = (DATA_PCST_Xa_Khi_H1_BOOL != null && DATA_PCST_Xa_Khi_H1_BOOL == true) ? Resources.ongThoatXanh : Resources.ongThoatXam;

                    this.BangTai1.Image = (DATA_PCMotor_BT1_Vao_BOOL != null && DATA_PCMotor_BT1_Vao_BOOL == true) ? Resources.BangTaiXanh : Resources.BangTaiXam;
                    this.Motor1.Image = (DATA_PCMotor_BT1_Vao_BOOL != null && DATA_PCMotor_BT1_Vao_BOOL == true) ? Resources.MotorXanh : Resources.MotorXam;

                    this.BangTai2.Image = (DATA_PCMotor_BT1_Nap1_BOOL != null && DATA_PCMotor_BT1_Nap1_BOOL == true) ? Resources.BangTaiXanh : Resources.BangTaiXam;
                    this.Motor2.Image = (DATA_PCMotor_BT1_Nap1_BOOL != null && DATA_PCMotor_BT1_Nap1_BOOL == true) ? Resources.MotorXanh : Resources.MotorXam;

                    this.BangTai3.Image = (DATA_PCMotor_BT1_Nap2_BOOL != null && DATA_PCMotor_BT1_Nap2_BOOL == true) ? Resources.BangTaiXanh : Resources.BangTaiXam;
                    this.Motor3.Image = (DATA_PCMotor_BT1_Nap2_BOOL != null && DATA_PCMotor_BT1_Nap2_BOOL == true) ? Resources.MotorXanh : Resources.MotorXam;

                    this.BangTai4.Image = (DATA_PCMotor_BT1_Ra_BOOL != null && DATA_PCMotor_BT1_Ra_BOOL == true) ? Resources.BangTaiXanh : Resources.BangTaiXam;
                    this.Motor4.Image = (DATA_PCMotor_BT1_Ra_BOOL != null && DATA_PCMotor_BT1_Ra_BOOL == true) ? Resources.MotorXanh : Resources.MotorXam;

                    this.CB1.Image = (DATA_PCCB_PL_VT_Cap1_BOOL != null && DATA_PCCB_PL_VT_Cap1_BOOL == true) ? Resources.SensorXanh : Resources.SensorXam;
                    this.CB2.Image = (DATA_PCCB_PL_qua_Vtcap1_BOOL != null && DATA_PCCB_PL_qua_Vtcap1_BOOL == true) ? Resources.SensorXanh : Resources.SensorXam;
                    this.CB3.Image = (DATA_PCCB_PL_cuoi_Btvao1_BOOL != null && DATA_PCCB_PL_cuoi_Btvao1_BOOL == true) ? Resources.SensorXanh : Resources.SensorXam;
                    this.CB4.Image = (DATA_PCCB_RunBT_Nap1_1_BOOL != null && DATA_PCCB_RunBT_Nap1_1_BOOL == true) ? Resources.SensorXanh : Resources.SensorXam;
                    this.CB5.Image = (DATA_PCCB_StopBT_Nap1_1_BOOL != null && DATA_PCCB_StopBT_Nap1_1_BOOL == true) ? Resources.SensorXanh : Resources.SensorXam;
                    this.CB6.Image = (DATA_PCCB_RunBT_Nap1_2_BOOL != null && DATA_PCCB_RunBT_Nap1_2_BOOL == true) ? Resources.SensorXanh : Resources.SensorXam;
                    this.CB7.Image = (DATA_PCCB_StopBT_Nap1_2_BOOL != null && DATA_PCCB_StopBT_Nap1_2_BOOL == true) ? Resources.SensorXanh : Resources.SensorXam;
                    this.CB8.Image = (DATA_PCCB_co_PL_Ra1_BOOL != null && DATA_PCCB_co_PL_Ra1_BOOL == true) ? Resources.SensorXanh : Resources.SensorXam;
                    this.CB9.Image = (DATA_PCCB_PL_den_VTRa1_BOOL != null && DATA_PCCB_PL_den_VTRa1_BOOL == true) ? Resources.SensorXanh : Resources.SensorXam;
                    this.CB10.Image = (DATA_PCCB_CB_PL_VT_Lay1_BOOL != null && DATA_PCCB_CB_PL_VT_Lay1_BOOL == true) ? Resources.SensorXanh : Resources.SensorXam;

                });
            }




        }
    }
}
