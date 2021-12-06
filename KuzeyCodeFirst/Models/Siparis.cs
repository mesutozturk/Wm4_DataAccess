using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace KuzeyCodeFirst.Models
{
    [Table("Siparisler")]
    public class Siparis
    {
        [Key]
        public int Id { get; set; }
        public DateTime SiparisTarihi { get; set; } = DateTime.Now;
        [Column(TypeName = "smalldatetime")]
        public DateTime? UlasmaTarihi { get; set; }

        public ICollection<SiparisDetay> SiparisDetaylari { get; set; } = new HashSet<SiparisDetay>();
    }
}