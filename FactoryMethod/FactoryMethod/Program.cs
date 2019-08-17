using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FactoryMethod
{
    class Program
    {
        static void Main(string[] args)
        {
            Creator [] creators = new Creator[2];
            creators[0] = new ConcretCreatorA();
            creators[1] = new ConcreteCreatorB();
            foreach(Creator creator in creators)
            {
                Product product = creator.FactoyMethod();
                Console.WriteLine("creted {0}",
                product.GetType().Name);
                    
            }
            Console.ReadKey();
        }
    }
    abstract class Product
    {

    }
    class ConcreteProductA:Product
    {

    }
    class ConcreteProductB : Product {

    }

    abstract class Creator
    {
        public abstract Product FactoyMethod();
    }

class  ConcretCreatorA: Creator
    {
        public override Product FactoyMethod()
        {
            return new ConcreteProductA();
        }
    }
    class ConcreteCreatorB : Creator
    {
        public override Product FactoyMethod()
        {
          return new ConcreteProductB();
        }
    }

}
