using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace ManagementSoftware.GUI
{
    public class TimerUpdateGUI
    {
        public System.Threading.Timer? timer = null;
        private int dueTimeInit = 1000;
        private int dueTimeChange = 1000;
        public delegate Task DelegateGetDataAndUpdateGUI();
        private DelegateGetDataAndUpdateGUI delegateUpdateGUI;

        public TimerUpdateGUI(int dueTimeInit, int dueTimeChange, DelegateGetDataAndUpdateGUI myDelegate)
        {
            this.dueTimeInit = dueTimeInit;
            this.dueTimeChange = dueTimeChange;
            this.delegateUpdateGUI = myDelegate;
        }

        public void StartTimer(bool isStop)
        {
            if (timer == null)
            {
                if (isStop == true)
                {
                    timer = new System.Threading.Timer(CallbackStop, null, dueTimeInit, Timeout.Infinite);
                }
                else
                {
                    timer = new System.Threading.Timer(CallbackNoStop, null, dueTimeInit, Timeout.Infinite);
                }
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

        private void CallbackStop(Object state)
        {
            Stopwatch watch = new Stopwatch();

            watch.Start();


            // update data
            // Long running operation
            delegateUpdateGUI.Invoke();


            watch.Stop();
            if (timer != null)
            {
                timer.Change(Math.Max(0, dueTimeChange - watch.ElapsedMilliseconds), Timeout.Infinite);
            }
        }
        private void CallbackNoStop(Object state)
        {
            Stopwatch watch = new Stopwatch();

            watch.Start();


            // update data
            // Long running operation
            delegateUpdateGUI.Invoke();


            if (timer != null)
            {
                timer.Change(Math.Max(0, dueTimeChange - watch.ElapsedMilliseconds), Timeout.Infinite);
            }
        }
    }
}
