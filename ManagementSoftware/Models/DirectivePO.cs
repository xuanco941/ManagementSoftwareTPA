using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ManagementSoftware.Models
{
    [Table("DirectivePO")]
    public class DirectivePO
    {
        [Key]
        public int DirectivePOID { get; set; }
        public string Barcode { get; set; }

        public double ApSuat { get; set; }
        public double TheTich { get; set; }
        public string LoaiKhi { get; set; }
        public string? ChatLuongKhi { get; set; }

        public string? Description { get; set; }
        public string? DVT { get; set; }
        public int Quantity { get; set; }
        public uint UnitPrice { get; set; }
        public uint Amount { get; set; }
        public DateTime CreateAt { get; set; }
        //người vận hành
        public string? Username { get; set; }
        public bool Status { get; set; }
        //kho
        public bool IsImported { get; set; }
        public bool IsExported { get; set; }
        public int PurchaseOrderID { get; set; }
        public PurchaseOrder PurchaseOrder { get; set; }
    }
}
