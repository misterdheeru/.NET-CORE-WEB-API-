using Microsoft.EntityFrameworkCore;

namespace Exmp3.Models
{
    public class DataContext : DbContext
    {
        public DataContext(DbContextOptions options) : base(options)
        {

        }

        public DbSet<Employees> Employees { get; set; }
    }
}
