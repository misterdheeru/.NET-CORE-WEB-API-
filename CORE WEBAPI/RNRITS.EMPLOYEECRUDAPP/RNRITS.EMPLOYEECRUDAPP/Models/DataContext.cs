using Microsoft.EntityFrameworkCore;
namespace RNRITS.EMPLOYEECRUDAPP.Models
{
    public class DataContext :  DbContext
    {
        public DataContext(DbContextOptions options) : base(options)
        {
        
        
        }

        public DbSet<Employee> employee { get; set; }

        public DbSet<Positions> Positions { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            // Configure relationships

            modelBuilder.Entity<Employee>()
               .HasOne(e => e.Position)
               .WithMany(p => p.Employees)
               .HasForeignKey(e => e.PID)
               .OnDelete(DeleteBehavior.Cascade);

            //modelBuilder.Entity<Employee>()
            //    .HasOne(e => e.Department)
            //    .WithMany(d => d.Employees)
            //    .HasForeignKey(e => e.DEPTID)
            //    .OnDelete(DeleteBehavior.Cascade);

            base.OnModelCreating(modelBuilder);



        }

    }
}
