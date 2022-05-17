using Ninject.Modules;
using Pool.Bll.Abstract;
using Pool.Bll.Concrete;
using Pool.Core.CrossCuttingConcerns.Caching;
using Pool.Core.CrossCuttingConcerns.Caching.Microsoft;
using Pool.DataAccess.Abstract;
using Pool.DataAccess.Concrete.EntityFramework;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Pool.Bll.DependencyResolvers.Ninjekt
{
    public class BusinessModule : NinjectModule
    {
        public override void Load()
        {
            Bind<IMasaService>().To<MasaManager>().InSingletonScope();
            Bind<IHareketService>().To<HareketManager>().InSingletonScope();
            Bind<IKategoriService>().To<KategoriManager>().InSingletonScope();
            Bind<IMasaDetayService>().To<MasaDetayManager>().InSingletonScope();
            Bind<ISiparisService>().To<SiparisManager>().InSingletonScope();
            Bind<IStokService>().To<StokManager>().InSingletonScope();
            Bind<ICacheManager>().To<MemoryCacheManager>().InSingletonScope();

            Bind<IMasaDal>().To<EfMasaDal>();
            Bind<IHareketDal>().To<EfHareketDal>();
            Bind<IKategoriDal>().To<EfKategoriDal>();
            Bind<IMasaDetayDal>().To<EfMasaDetayDal>();
            Bind<ISiparisDal>().To<EfSiparisDal>();
            Bind<IStokDal>().To<EfStokDal>();

            

            Bind<DbContext>().To<PoolContext>();
        }

        public static BusinessModule Create()
        {
            return new BusinessModule();
        }
    }
}
