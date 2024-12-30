using Microsoft.EntityFrameworkCore;

namespace _14CodeFirstEF.Models
{
    public class DACDbContext:DbContext
    {
        public DbSet<Emp> emp {  get; set; }

        public DACDbContext(DbContextOptions options) : base(options)
        {
             
        }
    }
}
