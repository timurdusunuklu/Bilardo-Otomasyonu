using Pool.Bll.Abstract;
using Pool.Core.CrossCuttingConcerns.Caching;
using Pool.DataAccess.Abstract;
using Pool.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Pool.Bll.Concrete
{
    public class HareketManager : IHareketService
    {
        private IHareketDal _hareketDal;
        private IMasaDal _masaDal;
        private ICacheManager _cacheManager;
        private ISiparisDal _siparisDal;

        public HareketManager(
            IHareketDal hareketDal, IMasaDal masaDal, 
            ICacheManager cacheManager, ISiparisDal siparisDal)
        {
            _hareketDal = hareketDal;
            _masaDal = masaDal;
            _cacheManager = cacheManager;
            _siparisDal = siparisDal;
        }

        public Hareket Add(Hareket hareket)
        {
            return _hareketDal.Add(hareket);
        }

        public Hareket Get(int Id)
        { 
           return _hareketDal.Get(x => x.Durum == true && x.Masa_Id == Id);
        }

        public List<Hareket> GetOnAll()
        {
            return _hareketDal.GetList(x => x.Durum == true);
        }

        public Hareket HareketEkle(Hareket hareket)
        {
            var time =DateTime.Now;
           
            var result = _hareketDal.Get(x => x.Masa_Id == hareket.Masa_Id && x.Durum == true);
            if (result!=null)
            {
                var item= _hareketDal.Update(new Hareket
                {
                    Id = result.Id,
                    Tarih=result.Tarih,
                    Masa_Id = result.Masa_Id,
                    Tarife = result.Tarife,
                    Baslanma_saati = result.Baslanma_saati,
                    aktarilan_Ucret =hareket.aktarilan_Ucret,
                    Odenmis_Ucret=hareket.Odenmis_Ucret,
                    Oynan_sure=hareket.Oynan_sure,
                    Toplam=hareket.Toplam,
                    Durum = hareket.Durum
                });
                //_cacheManager.Remove(Convert.ToString(item.Masa_Id));

                if (hareket.Durum == false)
                {
                    foreach (var value in _siparisDal.GetList(x=>x.Hareket_ID==item.Id))
                    {
                        _siparisDal.Delete(value);
                    }
                    //_cacheManager.Add(Convert.ToString(item.Masa_Id), item);
                }


                return item;
            }
            else
            {
               var item= _hareketDal.Add(new Hareket
                {
                   Masa_Id = hareket.Masa_Id,
                   Tarih = time.Date,
                   Tarife = hareket.Tarife,
                   Baslanma_saati = time.TimeOfDay,
                   Durum=true,
                    
                });
                _cacheManager.Add(Convert.ToString(item.Masa_Id), item);
                return item;
            }
        }

        public Hareket HareketGet(int MasaId)
        {
            return _hareketDal.Get(x => x.Masa_Id == MasaId && x.Durum == true);
        }

        public void HareketTemizle()
        {
            var tarih = DateTime.Now.Date.AddDays(-3);
            foreach (var item in _hareketDal.GetList(x => x.Tarih < tarih))
            {
                _hareketDal.Delete(item);
            } 
            {

            }
        }

        public Hareket Update(Hareket hareket)
        {
            return _hareketDal.Update(hareket);
        }
    }
}
