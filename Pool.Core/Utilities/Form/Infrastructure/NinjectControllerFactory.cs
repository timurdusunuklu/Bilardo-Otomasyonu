using Ninject;
using Ninject.Modules;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Pool.Core.Utilities.Form.Infrastructure
{
    public class FormResolve
    {
         private static  IKernel _ninjectKarnel;

        public static void Wire(INinjectModule module)
        {
            _ninjectKarnel = new StandardKernel(module);
        }

        public static T resolve<T>()
        {
            return _ninjectKarnel.Get<T>();
        }
    }
}
