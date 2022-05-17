using Pool.Core.Entities;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Pool.Entities
{
    public class Siparisler:IEntity
    {
        public int Id { get; set; }
        public int Hareket_ID { get; set; }
        public int StokId { get; set; }
        public int Adet { get; set; }
        public decimal Tutar { get; set; }
    }
}
