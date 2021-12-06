using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using KuzeyCodeFirst.Models.Abstracts;

namespace KuzeyCodeFirst.Models
{
    [Table("Urunler")]
    public class Urun : BaseEntity, IKey<int>
    {
        [Key]
        public int Id { get; set; }
        [Required, StringLength(50)]
        public string Ad { get; set; }
        public decimal Fiyat { get; set; } = 0;
        public int KategorId { get; set; }
        [Range(0, 10000)]
        public int StokMiktari { get; set; }
        public bool DevamEtmiyorMu { get; set; } = true;

        [ForeignKey(nameof(KategorId))]
        public Kategori Kategori { get; set; }
        public ICollection<SiparisDetay> SiparisDetaylari { get; set; } = new HashSet<SiparisDetay>();

    }
}