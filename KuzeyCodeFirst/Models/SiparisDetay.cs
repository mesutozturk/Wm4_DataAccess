using System.ComponentModel.DataAnnotations.Schema;

namespace KuzeyCodeFirst.Models
{
    //[Table("SiparisDetaylari")]
    public class SiparisDetay
    {
        public int SiparisId { get; set; }
        public int UrunId { get; set; }
        public int Adet { get; set; }
        public decimal Fiyat { get; set; }

        //[ForeignKey(nameof(SiparisId))]
        public Siparis Siparis { get; set; }
        //[ForeignKey(nameof(UrunId))]
        public Urun Urun { get; set; }
    }
}