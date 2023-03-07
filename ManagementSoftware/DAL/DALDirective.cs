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
                dbContext.Directives.Update(directive);
                return dbContext.SaveChanges();
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
