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

                dalMachine.AddRange(new List<Machine>() { new Machine() { CreateAt = now, NameMachine = Common.GianNap1, ApSuat = apSuatHe1, TheTich = theTichHe1, ApSuatTong = apSuatTong, ResultID = Common.ResultCurrent.ResultID },
                    new Machine() { CreateAt = now, NameMachine = Common.GianNap2, ApSuat = apSuatHe2, TheTich = theTichHe2, ApSuatTong = apSuatTong, ResultID = Common.ResultCurrent.ResultID } });

            }


            watch.Stop();

            if (timer != null)
            {
                timer.Change(Math.Max(0, 300000 - watch.ElapsedMilliseconds), Timeout.Infinite);
            }
        }
       
    }
}
