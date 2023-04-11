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
    public partial class HeNap : Form
    {
        TheoDoiHeNap heNap1;
        TheoDoiHeNap heNap2;
        public HeNap()
        {
            InitializeComponent();
            heNap1 = new TheoDoiHeNap(AddressPLC.DATA_PC_PC_ong_H1, AddressPLC.DATA_PC_ST_Run_Nap_H1,
                AddressPLC.DATA_PC_Van_Cap_H1, AddressPLC.DATA_PC_Van_Xa_H1, AddressPLC.DATA_PC_ST_Xa_Khi_H1, AddressPLC.DATA_PC_Motor_BT1_Vao,
                AddressPLC.DATA_PC_Motor_BT1_Nap1, AddressPLC.DATA_PC_Motor_BT1_Nap2, AddressPLC.DATA_PC_Motor_BT1_Ra, AddressPLC.DATA_PC_CB_PL_VT_Cap1,
                AddressPLC.DATA_PC_CB_PL_qua_Vtcap1, AddressPLC.DATA_PC_CB_PL_cuoi_Btvao1, AddressPLC.DATA_PC_CB_RunBT_Nap1_1, AddressPLC.DATA_PC_CB_StopBT_Nap1_1,
                AddressPLC.DATA_PC_CB_RunBT_Nap1_2, AddressPLC.DATA_PC_CB_StopBT_Nap1_2, AddressPLC.DATA_PC_CB_co_PL_Ra1, AddressPLC.DATA_PC_CB_PL_den_VTRa1, AddressPLC.DATA_PC_CB_CB_PL_VT_Lay1
                , AddressPLC.DATA_PC_GT_AS_Tong, AddressPLC.DATA_PC_GT_AS_ST_H1);
            heNap2 = new TheoDoiHeNap(AddressPLC.DATA_PC_PC_ong_H2, AddressPLC.DATA_PC_ST_Run_Nap_H2,
                AddressPLC.DATA_PC_Van_Cap_H2, AddressPLC.DATA_PC_Van_Xa_H2, AddressPLC.DATA_PC_ST_Xa_Khi_H2, AddressPLC.DATA_PC_Motor_BT2_Vao,
                AddressPLC.DATA_PC_Motor_BT2_Nap1, AddressPLC.DATA_PC_Motor_BT2_Nap2, AddressPLC.DATA_PC_Motor_BT2_Ra, AddressPLC.DATA_PC_CB_PL_VT_Cap2,
                AddressPLC.DATA_PC_CB_PL_qua_Vtcap2, AddressPLC.DATA_PC_CB_PL_cuoi_Btvao2, AddressPLC.DATA_PC_CB_RunBT_Nap2_1, AddressPLC.DATA_PC_CB_StopBT_Nap2_1,
                AddressPLC.DATA_PC_CB_RunBT_Nap2_2, AddressPLC.DATA_PC_CB_StopBT_Nap2_2, AddressPLC.DATA_PC_CB_co_PL_Ra2, AddressPLC.DATA_PC_CB_PL_den_VTRa2, AddressPLC.DATA_PC_CB_CB_PL_VT_Lay2
                , AddressPLC.DATA_PC_GT_AS_Tong, AddressPLC.DATA_PC_GT_AS_ST_H2);
            this.FormBorderStyle = FormBorderStyle.FixedSingle;
        }

        private void HeNap_Load(object sender, EventArgs e)
        {

            new MethodCommonGUI().ShowFormOnTabPage(tabPage1, heNap1);
            new MethodCommonGUI().ShowFormOnTabPage(tabPage2, heNap2);
            heNap1.StartUpdate();
            heNap2.StartUpdate();

        }

        private void HeNap_FormClosing(object sender, FormClosingEventArgs e)
        {
            heNap1.StopUpdate();
            heNap2.StopUpdate();
            if (IsHandleCreated && InvokeRequired)
            {
                BeginInvoke(new Action(() =>
                {
                    heNap1.Close();
                    heNap2.Close();
                }));

            }
            else
            {
                heNap1.Close();
                heNap2.Close();
            }

        }
    }
}
