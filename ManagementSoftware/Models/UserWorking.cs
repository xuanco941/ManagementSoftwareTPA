using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ManagementSoftware.Models
{
    public class UserWorking
    {
        [Key]
        public int UserWorkingID { get; set; }
        public DateTime TimeStart { get; set; }
        public DateTime TimeEnd { get; set; }
        public int ProductionNumber { get; set; }
        public string? ProductName { get; set; } = "";
        public int UserID { get; set; }
        public User User { get; set; }

    }
}
