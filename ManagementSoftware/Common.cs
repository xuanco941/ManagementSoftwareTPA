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
        //GUI
        public static Font FontForm = new Font("Segoe UI", 11, FontStyle.Regular);
        public static Font FontHeaderColumnDGV = new Font("Segoe UI", 12, FontStyle.Regular);

        //Connect
        public static string ConnectionString = @"Data Source=DESKTOP-P4IC2M8\SQLEXPRESS;Initial Catalog=ManagementSoftwareTPA;User ID=sa;Password=942001xX";
        public const string LicenseSyncfusion = "NzE5NjE0QDMyMzAyZTMyMmUzMFlqaFh1Qk9GKytyNHNaaE16dktXZFg0cERMU2Qvai9KQmdEYUZSL0U4OE09";

        //App
        public static User? USERSESSION { get; set; } = null;
        public static int NumberRows = 40;

        //Key ID
        //User
        public const string USERS = "NV";
        public const string GROUPS = "GR";
        public const string ACTIVITIES = "A";

    }
}
