using ManagementSoftware.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ManagementSoftware.DAL
{
    public class DALImportedWareHouse
    {
        public static int GetTongSoLuongDaNhapKhoOfDirective(int directiveID)
        {
            DataBaseContext dbContext = new DataBaseContext();
            return dbContext.ImportedWarehouses.Where(p => p.DirectiveID == directiveID).Sum(p => p.Amount);
        }

        public List<ImportedWarehouse>? GetAllImportedWareHousesFromIDDirective(int directiveID)
        {
            DataBaseContext dbContext = new DataBaseContext();
            return dbContext.ImportedWarehouses.Where(p => p.DirectiveID == directiveID).ToList();
        }
    }
}
