using Microsoft.EntityFrameworkCore;

namespace MODAL
{
    public class DATACONTEXT : DbContext
    {
         DATACONTEXT (DbContextOptions<DATACONTEXT> options) : base(options)
        {

        }

        DbSet<Employees> Employees { get; set; }
    }
}
