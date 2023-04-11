using ManagementSoftware.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ManagementSoftware.DAL
{
    public class DALResult
    {
        public Result? Add(Result result)
        {
            using (var context = new DataBaseContext())
            {
                try
                {
                    context.Results.Add(result);
                    context.SaveChanges();

                    return result;
                }
                catch
                {
                    return null;
                }

            }
        }


        public bool Update(Result result)
        {
            using (var context = new DataBaseContext())
            {
                try
                {
                    var resultToUpdate = context.Results.FirstOrDefault(r => r.ResultID == result.ResultID);
                    if (resultToUpdate == null)
                    {
                        return false;
                    }

                    resultToUpdate.LoaiKhi = result.LoaiKhi;
                    resultToUpdate.TimeStart = result.TimeStart;
                    resultToUpdate.TimeEnd = result.TimeEnd;
                    resultToUpdate.Status = result.Status;
                    resultToUpdate.UserID = result.UserID;
                    resultToUpdate.Username = result.Username;
                    resultToUpdate.TheTichCanNap = result.TheTichCanNap;
                    resultToUpdate.TheTichTieuChuan = result.TheTichTieuChuan;
                    resultToUpdate.ApSuatTieuChuan = result.ApSuatTieuChuan;
                    resultToUpdate.HeSoTieuChuan = result.HeSoTieuChuan;
                    resultToUpdate.ThoiGianTrichMau = result.ThoiGianTrichMau;
                    resultToUpdate.SoLuongBinhCanNapHe1 = result.SoLuongBinhCanNapHe1;
                    resultToUpdate.SoLuongBinhCanNapHe2 = result.SoLuongBinhCanNapHe2;

                    context.SaveChanges();
                    return true;
                }
                catch
                {
                    return false;
                }

            }
        }



        public void Delete(int resultID)
        {
            using (var context = new DataBaseContext())
            {
                try
                {
                    var resultToDelete = context.Results.Find(resultID);
                    if (resultToDelete != null)
                    {
                        context.Results.Remove(resultToDelete);
                        context.SaveChanges();
                    }
                }
                catch
                {

                }

            }
        }


        public List<string> GetListNameLoaiKhi()
        {
            using (var context = new DataBaseContext())
            {
                try
                {
                    return context.Results.Select(x => x.LoaiKhi).Distinct().ToList();
                }
                catch
                {
                    return new List<string>();
                }
            }
        }
        public List<string> GetListNameNguoiVanHanh()
        {
            using (var context = new DataBaseContext())
            {
                try
                {
                    return context.Results.Select(x => x.Username).Distinct().ToList();
                }
                catch
                {
                    return new List<string>();
                }
            }
        }

        public Result? GetResultNewestWithStatusFalse()
        {
            using (var context = new DataBaseContext())
            {
                try
                {
                    Result? latestResult = context.Results.OrderByDescending(r => r.ResultID).FirstOrDefault(a => a.Status == false);
                    return latestResult;
                }
                catch
                {
                    return null;
                }
            }
        }




        //public static int Update(Result r)
        //{
        //    using (DataBaseContext dbContext = new DataBaseContext())
        //    {
        //        var result = dbContext.Results.FirstOrDefault(g => g.ResultID == r.ResultID);
        //        if (result != null)
        //        {
        //            dbContext.Entry(result).CurrentValues.SetValues(r);
        //        }
        //        return dbContext.SaveChanges();
        //    }
        //}

    }
}
