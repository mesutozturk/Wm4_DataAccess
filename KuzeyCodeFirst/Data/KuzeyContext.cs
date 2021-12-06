using KuzeyCodeFirst.Models;
using Microsoft.EntityFrameworkCore;

namespace KuzeyCodeFirst.Data
{
    public class KuzeyContext : DbContext
    {
        public KuzeyContext()
            : base()
        {

        }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            if (!optionsBuilder.IsConfigured)
            {
                optionsBuilder.UseSqlServer(@"Data Source=(localdb)\MSSQLLocalDB;Initial Catalog=Kuzey4Db;Integrated Security=True;");
            }
        }

        public DbSet<Kategori> Kategoriler { get; set; }
        public DbSet<Urun> Urunler { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Urun>()
                .Property(x => x.Fiyat)
                .HasPrecision(10, 2);
        }
    }
}