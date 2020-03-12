using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;

namespace StoreManager.Models
{
    public class StoreDbContext: DbContext
    {

        public DbSet<Users> Users { get; set; }

        public DbSet<Products> Products { get; set; }

        public DbSet<Bills> Bills { get; set; }
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer("Data Source=HCM-PHONGCT\\SQLEXPRESS;Initial Catalog=StoreDB;Integrated Security=True");
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Users>(b =>
            {
                b.HasKey(e => e.ID);
                b.Property(e => e.ID).ValueGeneratedOnAdd();
            });

            modelBuilder.Entity<Products>(b =>
            {
                b.HasKey(e => e.ID);
                b.Property(e => e.ID).ValueGeneratedOnAdd();
            });

            modelBuilder.Entity<Bills>(b =>
            {
                b.HasKey(e => e.ID);
                b.Property(e => e.ID).ValueGeneratedOnAdd();
            });
        }
    }
}
