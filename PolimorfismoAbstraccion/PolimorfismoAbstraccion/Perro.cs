using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PolimorfismoAbstraccion
{
    public abstract class Perro
    {
        public virtual string ladrar()
        {
            return "Perro ladrando";
        }
        public abstract string Dormir();
    }
}
