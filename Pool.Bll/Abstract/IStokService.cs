using Pool.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Pool.Bll.Abstract
{
    public interface IStokService
    {
        List<Stoklar> GetAllType(int UrunKategori);
        List<Stoklar> GetAll();
        Stoklar GetId(string name);
        Stoklar Get(int StokId);
    }
}
