using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ManagementSoftware.Models
{
    [Table("ExportedWareHouse")]
    public class ExportedWareHouse
    {
        public int ExportedWareHouseID { get; set; }
        public string Exporter { get; set; }
        public int Amount { get; set; }
        public DateTime CreateAt { get; set; }
        public int ProductID { get; set; }
        public Product Product { get; set; }

    }
}
