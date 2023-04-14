using ManagementSoftware.DAL;
using ManagementSoftware.Models;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ManagementSoftware
{
    public class AlwaysCheckAddMachine
    {
        public System.Threading.Timer? timer = null;
        public PLCBeckhOff plc = new PLCBeckhOff();

        private DALMachine dalMachine = new DALMachine();

        public AlwaysCheckAddMachine()
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

        private async void Callback(Object state)
        {
            Stopwatch watch = new Stopwatch();

            watch.Start();

            // update data
            // Long running operation

            if (plc.CheckState() && Common.ResultCurrent != null)
            {
                int id = Common.ResultCurrent.ResultID;
                DateTime now = DateTime.Now;

                float? apSuatTong = 0;
                float? apSuatHe1 = 0;
                float? theTichHe1 = 0;
                float? apSuatHe2 = 0;
                float? theTichHe2 = 0;

                apSuatTong = await Task.Run(() => plc.ReadAVariableNumber<float>(AddressPLC.DATA_PC_GT_AS_Tong));
                apSuatHe1 = await Task.Run(() => plc.ReadAVariableNumber<float>(AddressPLC.DATA_PC_GT_AS_ST_H1));
                theTichHe1 = await Task.Run(() => plc.ReadAVariableNumber<float>(AddressPLC.DATA_PC_GT_V_ST_H1));
                apSuatHe2 = await Task.Run(() => plc.ReadAVariableNumber<float>(AddressPLC.DATA_PC_GT_AS_ST_H2));
                theTichHe2 = await Task.Run(() => plc.ReadAVariableNumber<float>(AddressPLC.DATA_PC_GT_V_ST_H2));


                if (apSuatTong == null || apSuatTong == float.PositiveInfinity)
                {
                    apSuatTong = 0;
                }
                if (apSuatHe1 == null || apSuatHe1 == float.PositiveInfinity)
                {
                    apSuatHe1 = 0;
                }
                if (apSuatHe2 == null || apSuatHe2 == float.PositiveInfinity)
                {
                    apSuatHe2 = 0;
                }
                if (theTichHe1 == null || theTichHe1 == float.PositiveInfinity)
                {
                    theTichHe1 = 0;
                }
                if (theTichHe2 == null || theTichHe2 == float.PositiveInfinity)
                {
                    theTichHe2 = 0;
                }


                dalMachine.AddRange(new List<Machine>() { new Machine() { CreateAt = now, NameMachine = Common.GianNap1, ApSuat = Math.Round( (double)apSuatHe1,2,MidpointRounding.AwayFromZero), TheTich = Math.Round( (double)theTichHe1,2,MidpointRounding.AwayFromZero), ApSuatTong = Math.Round( (double)apSuatTong,2,MidpointRounding.AwayFromZero), ResultID = id },
                    new Machine() { CreateAt = now, NameMachine = Common.GianNap2, ApSuat = Math.Round( (double)apSuatHe2,2,MidpointRounding.AwayFromZero), TheTich = Math.Round( (double)theTichHe2,2,MidpointRounding.AwayFromZero), ApSuatTong = Math.Round( (double)apSuatTong,2,MidpointRounding.AwayFromZero), ResultID = id } });
            }


            watch.Stop();

            if (timer != null)
            {
                timer.Change(Math.Max(0, 300000 - watch.ElapsedMilliseconds), Timeout.Infinite);
            }
        }

    }
}
