using Pool.Entities;
using Pool.Entities.ComplexTypes;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Pool.Bll.Abstract
{
    public interface IMasaService
    {
        MasaHareket MasaHareket(int masaId);
        List<Masalar> GetAll();
        List<Masalar> Durum();
        List<Masalar> GetAllType(int type);
        Masalar Get(int id);
        Masalar Add(Masalar masa);
        Masalar Update(Masalar masa);
        void Delete(Masalar masa);

    }
}
