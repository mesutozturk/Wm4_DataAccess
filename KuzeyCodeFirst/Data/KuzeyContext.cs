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

            modelBuilder.Entity<SiparisDetay>()
                .ToTable("SiparisDetaylari");

            modelBuilder.Entity<SiparisDetay>()
                .HasKey(x => new { x.SiparisId, x.UrunId }); //composite key

            modelBuilder.Entity<SiparisDetay>()
                .HasOne<Siparis>(sd => sd.Siparis)
                .WithMany(s =>s.SiparisDetaylari)
                .HasForeignKey(sd=>sd.SiparisId);

            modelBuilder.Entity<SiparisDetay>()
                .HasOne<Urun>(sd => sd.Urun)
                .WithMany(u => u.SiparisDetaylari)
                .HasForeignKey(sd => sd.UrunId);
            
            modelBuilder.Entity<SiparisDetay>()
                .Property(x => x.Fiyat)
                .HasPrecision(10, 2);
        }
    }
}