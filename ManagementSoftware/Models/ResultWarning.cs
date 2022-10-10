using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ManagementSoftware.Models
{
    [Table("ResultWarning")]
    public class ResultWarning
    {
        [Key]
        public int ResultWarningID { get; set; }
        public string Description { get; set; }
        public int ResultID { get; set; }
        public Result Result { get; set; }
    }
}
