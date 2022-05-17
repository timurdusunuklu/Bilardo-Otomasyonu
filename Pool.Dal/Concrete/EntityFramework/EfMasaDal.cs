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
    public class EfMasaDal : EfEntityRepositoryBase<Masalar, PoolContext>, IMasaDal
    {
        public MasaHareket MasaHareket(int masaId)
        {


            using (PoolContext context = new PoolContext())
            {
                var result = (from M in context.Masalar
                              join D in context.MasaDetaylari
                              on M.masa_tipi equals D.masa_tipi
                              join H in context.Hareket
                              on M.Id equals H.Masa_Id
                              where (M.Id == masaId && H.Durum==true)
                              select new MasaHareket
                              {
                                  MasaId = M.Id,
                                  masaId = M.Id,
                                  MasaTipi = M.masa_tipi,
                                  hareketId = H.Id,
                                  Baslanma_saati = H.Baslanma_saati,
                                  Tarife = H.Tarife,
                                  aktarilan_Ucret = H.aktarilan_Ucret,
                                  Odenmis_Ucret = H.Odenmis_Ucret,
                                  Durum = H.Durum,
                                  Standart_Masa_Ucreti = D.Standart_Masa_Ucreti,
                                  Antreman_Masa_Ucreti = D.Antreman_Masa_Ucreti,
                                  Coklu_Masa_Ucreti = D.Coklu_Masa_Ucreti,
                                  Toplam=H.Toplam

                              }).FirstOrDefault();
                return result;
            }
        }
        public List<OpenTables> OpenTables()
        {
            using (PoolContext context = new PoolContext())
            {
                var result = (from M in context.Masalar
                              join H in context.Hareket
                              on M.Id equals H.Masa_Id
                              where (H.Durum == false)

                              select new OpenTables
                              {
                                  masa_tipi = M.masa_tipi,
                                  Id = H.Id,
                                  Masa_Adi = M.Masa_Adi

                              }).Distinct();

                return result.ToList();


            }
        }
    }
}


