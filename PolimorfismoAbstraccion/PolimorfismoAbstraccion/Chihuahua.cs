using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PolimorfismoAbstraccion
{
   public class Chihuahua:Perro
    {
        public override string ladrar()
        {
            return "Chihuahua ladrando";
        }
        public override string Dormir()
        {
            return "Chihuahua durmiendo";
        }
    }
}
