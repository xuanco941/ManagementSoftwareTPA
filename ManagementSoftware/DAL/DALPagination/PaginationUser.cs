using ManagementSoftware.DAL;
using ManagementSoftware.Models;
using ManagementSoftware.ViewModels;

namespace ManagementSoftware.DALPagination
{
    public class PaginationUser
    {
        public static int NumberRows { get; set; } = Common.NumberRows;
        public int PageCurrent { get; set; }
        public int TotalPages { get; set; }
        public int TotalResults { get; set; }
        public List<UserHasGroupName>? ListResults { get; set; }

        public void Set(int page, int? rows)
        {
            DataBaseContext dbContext = new DataBaseContext();

            if (rows != null)
            {
                NumberRows = rows ?? Common.NumberRows;
            }
            int position = (page - 1) * NumberRows;
            this.TotalResults = dbContext.Users.Count();

            List<User> users = dbContext.Users.OrderByDescending(t => t.UserID)
            .Skip(position)
            .Take(NumberRows)
            .ToList();

            List<UserHasGroupName>? ListResults2 = new List<UserHasGroupName>();


            foreach (User item in users)
            {
                Group? grOfUser = DALGroup.GetGroupFromID(item.GroupID);
                string nameGr = grOfUser != null ? grOfUser.GroupName : "Lỗi(Not Found)";
                ListResults2.Add(new UserHasGroupName
                {
                    UserID = item.UserID,
                    FullName = item.FullName,
                    Username = item.Username,
                    Password = item.Password,
                    GroupName = nameGr
                });
            }
            this.ListResults = ListResults2;
            this.PageCurrent = page;
            this.TotalPages = (int)Math.Ceiling((float)this.TotalResults / (float)NumberRows);

        }
    }
}