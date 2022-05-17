using Pool.Entities;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Pool.DataAccess.Concrete.EntityFramework
{
    public class DataInitializer : DropCreateDatabaseIfModelChanges<PoolContext>
    {
        protected override void Seed(PoolContext context)
        {
            List<MasaDetaylari> masaDetaylari = new List<MasaDetaylari>()
            {
                new MasaDetaylari{ masa_tipi=1,Antreman_Masa_Ucreti=0,Coklu_Masa_Ucreti=0,Standart_Masa_Ucreti=0},
                new MasaDetaylari{masa_tipi=2,Antreman_Masa_Ucreti=0,Coklu_Masa_Ucreti=0,Standart_Masa_Ucreti=0},
                new MasaDetaylari{masa_tipi=3,Antreman_Masa_Ucreti=0,Coklu_Masa_Ucreti=0,Standart_Masa_Ucreti=0},
                 new MasaDetaylari{masa_tipi=4,Antreman_Masa_Ucreti=0,Coklu_Masa_Ucreti=0,Standart_Masa_Ucreti=0},
                  new MasaDetaylari{masa_tipi=5,Antreman_Masa_Ucreti=0,Coklu_Masa_Ucreti=0,Standart_Masa_Ucreti=0}
            };
            List<Masalar> masa = new List<Masalar>();
            for (int i = 1; i <= 20; i++)
            {
                masa.Add(new Masalar { Masa_Adi = "A" + i, masa_tipi = 1 });
            }
            for (int i = 1; i <= 20; i++)
            {
                masa.Add(new Masalar { Masa_Adi = "U" + i, masa_tipi = 2 });
            }
            for (int i = 1; i <= 20; i++)
            {
                masa.Add(new Masalar { Masa_Adi = "O" + i, masa_tipi = 3 });
            }
            for (int i = 1; i <= 20; i++)
            {
                masa.Add(new Masalar { Masa_Adi = "T" + i, masa_tipi = 4 });
            }
            for (int i = 1; i <= 20; i++)
            {
                masa.Add(new Masalar { Masa_Adi = "S" + i, masa_tipi = 5 });
            }
            

            List<Kategoriler> kategori = new List<Kategoriler>()
            {
                new Kategoriler {Kategori_Adi="Sıcak İçecekler"},
                new Kategoriler {Kategori_Adi="Soğuk İçecekler"},
                new Kategoriler {Kategori_Adi="Mutfak"},
                new Kategoriler {Kategori_Adi="Market"}

            };
            foreach (var item in kategori)
            {
                context.Kategoriler.Add(item);
            }
            List<Stoklar> stok = new List<Stoklar>()
            {
                new Stoklar{Kategori_ID=1,Ürün_Adı="Çay",Ürün_Fiyatı=2},
                new Stoklar{Kategori_ID=1,Ürün_Adı="Kahve",Ürün_Fiyatı=2},
                new Stoklar{Kategori_ID=1,Ürün_Adı="Kuş Burnu",Ürün_Fiyatı=2},
                new Stoklar{Kategori_ID=1,Ürün_Adı="Kivi",Ürün_Fiyatı=2},
                new Stoklar{Kategori_ID=1,Ürün_Adı="Muz",Ürün_Fiyatı=2},
                new Stoklar{Kategori_ID=3,Ürün_Adı="Tost",Ürün_Fiyatı=10},
                new Stoklar{Kategori_ID=4,Ürün_Adı="Ayran",Ürün_Fiyatı=3},
                new Stoklar{Kategori_ID=4,Ürün_Adı="kola",Ürün_Fiyatı=3},
                new Stoklar{Kategori_ID=4,Ürün_Adı="Kutu Kola",Ürün_Fiyatı=4},
            };
            foreach (var item in stok)
            {
                context.Stoklar.Add(item);
            }
            foreach (var item in masa)
            {
                context.Masalar.Add(item);
            }

            foreach (var item in masaDetaylari)
            {
                context.MasaDetaylari.Add(item);
            }
            context.SaveChanges();
            base.Seed(context);
        }
    }
}
