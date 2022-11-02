using ManagementSoftware.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ManagementSoftware.DAL.DALPagination
{
    public class PaginationDirectiveImportWareHouse
    {
        public static int NumberRows { get; set; } = Common.NumberRows;
        public int PageCurrent { get; set; } = 1;
        public int TotalPages { get; set; } = 1;
        public int TotalResults { get; set; } = 0;
        public List<Directive>? ListResults { get; set; }

        public void Set(int page, string str)
        {
            DataBaseContext dbContext = new DataBaseContext();

            int position = (page - 1) * NumberRows;

            if (String.IsNullOrEmpty(str))
            {
                this.ListResults = dbContext.Directives
                .Where(d => d.SoLuongDaSanXuat != 0)
                .Skip(position)
                .Take(NumberRows)
                .ToList();

                this.TotalResults = dbContext.Directives.Where(d => d.SoLuongDaSanXuat != 0).Count();

            }
            else
            {
                this.ListResults = dbContext.Directives
                .Where(d => d.SoLuongDaSanXuat != 0 && (Common.DIRECTIVE + d.DirectiveID).Contains(str))
                .Skip(position)
                .Take(NumberRows)
                .ToList();
                this.TotalResults = dbContext.Directives.Where(d => d.SoLuongDaSanXuat != 0 && (Common.DIRECTIVE + d.DirectiveID).Contains(str)).Count();
            }

            this.PageCurrent = page;
            this.TotalPages = TotalResults % NumberRows == 0 ? TotalResults / NumberRows : (TotalResults / NumberRows) + 1;

        }
    }
}
