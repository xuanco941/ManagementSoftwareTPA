using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ManagementSoftware.GUI.Dashboard_Management
{
    public class DataAlwaysUpdate
    {
        public float? apSuatHe1 { get; set; } = 0;
        public float? apSuatHe2 { get; set; } = 0;
        public float? apSuatTong { get; set; } = 0;
        public float? theTichHe1 { get; set; } = 0;
        public float? theTichHe2 { get; set; } = 0;
        public int? pallet1 { get; set; } = 0;
        public int? pallet2 { get; set; } = 0;

        public bool? sanSangNapHe1 { get; set; } = false;
        public bool? sanSangNapHe2 { get; set; } = false;
        //public bool? ketThucNapHe1 { get; set; } = false;
        //public bool? ketThucNapHe2 { get; set; } = false;
        //public bool? xaKhiHe1 { get; set; } = false;
        //public bool? xaKhiHe2 { get; set; } = false;
        //public bool? batDauNapHe1 { get; set; } = false;
        //public bool? batDauNapHe2 { get; set; } = false;

        //error
        public bool? canhBaoLoiDongCoOHeHoaHoi = false;
        public bool? canhBaoChuaMoHeHoaHoi = false;
        public bool? loiQuaTrinhXaKhiHe1 = false;
        public bool? loiQuaTrinhXaKhiHe2 = false;
        public bool? loiQuaTrinhNapKhiHe1 = false;
        public bool? loiQuaTrinhNapKhiHe2 = false;



    }
}
