using ManagementSoftware.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ManagementSoftware.DAL.DALPagination
{
    public class PaginationProductCanBeExportWarehouse
    {
        public static int NumberRows { get; set; } = Common.NumberRows;
        public int PageCurrent { get; set; } = 1;
        public int TotalPages { get; set; } = 1;
        public int TotalResults { get; set; } = 0;
        public List<Product> ListResults { get; set; } = new List<Product>();

        public void Set(int page, string productID)
        {
            DataBaseContext dbContext = new DataBaseContext();

            int position = (page - 1) * NumberRows;
            this.ListResults = dbContext.Products
            .Where(p => (Common.PRODUCT + p.ProductID).Contains(productID) == true)
            .OrderByDescending(t => t.ProductID)
            .Skip(position)
            .Take(NumberRows)
            .ToList();
            this.TotalResults = dbContext.Products.Where(p => (Common.PRODUCT + p.ProductID).Contains(productID) == true).Count();

            this.PageCurrent = page;
            this.TotalPages = TotalResults % NumberRows == 0 ? TotalResults / NumberRows : (TotalResults / NumberRows) + 1;

        }
        public void Set2(int page, string poID)
        {
            DataBaseContext dbContext = new DataBaseContext();

            int position = (page - 1) * NumberRows;

            List<PurchaseOrder> list = dbContext.PurchaseOrders.Where(a => (Common.PURCHASEORDER + a.PurchaseOrderID).Contains(poID) == true).ToList();

            List<Product> l = new List<Product>();
            foreach (var item in list)
            {
                l.AddRange(dbContext.Products.Where(p => p.PurchaseOrderID == item.PurchaseOrderID).ToList());
            }

            this.ListResults = l
            .OrderByDescending(t => t.ProductID)
            .Skip(position)
            .Take(NumberRows)
            .ToList();
            this.TotalResults = l.Count();

            this.PageCurrent = page;
            this.TotalPages = TotalResults % NumberRows == 0 ? TotalResults / NumberRows : (TotalResults / NumberRows) + 1;

        }

    }
}
