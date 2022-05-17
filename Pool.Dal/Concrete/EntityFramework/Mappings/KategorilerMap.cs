using Pool.Entities;
using System;
using System.Collections.Generic;
using System.Data.Entity.ModelConfiguration;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Pool.DataAccess.Concrete.EntityFramework.Mappings
{
    public class KategorilerMap : EntityTypeConfiguration<Kategoriler>
    {
        public KategorilerMap()
        {
            ToTable(@"Kategoriler", @"dbo");
            HasKey(x => x.Id);

            Property(x => x.Kategori_Adi).HasColumnName("Kategori_Adi").
                HasMaxLength(50).HasColumnType("nvarchar");
            
        }
    }
}
