using Pool.Bll.Abstract;
using Pool.DataAccess.Abstract;
using Pool.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Pool.Bll.Concrete
{
    public class StokManager : IStokService
    {
        private IStokDal _stokDal;

        public StokManager(IStokDal stokDal)
        {
            _stokDal = stokDal;
        }

        public Stoklar Get(int StokId)
        {
            return _stokDal.Get(x => x.Id == StokId);
        }

        public List<Stoklar> GetAll()
        {
            return _stokDal.GetList();
        }

        public List<Stoklar> GetAllType(int UrunKategori)
        {
           return _stokDal.GetList(x => x.Kategori_ID == UrunKategori);
        }

        public Stoklar GetId(string name)
        {
            return _stokDal.Get(x => x.Ürün_Adı == name);
        }
    }
}
