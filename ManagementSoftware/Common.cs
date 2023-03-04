﻿using ManagementSoftware.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ManagementSoftware
{
    public class Common
    {
        //Account Admin
        public static User UserAdmin = new User("Admin","admin","123",1);
        public static Group GroupAdmin = new Group("Admin", true, true);

        //GUI
        public static Font FontForm = new Font("Segoe UI", 11, FontStyle.Regular);
        public static Font FontHeaderColumnDGV = new Font("Segoe UI", 12, FontStyle.Regular);

        //Connect
        public static string ConnectionString = @"Data Source=DESKTOP-NU3N490\SQLEXPRESS;Initial Catalog=ManagementSoftwareTPA;User ID=sa;Password=123;Encrypt=True;TrustServerCertificate=True";

        public const string LicenseSyncfusion = "NzE5NjE0QDMyMzAyZTMyMmUzMFlqaFh1Qk9GKytyNHNaaE16dktXZFg0cERMU2Qvai9KQmdEYUZSL0U4OE09";

        //App
        public static User? USERSESSION { get; set; } = null;
        public static int NumberRows = 40;
        public static int NumberRowsFormPurchaseOrder = 10;

        //Key ID
        //User
        public const string USERS = "NV";
        public const string GROUPS = "GR";
        public const string ACTIVITIES = "A";
        public const string PURCHASEORDER = "PO";
        public const string PRODUCT = "SP";
        public const string DIRECTIVE = "CT";
        public const string IMPORTED_WAREHOUSE = "PN";
        public const string EXPORTED_WAREHOUSE = "PX";

    }
}
