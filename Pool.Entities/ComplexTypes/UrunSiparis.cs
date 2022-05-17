using Pool.Core.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Pool.Entities.ComplexTypes
{
  public class UrunSiparis:IEntity
    {
        public string Ürün_Adi { get; set; }
        public int Adet { get; set; }
        public decimal BirimTutar { get; set; }
    }
}
