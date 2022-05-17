using Pool.Core.Entities;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Pool.Entities
{
    public class Hareket : IEntity
    {
        public int Id { get; set; }
        public DateTime Tarih { get; set; }
        public int Masa_Id { get; set; }
        public TimeSpan Baslanma_saati { get; set; }
        public int Oynan_sure { get; set; }
        public decimal Odenmis_Ucret { get; set; }
        public decimal aktarilan_Ucret { get; set; }
        public int Tarife { get; set; }
        public decimal Toplam { get; set; }
        public bool Durum { get; set; }
    }
}
