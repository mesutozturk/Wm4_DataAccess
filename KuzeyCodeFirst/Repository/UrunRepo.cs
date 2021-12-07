using KuzeyCodeFirst.Models;
using KuzeyCodeFirst.Repository.Abstracts;

namespace KuzeyCodeFirst.Repository
{
    public class UrunRepo : RepositoryBase<Urun, int>
    {
        public override void Update(Urun entity, bool isSaveLater = false)
        {
            var entry = _context.Entry(entity);
            var eskiFiyat = (decimal)entry.OriginalValues["Fiyat"];
            //ürün fiyat geçmişi tablosuna eklenir/loglanır
            base.Update(entity, isSaveLater);
        }
    }
}