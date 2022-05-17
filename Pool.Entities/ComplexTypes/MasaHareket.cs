using Pool.Core.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Pool.Entities.ComplexTypes
{
  public  class MasaHareket:IEntity
    {
        public int MasaId { get; set; }
        public int masaId { get; set; }
        public int hareketId { get; set; }
        public TimeSpan Baslanma_saati { get; set; }
        public decimal Odenmis_Ucret { get; set; }
        public decimal aktarilan_Ucret { get; set; }
        public bool Durum { get; set; }
        public int MasaTipi { get; set; }
        public int Tarife { get; set; }
        public decimal Antreman_Masa_Ucreti { get; set; }
        public decimal Standart_Masa_Ucreti { get; set; }
        public decimal Coklu_Masa_Ucreti { get; set; }
        public decimal Toplam { get; set; }

    }
}
