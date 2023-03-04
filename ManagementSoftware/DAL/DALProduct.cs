using ManagementSoftware.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ManagementSoftware.DAL
{
    public class DALProduct
    {
        public static List<Product> GetProductOfPO(int poID)
        {
            DataBaseContext dbContext = new DataBaseContext();
            return dbContext.Products.Where(p => p.PurchaseOrderID == poID).ToList();
        }
        public Product? GetProductFromID(int id)
        {
            DataBaseContext dbContext = new DataBaseContext();
            return dbContext.Products.Where(p => p.ProductID == id).FirstOrDefault();
        }

        public List<Product> GetProductFromListID(List<int> list)
        {
            DataBaseContext dbContext = new DataBaseContext();
            return dbContext.Products.Where(p => list.Contains(p.ProductID)).ToList();
        }

        public static int GetSoLuongSanXuatDaPhanChiThiOnProduct(int productID)
        {
            DataBaseContext dbContext = new DataBaseContext();
            return dbContext.Directives.Where(d => d.ProductID == productID).Sum(d => d.SoLuongCanSanXuat);
        }
        public static int AddRange(List<Product> listProduct)
        {
            DataBaseContext dbContext = new DataBaseContext();
            dbContext.Products.AddRange(listProduct);
            return dbContext.SaveChanges();
        }
        public static int Add(Product product)
        {
            DataBaseContext dbContext = new DataBaseContext();
            dbContext.Products.Add(product);
            return dbContext.SaveChanges();
        }
        public static int Update(Product product)
        {
            DataBaseContext dbContext = new DataBaseContext();
            var productUpdate = dbContext.Products.FirstOrDefault(g => g.ProductID == product.ProductID);
            if (productUpdate != null)
            {
                productUpdate = product;
            }
            return dbContext.SaveChanges();
        }
        public static int Delete(int productID)
        {
            DataBaseContext dbContext = new DataBaseContext();
            var productDelete = dbContext.Products.FirstOrDefault(s => s.ProductID == productID);
            if (productDelete != null)
            {
                dbContext.Products.Remove(productDelete);
            }
            return dbContext.SaveChanges();
        }
    }
}
