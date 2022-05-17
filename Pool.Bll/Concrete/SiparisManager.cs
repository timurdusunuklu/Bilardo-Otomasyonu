using Pool.Bll.Abstract;
using Pool.DataAccess.Abstract;
using Pool.Entities;
using Pool.Entities.ComplexTypes;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Pool.Bll.Concrete
{
    public class SiparisManager : ISiparisService
    {
        private ISiparisDal _siparisDal;
        private IHareketService _hareketService;
        private IStokService _stokService;

        public SiparisManager(ISiparisDal siparisDal, IHareketService hareketService, IStokService stokService)
        {
            _siparisDal = siparisDal;
            _hareketService = hareketService;
            _stokService = stokService;
        }

        public Siparisler Add(Siparisler siparis)
        {
            return _siparisDal.Add(siparis);
        }

        public void Delete(Siparisler siparis)
        {
            _siparisDal.Delete(siparis);
        }

        public List<UrunSiparis> SiparisDetailsGetAll(int HareketID)
        {
            return _siparisDal.SiparisJoinUrun(HareketID);
        }

        public List<Siparisler> SiparisGetAllType(int HaretketId)
        {
            return _siparisDal.GetList(x => x.Hareket_ID == HaretketId);
        }

        public Siparisler SiparisEkleme(int adet, int hareketId, int StokId)
        {
            
            var stok = _stokService.Get(StokId);
            bool add = true;
            foreach (var item in _siparisDal.GetList(x => x.Hareket_ID == hareketId))
            {
                if (item.StokId == StokId)
                {
                    add = false;
                    return _siparisDal.Update(new Siparisler
                    {
                        Id = item.Id,
                        StokId = item.StokId,
                        Hareket_ID = item.Hareket_ID,
                        Adet = item.Adet + adet,
                        Tutar = item.Tutar + adet * stok.Ürün_Fiyatı
                    });

                }


            }
            if (add)
            {
                return _siparisDal.Add(new Siparisler
                {
                    StokId = StokId,
                    Hareket_ID = hareketId,
                    Adet = adet,
                    Tutar = adet * stok.Ürün_Fiyatı
                });
            }
            return null;
        }

        public Siparisler Update(Siparisler siparis)
        {
            return _siparisDal.Update(siparis);
        }



        public Siparisler SiparisSilme(int adet, int hareketId, string stokAdi)
        {
            var stok = _stokService.GetId(stokAdi);
            foreach (var item in _siparisDal.GetList(x => x.Hareket_ID == hareketId))
            {
                if (item.StokId == stok.Id)
                {
                    if (adet < item.Adet)
                    {
                        return _siparisDal.Update(new Siparisler
                        {
                            Id = item.Id,
                            StokId = item.StokId,
                            Hareket_ID = item.Hareket_ID,
                            Adet = item.Adet - adet,
                            Tutar = item.Tutar - adet * stok.Ürün_Fiyatı
                        });

                    }
                    else if (adet==item.Adet)
                    {
                        _siparisDal.Delete(new Siparisler { Id = item.Id });
                    }
                }
            }
           
            return null;
        }
    }
}
