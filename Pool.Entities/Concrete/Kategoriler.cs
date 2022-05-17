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
    public class Kategoriler : IEntity
    {
        public int Id { get; set; }
        public string Kategori_Adi { get; set; }
    }
}
