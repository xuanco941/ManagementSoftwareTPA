﻿using ManagementSoftware.Models;
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
        public int Update(Product product)
        {
            DataBaseContext dbContext = new DataBaseContext();
            var productUpdate = dbContext.Products.FirstOrDefault(g => g.ProductID == product.ProductID);

            if (productUpdate != null)
            {
                productUpdate = product;

                dbContext.Products.Update(productUpdate);
            }
            return dbContext.SaveChanges();
        }

        //public async Task UpdateSLNhapKho(Product product)
        //{
        //    using (var dbContext = new DataBaseContext())
        //    {
        //        var productUpdate = dbContext.Products.FirstOrDefault(g => g.ProductID == product.ProductID);

        //        if (productUpdate != null)
        //        {
        //            productUpdate = product;
        //            List<Directive>? directives = dbContext.Directives.Where(a => a.ProductID == productUpdate.ProductID).ToList();

        //            if (directives != null && directives.Count > 0)
        //            {
        //                int sumIm = 0;
        //                foreach (var item in directives)
        //                {
        //                    sumIm = sumIm + dbContext.ImportedWarehouses.Where(a => a.DirectiveID == item.DirectiveID).Sum(o => o.Amount);
        //                }
        //                productUpdate.SoLuongDaNhapKho = sumIm;
        //            }

        //            dbContext.Products.Update(productUpdate);
        //        }
        //       await dbContext.SaveChangesAsync();
        //    }


        //}

        //public int UpdateSLXuatKho(Product product)
        //{
        //    DataBaseContext dbContext = new DataBaseContext();
        //    var productUpdate = dbContext.Products.FirstOrDefault(g => g.ProductID == product.ProductID);

        //    if (productUpdate != null)
        //    {
        //        productUpdate = product;
        //        List<ExportedWareHouse>? exportedWareHouses = dbContext.ExportedWareHouses.Where(a => a.ProductID == productUpdate.ProductID).ToList();

        //        if (exportedWareHouses != null && exportedWareHouses.Count > 0)
        //        {
        //            productUpdate.SoLuongDaXuatKho = exportedWareHouses.Sum(a => a.Amount);
        //        }

        //        dbContext.Products.Update(productUpdate);
        //    }
        //    return dbContext.SaveChanges();
        //}

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
