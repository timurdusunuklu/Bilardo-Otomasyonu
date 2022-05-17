using Pool.DataAccess.Concrete.EntityFramework.Mappings;
using Pool.Entities;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Pool.DataAccess.Concrete.EntityFramework
{
   public class PoolContext:DbContext
    {
        public PoolContext() : base("Pool")
        {
            Database.SetInitializer(new DataInitializer());
        }

        public  DbSet<Hareket> Hareket { get; set; }
        public  DbSet<Masalar> Masalar { get; set; }
        public  DbSet<Siparisler> Siparişler { get; set; }
        public  DbSet<Stoklar> Stoklar { get; set; }
        public  DbSet<Kategoriler> Kategoriler { get; set; }
        public  DbSet<MasaDetaylari> MasaDetaylari { get; set; }


        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            modelBuilder.Configurations.Add(new HareketMap());
            modelBuilder.Configurations.Add(new KategorilerMap());
            modelBuilder.Configurations.Add(new MasaDetaylariMap());
            modelBuilder.Configurations.Add(new MasalarMap());
            modelBuilder.Configurations.Add(new SiparislerMap());
            modelBuilder.Configurations.Add(new StoklarMap());
        }
    }
}
