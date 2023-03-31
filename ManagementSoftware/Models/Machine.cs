﻿using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ManagementSoftware.Models
{
    [Table("Machine")]
    public class Machine
    {
        [Key]
        public int MachineID { get; set; }
        public double ApSuat { get; set; }
        public double TheTich { get; set; }
        public string NameMachine { get; set; } = "Hệ Nạp 1";
        public int ResultID { get; set; }
        public Result Result { get; set; }

    }
}
