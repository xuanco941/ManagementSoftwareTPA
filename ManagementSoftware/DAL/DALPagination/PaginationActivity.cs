using ManagementSoftware.Models;

namespace ManagementSoftware.DAL.DALPagination
{
    public class PaginationActivity
    {
        private static int NumberRows { get; set; } = Common.NumberRows;
        private int PageCurrent { get; set; }
        private int TotalPages { get; set; }
        private int TotalResults { get; set; }
        private List<Activity>? ListResults { get; set; }

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
