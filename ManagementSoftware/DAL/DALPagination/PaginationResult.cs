using ManagementSoftware.Models;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ManagementSoftware.DAL.DALPagination
{
    public class PaginationResult
    {
        public static int NumberRows { get; set; } = 30;
        public int PageCurrent { get; set; } = 1;
        public int TotalPages { get; set; } = 1;
        public int TotalResults { get; set; } = 0;
        public List<Result> ListResults { get; set; } = new List<Result>();
        public void Set(int page, DateTime? start, DateTime? end, string loaiKhi, string nguoiVanHanh)
        {
            DataBaseContext dbContext = new DataBaseContext();

            int position = (page - 1) * NumberRows;

            if (start != null && end != null)
            {
                if (end.HasValue)
                {
                    end = end.Value.AddDays(1);
                }

                if (loaiKhi != "Tất cả" && nguoiVanHanh != "Tất cả")
                {
                    ListResults = dbContext.Results.OrderByDescending(t => t.ResultID)
                    .Where(a => start <= a.TimeStart && end >= a.TimeStart && a.LoaiKhi == loaiKhi && a.Username == nguoiVanHanh)
                    .Skip(position)
                    .Take(NumberRows)
                    .ToList();

                    this.TotalResults = dbContext.Results.Where(a => start <= a.TimeStart && end >= a.TimeStart && a.LoaiKhi == loaiKhi && a.Username == nguoiVanHanh).Count();
                }
                else if (loaiKhi == "Tất cả" && nguoiVanHanh != "Tất cả")
                {
                    ListResults = dbContext.Results.OrderByDescending(t => t.ResultID)
                    .Where(a => start <= a.TimeStart && end >= a.TimeStart && a.Username == nguoiVanHanh)
                    .Skip(position)
                    .Take(NumberRows)
                    .ToList();

                    this.TotalResults = dbContext.Results.Where(a => start <= a.TimeStart && end >= a.TimeStart && a.Username == nguoiVanHanh).Count();
                }
                else if (loaiKhi != "Tất cả" && nguoiVanHanh == "Tất cả")
                {
                    ListResults = dbContext.Results.OrderByDescending(t => t.ResultID)
                    .Where(a => start <= a.TimeStart && end >= a.TimeStart && a.LoaiKhi == loaiKhi)
                    .Skip(position)
                    .Take(NumberRows)
                    .ToList();

                    this.TotalResults = dbContext.Results.Where(a => start <= a.TimeStart && end >= a.TimeStart && a.LoaiKhi == loaiKhi).Count();
                }
                else
                {
                    ListResults = dbContext.Results.OrderByDescending(t => t.ResultID)
                    .Where(a => start <= a.TimeStart && end >= a.TimeStart)
                    .Skip(position)
                    .Take(NumberRows)
                    .ToList();

                    this.TotalResults = dbContext.Results.Where(a => start <= a.TimeStart && end >= a.TimeStart).Count();
                }



            }
            else
            {
                if (loaiKhi != "Tất cả" && nguoiVanHanh != "Tất cả")
                {
                    ListResults = dbContext.Results.OrderByDescending(t => t.ResultID)
                    .Where(a => a.LoaiKhi == loaiKhi && a.Username == nguoiVanHanh)
                    .Skip(position)
                    .Take(NumberRows)
                    .ToList();

                    this.TotalResults = dbContext.Results.Where(a => a.LoaiKhi == loaiKhi && a.Username == nguoiVanHanh).Count();
                }
                else if (loaiKhi == "Tất cả" && nguoiVanHanh != "Tất cả")
                {
                    ListResults = dbContext.Results.OrderByDescending(t => t.ResultID)
                    .Where(a => a.Username == nguoiVanHanh)
                    .Skip(position)
                    .Take(NumberRows)
                    .ToList();

                    this.TotalResults = dbContext.Results.Where(a => a.Username == nguoiVanHanh).Count();
                }
                else if (loaiKhi != "Tất cả" && nguoiVanHanh == "Tất cả")
                {
                    ListResults = dbContext.Results.OrderByDescending(t => t.ResultID)
                    .Where(a => a.LoaiKhi == loaiKhi)
                    .Skip(position)
                    .Take(NumberRows)
                    .ToList();

                    this.TotalResults = dbContext.Results.Where(a => a.LoaiKhi == loaiKhi).Count();
                }
                else
                {
                    ListResults = dbContext.Results.OrderByDescending(t => t.ResultID)
                    .Skip(position)
                    .Take(NumberRows)
                    .ToList();

                    this.TotalResults = dbContext.Results.Count();
                }
            }


            this.PageCurrent = page;
            this.TotalPages = TotalResults % NumberRows == 0 ? TotalResults / NumberRows : (TotalResults / NumberRows) + 1;

        }
    }
}
