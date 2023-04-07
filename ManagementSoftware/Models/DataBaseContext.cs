using ManagementSoftware.DAL;
using Microsoft.EntityFrameworkCore;

namespace ManagementSoftware.Models
{
    public class DataBaseContext : DbContext
    {
        public DbSet<User> Users { get; set; }
        public DbSet<Group> Groups { get; set; }
        public DbSet<Activity> Activities { get; set; }
        public DbSet<Result> Results { get; set; }
        public DbSet<ResultWarning> ResultWarnings { get; set; }
        public DbSet<Machine> Machines { get; set; }
        public DbSet<UserWorking> UserWorkings { get; set; }


        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            base.OnConfiguring(optionsBuilder);
            optionsBuilder.UseSqlServer(Common.ConnectionString);
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            //user
            modelBuilder.Entity<User>(entity =>
            {
                entity.Property(e => e.Password).HasDefaultValueSql("('leanway')");
                entity.HasIndex(e => e.Username).IsUnique();
            });

            //GroupID có thể null
            modelBuilder.Entity<User>()
            .HasOne(t => t.Group)
            .WithMany()
            .HasForeignKey(t => t.GroupID)
            .OnDelete(DeleteBehavior.SetNull);




            //group
            modelBuilder.Entity<Group>(entity =>
            {
                entity.Property(e => e.IsManagementMachine).HasDefaultValueSql("(0)");
                entity.Property(e => e.IsManagementUser).HasDefaultValueSql("(0)");
                entity.HasIndex(e => e.GroupName).IsUnique();

            });

            //activity
            modelBuilder.Entity<Activity>(entity =>
            {
                entity.Property(e => e.CreateAt).HasDefaultValueSql("(getdate())");
            });



            //Result
            modelBuilder.Entity<Result>(entity =>
            {
                entity.Property(e => e.Status).HasDefaultValueSql("(0)");
                entity.Property(e => e.TimeStart).HasDefaultValueSql("(getdate())");
            });


            //ResultWarning
            modelBuilder.Entity<ResultWarning>(entity =>
            {
                entity.Property(e => e.CreateAt).HasDefaultValueSql("(getdate())");
            });

            //UserWorking
            modelBuilder.Entity<UserWorking>(entity =>
            {
                entity.Property(e => e.CreateAt).HasDefaultValueSql("(getdate())");
                entity.Property(e => e.EndAt).HasDefaultValueSql("(getdate())");
            });

            //machine
            modelBuilder.Entity<Machine>(entity =>
            {
                entity.Property(e => e.CreateAt).HasDefaultValueSql("(getdate())");
            });

        }





        public bool CheckDatabaseExists()
        {
            try
            {
                return this.Database.CanConnect();
            }
            catch
            {
                return false;
            }
        }

        public bool CreateDatabase()
        {
            try
            {
                //this.Database.EnsureDeleted();
                //init db
                if (this.Database.EnsureCreated() == true)
                {
                    //tao quuyen cho admin
                    new DALGroup().Add(Common.GroupAdmin);
                    new DALGroup().Add(Common.GroupUser);

                    //tao tai khoan admin
                    new DALUser().Add(Common.UserAdmin);

                    new DALActivity().Add(new Activity { Title = "Tạo mới", Description = "Khởi tạo tài khoản admin.", Username = Common.UserAdmin.Username, UserID = Common.UserAdmin.UserID });


                }
                return true;

            }
            catch
            {
                return false;
            }


        }

    }
}
