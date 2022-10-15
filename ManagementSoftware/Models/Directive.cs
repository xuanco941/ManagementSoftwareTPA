using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ManagementSoftware.Models
{
    [Table("Directive")]
    public class Directive
    {
        [Key]
        public int DirectiveID { get; set; }
        public int SoLuongDaSanXuat { get; set; }
        public int SoLuongCanSanXuat { get; set; }
        //người vận hành
        public string UsernameWorker { get; set; }
        public bool Status { get; set; }
        public DateTime CreateAt { get; set; }
        public DateTime EndAt { get; set; }

        public int ProductID { get; set; }
        public Product Product { get; set; }
    }
}
