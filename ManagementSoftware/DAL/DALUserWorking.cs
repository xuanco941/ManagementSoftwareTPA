using ManagementSoftware.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ManagementSoftware.DAL
{
    public class DALUserWorking
    {
        public UserWorking? Add(UserWorking userWorking)
        {
            using (var context = new DataBaseContext())
            {
                try
                {
                    context.UserWorkings.Add(userWorking);
                    context.SaveChanges();
                    return userWorking;
                }
                catch
                {
                    return null;
                }
            }
        }
        public void Update(UserWorking userWorking)
        {
            using (var context = new DataBaseContext())
            {
                try
                {
                    var userWorkingToUpdate = context.UserWorkings.FirstOrDefault(uw => uw.UserWorkingID == userWorking.UserWorkingID);
                    if (userWorkingToUpdate != null)
                    {
                        userWorkingToUpdate.CreateAt = userWorking.CreateAt;
                        userWorkingToUpdate.EndAt = userWorking.EndAt;
                        userWorkingToUpdate.Username = userWorking.Username;
                        userWorkingToUpdate.Fullname = userWorking.Fullname;
                        context.SaveChanges();
                    }
                }
                catch
                {

                }

            }
        }
        public void Delete(int userWorkingID)
        {
            using (var context = new DataBaseContext())
            {
                try
                {
                    var userWorkingToDelete = context.UserWorkings.FirstOrDefault(uw => uw.UserWorkingID == userWorkingID);
                    if (userWorkingToDelete != null)
                    {
                        context.UserWorkings.Remove(userWorkingToDelete);
                        context.SaveChanges();
                    }
                }
                catch
                {

                }

            }
        }

    }
}
