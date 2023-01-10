using System;
using System.IO;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Storage;
using SalesSystemApi.Clients.Domain;
using SalesSystemApi.Database.Domain.MSSql;

namespace SalesSystemApi.Clients.Infrastructure.MSSql
{
    public class ClientContext : DbContext
    {
        private MsSqlRelationalDatabase database;
        public DbSet<Client> Clients { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            this.database = new MsSqlRelationalDatabase();
            optionsBuilder.UseSqlServer($"Server={this.database.Server},{this.database.Port};Database={this.database.Database};User Id={this.database.User};Password={this.database.Password};TrustServerCertificate=True;MultiSubnetFailover=True");
        }


        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);

            modelBuilder.Entity<Client>(entity =>
            {
                entity.HasKey(e => e.Id);
                entity.Property(e => e.Name).IsRequired();
            });
        }
    }
}