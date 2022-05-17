using Pool.Entities;
using System;
using System.Collections.Generic;
using System.Data.Entity.ModelConfiguration;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Pool.DataAccess.Concrete.EntityFramework.Mappings
{
    class StoklarMap:EntityTypeConfiguration<Stoklar>
    {
        public StoklarMap()
        {
            ToTable(@"Stoklar", @"dbo");
            HasKey(x => x.Id);

            Property(x => x.Kategori_ID).HasColumnName("Kategori_Id").HasColumnType("int");
            Property(x => x.Ürün_Adı).HasColumnName("Ürün_Adi").HasColumnType("nvarchar").HasMaxLength(50);
            Property(x => x.Ürün_Fiyatı).HasColumnName("Ürün_Fiyatı").HasColumnType("money");
        }
    }
}
