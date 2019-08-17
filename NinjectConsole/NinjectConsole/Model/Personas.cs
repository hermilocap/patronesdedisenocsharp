using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NinjectConsole.Model
{
 public   class Personas
    {
        private IMensaje _saludo;
        //private SaludoMundo _saludo;
        //public Personas()
        //{
        //    _saludo = new SaludoMundo();
        //}
        //public void Saludar()
        //{
        //    _saludo.Emitir();
        //}
        public Personas(IMensaje saludo) {
            _saludo = saludo;

        }
        public void Saludar()
        {
            _saludo.Emitir();
        }
    }
}
