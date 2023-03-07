using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ManagementSoftware.Models
{
    [Table("ImportedWarehouse")]
    public class ImportedWarehouse
    {
        public int ImportedWarehouseID { get; set; }
        public string Importer { get; set; }
        public int Amount { get; set; }
        public string BarCode { get; set; }
        public DateTime DateAdded { get; set; }
        public DateTime CreateAt { get; set; }
        public int DirectiveID { get; set; }
        public Directive Directive { get; set; }
    }
}
