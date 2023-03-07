using Syncfusion.Windows.Forms.Chart;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ManagementSoftware.Models
{
    [Table("Product")]
    public class Product
    {
        [Key]
        public int ProductID { get; set; }
        public string ProductName { get; set; }
        public int SoLuongSanXuat { get; set; }
        public int SoLuongDaXuatKho { get; set; }
        public int SoLuongDaNhapKho { get; set; }
        public bool Status { get; set; }



        public double ApSuatNap { get; set; }
        public double TheTichBinh { get; set; }
        public string LoaiKhi { get; set; }
        public int ChatLuongKhi { get; set; }
        public double QuyCach { get; set; }


        //public string? Description { get; set; }
        //public string? DVT { get; set; }
        //public int Quantity { get; set; }
        //public uint UnitPrice { get; set; }
        //public uint Amount { get; set; }
        //người vận hành
        public int PurchaseOrderID { get; set; }
        public PurchaseOrder PurchaseOrder { get; set; }
    }
}
