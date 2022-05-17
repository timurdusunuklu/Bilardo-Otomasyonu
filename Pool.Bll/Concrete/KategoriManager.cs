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
    public class KategoriManager : IKategoriService
    {
        private IKategoriDal _kategoriDal;

        public KategoriManager(IKategoriDal kategoriDal)
        {
            _kategoriDal = kategoriDal;
        }

        public List<Kategoriler> GetAll()
        {
            return _kategoriDal.GetList();
        }
    }
}
