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

    public class Stoklar : IEntity
    {
        public int Id { get; set; }

        public string Ürün_Adı { get; set; }

        public int Kategori_ID { get; set; }

        public decimal Ürün_Fiyatı { get; set; }
    }
}