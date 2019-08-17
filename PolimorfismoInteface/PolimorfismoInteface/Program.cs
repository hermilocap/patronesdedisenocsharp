using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PolimorfismoInteface
{
    class Program
    {
        static void Main(string[] args)
        {
            Chihuahua chihuahua1 = new Chihuahua();
            Chihuahua chihuahua2 = new Chihuahua();
            Buldog bulldog1 = new Buldog();
            Buldog bulldog2 = new Buldog();
            IPerro[] iperrera = { chihuahua1, chihuahua2, bulldog1, bulldog2 };
            foreach (IPerro item in iperrera)
            {
                Console.WriteLine(item.ladrar());
                Console.WriteLine(item.Dormir());
            }
            Console.ReadKey();
        }
    }
}
