using Pool.Bll.Abstract;
using Pool.Core.CrossCuttingConcerns.Caching;
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
    public class MasaManager : IMasaService
    {
        private IMasaDal _masaDal;
        private ICacheManager _cacheManager;
        private IHareketDal _hareketDal;
        public MasaManager(IMasaDal masaDal, IHareketDal hareketDal, ICacheManager cacheManager)
        {
            _masaDal = masaDal;
            _hareketDal = hareketDal;
            _cacheManager = cacheManager;
        }

        public Masalar Add(Masalar masa)
        {
            return _masaDal.Add(masa);
        }

        public void Delete(Masalar masa)
        {
             _masaDal.Delete(masa);
        }


        public Masalar Get(int id)
        {
            return _masaDal.Get(x => x.Id == id);
        }

        public List<Masalar> GetAll()
        {
           return _masaDal.GetList();
        }

        public Masalar Update(Masalar masa)
        {
            return _masaDal.Update(masa);
        }

        public List<Masalar> GetAllType(int type)
        {
            return _masaDal.GetList(x => x.masa_tipi == type);
        }
        public List<Masalar> Durum()
        {
            foreach (var item in _masaDal.OpenTables())
            {
                 _masaDal.GetList(x => x.Masa_Adi == item.Masa_Adi);
            }
            return null;
        }

        public MasaHareket MasaHareket(int masaId)
        {
            return _masaDal.MasaHareket(masaId);
            //_cacheManager.Add(Convert.ToString(result.hareketId), result);
            //var item= _cacheManager.Get<MasaHareket>(Convert.ToString(result.hareketId));
            //return result;
        }
    }
}
