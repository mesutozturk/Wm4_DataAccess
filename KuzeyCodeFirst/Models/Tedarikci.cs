using KuzeyCodeFirst.Models.Abstracts;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace KuzeyCodeFirst.Models
{
    [Table("Tedarikciler")]
    public class Tedarikci : BaseEntity, IKey<Guid>
    {
        [Key]
        public Guid Id { get; set; } = Guid.NewGuid();
        [Required,StringLength(200)]
        public string FirmaAdi { get; set; }
        [StringLength(11)]
        public string Telefon { get; set; }

        public ICollection<Urun> Urunler { get; set; } = new HashSet<Urun>();
    }
}