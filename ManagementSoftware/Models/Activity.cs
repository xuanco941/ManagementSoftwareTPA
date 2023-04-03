using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ManagementSoftware.Models
{
    [Table("Activity")]
    public class Activity
    {
        [Key]
        public int ActivityID { get; set; }
        public string? Title { get; set; }
        public string? Description { get; set; }
        public DateTime CreateAt { get; set; }
        public string? Username { get; set; } = "";
        public int UserID { get; set; }


    }
}
