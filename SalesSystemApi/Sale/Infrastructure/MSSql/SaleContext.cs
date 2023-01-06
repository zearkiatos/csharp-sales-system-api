using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Storage;
using SalesSystemApi.Concept.Domain;
using SalesSystemApi.Database.Domain.MSSql;

namespace SalesSystemApi.Sale.Infrastructure.Context
{
    public class SaleContext : DbContext
    {
        private MsSqlRelationalDatabase database;
        public DbSet<Concept> Concepts { get; set; }

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
                entity.Property(e => e.Date).IsRequired();
                entity.Property(e => e.Total).IsRequired();
                entity.Property(e => e.ClientId).IsRequired();
            });
        }
    }
}