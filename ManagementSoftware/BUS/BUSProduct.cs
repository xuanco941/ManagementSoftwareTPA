using ManagementSoftware.BUS.Validate;
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
    public class BUSProduct
    {
        public static int GetSoLuongSanXuatDaPhanChiThiOnProduct(int productID)
        {
            return DALProduct.GetSoLuongSanXuatDaPhanChiThiOnProduct(productID);
        }
        public static List<Product> GetProductOfPO(int poID)
        {
            return DALProduct.GetProductOfPO(poID);
        }
        public static Product? GetProductFromID(int id)
        {
            return DALProduct.GetProductFromID(id);
        }
        public static AddUpdateDeleteResponse<List<Product>> AddRange(List<Product> listProduct)
        {
            //response
            AddUpdateDeleteResponse<List<Product>> response = new AddUpdateDeleteResponse<List<Product>>();
            try
            {
                // số dòng thay đổi lớn hơn 0 thì thành công
                response.RowsNumberChanged = DALProduct.AddRange(listProduct);
                response.Status = response.RowsNumberChanged > 0 ? true : false;
                response.Message = response.Status == true ? $"Thêm thành công." : $"Thêm thất bại.";
                response.Data = listProduct;
            }
            catch
            {
                response.Status = false;
                response.Message = "Lỗi hệ thống, không thể thêm.";
            }
            return response;
        }

    }
}
