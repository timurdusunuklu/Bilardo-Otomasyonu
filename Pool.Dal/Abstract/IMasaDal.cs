using Pool.Core.DataAccess;
using Pool.Entities;
using Pool.Entities.ComplexTypes;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace Pool.DataAccess.Abstract
{
    public interface IMasaDal : IEntityRepository<Masalar>
    {
        List<OpenTables> OpenTables();
        MasaHareket MasaHareket(int masaId);
    }
}
