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
        public double ApSuatMin { get; set; }
        public double ApSuatMax { get; set; }
        public double ApSuatAvg { get; set; }
        public double TheTichMin { get; set; }
        public double TheTichMax { get; set; }
        public double TheTichAvg { get; set; }
        public double LuuLuongMin { get; set; }
        public double LuuLuongMax { get; set; }
        public double LuuLuongAvg { get; set; }
        public DateTime TimeStart { get; set; }
        public DateTime TimeEnd { get; set; }
        public string NameMachine { get; set; }
        public string Worker { get; set; }
        public bool Status { get; set; }
        public Result()
        {
        }
    }
}
