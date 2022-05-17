using Pool.Core.DataAccess;
using Pool.Core.DataAccess.EntityFramework;
using Pool.DataAccess.Abstract;
using Pool.Entities;
using Pool.Entities.ComplexTypes;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace Pool.DataAccess.Concrete.EntityFramework
{
    public class EfSiparisDal : EfEntityRepositoryBase<Siparisler, PoolContext>, ISiparisDal
    {
        public List<UrunSiparis> SiparisJoinUrun(int hareketId)
        {
            using (PoolContext context = new PoolContext())
            {
                var result = from S in context.Siparişler
                             join U in context.Stoklar
                             on S.StokId equals U.Id
                             where (S.Hareket_ID ==hareketId)
                             select new UrunSiparis
                             {

                                 Ürün_Adi = U.Ürün_Adı,
                                 Adet = S.Adet,
                                 BirimTutar=U.Ürün_Fiyatı,                                

                             };
                return result.ToList();
            }
        }
    }
}
