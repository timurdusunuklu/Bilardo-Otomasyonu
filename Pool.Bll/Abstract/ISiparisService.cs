using Pool.Entities;
using Pool.Entities.ComplexTypes;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Pool.Bll.Abstract
{
    public interface ISiparisService
    {
        Siparisler SiparisEkleme(int adet, int hareketId, int stokId);
        Siparisler SiparisSilme(int adet, int hareketId, string stokAdi);
        List<Siparisler> SiparisGetAllType(int HaretketId);
        List<UrunSiparis> SiparisDetailsGetAll(int HareketID);
        Siparisler Add(Siparisler siparis);
        Siparisler Update(Siparisler siparis);
        void Delete(Siparisler siparis);
    }
}
