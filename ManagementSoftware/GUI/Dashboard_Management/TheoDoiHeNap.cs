using ManagementSoftware.GUI.Dashboard_Management;
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

namespace ManagementSoftware.GUI
{
    public partial class TheoDoiHeNap : Form
    {
        MethodUpdateStatusTheoDoiHeNap methodUpdate;
        public TheoDoiHeNap(string DATA_PC_PC_RunSYS, string DATA_PCPC_ong_H1, string DATA_PCST_Run_Nap_H1, string DATA_PCVan_Cap_H1, string DATA_PCVan_Xa_H1,
        string DATA_PCST_Xa_Khi_H1, string DATA_PCMotor_BT1_Vao, string DATA_PCMotor_BT1_Nap1, string DATA_PCMotor_BT1_Nap2,
        string DATA_PCMotor_BT1_Ra, string DATA_PCCB_PL_VT_Cap1, string DATA_PCCB_PL_qua_Vtcap1, string DATA_PCCB_PL_cuoi_Btvao1, string DATA_PCCB_RunBT_Nap1_1,
        string DATA_PCCB_StopBT_Nap1_1, string DATA_PCCB_RunBT_Nap1_2, string DATA_PCCB_StopBT_Nap1_2, string DATA_PCCB_co_PL_Ra1, string DATA_PCCB_PL_den_VTRa1, string DATA_PCCB_CB_PL_VT_Lay1, string apSuatTong, string apSuatHe)
        {
            InitializeComponent();

            this.CB1.Image = Resources.SensorXam;
            this.CB2.Image = Resources.SensorXam;
            this.CB3.Image = Resources.SensorXam;
            this.CB4.Image = Resources.SensorXam;
            this.CB5.Image = Resources.SensorXam;
            this.CB6.Image = Resources.SensorXam;
            this.CB7.Image = Resources.SensorXam;
            this.CB8.Image = Resources.SensorXam;
            this.CB9.Image = Resources.SensorXam;
            this.CB10.Image = Resources.SensorXam;

            methodUpdate = new MethodUpdateStatusTheoDoiHeNap(this, DauOng, textBoxASTong, textBoxASHeNap, ong1, ong2, RunNap, VanCap, VanXa, OngXa, BangTai1, Motor1, BangTai2, Motor2, BangTai3, Motor3, BangTai4, Motor4, CB1, CB2, CB3, CB4, CB5, CB6, CB7, CB8, CB9, CB10,
             DATA_PC_PC_RunSYS,    DATA_PCPC_ong_H1, DATA_PCST_Run_Nap_H1, DATA_PCVan_Cap_H1, DATA_PCVan_Xa_H1,
         DATA_PCST_Xa_Khi_H1, DATA_PCMotor_BT1_Vao, DATA_PCMotor_BT1_Nap1, DATA_PCMotor_BT1_Nap2,
         DATA_PCMotor_BT1_Ra, DATA_PCCB_PL_VT_Cap1, DATA_PCCB_PL_qua_Vtcap1, DATA_PCCB_PL_cuoi_Btvao1, DATA_PCCB_RunBT_Nap1_1,
         DATA_PCCB_StopBT_Nap1_1, DATA_PCCB_RunBT_Nap1_2, DATA_PCCB_StopBT_Nap1_2, DATA_PCCB_co_PL_Ra1, DATA_PCCB_PL_den_VTRa1, DATA_PCCB_CB_PL_VT_Lay1, apSuatTong, apSuatHe);
        }


        public void StartUpdate()
        {
            methodUpdate.StartUpdate();
        }
        public void StopUpdate()
        {
            methodUpdate.StopUpdate();
        }

        private void TheoDoiHeNap_FormClosing(object sender, FormClosingEventArgs e)
        {
            methodUpdate.StopUpdate();
        }
    }
}
