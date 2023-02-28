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
        public static AddUpdateDeleteResponse<PurchaseOrder> Update(PurchaseOrder po)
        {
            AddUpdateDeleteResponse<PurchaseOrder> response = new AddUpdateDeleteResponse<PurchaseOrder>();

            try
            {
                // số dòng thay đổi lớn hơn 0 thì thành công
                response.RowsNumberChanged = DALPurchaseOrder.Update(po);
                response.Status = response.RowsNumberChanged > 0 ? true : false;
                response.Message = response.Status == true ? $"Cập nhật thành công." : $"Cập nhật thất bại.";
                response.Data = po;
            }
            catch
            {
                response.Status = false;
                response.Message = "Lỗi hệ thống, không thể cập nhật.";
            }
            return response;
        }

        public static AddUpdateDeleteResponse<int> Delete(int PurchaseOrderID)
        {
            AddUpdateDeleteResponse<int> response = new AddUpdateDeleteResponse<int>();
            try
            {
                // số dòng thay đổi lớn hơn 0 thì thành công
                response.RowsNumberChanged = DALPurchaseOrder.Delete(PurchaseOrderID);
                response.Status = response.RowsNumberChanged > 0 ? true : false;
                response.Message = response.Status == true ? $"Xóa thành công." : $"Xóa thất bại.";
                response.Data = PurchaseOrderID;
            }
            catch
            {
                response.Status = false;
                response.Message = "Lỗi hệ thống, không thể xóa.";
            }
            return response;
        }
    }
}
