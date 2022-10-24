﻿using ManagementSoftware.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ManagementSoftware.DAL
{
    public class DALDirective
    {
        public static int Add(Directive directive)
        {
            DataBaseContext dbContext = new DataBaseContext();
            dbContext.Directives.Add(directive);
            return dbContext.SaveChanges();
        }
        public static int Update(Directive directive)
        {
            DataBaseContext dbContext = new DataBaseContext();
            var update = dbContext.Directives.FirstOrDefault(g => g.DirectiveID == directive.DirectiveID);
            if (update != null)
            {
                update = directive;
            }
            return dbContext.SaveChanges();
        }
        public static int Delete(int directiveID)
        {
            DataBaseContext dbContext = new DataBaseContext();
            var delete = dbContext.Directives.FirstOrDefault(s => s.DirectiveID == directiveID);
            if (delete != null)
            {
                dbContext.Directives.Remove(delete);
            }
            return dbContext.SaveChanges();
        }
    }
}