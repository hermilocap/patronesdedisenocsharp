using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Composite
{
    class Ingrediente:Component
    {
        public int cantidad { get; set; }
        public string Unidad { get; set; }

        public Ingrediente(string nombre, decimal costo,string unidad): base(nombre,costo)
        {
            this.cantidad = cantidad;
            this.Unidad = Unidad;
        }
    }
}
