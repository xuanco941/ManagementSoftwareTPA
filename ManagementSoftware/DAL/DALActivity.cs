using ManagementSoftware.Models;
using Microsoft.EntityFrameworkCore;

namespace ManagementSoftware.DAL
{
    public class DALActivity
    {
        public void Add(Activity activity)
        {
            using (var dbContext = new DataBaseContext())
            {
                try
                {
                    dbContext.Activities.Add(activity);
                    dbContext.SaveChanges();
                }
                catch
                {

                }

            }
        }

        public void Update(Activity activity)
        {
            using (var dbContext = new DataBaseContext())
            {
                try
                {
                    var existingActivity = dbContext.Activities.FirstOrDefault(a => a.ActivityID == activity.ActivityID);
                    if (existingActivity != null)
                    {
                        dbContext.Entry(existingActivity).CurrentValues.SetValues(activity);
                        dbContext.SaveChanges();
                    }
                }
                catch
                {

                }

            }
        }

        public void Delete(int activityID)
        {
            using (var dbContext = new DataBaseContext())
            {
                try
                {
                    var existingActivity = dbContext.Activities.FirstOrDefault(a => a.ActivityID == activityID);
                    if (existingActivity != null)
                    {
                        dbContext.Activities.Remove(existingActivity);
                        dbContext.SaveChanges();
                    }
                }
                catch
                {

                }

            }
        }
        public void DeleteRange(List<int> activityID)
        {
            using (var dbContext = new DataBaseContext())
            {
                try
                {
                    List<Activity> usersToDelete = dbContext.Activities.Where(u => activityID.Contains(u.ActivityID)).ToList();
                    dbContext.Activities.RemoveRange(usersToDelete);
                    dbContext.SaveChanges();
                }
                catch
                {

                }

            }
        }

    }
}
