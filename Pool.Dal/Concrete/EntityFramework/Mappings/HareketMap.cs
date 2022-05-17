using Pool.Entities;
using System;
using System.Collections.Generic;
using System.Data.Entity.ModelConfiguration;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Pool.DataAccess.Concrete.EntityFramework.Mappings
{
    class HareketMap:EntityTypeConfiguration<Hareket>
    {
        public HareketMap()
        {
            ToTable(@"Hareket", @"dbo");
            HasKey(x => x.Id);

            Property(x => x.Masa_Id).HasColumnName("Masa_Id").HasColumnType("int");
            Property(x => x.Tarih).HasColumnName("Tarih").HasColumnType("date");
            Property(x => x.Baslanma_saati).HasColumnName("Baslanma_saati").HasColumnType("Time");
            Property(x => x.Durum).HasColumnName("Durum").HasColumnType("bit");
            Property(x => x.Tarife).HasColumnName("Tarife").HasColumnType("int");
            Property(x => x.Oynan_sure).HasColumnName("Oynan_sure").HasColumnType("int").IsOptional();
            Property(x => x.Odenmis_Ucret).HasColumnName("Odenmis_Ucret").HasColumnType("money").IsOptional();
            Property(x => x.aktarilan_Ucret).HasColumnName("Aktarilan_Ucret").HasColumnType("money").IsOptional();
            Property(x => x.Toplam).HasColumnName("Toplam").HasColumnType("money").IsOptional();

        }
    }
}
