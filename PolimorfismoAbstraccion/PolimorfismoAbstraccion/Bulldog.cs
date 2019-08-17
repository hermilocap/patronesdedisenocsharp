using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PolimorfismoAbstraccion
{
  public  class Bulldog:Perro
    {
        public override string ladrar()
        {
            return "Bulldog ladrando";
        }
        public override string Dormir()
        {
            return "Buldog durmiendo";
        }
    }
}
