using System;
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
        public DateTime TimeStart { get; set; }
        public DateTime TimeEnd { get; set; }
        public int ProductionNumber { get; set; }
        public bool Status { get; set; }
        public string Username { get; set; } = Common.UserAdmin.Username;
        public int? UserID { get; set; }
        public User? User { get; set; }

    }
}
