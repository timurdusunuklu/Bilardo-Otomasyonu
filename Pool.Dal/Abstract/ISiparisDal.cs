using Pool.Core.DataAccess;
using Pool.Entities;
using Pool.Entities.ComplexTypes;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Pool.DataAccess.Abstract
{
    public interface ISiparisDal: IEntityRepository<Siparisler>
    {
        List<UrunSiparis> SiparisJoinUrun(int hareketId);

       
    }
}
