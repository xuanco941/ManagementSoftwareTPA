using ManagementSoftware.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ManagementSoftware.DAL.DALPagination
{

    //directive.status == true
    public class PaginationDirectiveImportWareHouse
    {
        public static int NumberRows { get; set; } = Common.NumberRows;
        public int PageCurrent { get; set; } = 1;
        public int TotalPages { get; set; } = 1;
        public int TotalResults { get; set; } = 0;
        public List<Directive> ListResults { get; set; } = new List<Directive>();

        public void Set(int page, DateTime? start, DateTime? end)
        {
            DataBaseContext dbContext = new DataBaseContext();

            int position = (page - 1) * NumberRows;

            
            end = end.Value.AddDays(1);

            this.ListResults = dbContext.Directives.OrderByDescending(t => t.DirectiveID)
            .Where(p => start <= p.CreateAt && end >= p.CreateAt && p.Status == true)
            .Skip(position)
            .Take(NumberRows)
            .ToList();
            this.TotalResults = dbContext.Directives.Where(p => start <= p.CreateAt && end >= p.CreateAt && p.Status == true).Count();

            this.PageCurrent = page;
            this.TotalPages = TotalResults % NumberRows == 0 ? TotalResults / NumberRows : (TotalResults / NumberRows) + 1;

        }

        public void Set2(int page, string poID)
        {
            DataBaseContext dbContext = new DataBaseContext();

            int position = (page - 1) * NumberRows;
            this.ListResults = dbContext.Directives.OrderByDescending(t => t.DirectiveID)
            .Where(p => (Common.DIRECTIVE + p.DirectiveID).Contains(poID) == true && p.Status == true)
            .Skip(position)
            .Take(NumberRows)
            .ToList();
            this.TotalResults = dbContext.Directives.Where(p => (Common.DIRECTIVE + p.DirectiveID).Contains(poID) == true && p.Status == true).Count();

            this.PageCurrent = page;
            this.TotalPages = TotalResults % NumberRows == 0 ? TotalResults / NumberRows : (TotalResults / NumberRows) + 1;

        }



    }
}
