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
        public void AddUserWorking(UserWorking userWorking)
        {
            using (var context = new DataBaseContext())
            {
                context.UserWorkings.Add(userWorking);
                context.SaveChanges();
            }
        }
        public void UpdateUserWorking(UserWorking userWorking)
        {
            using (var context = new DataBaseContext())
            {
                var userWorkingToUpdate = context.UserWorkings.FirstOrDefault(uw => uw.UserWorkingID == userWorking.UserWorkingID);
                if (userWorkingToUpdate != null)
                {
                    userWorkingToUpdate.CreateAt = userWorking.CreateAt;
                    userWorkingToUpdate.EndAt = userWorking.EndAt;
                    userWorkingToUpdate.UserID = userWorking.UserID;
                    userWorkingToUpdate.Username = userWorking.Username;
                    userWorkingToUpdate.Fullname = userWorking.Fullname;
                    context.SaveChanges();
                }
            }
        }
        public void DeleteUserWorking(int userWorkingID)
        {
            using (var context = new DataBaseContext())
            {
                var userWorkingToDelete = context.UserWorkings.FirstOrDefault(uw => uw.UserWorkingID == userWorkingID);
                if (userWorkingToDelete != null)
                {
                    context.UserWorkings.Remove(userWorkingToDelete);
                    context.SaveChanges();
                }
            }
        }

    }
}
