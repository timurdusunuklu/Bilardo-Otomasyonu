using Pool.Core.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Pool.Entities.ComplexTypes
{
   public class OpenTables:IEntity
    {
        public int Id { get; set; }
        public string Masa_Adi { get; set; }
        public int masa_tipi { get; set; }

    }
}
