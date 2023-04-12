using ManagementSoftware.Models;
using ManagementSoftware.GUI;
using System.Diagnostics;
using ManagementSoftware.DAL;

namespace ManagementSoftware
{
    internal static class Program
    {
        /// <summary>
        ///  The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            // To customize application configuration such as set high DPI settings or default font,
            // see https://aka.ms/applicationconfiguration.

            ApplicationConfiguration.Initialize();

            //Syncfusion
            Syncfusion.Licensing.SyncfusionLicenseProvider.RegisterLicense(Common.LicenseSyncfusion);

            var path = Path.Combine(Directory.GetCurrentDirectory(), "ConnectStringDB.txt");
            string text = File.ReadAllText(path);
            Common.ConnectionString = text;




            

            using (var context = new DataBaseContext())
            {
                if (context.CheckDatabaseExists() == false)
                {
                    if (context.CreateDatabase() == false)
                    {
                        MessageBox.Show("Lỗi khởi tạo cơ sở dữ liệu, hãy thử xem lại đường dẫn kết nối của bạn.", "Lỗi kết nối", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }

            }


            try
            {
                Common.listAllUser = new DALUser().GetAll();
            }
            catch
            {

            }



            Application.Run(new Login());

            if (Common.USERSESSION != null)
            {
                Common.TenHeNap = "Oxy";
                Main main = new Main();

                AlwaysCheckConnection alwaysCheckConnection = new AlwaysCheckConnection(main);
                alwaysCheckConnection.ConnectPLC();
                alwaysCheckConnection.StartTimer();


                AlwaysCheckResult alwaysCheckResult = new AlwaysCheckResult();
                alwaysCheckResult.ConnectPLC();
                alwaysCheckResult.StartTimer();

                AlwaysCheckAddMachine alwaysCheckAddMachine = new AlwaysCheckAddMachine();
                alwaysCheckAddMachine.ConnectPLC();
                alwaysCheckAddMachine.StartTimer();


                Application.Run(main);

                   
            }
        }
    }
}