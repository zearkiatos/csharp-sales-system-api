using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Storage;
using SalesSystemApi.Concepts.Domain;
using SalesSystemApi.Database.Domain.MSSql;

namespace SalesSystemApi.Concepts.Infrastructure.Context
{
    public class ConceptContext : DbContext
    {
        private MsSqlRelationalDatabase database;
        public DbSet<Concept> Concepts { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            this.database = new MsSqlRelationalDatabase();
            optionsBuilder.UseSqlServer($"Server={this.database.Server},{this.database.Port};Database={this.database.Database};User Id={this.database.User};Password={this.database.Password}");
        }


        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);

            modelBuilder.Entity<Concept>(entity =>
            {
                entity.HasKey(e => e.Id);
                entity.Property(e => e.SaleId).IsRequired();
                entity.Property(e => e.Quantity).IsRequired();
                entity.Property(e => e.UnitPrice).IsRequired();
                entity.Property(e => e.Import).IsRequired();
                entity.Property(e => e.ProductId).IsRequired();
            });
        }
    }
}