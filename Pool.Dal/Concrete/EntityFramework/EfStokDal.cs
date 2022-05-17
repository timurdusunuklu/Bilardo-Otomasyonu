using Pool.Core.DataAccess.EntityFramework;
using Pool.DataAccess.Abstract;
using Pool.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace Pool.DataAccess.Concrete.EntityFramework
{
    public class EfStokDal : EfEntityRepositoryBase<Stoklar, PoolContext>, IStokDal
    {
      
    }
}
