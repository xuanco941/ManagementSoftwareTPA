using ManagementSoftware.Models;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ManagementSoftware.DAL.DALPagination
{
    public class PaginationWorkingList
    {
        public static int NumberRows { get; set; } = 40;
        public int PageCurrent { get; set; } = 1;
        public int TotalPages { get; set; } = 1;
        public int TotalResults { get; set; } = 0;
        public List<Directive> ListResults { get; set; } = new List<Directive>();
        public void Set(int page, DateTime? start, DateTime? end, bool? status)
        {
            DataBaseContext dbContext = new DataBaseContext();

            int position = (page - 1) * NumberRows;


            if (status != null)
            {
                if (start != null && end != null)
                {
                    if (end.HasValue)
                    {
                        end = end.Value.AddDays(1);
                    }
                    ListResults = dbContext.Directives.Include(d => d.Product).OrderByDescending(t => t.DirectiveID)
                    .Where(a => a.Status == status && start <= a.CreateAt && end >= a.CreateAt)
                    .Skip(position)
                    .Take(NumberRows)
                    .ToList();

                    this.TotalResults = dbContext.Directives.Where(a => a.Status == status && start <= a.CreateAt && end >= a.CreateAt).Count();

                }
                else
                {
                    ListResults = dbContext.Directives.Include(d => d.Product).OrderByDescending(t => t.DirectiveID)
                    .Where(a => a.Status == status)
                    .Skip(position)
                    .Take(NumberRows)
                    .ToList();
                    this.TotalResults = dbContext.Directives.Where(a => a.Status == status).Count();
                }
            }
            else
            {
                if (start != null && end != null)
                {
                    if (end.HasValue)
                    {
                        end = end.Value.AddDays(1);
                    }
                    ListResults = dbContext.Directives.Include(d => d.Product).OrderByDescending(t => t.DirectiveID)
                    .Where(a => start <= a.CreateAt && end >= a.CreateAt)
                    .Skip(position)
                    .Take(NumberRows)
                    .ToList();

                    this.TotalResults = dbContext.Directives.Where(a => start <= a.CreateAt && end >= a.CreateAt).Count();

                }
                else
                {
                    ListResults = dbContext.Directives.Include(d => d.Product).OrderByDescending(t => t.DirectiveID)
                    .Skip(position)
                    .Take(NumberRows)
                    .ToList();
                    this.TotalResults = dbContext.Directives.Count();
                }
            }

            




            this.PageCurrent = page;
            this.TotalPages = TotalResults % NumberRows == 0 ? TotalResults / NumberRows : (TotalResults / NumberRows) + 1;

        }
    }
}
