using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PolimorfismoInteface
{
   public class Chihuahua:IPerro
    {
        public string ladrar()
        {
            return "Chihuahua ladrando";
        }
        public string Dormir()
        {
            return "Chihuahua Durmiendo";
        }
    }
}
