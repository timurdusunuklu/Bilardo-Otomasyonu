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

    public class MasaDetaylari: IEntity
    {

        public int Id { get; set; }
        public int masa_tipi { get; set; }
        public decimal Antreman_Masa_Ucreti { get; set; }
        public decimal Standart_Masa_Ucreti { get; set; }
        public decimal Coklu_Masa_Ucreti { get; set; }
    }
}
