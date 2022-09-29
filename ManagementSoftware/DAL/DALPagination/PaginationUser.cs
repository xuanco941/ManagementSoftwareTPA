using ManagementSoftware.DAL;
using ManagementSoftware.Models;
using ManagementSoftware.ViewModels;

namespace ManagementSoftware.DALPagination
{
    public class PaginationUser
    {
        private static int NumberRows { get; set; } = Common.NumberRows;
        private int pageCurrent { get; set; }
        private int totalPages { get; set; }
        private int totalResults { get; set; }
        private List<UserHasGroupName>? listResults { get; set; }

        public void Set(int page, int? rows)
        {
            DataBaseContext dbContext = new DataBaseContext();

            if (rows != null)
            {
                NumberRows = rows ?? Common.NumberRows;
            }
            int position = (page - 1) * NumberRows;
            this.totalResults = dbContext.Users.Count();

            List<User> users = dbContext.Users.OrderByDescending(t => t.UserID)
            .Skip(position)
            .Take(NumberRows)
            .ToList();

            foreach (var item in users)
            {
                if (item != null)
                {
                    this.listResults.Add(new UserHasGroupName() { UserID = item.UserID, FullName = item.FullName, Username = item.Username, Password = item.Password, GroupName = DALGroup.GetGroupFromID(item.GroupID).GroupName });
                }
            }

            this.pageCurrent = page;
            this.totalPages = (int)Math.Ceiling((float)this.totalResults / (float)NumberRows);

        }
    }
}