using ManagementSoftware.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ManagementSoftware.DAL
{
    public class DALResultWarning
    {
        public void Add(ResultWarning resultWarning)
        {
            using (var context = new DataBaseContext())
            {
                try
                {
                    context.ResultWarnings.Add(resultWarning);
                    context.SaveChanges();
                }
                catch
                {

                }

            }
        }
        public void Update(ResultWarning resultWarning)
        {
            using (var context = new DataBaseContext())
            {
                try
                {
                    var resultWarningToUpdate = context.ResultWarnings.Find(resultWarning.ResultWarningID);
                    if (resultWarningToUpdate != null)
                    {
                        resultWarningToUpdate.Title = resultWarning.Title;
                        resultWarningToUpdate.Description = resultWarning.Description;
                        resultWarningToUpdate.CreateAt = resultWarning.CreateAt;
                        resultWarningToUpdate.ResultID = resultWarning.ResultID;
                        resultWarningToUpdate.Result = resultWarning.Result;
                        context.SaveChanges();
                    }
                }
                catch
                {

                }

            }
        }
        public void Delete(int resultWarningID)
        {
            using (var context = new DataBaseContext())
            {
                try
                {
                    var resultWarningToDelete = context.ResultWarnings.Find(resultWarningID);
                    if (resultWarningToDelete != null)
                    {
                        context.ResultWarnings.Remove(resultWarningToDelete);
                        context.SaveChanges();
                    }
                }
                catch
                {

                }
            }
        }

        public List<ResultWarning> GetAllResultWarningsByResultID(int resultID)
        {
            using (var context = new DataBaseContext())
            {
                try
                {
                    var resultWarnings = context.ResultWarnings
                    .Where(rw => rw.ResultID == resultID)
                    .ToList();
                    return resultWarnings;
                }
                catch
                {
                    return new List<ResultWarning>();
                }
            }
        }

    }
}
