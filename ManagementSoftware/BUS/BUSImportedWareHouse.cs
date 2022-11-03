using ManagementSoftware.DAL;
using ManagementSoftware.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ManagementSoftware.BUS
{
    public class BUSImportedWareHouse
    {
        public static int GetImportedWareHouseOfDirective(int directiveID)
        {
            return DALImportedWareHouse.GetTongSoLuongDaNhapKhoOfDirective(directiveID);
        }
    }
}
