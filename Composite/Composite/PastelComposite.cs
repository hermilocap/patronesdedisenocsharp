using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Composite
{
    class PastelComposite:Component
    {
        List<Component> ingredientes = new List<Component>();
        public decimal costo
        {
            get
            {
                decimal costo = 0;
                foreach(var oelement in ingredientes)
                {
                    costo = oelement.costo;
                }
                return costo;
            }
        }
        public void Add(Component oelement)
        {
            ingredientes.Add(oelement);
        }
        public void Remove(Component oelement)
        {
            ingredientes.Remove(oelement);
        }

        public PastelComposite(string nombre, decimal costo, string unidad): base(nombre, costo)
        {

        }
    }
}
