using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PolimorfismoInteface
{
    class Buldog:IPerro
    {
        public string ladrar()
        {
            return "Buldog Ladrando";
        }
        public string Dormir()
        {
            return "Bulldog Durmiendo";
        }
    }
}
