using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Storage;
using SalesSystemApi.Product.Domain;
using SalesSystemApi.Database.Domain.MSSql;

namespace SalesSystemApi.Product.Infrastructure.Context
{
    public class ConceptContext : DbContext
    {
        private MsSqlRelationalDatabase database;
        public DbSet<Product> Products { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            this.database = new MsSqlRelationalDatabase();
            optionsBuilder.UseSqlServer($"Server={this.database.Server},{this.database.Port};Database={this.database.Database};User Id={this.database.User};Password={this.database.Password}");
        }


        protected override void OnModelCreating(DbContextOptionsBuilder optionsBuilder)
        {
            base.OnModelCreating(modelBuilder);

            modelBuilder.Entity<Concept>(entity =>
            {
                entity.HasKey(e => e.Id);
                entity.Property(e => e.Name).IsRequired();
                entity.Property(e => e.UnitPrice).IsRequired();
                entity.Property(e => e.Cost).IsRequired();
            });
        }
    }
}