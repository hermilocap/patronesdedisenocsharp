using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NinjectConsole.Model
{
 
        public class SaludoTodos : IMensaje
        {
            public void Emitir()
            {
                Console.WriteLine("Hola Todos");
            }
        }
}
