using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ManagementSoftware.Models
{
    [Table("DataResult")]
    public class DataResult
    {
        [Key]
        public int DataResultID { get; set; }
        public double ApSuat { get; set; }
        public double TheTich { get; set; }
        public double LuuLuong { get; set; }
        public DateTime CreateAt { get; set; }
        public int ResultID { get; set; }
        public Result Result { get; set; }



    }
}
