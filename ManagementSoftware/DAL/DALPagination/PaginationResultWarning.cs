using ManagementSoftware.Models;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ManagementSoftware.DAL.DALPagination
{
    public class PaginationResultWarning
    {
        public static int NumberRows { get; set; } = 30;
        public int PageCurrent { get; set; } = 1;
        public int TotalPages { get; set; } = 1;
        public int TotalResults { get; set; } = 0;
        public List<ResultWarning> ListResults { get; set; } = new List<ResultWarning>();
        DataBaseContext dbContext = new DataBaseContext();
        public void Set(int page, DateTime? start, DateTime? end)
        {

            int position = (page - 1) * NumberRows;

            if (start != null && end != null)
            {
                if (end.HasValue)
                {
                    end = end.Value.AddDays(1);
                }
                ListResults = dbContext.ResultWarnings.Include(r => r.Result).OrderByDescending(t => t.ResultWarningID)
                .Where(a => start <= a.CreateAt && end >= a.CreateAt)
                .Skip(position)
                .Take(NumberRows)
                .ToList();

                this.TotalResults = dbContext.ResultWarnings.Where(a => start <= a.CreateAt && end >= a.CreateAt).Count();

            }
            else
            {
                ListResults = dbContext.ResultWarnings.OrderByDescending(t => t.ResultWarningID)
                .Skip(position)
                .Take(NumberRows)
                .ToList();
                this.TotalResults = dbContext.ResultWarnings.Count();
            }


            this.PageCurrent = page;
            this.TotalPages = TotalResults % NumberRows == 0 ? TotalResults / NumberRows : (TotalResults / NumberRows) + 1;

        }
    }
}
