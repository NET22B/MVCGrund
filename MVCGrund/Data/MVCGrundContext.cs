using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using MVCGrund.Models;

namespace MVCGrund.Data
{
    public class MVCGrundContext : DbContext
    {
        public MVCGrundContext (DbContextOptions<MVCGrundContext> options)
            : base(options)
        {
        }

        public DbSet<MVCGrund.Models.Employee>? Employee { get; set; }

        public DbSet<MVCGrund.Models.Robot>? Robot { get; set; }
    }
}
