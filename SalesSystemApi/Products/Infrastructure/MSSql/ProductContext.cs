using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Storage;
using SalesSystemApi.Products.Domain;
using SalesSystemApi.Database.Domain.MSSql;

namespace SalesSystemApi.Products.Infrastructure.Context
{
    public class ProductContext : DbContext
    {
        private MsSqlRelationalDatabase database;
        public DbSet<Product> Products { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            this.database = new MsSqlRelationalDatabase();
            optionsBuilder.UseSqlServer($"Server={this.database.Server},{this.database.Port};Database={this.database.Database};User Id={this.database.User};Password={this.database.Password}");
        }


        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);
            modelBuilder.Entity<Product>(entity =>
            {
                entity.HasKey(e => e.Id);
                entity.Property(e => e.Name).IsRequired();
                entity.Property(e => e.UnitPrice).IsRequired();
                entity.Property(e => e.Cost).IsRequired();
            });
        }
    }
}