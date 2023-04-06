using System.Text;
using ManagementSoftware.Models;
using ManagementSoftware.ViewModels;
using Microsoft.EntityFrameworkCore;

namespace ManagementSoftware.DAL;

public class DALUser
{
    public User? AuthLogin(string username, string password)
    {
        using (var dbContext = new DataBaseContext())
        {
            try
            {
                User? user = dbContext.Users.Include(u => u.Group).FirstOrDefault(u => u.Username == username.Trim() && u.Password == password.Trim());
                return user;
            }
            catch
            {
                return null;
            }
        }

    }


    // Them TK
    public void Add(User user)
    {
        using (var context = new DataBaseContext())
        {
            try
            {
                context.Users.Add(user);
                int x = context.SaveChanges();
                if (x > 0)
                {
                    Common.listAllUser.Add(user);
                }
            }
            catch
            {

            }

        }
    }


    // Sua TK
    public void Update(User user)
    {
        using (var context = new DataBaseContext())
        {
            try
            {
                var existingUser = context.Users.FirstOrDefault(u => u.UserID == user.UserID);
                if (existingUser != null)
                {
                    existingUser.FullName = user.FullName;
                    existingUser.Username = user.Username;
                    existingUser.Password = user.Password;
                    existingUser.Email = user.Email;
                    existingUser.PhoneNumber = user.PhoneNumber;
                    existingUser.GroupID = user.GroupID;
                    int x = context.SaveChanges();
                    if (x > 0)
                    {
                        int index = Common.listAllUser.FindIndex(u => u.UserID == user.UserID);

                        if (index != -1)
                        {
                            Common.listAllUser[index].FullName = user.FullName;
                            Common.listAllUser[index].Username = user.Username;
                            Common.listAllUser[index].Password = user.Password;
                            Common.listAllUser[index].Email = user.Email;
                            Common.listAllUser[index].PhoneNumber = user.PhoneNumber;
                            Common.listAllUser[index].GroupID = user.GroupID;
                        }
                    }
                }
            }
            catch
            {

            }

        }
    }


    public void Delete(int userId)
    {
        using (var context = new DataBaseContext())
        {
            try
            {
                var user = context.Users.FirstOrDefault(u => u.UserID == userId);
                if (user != null)
                {
                    context.Users.Remove(user);
                    int x = context.SaveChanges();
                    if (x > 0)
                    {
                        var u2 = Common.listAllUser.FirstOrDefault(u => u.UserID == userId);
                        if (u2 != null)
                        {
                            Common.listAllUser.Remove(u2);
                        }
                    }
                }
            }
            catch
            {

            }

        }
    }


    public List<User> GetAll()
    {
        using (var dbContext = new DataBaseContext())
        {
            return dbContext.Users.Include(u => u.Group).ToList();
        }
    }
}


