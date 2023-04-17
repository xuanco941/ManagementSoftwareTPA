using ManagementSoftware.Models;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ManagementSoftware.DAL.DALPagination
{
    internal class PaginationMachine
    {
        public int NumberRows { get; set; } = 40;
        public int PageCurrent { get; set; } = 1;
        public int TotalPages { get; set; } = 1;
        public int TotalResults { get; set; } = 0;
        public List<Machine> ListResults { get; set; } = new List<Machine>();
        DataBaseContext dbContext = new DataBaseContext();

        public void SetNumRow(int n)
        {
            NumberRows = n;
        }

        public void Set(int page, DateTime? start, DateTime? end, string? idMachine)
        {
            if (string.IsNullOrEmpty(idMachine) == false)
            {
                idMachine = idMachine.Replace(" ", "").Replace("\r\n", "").Replace("\n", "");
            }

            List<string>? listStrings = string.IsNullOrEmpty(idMachine) == false ? idMachine.ToUpper().Split(',').Distinct().ToList() : null;
            int position = (page - 1) * NumberRows;



            if (listStrings != null && listStrings.Count > 0)
            {
                if (start != null && end != null)
                {
                    if (end.HasValue)
                    {
                        end = end.Value.AddDays(1);
                    }
                    ListResults = dbContext.Machines.Include(a => a.Result).OrderByDescending(t => t.MachineID)
                    .Where(a => (start <= a.CreateAt && end >= a.CreateAt) && (listStrings.Contains(a.ResultID.ToString()) || listStrings.Contains(Common.RESULT + a.ResultID)))
                    .Skip(position)
                    .Take(NumberRows)
                    .ToList();

                    this.TotalResults = dbContext.Machines.Where(a => (start <= a.CreateAt && end >= a.CreateAt) && (listStrings.Contains(a.ResultID.ToString()) || listStrings.Contains(Common.RESULT + a.ResultID))).Count();

                }
                else
                {
                    ListResults = dbContext.Machines.Include(a => a.Result).OrderByDescending(t => t.MachineID)
                        .Where(a => listStrings.Contains(a.ResultID.ToString()) || listStrings.Contains(Common.RESULT + a.ResultID))
                    .Skip(position)
                    .Take(NumberRows)
                    .ToList();

                    this.TotalResults = dbContext.Machines.Where(a => listStrings.Contains(a.ResultID.ToString()) || listStrings.Contains(Common.RESULT + a.ResultID)).Count();
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
                    ListResults = dbContext.Machines.Include(a => a.Result).OrderByDescending(t => t.MachineID)
                    .Where(a => start <= a.CreateAt && end >= a.CreateAt)
                    .Skip(position)
                    .Take(NumberRows)
                    .ToList();

                    this.TotalResults = dbContext.Machines.Where(a => start <= a.CreateAt && end >= a.CreateAt).Count();

                }
                else
                {
                    ListResults = dbContext.Machines.Include(a => a.Result).OrderByDescending(t => t.MachineID)
                    .Skip(position)
                    .Take(NumberRows)
                    .ToList();
                    this.TotalResults = dbContext.Machines.Count();
                }
            }



            this.PageCurrent = page;
            this.TotalPages = TotalResults % NumberRows == 0 ? TotalResults / NumberRows : (TotalResults / NumberRows) + 1;

        }
    }
}
