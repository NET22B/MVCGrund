using Microsoft.EntityFrameworkCore;

namespace MVCGrund.Data
{
    public class MVCGrundContext : DbContext
    {
        public MVCGrundContext(DbContextOptions<MVCGrundContext> options)
            : base(options)
        {
        }

        public DbSet<MVCGrund.Models.Employee>? Employee { get; set; }

        public DbSet<MVCGrund.Models.Robot>? Robot { get; set; }


    }
}
