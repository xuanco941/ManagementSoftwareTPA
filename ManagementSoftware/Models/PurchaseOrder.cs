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
        public string SoPRPQ { get; set; } = "";
        //tên công ty đặt hàng
        public string TenKhachHang { get; set; } = "";
        public string MaKhachHang { get; set; } = "";
        public string DiaChi { get; set; } = "";
        public string NguoiLienHe { get; set; } = "";
        public DateTime? NgayGiaoHang { get; set; }
        public string ThamChieu { get; set; } = "";
        public string NhanVienMuaHang { get; set; } = "";

        public long ChiPhiVanChuyen { get; set; } = 0;
        public long ChiPhiChuyenGiao { get; set; } = 0;
        public long ChiPhiKyThuat { get; set; } = 0;
        public long ChiPhiKhac { get; set; } = 0;
        public int Vuot { get; set; } = 0;
        public long TongTienHang { get; set; } = 0;
        public long VAT { get; set; } = 0;
        public long TongTienThanhToan { get; set; } = 0;

        public string DiaDiemGiaoHang { get; set; } = "";
        public string ThanhToan { get; set; } = "";
        public string ThongTinNganHang { get; set; } = "";
        public string GhiChu { get; set; } = "";

        public string OrderCreator { get; set; } = "";
        public bool Status { get; set; } = false;
        public DateTime CreateAt { get; set; }


    }
}
