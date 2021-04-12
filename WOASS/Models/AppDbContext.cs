using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace WOASS.Models
{
    public class AppDbContext : DbContext
    {
        // F i e l d s  &  P r o p e r t i e s

        public DbSet<Work> WorkOrders { get; set; }

        // C o n s t r u c t o r s

        public AppDbContext(DbContextOptions<AppDbContext> options)
            : base(options) //Let Parent constructor deal with options
        {
        }

        // M e t h o d s
    }
}
