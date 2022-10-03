using ManagementSoftware.Models;

namespace ManagementSoftware.DAL.DALPagination
{
    public class PaginationActivity
    {
        public static int NumberRows { get; set; } = Common.NumberRows;
        public int PageCurrent { get; set; }
        public int TotalPages { get; set; }
        public int TotalResults { get; set; }
        public List<Activity>? ListResults { get; set; }

        public void Set(int page, int? rows)
        {
            DataBaseContext dbContext = new DataBaseContext();

            if (rows != null)
            {
                NumberRows = rows ?? Common.NumberRows;
            }
            int position = (page - 1) * NumberRows;
            this.TotalResults = dbContext.Groups.Count();

            this.ListResults = dbContext.Activities.OrderByDescending(t => t.ActivityID)
            .Skip(position)
            .Take(NumberRows)
            .ToList();

            this.PageCurrent = page;
            this.TotalPages = (int)Math.Ceiling((float)this.TotalResults / (float)NumberRows);

        }
    }
}
