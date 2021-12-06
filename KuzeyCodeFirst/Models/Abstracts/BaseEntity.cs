using System;
using System.ComponentModel.DataAnnotations;

namespace KuzeyCodeFirst.Models.Abstracts
{
    public abstract class BaseEntity
    {
        public DateTime CreatedDate { get; set; }
        public DateTime? UpdatedDate { get; set; }
        public DateTime? DeletedDate { get; set; }
        public bool IsDeleted { get; set; } = false;
    }

    public interface IKey<TId>
    {
        [Key]
        public TId Id { get; set; }
    }
}
