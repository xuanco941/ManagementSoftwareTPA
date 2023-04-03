﻿using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ManagementSoftware.Models
{
    [Table("Result")]
    public class Result
    {
        [Key]
        public int ResultID { get; set; }
        public double ApSuatTong { get; set; }
        public string LoaiKhi { get; set; }
        public DateTime TimeStart { get; set; }
        public DateTime TimeEnd { get; set; }
        public bool Status { get; set; }

        //người vận hành
        public int UserID { get; set; }
        public string Username { get; set; } = Common.UserAdmin.Username;

        //thông số cài đặt
        public double TheTichCanNap { get; set; }
        public double TheTichTieuChuan { get; set; }
        public double ApSuatTieuChuan { get; set; }
        public double HeSoTieuChuan { get; set; }
        public DateTime ThoiGianTrichMau { get; set; }
        public int SoLuongBinhCanNapHe1 { get; set; }
        public int SoLuongBinhCanNapHe2 { get; set; }




    }
}
