using ManagementSoftware.DAL;
using ManagementSoftware.GUI;
using ManagementSoftware.Models;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.StartPanel;

namespace ManagementSoftware
{
    public class AlwaysCheckConnection
    {
        public System.Threading.Timer? timer = null;
        public PLCBeckhOff plc = new PLCBeckhOff();
        private DALUser dalUser = new DALUser();
        private DALUserWorking dalUserWorking = new DALUserWorking();

        Main? formMain;
        public AlwaysCheckConnection(Main? main)
        {
            this.formMain = main;
        }

        void ChangeTextTitleFormMain()
        {
            if (formMain != null && !formMain.IsDisposed)
            {
                if (formMain.IsHandleCreated && formMain.InvokeRequired)
                {
                    formMain.BeginInvoke(() => ChangeTextTitleFormMain());
                    return;
                }
                formMain.SetLabelHeaderUserPLC();
            }

        }


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

        private void Callback(Object state)
        {
            Stopwatch watch = new Stopwatch();

            watch.Start();

            // update data
            // Long running operation


            if (plc.CheckState() == true)
            {
                plc.WriteAVariableNumber(AddressPLC.DATA_PC_Trang_Thai_PC, true);

                bool? isLogIn = plc.ReadAVariableNumber<bool>(AddressPLC.DATA_PC_Dang_nhap_thanh_cong);

                //đăng nhập thành công, đã có usercurrent trên hệ thống
                if (isLogIn != null && isLogIn == true && Common.UserCurrent != null)
                {
                    dalUserWorking.UpdateEndAt(Common.UserCurrent.UserWorkingID);
                }
                //chưa đăng nhập, chưa có usercurrent trên hệ thống
                else if (isLogIn != null /*&& isLogIn == false*/ && Common.UserCurrent == null)
                {
                    string? taiKhoan = plc.ReadAVariableString(AddressPLC.DATA_PC_Tai_Khoan);
                    string? matKhau = plc.ReadAVariableString(AddressPLC.DATA_PC_Mat_khau);

                    if (taiKhoan != null && matKhau != null)
                    {
                        User? user;
                        if (Common.listAllUser != null && Common.listAllUser.Count > 0)
                        {
                            user = Common.listAllUser.FirstOrDefault(u => u.Username.ToLower() == taiKhoan.ToLower() && u.Password.ToLower() == matKhau.ToLower());
                        }
                        else
                        {
                            user = dalUser.AuthLogin(taiKhoan, matKhau);
                        }

                        //trả kết quả về plc
                        if (user != null)
                        {

                            UserWorking userWorking = new UserWorking() { Username = user.Username, Fullname = user.FullName };
                            UserWorking? userWorkingAdded = dalUserWorking.Add(userWorking);
                            if (userWorkingAdded != null)
                            {
                                Common.UserCurrent = userWorkingAdded;
                                plc.WriteAVariableNumber(AddressPLC.DATA_PC_Dang_nhap_thanh_cong, true);
                                ChangeTextTitleFormMain();
                            }
                            else
                            {
                                Common.UserCurrent = null;
                                ChangeTextTitleFormMain();
                            }

                        }
                        else
                        {
                            Common.UserCurrent = null;
                            ChangeTextTitleFormMain();

                        }
                    }
                    else
                    {
                        Common.UserCurrent = null;
                        ChangeTextTitleFormMain();
                    }

                }
                else
                {
                    Common.UserCurrent = null;
                    ChangeTextTitleFormMain();
                }

            }
            else
            {
                Common.UserCurrent = null;
                ChangeTextTitleFormMain();
            }



            if (timer != null)
            {
                timer.Change(Math.Max(0, 1000 - watch.ElapsedMilliseconds), Timeout.Infinite);
            }
        }

    }
}
