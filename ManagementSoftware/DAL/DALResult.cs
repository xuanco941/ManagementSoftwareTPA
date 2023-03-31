using ManagementSoftware.Models;
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

        public void Update(Result result)
        {
            using (var context = new DataBaseContext())
            {
                var existingResult = context.Results.FirstOrDefault(r => r.ResultID == result.ResultID);
                if (existingResult != null)
                {
                    existingResult.ApSuatTong = result.ApSuatTong;
                    existingResult.TimeStart = result.TimeStart;
                    existingResult.ProductionNumber = result.ProductionNumber;
                    existingResult.TimeEnd = result.TimeEnd;
                    existingResult.Status = result.Status;
                    existingResult.Username = result.Username;
                    existingResult.UserID = result.UserID;
                    context.SaveChanges();
                }
            }
        }


        public void Delete(int resultId)
        {
            using (var context = new DataBaseContext())
            {
                var result = context.Results.FirstOrDefault(r => r.ResultID == resultId);
                if (result != null)
                {
                    context.Results.Remove(result);
                    context.SaveChanges();
                }
            }
        }




        //public static int Update(Result r)
        //{
        //    using (DataBaseContext dbContext = new DataBaseContext())
        //    {
        //        var result = dbContext.Results.FirstOrDefault(g => g.ResultID == r.ResultID);
        //        if (result != null)
        //        {
        //            dbContext.Entry(result).CurrentValues.SetValues(r);
        //        }
        //        return dbContext.SaveChanges();
        //    }
        //}

    }
}
