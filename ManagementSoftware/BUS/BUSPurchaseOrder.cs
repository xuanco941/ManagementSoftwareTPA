using ManagementSoftware.DAL;
using ManagementSoftware.DAL.DALPagination;
using ManagementSoftware.Models;
using ManagementSoftware.ViewModels;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ManagementSoftware.BUS
{
    public class BUSPurchaseOrder
    {
        public static PaginationPurchaseOrder GetData(int page,bool? status, string? poID)
        {
            PaginationPurchaseOrder pagination = new PaginationPurchaseOrder();
            pagination.Set(page, status, poID);
            return pagination;
        }

        public static AddUpdateDeleteResponse<PurchaseOrder> Add(PurchaseOrder po)
        {

            AddUpdateDeleteResponse<PurchaseOrder> response = new AddUpdateDeleteResponse<PurchaseOrder>();
            try
            {
                // số dòng thay đổi lớn hơn 0 thì thành công
                response.RowsNumberChanged = DALPurchaseOrder.Add(po);
                response.Status = response.RowsNumberChanged > 0 ? true : false;
                response.Message = response.Status == true ? $"Thêm thành công." : $"Thêm thất bại.";
                response.Data = po;
            }
            catch
            {
                response.Status = false;
                response.Message = "Lỗi hệ thống, không thể thêm.";
            }
            return response;
        }
        //public static int Update(PurchaseOrder po)
        //{
        //    DataBaseContext dbContext = new DataBaseContext();
        //    var purchaseOrderUpdate = dbContext.PurchaseOrders.FirstOrDefault(g => g.PurchaseOrderID == po.PurchaseOrderID);
        //    if (purchaseOrderUpdate != null)
        //    {
        //        purchaseOrderUpdate = po;
        //    }
        //    return dbContext.SaveChanges();
        //}
        //public static int Delete(int PurchaseOrderID)
        //{
        //    DataBaseContext dbContext = new DataBaseContext();
        //    var poDelete = dbContext.PurchaseOrders.FirstOrDefault(s => s.PurchaseOrderID == PurchaseOrderID);
        //    if (poDelete != null)
        //    {
        //        dbContext.PurchaseOrders.Remove(poDelete);
        //    }
        //    return dbContext.SaveChanges();
        //}
    }
}
