using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Text;

namespace CombainedElementsLesson
{
    public class TraderContext : DbContext
    {
        public TraderContext()
        {
            Database.EnsureCreated();
        }

        public DbSet<Company> Companies { get; set; }
        public DbSet<PriceHistory> PriceHistories { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer("Server=A-104-10;Database=TraderDb;Trusted_Connection=True;").UseLazyLoadingProxies();
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            var firstCompany = new Company
            {
                Name = "apple"
            };

            var secondCompany = new Company
            {
                Name = "samsung"
            };

            var priceHistory1 = new PriceHistory
            {
                CompanyId = firstCompany.Id,
                Price = 4
            };
            var priceHistory2 = new PriceHistory
            {
                CompanyId = firstCompany.Id,
                Price = 800
            };
            var priceHistory3 = new PriceHistory
            {
                CompanyId = secondCompany.Id,
                Price = 1600
            };
            var priceHistory4 = new PriceHistory
            {
                CompanyId = secondCompany.Id,
                Price = 3200
            };
            var priceHistory5 = new PriceHistory
            {
                CompanyId = firstCompany.Id,
                Price = 6400
            };
            var priceHistory6 = new PriceHistory
            {
                CompanyId = secondCompany.Id,
                Price = 12800
            };

            modelBuilder.Entity<Company>().HasData(firstCompany);
            modelBuilder.Entity<Company>().HasData(secondCompany);
            modelBuilder.Entity<PriceHistory>().HasData(priceHistory1);
            modelBuilder.Entity<PriceHistory>().HasData(priceHistory2);
            modelBuilder.Entity<PriceHistory>().HasData(priceHistory3);
            modelBuilder.Entity<PriceHistory>().HasData(priceHistory4);
            modelBuilder.Entity<PriceHistory>().HasData(priceHistory5);
            modelBuilder.Entity<PriceHistory>().HasData(priceHistory6);
        }
    }
}
