using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Logging;

namespace ManagementSoftware.Models
{
    public class DataBaseContext : DbContext
    {
        public DbSet<User> Users { get; set; }
        public DbSet<Group> Groups { get; set; }
        public DbSet<Activity> Activities { get; set; }
        public DbSet<Shift> Shifts { get; set; }
        public DbSet<PurchaseOrder> PurchaseOrders { get; set; }
        public DbSet<DirectivePO> DirectivePOs { get; set; }
        public DbSet<Result> Results { get; set; }
        public DbSet<DataResult> DataResults { get; set; }
        public DbSet<ResultWarning> ResultWarnings { get; set; }

        // Tạo ILoggerFactory 
        public static readonly ILoggerFactory loggerFactory = LoggerFactory.Create(builder => {
            builder
                   .AddFilter(DbLoggerCategory.Database.Command.Name, LogLevel.Information)
                   .AddFilter(DbLoggerCategory.Query.Name, LogLevel.Information)
                   .AddDebug();
        }
        );

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            base.OnConfiguring(optionsBuilder);
            optionsBuilder
                .UseLoggerFactory(loggerFactory)  // - Thiết lập sử Logger
                .UseSqlServer(Common.ConnectionString);
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            //user
            modelBuilder.Entity<User>(entity =>
            {
                entity.Property(e => e.Password).HasDefaultValueSql("('leanway')");
                entity.HasIndex(e => e.Username).IsUnique();
            });

            //group
            modelBuilder.Entity<Group>(entity =>
            {
                entity.Property(e => e.IsManagementGroup).HasDefaultValueSql("(0)");
                entity.Property(e => e.IsManagementUser).HasDefaultValueSql("(0)");
                entity.HasIndex(e => e.GroupName).IsUnique();

            });

            //activity
            modelBuilder.Entity<Activity>(entity =>
            {
                entity.Property(e => e.CreateAt).HasDefaultValueSql("(getdate())");
            });

            //PO
            modelBuilder.Entity<PurchaseOrder>(entity =>
            {
                entity.Property(e => e.Status).HasDefaultValueSql("(0)");
                entity.Property(e => e.CreateAt).HasDefaultValueSql("(getdate())");
                entity.Property(e => e.SoPRPQ).HasDefaultValueSql("(0)");
            });
            //DirectivePO
            modelBuilder.Entity<DirectivePO>(entity =>
            {
                entity.Property(e => e.Status).HasDefaultValueSql("(0)");
                entity.Property(e => e.CreateAt).HasDefaultValueSql("(getdate())");
            });
            //Result
            modelBuilder.Entity<Result>(entity =>
            {
                entity.Property(e => e.Status).HasDefaultValueSql("(0)");
                entity.Property(e => e.TimeStart).HasDefaultValueSql("(getdate())");
            });
            //DataResult
            modelBuilder.Entity<DataResult>(entity =>
            {
                entity.Property(e => e.CreateAt).HasDefaultValueSql("(getdate())");
            });
            //ResultWarning
            modelBuilder.Entity<ResultWarning>(entity =>
            {
                entity.Property(e => e.CreateAt).HasDefaultValueSql("(getdate())");
            });

        }

        public bool CreateDatabase()
        {
            this.Database.EnsureDeleted();
            return this.Database.EnsureCreated();
        }

    }
}
