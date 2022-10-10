using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ManagementSoftware.Models
{
    [Table("PurchaseOrder")]
    public class PurchaseOrder
    {
        [Key]
        public int PurchaseOrderID { get; set; }
        public int? SoPRPQ { get; set; }
        //tên công ty đặt hàng
        public string? OrdererName { get; set; }
        public string? CodeOrderer { get; set; }
        public string? Address { get; set; }
        public string? ContactPerson { get; set; }
        public DateTime? DeliveryDate { get; set; }
        public string? Reference { get; set; }
        public string? Buyer { get; set; }

        public uint? ConstOfTransportation { get; set; }
        public uint? ConstOfTransfer { get; set; }
        public uint? ConstOfEngineering { get; set; }
        public uint? ConstOther { get; set; }
        public int? Over { get; set; }
        public uint? TotalAmount { get; set; }
        public uint? VAT { get; set; }
        public long? TotalPayment { get; set; } 

        public string? PlaceOfDelivery { get; set; }
        public string? PaymentTerm { get; set; }
        public string? BankInformation { get; set; }
        public string? Note { get; set; }

        public DateTime? Date { get; set; }

        public string? OrderCreator { get; set; }
        public bool Status { get; set; }
        public DateTime CreateAt { get; set; }


    }
}
