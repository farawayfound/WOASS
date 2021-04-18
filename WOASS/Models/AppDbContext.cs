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

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);


            modelBuilder.Entity<Work>()
                        .HasData(new Work
                        {
                            WorkId = 1,
                            OrderDate = "10/27/2020",
                            Priority = false,
                            WorkType = "wax",
                            Notes = null,
                            PayStatus = true,
                            PriceId = 1,
                            GearId = 1,
                            UserId = 1
                        });

            modelBuilder.Entity<Work>()
                        .HasData(new Work
                        {
                            WorkId = 2,
                            OrderDate = "10/28/2020",
                            Priority = false,
                            WorkType = "base grind",
                            Notes = null,
                            PayStatus = true,
                            PriceId = 2,
                            GearId = 2,
                            UserId = 2
                        });

            modelBuilder.Entity<Work>()
                        .HasData(new Work
                        {
                            WorkId = 3,
                            OrderDate = "10/29/2020",
                            Priority = false,
                            WorkType = "base grind",
                            Notes = null,
                            PayStatus = true,
                            PriceId = 2,
                            GearId = 3,
                            UserId = 2
                        });

            modelBuilder.Entity<Work>()
                        .HasData(new Work
                        {
                            WorkId = 4,
                            OrderDate = "10/30/2020",
                            Priority = false,
                            WorkType = "basic tune",
                            Notes = null,
                            PayStatus = true,
                            PriceId = 3,
                            GearId = 4,
                            UserId = 3
                        });
            modelBuilder.Entity<Work>()
                        .HasData(new Work
                        {
                            WorkId = 5,
                            OrderDate = "11/1/2020",
                            Priority = false,
                            WorkType = "basic tune",
                            Notes = null,
                            PayStatus = true,
                            PriceId = 3,
                            GearId = 4,
                            UserId = 3
                        });
        }
    }
}
