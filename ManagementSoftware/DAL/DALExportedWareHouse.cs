using ManagementSoftware.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ManagementSoftware.DAL
{
    public class DALExportedWareHouse
    {
        public int Add(ExportedWareHouse exportedWareHouse)
        {
            DataBaseContext dbContext = new DataBaseContext();
            dbContext.ExportedWareHouses.Add(exportedWareHouse);
            int x = dbContext.SaveChanges();

            return x;
        }
        public int Update(ExportedWareHouse exportedWareHouse)
        {
            using (var dbContext = new DataBaseContext())
            {
                var exportedWareHouseUpdate = dbContext.ExportedWareHouses.FirstOrDefault(g => g.ExportedWareHouseID == exportedWareHouse.ExportedWareHouseID);
                if (exportedWareHouseUpdate != null)
                {
                    // Update the properties of the existing exported warehouse object
                    dbContext.Entry(exportedWareHouseUpdate).CurrentValues.SetValues(exportedWareHouse);

                    // Update the product

                    int x = dbContext.SaveChanges();

                    return x;
                }
                return 0; // Or you can throw an exception if the exported warehouse is not found
            }
        }
        public int Delete(int exportedWareHouseID)
        {
            DataBaseContext dbContext = new DataBaseContext();
            var poDelete = dbContext.ExportedWareHouses.FirstOrDefault(s => s.ExportedWareHouseID == exportedWareHouseID);
            int x = 0;
            if (poDelete != null)
            {
                dbContext.ExportedWareHouses.Remove(poDelete);

                x = dbContext.SaveChanges();

            }

            return x;
        }
    }
}
