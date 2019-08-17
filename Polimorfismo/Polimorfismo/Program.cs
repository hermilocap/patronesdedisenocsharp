using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Polimorfismo
{
    class Program
    {
        static void Main(string[] args)
        {
            Chihuahua chihuahua1 = new Chihuahua();
            Chihuahua chihuahua2 = new Chihuahua();
            Bulldog bulldog1 = new Bulldog();
            Bulldog bulldog2 = new Bulldog();
            Perro[] perrera = { chihuahua1, chihuahua2, bulldog1, bulldog2 };
            foreach(Perro item in perrera)
            {
                Console.WriteLine(item.ladrar());
            }
            Console.ReadKey();
        }
    }
}
