using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Composite
{
    abstract class Component
    {
        public string Nombre { get; set; }
        public decimal costo { get; set; }
        public Component(string nombre, decimal costo)
        {
            this.Nombre = nombre;
            this.costo = costo;
        }

    }
}
