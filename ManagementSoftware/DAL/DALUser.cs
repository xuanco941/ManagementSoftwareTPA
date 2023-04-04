using System.Text;
using ManagementSoftware.Models;
using ManagementSoftware.ViewModels;
using Microsoft.EntityFrameworkCore;

namespace ManagementSoftware.DAL;

public class DALUser
{
    public static User? AuthLogin(string username, string password)
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
                context.SaveChanges();
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
            var existingUser = context.Users.FirstOrDefault(u => u.UserID == user.UserID);
            if (existingUser != null)
            {
                existingUser.FullName = user.FullName;
                existingUser.Username = user.Username;
                existingUser.Password = user.Password;
                existingUser.Email = user.Email;
                existingUser.PhoneNumber = user.PhoneNumber;
                existingUser.GroupID = user.GroupID;
                context.SaveChanges();
            }
        }
    }


    public void Delete(int userId)
    {
        using (var context = new DataBaseContext())
        {
            var user = context.Users.FirstOrDefault(u => u.UserID == userId);
            if (user != null)
            {
                context.Users.Remove(user);
                context.SaveChanges();
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


