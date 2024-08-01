using Microsoft.EntityFrameworkCore;
 
namespace EMP_CRUD.Models
{
    public class DataContext : DbContext
    {
        public DataContext(DbContextOptions<DataContext> options) : base(options)
        {


        }

        public DbSet<EMPLOYEES> employee { get; set; }
        public DbSet<DEPARTMENT> department { get; set; } // Corrected spelling to 'department'
        public DbSet<POSITION> position { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            // Configure relationships

            modelBuilder.Entity<EMPLOYEES>()
                .HasOne(e => e.DEPARTMENT)
                .WithMany(d => d.EMPLOYEE)
                .HasForeignKey(e => e.deptId)
                .OnDelete(DeleteBehavior.Restrict); // Adjust deletion behavior as needed 

         
        }
    }
}
