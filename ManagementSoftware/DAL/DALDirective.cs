using ManagementSoftware.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;

namespace ManagementSoftware.DAL
{
    public class DALDirective
    {
        public static List<Directive> GetAllDirectiveOfProduct(int pID)
        {
            DataBaseContext dbContext = new DataBaseContext();
            return dbContext.Directives.Where(p => p.ProductID == pID).ToList();
        }
        public static List<Directive> GetAllDirectiveOfUser(int uid)
        {
            DataBaseContext dbContext = new DataBaseContext();
            return dbContext.Directives.Where(p => p.UserID == uid).ToList();
        }
        public static int Add(Directive directive)
        {
            DataBaseContext dbContext = new DataBaseContext();
            dbContext.Directives.Add(directive);
            return dbContext.SaveChanges();
        }
        public static int AddRange(List<Directive> listProduct)
        {
            DataBaseContext dbContext = new DataBaseContext();
            dbContext.Directives.AddRange(listProduct);
            return dbContext.SaveChanges();
        }
        public static int Update(Directive directive)
        {
            using (var dbContext = new DataBaseContext())
            {
                var directiveToUpdate = dbContext.Directives.FirstOrDefault(d => d.DirectiveID == directive.DirectiveID);
                if (directiveToUpdate != null)
                {
                    dbContext.Entry(directiveToUpdate).CurrentValues.SetValues(directive);

                    int x = dbContext.SaveChanges();

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
                    return x;
                }
                else
                {
                    return 0;
                }
            }
        }
        public static int Delete(int directiveID)
        {
            using (var dbContext = new DataBaseContext())
            {
                var directives = dbContext.Directives.Where(s => s.DirectiveID == directiveID);
                if (directives.Any())
                {
                    dbContext.Directives.RemoveRange(directives);
                    return dbContext.SaveChanges();
                }
                return 0;
            }
        }

        public Directive? GetDirectiveFromID(int id)
        {
            DataBaseContext dbContext = new DataBaseContext();
            return dbContext.Directives.Include(d => d.Product).Where(p => p.DirectiveID == id).FirstOrDefault();
        }

    }
}
