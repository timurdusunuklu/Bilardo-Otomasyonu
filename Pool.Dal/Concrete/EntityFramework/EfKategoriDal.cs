using Pool.Core.DataAccess.EntityFramework;
using Pool.DataAccess.Abstract;
using Pool.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Pool.DataAccess.Concrete.EntityFramework
{
    public class EfKategoriDal:EfEntityRepositoryBase<Kategoriler,PoolContext>,IKategoriDal
    {

    }
}
