using ManagementSoftware.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ManagementSoftware.DAL
{
    public class DALPurchaseOrder
    {
        public static int Add(PurchaseOrder po)
        {
            DataBaseContext dbContext = new DataBaseContext();
            dbContext.PurchaseOrders.Add(po);
            return dbContext.SaveChanges();
        }
        public static int Update(PurchaseOrder po)
        {
            DataBaseContext dbContext = new DataBaseContext();
            var purchaseOrderUpdate = dbContext.PurchaseOrders.FirstOrDefault(g => g.PurchaseOrderID == po.PurchaseOrderID);
            if (purchaseOrderUpdate != null)
            {
                purchaseOrderUpdate = po;
            }
            return dbContext.SaveChanges();
        }
        public static int Delete(int PurchaseOrderID)
        {
            DataBaseContext dbContext = new DataBaseContext();
            var shiftDelete = dbContext.PurchaseOrders.FirstOrDefault(s => s.PurchaseOrderID == PurchaseOrderID);
            if (shiftDelete != null)
            {
                dbContext.PurchaseOrders.Remove(shiftDelete);
            }
            return dbContext.SaveChanges();
        }
    }
}
