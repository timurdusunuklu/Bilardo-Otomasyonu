using Pool.Entities;
using System;
using System.Collections.Generic;
using System.Data.Entity.ModelConfiguration;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Pool.DataAccess.Concrete.EntityFramework.Mappings
{
    public class MasalarMap:EntityTypeConfiguration<Masalar>
    {
        public MasalarMap()
        {
            ToTable(@"Masalar", @"dbo");
            HasKey(x => x.Id);
            Property(x => x.Masa_Adi).HasColumnName("Masa_Adi").HasColumnType("nvarchar").HasMaxLength(3);
            Property(x => x.masa_tipi).HasColumnName("Masa_Tipi").HasColumnType("int");
        }
        
    }
}
