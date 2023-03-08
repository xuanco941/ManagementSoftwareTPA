﻿using ManagementSoftware.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ManagementSoftware.DAL
{
    public class DALResult
    {
        public static int Add(Result r)
        {
            using (DataBaseContext dbContext = new DataBaseContext())
            {
                dbContext.Results.Add(r);
                return dbContext.SaveChanges();
            }
        }

        public static int Update(Result r)
        {
            using (DataBaseContext dbContext = new DataBaseContext())
            {
                var result = dbContext.Results.FirstOrDefault(g => g.ResultID == r.ResultID);
                if (result != null)
                {
                    dbContext.Entry(result).CurrentValues.SetValues(r);
                }
                return dbContext.SaveChanges();
            }
        }

        public static int Delete(int resultID)
        {
            using (DataBaseContext dbContext = new DataBaseContext())
            {
                var resultDelete = dbContext.Results.FirstOrDefault(s => s.ResultID == resultID);
                if (resultDelete != null)
                {
                    dbContext.Results.Remove(resultDelete);
                }
                return dbContext.SaveChanges();
            }
        }

    }
}
