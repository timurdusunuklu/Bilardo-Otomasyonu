using Pool.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Pool.Bll.Abstract
{
    public interface IHareketService
    {
        Hareket HareketGet(int MasaId);
        Hareket HareketEkle(Hareket hareket);
        Hareket Add(Hareket hareket);
        Hareket Update(Hareket hareket);
        Hareket Get(int Id);
        List<Hareket> GetOnAll();

        void HareketTemizle();
    }
}
