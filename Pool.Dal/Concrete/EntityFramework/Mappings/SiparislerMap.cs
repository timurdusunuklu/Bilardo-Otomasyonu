using Pool.Entities;
using System;
using System.Collections.Generic;
using System.Data.Entity.ModelConfiguration;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Pool.DataAccess.Concrete.EntityFramework.Mappings
{
    class SiparislerMap:EntityTypeConfiguration<Siparisler>
    {
        public SiparislerMap()
        {
            ToTable(@"Siparisler", @"dbo");
            HasKey(x => x.Id);

            Property(x => x.Hareket_ID).HasColumnName("Hareket_Id").HasColumnType("int");
            Property(x => x.StokId).HasColumnName("StokId").HasColumnType("int");
            Property(x => x.Adet).HasColumnName("Adet").HasColumnType("int");
            Property(x => x.Tutar).HasColumnName("Tutar").HasColumnType("money");
        }
    }
}
