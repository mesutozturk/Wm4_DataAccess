using KuzeyCodeFirst.Models;
using Microsoft.EntityFrameworkCore;

namespace KuzeyCodeFirst.Data
{
    public class KuzeyContext : DbContext
    {
        public KuzeyContext()
            :base()
        {
            
        }

        public DbSet<Kategori> Kategoriler { get; set; }
        public DbSet<Urun> Urunler { get; set; }
    }
}
