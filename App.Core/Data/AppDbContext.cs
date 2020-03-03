using System;
using System.Collections.Generic;
using System.Text;
using App.Core.Domain;
using Microsoft.EntityFrameworkCore;

namespace App.Core.Data
{
    public class AppDbContext : DbContext
    {
        public DbSet<Device> Devices { get; set; }

        public AppDbContext()
        {
            
        }

        public AppDbContext(DbContextOptions options) : base(options)
        {
        }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            base.OnConfiguring(optionsBuilder);
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Device>(pc =>
            {
                pc.HasKey(k => k.Id);
                pc.ToTable("vw_Devices");
            });

            base.OnModelCreating(modelBuilder);
        }
    }
}
