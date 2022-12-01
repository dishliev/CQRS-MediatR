using CQRS_MediatR.Models;
using Microsoft.EntityFrameworkCore;

namespace CQRS_MediatR.Data
{
    public class DatabaseContext : DbContext
    {
        public DbSet<Customer> Customers { get; set; }

        public DatabaseContext(DbContextOptions<DatabaseContext> options)
            : base(options)
        {
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);

            modelBuilder.Entity<Customer>().HasData
            (
                new Customer { Id = 1, Name = "Cust 1", Address = "Address 1" },
                new Customer { Id = 2, Name = "Cust 2", Address = "Address 2" },
                new Customer { Id = 3, Name = "Cust 3", Address = "Address 3" }
            );
        }
    }
}