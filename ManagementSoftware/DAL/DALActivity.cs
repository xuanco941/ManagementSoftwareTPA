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
                dbContext.Activities.Add(activity);
                dbContext.SaveChanges();
            }
        }

        public void Update(Activity activity)
        {
            using (var dbContext = new DataBaseContext())
            {
                var existingActivity = dbContext.Activities.FirstOrDefault(a => a.ActivityID == activity.ActivityID);
                if (existingActivity != null)
                {
                    dbContext.Entry(existingActivity).CurrentValues.SetValues(activity);
                    dbContext.SaveChanges();
                }
            }
        }

        public void Delete(int activityID)
        {
            using (var dbContext = new DataBaseContext())
            {
                var existingActivity = dbContext.Activities.FirstOrDefault(a => a.ActivityID == activityID);
                if (existingActivity != null)
                {
                    dbContext.Activities.Remove(existingActivity);
                    dbContext.SaveChanges();
                }
            }
        }
        public void DeleteRange(List<int> activityID)
        {
            using (var dbContext = new DataBaseContext())
            {
                List<Activity> usersToDelete = dbContext.Activities.Where(u => activityID.Contains(u.ActivityID)).ToList();
                dbContext.Activities.RemoveRange(usersToDelete);
                dbContext.SaveChanges();
            }
        }
        public async Task<List<string>>? GetDistinctUsernamesAsync()
        {
            using var dbContext = new DataBaseContext();
            var distinctUsernames = await dbContext.Activities.Select(a => a.Username).Distinct().ToListAsync();
            return distinctUsernames;
        }

    }
}
