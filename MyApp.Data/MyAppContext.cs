using Microsoft.EntityFrameworkCore;
using System;

namespace MyApp.Data
{
    public class MyAppContext : DbContext
    {
        public MyAppContext()
        {
        }

        public MyAppContext(DbContextOptions<MyAppContext> options)
            : base(options)
        {
        }

        public DbSet<Domain.Customer> Customers { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            if (optionsBuilder.IsConfigured)
            {
                return;
            }
            // throw exception not configured?
            //optionsBuilder.UseLoggerFactory
            optionsBuilder.UseSqlServer("Data Source=(local);Initial Catalog=CB.Tenant;Integrated Security=True",
                x =>
                {
                    //x.ExecutionStrategy
                    //x.MigrationsAssembly
                    //x.UseRowNumberForPaging
                });
            base.OnConfiguring(optionsBuilder); // Needed? Does what?
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.ApplyConfiguration(new CustomerConfig());
        }
    }
}
