using Pool.Entities;
using System;
using System.Collections.Generic;
using System.Data.Entity.ModelConfiguration;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Pool.DataAccess.Concrete.EntityFramework.Mappings
{
  public  class MasaDetaylariMap:EntityTypeConfiguration<MasaDetaylari>
    {

        public MasaDetaylariMap()
        {
            ToTable(@"MasaDetaylari", @"dbo");
            HasKey(x => x.Id);

            Property(x => x.masa_tipi).HasColumnName("Masa_Tipi").HasColumnType("int");
            Property(x => x.Antreman_Masa_Ucreti).HasColumnName("Antreman_Masa_Ucreti").HasColumnType("money");
            Property(x => x.Standart_Masa_Ucreti).HasColumnName("Standart_Masa_Ucreti").HasColumnType("money");
            Property(x => x.Coklu_Masa_Ucreti).HasColumnName("Çoklu_Masa_Ucreti").HasColumnType("money");
        }
    }
}
