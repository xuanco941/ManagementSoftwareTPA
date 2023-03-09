using ManagementSoftware.Models;
using Microsoft.EntityFrameworkCore;
using Syncfusion.Windows.Forms.PivotAnalysis;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace ManagementSoftware.DAL
{
    public class DALImportedWareHouse
    {
        public static int GetTongSoLuongDaNhapKhoOfDirective(int directiveID)
        {
            DataBaseContext dbContext = new DataBaseContext();
            return dbContext.ImportedWarehouses.Where(p => p.DirectiveID == directiveID).Sum(p => p.Amount);
        }

        public List<ImportedWarehouse>? GetAllImportedWareHousesFromIDDirective(int directiveID)
        {
            DataBaseContext dbContext = new DataBaseContext();
            return dbContext.ImportedWarehouses.Where(p => p.DirectiveID == directiveID).ToList();
        }



        public void Add(ImportedWarehouse importedWarehouse, Directive directive)
        {
            DataBaseContext dbContext = new DataBaseContext();
            // Tạo mã code mới dựa trên id của đối tượng
            importedWarehouse.BarCode = "";
            dbContext.ImportedWarehouses.Add(importedWarehouse);
            dbContext.SaveChanges();
            importedWarehouse.BarCode = Common.PURCHASEORDER + directive.Product.PurchaseOrder.PurchaseOrderID + "-" + Common.PRODUCT + directive.Product.ProductID + "-"
                + Common.DIRECTIVE + directive.DirectiveID + "-" + Common.IMPORTED_WAREHOUSE + importedWarehouse.ImportedWarehouseID + "-" + importedWarehouse.Amount;
            dbContext.Update(importedWarehouse);



            //update sp đã nhập kho
            var productUpdate = dbContext.Products.FirstOrDefault(g => g.ProductID == directive.ProductID);

            if (productUpdate != null)
            {
                var importedWarehouses = dbContext.ImportedWarehouses
                                    .Join(dbContext.Directives.Where(d => d.Status == true), iw => iw.DirectiveID, d => d.DirectiveID, (iw, d) => new { ImportedWarehouse = iw, Directive = d })
                                    .Join(dbContext.Products, x => x.Directive.ProductID, p => p.ProductID, (x, p) => new { x.ImportedWarehouse, Product = p })
                                    .Where(x => x.Product.ProductID == productUpdate.ProductID)
                                    .Select(x => x.ImportedWarehouse)
                                    .ToList();

                if (importedWarehouses != null && importedWarehouses.Count > 0)
                {
                    int sumIm = importedWarehouses.Sum(a => a.Amount);
                    
                    productUpdate.SoLuongDaNhapKho = sumIm;
                }
                else
                {
                    productUpdate.SoLuongDaNhapKho = 0;
                }
            }

            dbContext.SaveChanges();


        }


        public void Update(ImportedWarehouse i, Directive directive)
        {
            using (var dbContext = new DataBaseContext())
            {
                var importedWarehouse = dbContext.ImportedWarehouses.SingleOrDefault(s => s.ImportedWarehouseID == i.ImportedWarehouseID);
                if (importedWarehouse != null)
                {
                    importedWarehouse.Importer = i.Importer;
                    importedWarehouse.Amount = i.Amount;
                    importedWarehouse.DateAdded = i.DateAdded;

                    string[] parts = i.BarCode.Split('-');
                    string barcodeNew = string.Join("-", parts.Take(parts.Length - 1));

                    importedWarehouse.BarCode = barcodeNew + i.Amount;
                    dbContext.ImportedWarehouses.Update(importedWarehouse);



                    //update sp đã nhập kho
                    var productUpdate = dbContext.Products.FirstOrDefault(g => g.ProductID == directive.ProductID);

                    if (productUpdate != null)
                    {
                        var importedWarehouses = dbContext.ImportedWarehouses
                                            .Join(dbContext.Directives.Where(d => d.Status == true), iw => iw.DirectiveID, d => d.DirectiveID, (iw, d) => new { ImportedWarehouse = iw, Directive = d })
                                            .Join(dbContext.Products, x => x.Directive.ProductID, p => p.ProductID, (x, p) => new { x.ImportedWarehouse, Product = p })
                                            .Where(x => x.Product.ProductID == productUpdate.ProductID)
                                            .Select(x => x.ImportedWarehouse)
                                            .ToList();

                        if (importedWarehouses != null && importedWarehouses.Count > 0)
                        {
                            int sumIm = importedWarehouses.Sum(a => a.Amount);

                            productUpdate.SoLuongDaNhapKho = sumIm;
                        }
                        else
                        {
                            productUpdate.SoLuongDaNhapKho = 0;
                        }
                    }


                    dbContext.SaveChanges();
                }
            }
        }
        public void Delete(int id, Directive directive)
        {
            using (var dbContext = new DataBaseContext())
            {
                var im = dbContext.ImportedWarehouses.Where(s => s.ImportedWarehouseID == id).FirstOrDefault();
                if (im != null)
                {
                    dbContext.ImportedWarehouses.RemoveRange(im);

                    dbContext.SaveChanges();


                    //update sp đã nhập kho
                    var productUpdate = dbContext.Products.FirstOrDefault(g => g.ProductID == directive.ProductID);

                    if (productUpdate != null)
                    {
                        var importedWarehouses = dbContext.ImportedWarehouses
                                            .Join(dbContext.Directives.Where(d => d.Status == true), iw => iw.DirectiveID, d => d.DirectiveID, (iw, d) => new { ImportedWarehouse = iw, Directive = d })
                                            .Join(dbContext.Products, x => x.Directive.ProductID, p => p.ProductID, (x, p) => new { x.ImportedWarehouse, Product = p })
                                            .Where(x => x.Product.ProductID == productUpdate.ProductID)
                                            .Select(x => x.ImportedWarehouse)
                                            .ToList();

                        if (importedWarehouses != null && importedWarehouses.Count > 0)
                        {
                            int sumIm = importedWarehouses.Sum(a => a.Amount);

                            productUpdate.SoLuongDaNhapKho = sumIm;
                        }
                        else
                        {
                            productUpdate.SoLuongDaNhapKho = 0;
                        }
                    }


                    dbContext.SaveChanges();
                }
            }
        }


    }
}
