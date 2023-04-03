using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ManagementSoftware.Models
{
    [Table("UserWorking")]
    public class UserWorking
    {
        [Key]
        public int UserWorkingID { get; set; }
        public DateTime CreateAt { get; set; }
        public DateTime EndAt { get; set; }
        public int UserID { get; set; }
        public string Username { get; set; } = "";
        public string Fullname { get; set; } = "";
    }
}
