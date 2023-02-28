using ManagementSoftware.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ManagementSoftware.DAL.DALPagination
{
    public class PaginationPurchaseOrder
    {
        public static int NumberRows { get; set; } = Common.NumberRowsFormPurchaseOrder;
        public int PageCurrent { get; set; } = 1;
        public int TotalPages { get; set; } = 1;
        public int TotalResults { get; set; } = 0;
        public List<PurchaseOrder> ListResults { get; set; } = new List<PurchaseOrder>();

        public void Set(int page, bool? status, string poID, DateTime? start, DateTime? end)
        {
            DataBaseContext dbContext = new DataBaseContext();

            int position = (page - 1) * NumberRows;

            if (start == null && end == null)
            {
                start = DateTime.MinValue;
                end = DateTime.MaxValue;
            }

            if (status != null)
            {
                this.ListResults = dbContext.PurchaseOrders.OrderByDescending(t => t.PurchaseOrderID)
                .Where(p => (Common.PURCHASEORDER + p.PurchaseOrderID).Contains(poID) == true && p.Status == status && (start <= p.CreateAt && end >= p.CreateAt))
                .Skip(position)
                .Take(NumberRows)
                .ToList();
                this.TotalResults = dbContext.PurchaseOrders.Where(p => (Common.PURCHASEORDER + p.PurchaseOrderID).Contains(poID) == true && p.Status == status && (start <= p.CreateAt && end >= p.CreateAt)).Count();
            }
            else
            {
                this.ListResults = dbContext.PurchaseOrders.OrderByDescending(t => t.PurchaseOrderID)
                .Where(p => (Common.PURCHASEORDER + p.PurchaseOrderID).Contains(poID) == true && (start <= p.CreateAt && end >= p.CreateAt))
                .Skip(position)
                .Take(NumberRows)
                .ToList();
                this.TotalResults = dbContext.PurchaseOrders.Where(p => (Common.PURCHASEORDER + p.PurchaseOrderID).Contains(poID) == true && (start <= p.CreateAt && end >= p.CreateAt)).Count();
            }

            this.PageCurrent = page;
            this.TotalPages = TotalResults % NumberRows == 0 ? TotalResults / NumberRows : (TotalResults / NumberRows) + 1;

        }
    }
}
