using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Ninject;
using NinjectConsole.Model;

namespace NinjectConsole
{
    class Program
    {
        private static IKernel kernel;

        static void Main(string[] args)
        {
            kernel = new StandardKernel();
            kernel.Bind<IMensaje>().To<SaludoMundo>().InSingletonScope();

            MandarSaludo();
            Console.ReadKey();
        }
        private static void MandarSaludo()
        {
            // Personas persona = new Personas();
            //Personas persona = new Personas(new SaludoMundo());
            //persona.Saludar();
            Personas persona = kernel.Get<Personas>();

            persona.Saludar();

        }
    }
}
