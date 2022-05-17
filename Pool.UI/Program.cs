using Pool.Bll.DependencyResolvers.Ninjekt;
using Pool.Core.Utilities.Form.Infrastructure;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Pool.UI
{
    static class Program
    {
        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);

            FormResolve.Wire(BusinessModule.Create());
            Application.Run(FormResolve.resolve<Anasayfa>());
        }
    }
}
