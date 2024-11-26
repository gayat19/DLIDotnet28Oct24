using FirstAPiApp.Models;
using Microsoft.EntityFrameworkCore;

namespace FirstAPiApp.Contexts
{
    public class HRContext :DbContext
    {
        public HRContext(DbContextOptions options) : base(options)
        {

        }

        public DbSet<Employee>   Employees { get; set; }
        public DbSet<Department> Departments { get; set; }
        public DbSet<User> Users { get; set; }
        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Department>().HasData(new Department { DepartmentId = 1, DepartmentName = "HR" },
                new Department { DepartmentId = 2, DepartmentName = "Admin" });
            modelBuilder.Entity<Employee>().HasData(
                new Employee { Id = 101, Name = "Ramu", Email = "ramu@mycompany.com", DepartmentId = 1 },
                new Employee { Id = 102, Name = "Somu", Email = "somu@mycompany.com", DepartmentId = 2 },
                new Employee { Id = 103, Name = "Bimu", Email = "bimu@mycompany.com", DepartmentId = 2 },
                new Employee { Id = 104, Name = "Komu", Email = "komu@mycompany.com", DepartmentId = 2 });

            modelBuilder.Entity<User>()
                .Property(u => u.Id)
                .ValueGeneratedNever();

            modelBuilder.Entity<User>()
                .HasOne(u => u.Employee)
                .WithOne(e => e.User)
                .HasForeignKey<User>(u => u.Id)
                .HasConstraintName("FK_User_Employee")
                .OnDelete(DeleteBehavior.Restrict);

        }

    }
}
