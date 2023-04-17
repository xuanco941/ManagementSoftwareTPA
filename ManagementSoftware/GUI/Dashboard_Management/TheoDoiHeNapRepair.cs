using ManagementSoftware.Properties;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ManagementSoftware.GUI.Dashboard_Management
{
    public partial class TheoDoiHeNapRepair : Form
    {
        TimerUpdateGUI timerUpdateGUI;
        PLCBeckhOff plc = new PLCBeckhOff();

        public TheoDoiHeNapRepair()
        {
            InitializeComponent();
            this.FormBorderStyle = FormBorderStyle.FixedSingle;
            timerUpdateGUI = new TimerUpdateGUI(500, 900, UpdateData);
        }


        private async Task UpdateData()
        {
            if (plc.CheckState() == false)
            {
                timerUpdateGUI.StopTimer();
                return;
            }
            // call data
            //// adrress 1
            //bool? DATA_PCPC_ong_H1_BOOL = false;
            //bool? DATA_PCST_Run_Nap_H1_BOOL = false;
            //bool? DATA_PCVan_Cap_H1_BOOL = false;
            //bool? DATA_PCVan_Xa_H1_BOOL = false;
            //bool? DATA_PCST_Xa_Khi_H1_BOOL = false;
            //bool? DATA_PCMotor_BT1_Vao_BOOL = false;
            //bool? DATA_PCMotor_BT1_Nap1_BOOL = false;
            //bool? DATA_PCMotor_BT1_Nap2_BOOL = false;
            //bool? DATA_PCMotor_BT1_Ra_BOOL = false;
            //bool? DATA_PCCB_PL_VT_Cap1_BOOL = false;
            //bool? DATA_PCCB_PL_qua_Vtcap1_BOOL = false;
            //bool? DATA_PCCB_PL_cuoi_Btvao1_BOOL = false;
            //bool? DATA_PCCB_RunBT_Nap1_1_BOOL = false;
            //bool? DATA_PCCB_StopBT_Nap1_1_BOOL = false;
            //bool? DATA_PCCB_RunBT_Nap1_2_BOOL = false;
            //bool? DATA_PCCB_StopBT_Nap1_2_BOOL = false;
            //bool? DATA_PCCB_co_PL_Ra1_BOOL = false;
            //bool? DATA_PCCB_PL_den_VTRa1_BOOL = false;
            //bool? DATA_PCCB_CB_PL_VT_Lay1_BOOL = false;

            //bool? DATA_PC_PC_RunSYS_BOOL = false;

            //// adrress 2
            //bool? DATA_PCPC_ong_H1_BOOL2 = false;
            //bool? DATA_PCST_Run_Nap_H1_BOOL2 = false;
            //bool? DATA_PCVan_Cap_H1_BOOL2 = false;
            //bool? DATA_PCVan_Xa_H1_BOOL2 = false;
            //bool? DATA_PCST_Xa_Khi_H1_BOOL2 = false;
            //bool? DATA_PCMotor_BT1_Vao_BOOL2 = false;
            //bool? DATA_PCMotor_BT1_Nap1_BOOL2 = false;
            //bool? DATA_PCMotor_BT1_Nap2_BOOL2 = false;
            //bool? DATA_PCMotor_BT1_Ra_BOOL2 = false;
            //bool? DATA_PCCB_PL_VT_Cap1_BOOL2 = false;
            //bool? DATA_PCCB_PL_qua_Vtcap1_BOOL2 = false;
            //bool? DATA_PCCB_PL_cuoi_Btvao1_BOOL2 = false;
            //bool? DATA_PCCB_RunBT_Nap1_1_BOOL2 = false;
            //bool? DATA_PCCB_StopBT_Nap1_1_BOOL2 = false;
            //bool? DATA_PCCB_RunBT_Nap1_2_BOOL2 = false;
            //bool? DATA_PCCB_StopBT_Nap1_2_BOOL2 = false;
            //bool? DATA_PCCB_co_PL_Ra1_BOOL2 = false;
            //bool? DATA_PCCB_PL_den_VTRa1_BOOL2 = false;
            //bool? DATA_PCCB_CB_PL_VT_Lay1_BOOL2 = false;







            //

            bool? DATA_PCPC_ong_H1_BOOL = await Task.Run(() => plc.ReadAVariableNumber<bool>(AddressPLC.DATA_PC_PC_ong_H1));
            bool? DATA_PCST_Run_Nap_H1_BOOL = await Task.Run(() => plc.ReadAVariableNumber<bool>(AddressPLC.DATA_PC_ST_Run_Nap_H1));
            bool? DATA_PCVan_Cap_H1_BOOL = await Task.Run(() => plc.ReadAVariableNumber<bool>(AddressPLC.DATA_PC_Van_Cap_H1));
            bool? DATA_PCVan_Xa_H1_BOOL = await Task.Run(() => plc.ReadAVariableNumber<bool>(AddressPLC.DATA_PC_Van_Xa_H1));
            bool? DATA_PCST_Xa_Khi_H1_BOOL = await Task.Run(() => plc.ReadAVariableNumber<bool>(AddressPLC.DATA_PC_ST_Xa_Khi_H1));
            bool? DATA_PCMotor_BT1_Vao_BOOL = await Task.Run(() => plc.ReadAVariableNumber<bool>(AddressPLC.DATA_PC_Motor_BT1_Vao));
            bool? DATA_PCMotor_BT1_Nap1_BOOL = await Task.Run(() => plc.ReadAVariableNumber<bool>(AddressPLC.DATA_PC_Motor_BT1_Nap1));
            bool? DATA_PCMotor_BT1_Nap2_BOOL = await Task.Run(() => plc.ReadAVariableNumber<bool>(AddressPLC.DATA_PC_Motor_BT1_Nap2));
            bool? DATA_PCMotor_BT1_Ra_BOOL = await Task.Run(() => plc.ReadAVariableNumber<bool>(AddressPLC.DATA_PC_Motor_BT1_Ra));
            bool? DATA_PCCB_PL_VT_Cap1_BOOL = await Task.Run(() => plc.ReadAVariableNumber<bool>(AddressPLC.DATA_PC_CB_PL_VT_Cap1));
            bool? DATA_PCCB_PL_qua_Vtcap1_BOOL = await Task.Run(() => plc.ReadAVariableNumber<bool>(AddressPLC.DATA_PC_CB_PL_qua_Vtcap1));
            bool? DATA_PCCB_PL_cuoi_Btvao1_BOOL = await Task.Run(() => plc.ReadAVariableNumber<bool>(AddressPLC.DATA_PC_CB_PL_cuoi_Btvao1));
            bool? DATA_PCCB_RunBT_Nap1_1_BOOL = await Task.Run(() => plc.ReadAVariableNumber<bool>(AddressPLC.DATA_PC_CB_RunBT_Nap1_1));
            bool? DATA_PCCB_StopBT_Nap1_1_BOOL = await Task.Run(() => plc.ReadAVariableNumber<bool>(AddressPLC.DATA_PC_CB_StopBT_Nap1_1));
            bool? DATA_PCCB_RunBT_Nap1_2_BOOL = await Task.Run(() => plc.ReadAVariableNumber<bool>(AddressPLC.DATA_PC_CB_RunBT_Nap1_2));
            bool? DATA_PCCB_StopBT_Nap1_2_BOOL = await Task.Run(() => plc.ReadAVariableNumber<bool>(AddressPLC.DATA_PC_CB_StopBT_Nap1_2));

            bool? DATA_PCCB_co_PL_Ra1_BOOL = await Task.Run(() => plc.ReadAVariableNumber<bool>(AddressPLC.DATA_PC_CB_co_PL_Ra1));
            bool? DATA_PCCB_PL_den_VTRa1_BOOL = await Task.Run(() => plc.ReadAVariableNumber<bool>(AddressPLC.DATA_PC_CB_PL_den_VTRa1));
            bool? DATA_PCCB_CB_PL_VT_Lay1_BOOL = await Task.Run(() => plc.ReadAVariableNumber<bool>(AddressPLC.DATA_PC_CB_CB_PL_VT_Lay1));

            float? DATA_PCGT_AS_ST_H1_REAL = await Task.Run(() => plc.ReadAVariableNumber<float>(AddressPLC.DATA_PC_GT_AS_ST_H1));
            float? DATA_PCGT_AS_Tong_REAL = await Task.Run(() => plc.ReadAVariableNumber<float>(AddressPLC.DATA_PC_GT_AS_Tong));

            bool? DATA_PC_PC_RunSYS_BOOL = await Task.Run(() => plc.ReadAVariableNumber<bool>(AddressPLC.DATA_PC_PC_RunSYS));



            //



            bool? DATA_PCPC_ong_H1_BOOL2 = await Task.Run(() => plc.ReadAVariableNumber<bool>(AddressPLC.DATA_PC_PC_ong_H2));
            bool? DATA_PCST_Run_Nap_H1_BOOL2 = await Task.Run(() => plc.ReadAVariableNumber<bool>(AddressPLC.DATA_PC_ST_Run_Nap_H2));
            bool? DATA_PCVan_Cap_H1_BOOL2 = await Task.Run(() => plc.ReadAVariableNumber<bool>(AddressPLC.DATA_PC_Van_Cap_H2));
            bool? DATA_PCVan_Xa_H1_BOOL2 = await Task.Run(() => plc.ReadAVariableNumber<bool>(AddressPLC.DATA_PC_Van_Xa_H2));
            bool? DATA_PCST_Xa_Khi_H1_BOOL2 = await Task.Run(() => plc.ReadAVariableNumber<bool>(AddressPLC.DATA_PC_ST_Xa_Khi_H2));
            bool? DATA_PCMotor_BT1_Vao_BOOL2 = await Task.Run(() => plc.ReadAVariableNumber<bool>(AddressPLC.DATA_PC_Motor_BT2_Vao));
            bool? DATA_PCMotor_BT1_Nap1_BOOL2 = await Task.Run(() => plc.ReadAVariableNumber<bool>(AddressPLC.DATA_PC_Motor_BT2_Nap1));
            bool? DATA_PCMotor_BT1_Nap2_BOOL2 = await Task.Run(() => plc.ReadAVariableNumber<bool>(AddressPLC.DATA_PC_Motor_BT2_Nap2));
            bool? DATA_PCMotor_BT1_Ra_BOOL2 = await Task.Run(() => plc.ReadAVariableNumber<bool>(AddressPLC.DATA_PC_Motor_BT2_Ra));
            bool? DATA_PCCB_PL_VT_Cap1_BOOL2 = await Task.Run(() => plc.ReadAVariableNumber<bool>(AddressPLC.DATA_PC_CB_PL_VT_Cap2));
            bool? DATA_PCCB_PL_qua_Vtcap1_BOOL2 = await Task.Run(() => plc.ReadAVariableNumber<bool>(AddressPLC.DATA_PC_CB_PL_qua_Vtcap2));
            bool? DATA_PCCB_PL_cuoi_Btvao1_BOOL2 = await Task.Run(() => plc.ReadAVariableNumber<bool>(AddressPLC.DATA_PC_CB_PL_cuoi_Btvao2));
            bool? DATA_PCCB_RunBT_Nap1_1_BOOL2 = await Task.Run(() => plc.ReadAVariableNumber<bool>(AddressPLC.DATA_PC_CB_RunBT_Nap2_1));
            bool? DATA_PCCB_StopBT_Nap1_1_BOOL2 = await Task.Run(() => plc.ReadAVariableNumber<bool>(AddressPLC.DATA_PC_CB_StopBT_Nap2_1));
            bool? DATA_PCCB_RunBT_Nap1_2_BOOL2 = await Task.Run(() => plc.ReadAVariableNumber<bool>(AddressPLC.DATA_PC_CB_RunBT_Nap2_2));
            bool? DATA_PCCB_StopBT_Nap1_2_BOOL2 = await Task.Run(() => plc.ReadAVariableNumber<bool>(AddressPLC.DATA_PC_CB_StopBT_Nap2_2));

            bool? DATA_PCCB_co_PL_Ra1_BOOL2 = await Task.Run(() => plc.ReadAVariableNumber<bool>(AddressPLC.DATA_PC_CB_co_PL_Ra2));
            bool? DATA_PCCB_PL_den_VTRa1_BOOL2 = await Task.Run(() => plc.ReadAVariableNumber<bool>(AddressPLC.DATA_PC_CB_PL_den_VTRa2));
            bool? DATA_PCCB_CB_PL_VT_Lay1_BOOL2 = await Task.Run(() => plc.ReadAVariableNumber<bool>(AddressPLC.DATA_PC_CB_CB_PL_VT_Lay2));

            float? DATA_PCGT_AS_ST_H1_REAL2 = await Task.Run(() => plc.ReadAVariableNumber<float>(AddressPLC.DATA_PC_GT_AS_ST_H2));






















            //






            if (this.IsHandleCreated && this.InvokeRequired)
            {
                this.BeginInvoke(() =>
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

                    //update text apSuat
                    this.textBoxASTong.Text = DATA_PCGT_AS_Tong_REAL != null ? String.Format("{0:0.00}", DATA_PCGT_AS_Tong_REAL) : "";
                    this.textBoxASHeNap.Text = DATA_PCGT_AS_ST_H1_REAL != null ? String.Format("{0:0.00}", DATA_PCGT_AS_ST_H1_REAL) : "";

                    this.DauOng.Image = (DATA_PC_PC_RunSYS_BOOL != null && DATA_PC_PC_RunSYS_BOOL == true) ? Resources.DauOngXanh : Resources.DauOngXam;















                    //2


                    this.ong12.Image = (DATA_PCPC_ong_H1_BOOL2 != null && DATA_PCPC_ong_H1_BOOL2 == true) ? Resources.Ong1Xanh : Resources.Ong1Xam;
                    this.ong22.Image = (DATA_PCPC_ong_H1_BOOL2 != null && DATA_PCPC_ong_H1_BOOL2 == true) ? Resources.Ong2Xanh : Resources.Ong2Xam;

                    this.RunNap2.Image = (DATA_PCST_Run_Nap_H1_BOOL2 != null && DATA_PCST_Run_Nap_H1_BOOL2 == true) ? Resources.RunNapXanh : Resources.RunNapXam;

                    this.VanCap2.Image = (DATA_PCVan_Cap_H1_BOOL2 != null && DATA_PCVan_Cap_H1_BOOL2 == true) ? Resources.VanCapXanh : Resources.VanCapXam;
                    this.VanXa2.Image = (DATA_PCVan_Xa_H1_BOOL2 != null && DATA_PCVan_Xa_H1_BOOL2 == true) ? Resources.VanXaXanh : Resources.VanXaXam;

                    this.OngXa2.Image = (DATA_PCST_Xa_Khi_H1_BOOL2 != null && DATA_PCST_Xa_Khi_H1_BOOL2 == true) ? Resources.ongThoatXanh : Resources.ongThoatXam;

                    this.BangTai12.Image = (DATA_PCMotor_BT1_Vao_BOOL2 != null && DATA_PCMotor_BT1_Vao_BOOL2 == true) ? Resources.BangTaiXanh : Resources.BangTaiXam;
                    this.Motor12.Image = (DATA_PCMotor_BT1_Vao_BOOL2 != null && DATA_PCMotor_BT1_Vao_BOOL2 == true) ? Resources.MotorXanh : Resources.MotorXam;

                    this.BangTai22.Image = (DATA_PCMotor_BT1_Nap1_BOOL2 != null && DATA_PCMotor_BT1_Nap1_BOOL2 == true) ? Resources.BangTaiXanh : Resources.BangTaiXam;
                    this.Motor22.Image = (DATA_PCMotor_BT1_Nap1_BOOL2 != null && DATA_PCMotor_BT1_Nap1_BOOL2 == true) ? Resources.MotorXanh : Resources.MotorXam;

                    this.BangTai32.Image = (DATA_PCMotor_BT1_Nap2_BOOL2 != null && DATA_PCMotor_BT1_Nap2_BOOL2 == true) ? Resources.BangTaiXanh : Resources.BangTaiXam;
                    this.Motor32.Image = (DATA_PCMotor_BT1_Nap2_BOOL2 != null && DATA_PCMotor_BT1_Nap2_BOOL2 == true) ? Resources.MotorXanh : Resources.MotorXam;

                    this.BangTai42.Image = (DATA_PCMotor_BT1_Ra_BOOL2 != null && DATA_PCMotor_BT1_Ra_BOOL2 == true) ? Resources.BangTaiXanh : Resources.BangTaiXam;
                    this.Motor42.Image = (DATA_PCMotor_BT1_Ra_BOOL2 != null && DATA_PCMotor_BT1_Ra_BOOL2 == true) ? Resources.MotorXanh : Resources.MotorXam;

                    this.CB12.Image = (DATA_PCCB_PL_VT_Cap1_BOOL2 != null && DATA_PCCB_PL_VT_Cap1_BOOL2 == true) ? Resources.SensorXanh : Resources.SensorXam;
                    this.CB22.Image = (DATA_PCCB_PL_qua_Vtcap1_BOOL2 != null && DATA_PCCB_PL_qua_Vtcap1_BOOL2 == true) ? Resources.SensorXanh : Resources.SensorXam;
                    this.CB32.Image = (DATA_PCCB_PL_cuoi_Btvao1_BOOL2 != null && DATA_PCCB_PL_cuoi_Btvao1_BOOL2 == true) ? Resources.SensorXanh : Resources.SensorXam;
                    this.CB42.Image = (DATA_PCCB_RunBT_Nap1_1_BOOL2 != null && DATA_PCCB_RunBT_Nap1_1_BOOL2 == true) ? Resources.SensorXanh : Resources.SensorXam;
                    this.CB52.Image = (DATA_PCCB_StopBT_Nap1_1_BOOL2 != null && DATA_PCCB_StopBT_Nap1_1_BOOL2 == true) ? Resources.SensorXanh : Resources.SensorXam;
                    this.CB62.Image = (DATA_PCCB_RunBT_Nap1_2_BOOL2 != null && DATA_PCCB_RunBT_Nap1_2_BOOL2 == true) ? Resources.SensorXanh : Resources.SensorXam;
                    this.CB72.Image = (DATA_PCCB_StopBT_Nap1_2_BOOL2 != null && DATA_PCCB_StopBT_Nap1_2_BOOL2 == true) ? Resources.SensorXanh : Resources.SensorXam;
                    this.CB82.Image = (DATA_PCCB_co_PL_Ra1_BOOL2 != null && DATA_PCCB_co_PL_Ra1_BOOL2 == true) ? Resources.SensorXanh : Resources.SensorXam;
                    this.CB92.Image = (DATA_PCCB_PL_den_VTRa1_BOOL2 != null && DATA_PCCB_PL_den_VTRa1_BOOL2 == true) ? Resources.SensorXanh : Resources.SensorXam;
                    this.CB102.Image = (DATA_PCCB_CB_PL_VT_Lay1_BOOL2 != null && DATA_PCCB_CB_PL_VT_Lay1_BOOL2 == true) ? Resources.SensorXanh : Resources.SensorXam;

                    //update text apSuat
                    this.textBoxASTong2.Text = DATA_PCGT_AS_Tong_REAL != null ? String.Format("{0:0.00}", DATA_PCGT_AS_Tong_REAL) : "";
                    this.textBoxASHeNap2.Text = DATA_PCGT_AS_ST_H1_REAL2 != null ? String.Format("{0:0.00}", DATA_PCGT_AS_ST_H1_REAL2) : "";

                    this.DauOng2.Image = (DATA_PC_PC_RunSYS_BOOL != null && DATA_PC_PC_RunSYS_BOOL == true) ? Resources.DauOngXanh : Resources.DauOngXam;



























                });
            }















        }












        private async void TheoDoiHeNapRepair_FormClosing(object sender, FormClosingEventArgs e)
        {
            await Task.Run(() =>
            {
                timerUpdateGUI.StopTimer();
                plc.Disconnect();
            });
        }

        private void TheoDoiHeNapRepair_Load(object sender, EventArgs e)
        {
            if (plc.Connect() == true)
            {
                timerUpdateGUI.StartTimer(false);
            }
        }
    }
}
