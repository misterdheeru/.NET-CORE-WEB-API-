using Microsoft.EntityFrameworkCore;
using System.Reflection.Emit;

namespace GP.EMPLOYEE.CRUD.Models
{
    public class DataContext : DbContext
    {
     public DataContext(DbContextOptions options):base(options) 
        {
           
          
            

        }

        public DbSet<Employees> employees { get; set; }
        public DbSet<Company> companies { set; get; } 
        public DbSet<Positions> positions { get; set; }

        /* https://learn.microsoft.com/en-us/ef/core/modeling/ */
        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Employees>()
             .HasOne(p=>p.Positions)
             .WithMany(p=>p.employees)
             .HasForeignKey(p=>p.Id)
             .OnDelete(DeleteBehavior.Cascade);

            modelBuilder.Entity<Employees>()
                .HasOne(c=>c.company)
                .WithMany(e=>e.employees)
                .HasForeignKey(c=>c.companyID)
                .OnDelete(DeleteBehavior.Cascade);

            base.OnModelCreating(modelBuilder);
        }
        
    }
}
