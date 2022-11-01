using ManagementSoftware.DAL;
using ManagementSoftware.Models;
using ManagementSoftware.ViewModels;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ManagementSoftware.BUS
{
    public class BUSDirective
    {
        public static List<Directive> GetAllDirectiveOfProduct(int idP)
        {
            return DALDirective.GetAllDirectiveOfProduct(idP);
        }
        public static List<Directive> GetAllDirectiveOfUser(int uid)
        {
            return DALDirective.GetAllDirectiveOfUser(uid);
        }
        public static AddUpdateDeleteResponse<Directive> Add(Directive d)
        {

            AddUpdateDeleteResponse<Directive> response = new AddUpdateDeleteResponse<Directive>();
            try
            {
                // số dòng thay đổi lớn hơn 0 thì thành công
                response.RowsNumberChanged = DALDirective.Add(d);
                response.Status = response.RowsNumberChanged > 0 ? true : false;
                response.Message = response.Status == true ? $"Thêm thành công." : $"Thêm thất bại.";
                response.Data = d;
            }
            catch
            {
                response.Status = false;
                response.Message = "Lỗi hệ thống, không thể thêm.";
            }
            return response;
        }
        public static AddUpdateDeleteResponse<List<Directive>> AddRange(List<Directive> d)
        {

            AddUpdateDeleteResponse<List<Directive>> response = new AddUpdateDeleteResponse<List<Directive>>();
            try
            {
                // số dòng thay đổi lớn hơn 0 thì thành công
                response.RowsNumberChanged = DALDirective.AddRange(d);
                response.Status = response.RowsNumberChanged > 0 ? true : false;
                response.Message = response.Status == true ? $"Thêm thành công." : $"Thêm thất bại.";
                response.Data = d;
            }
            catch
            {
                response.Status = false;
                response.Message = "Lỗi hệ thống, không thể thêm.";
            }
            return response;
        }

        public static AddUpdateDeleteResponse<int> Delete(int id)
        {
            AddUpdateDeleteResponse<int> response = new AddUpdateDeleteResponse<int>();
            try
            {
                // số dòng thay đổi lớn hơn 0 thì thành công
                response.RowsNumberChanged = DALDirective.Delete(id);
                response.Status = response.RowsNumberChanged > 0 ? true : false;
                response.Message = response.Status == true ? $"Xóa thành công." : $"Xóa thất bại.";
                response.Data = id;
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
