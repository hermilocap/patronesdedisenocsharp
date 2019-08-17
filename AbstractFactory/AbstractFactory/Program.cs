using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AbstractFactory
{
    class Program
    {
        static void Main(string[] args)
        {
            AbstractFactoy factory1 = new ConcreteFactory1();
            Client client1 = new Client(factory1);
            Client cliente1 = new Client(factory1);
            client1.Run();
            AbstractFactoy factory2 = new ConcreteFactory2();
            Client client2 = new Client(factory2);
            client2.Run();
            Console.ReadKey();
        }
    }

    abstract class AbstractFactoy
    {
        abstract class AbstractProductA CreateProductA();
        public abstract AbstractProductB CreateProductB();
    }
    class ConcreteFactory1 : AbstractFactoy
    {
        public override AbstractProductA AbstractProductA()
        {
            return new ProductA1();
        }
        public override AbstractProductB CreateProductB()
        {
            return new ProductB1();
        }
    }
        class ConcreteFactory2 : AbstractFactoy
    {
            public override AbstractProductA CreateProductA()
            {
                return new ProductA2();
            }
            public override AbstractproductB CreateProductB()
            {
                return new ProductB2();
            }
        }
        abstract class AbstractProductA
        {

        }
        abstract class AbstractProductB
        {
            public abstract void Interact(AbstractProductA a);
        }

        class ProductA1: AbstractProductA
        {

        }
    class ProductB1 : AbstractProductB
    {
        public override void Interact(AbstractProductA a)
        {
            Console.WriteLine(this.GetType().Name + "interacts with" + a.GetType().Name);
        }
    }
    class ProductA2 : AbstractProductA
    {

    }
    class ProductB2 : AbstractProductB
    {
        public override void Interact(AbstractProductA a)
        {
            Console.WriteLine(this.GetType().Name + "interacts with" + a.GetType().Name);
        }
    }
    class Client
    {
        private AbstractProductA _abstractProductA;
        private AbstractProductB _abstractProductB;
        public Client(AbstractFactoy factory)
        {
            _abstractProductB = factory.CreateProductB();
            _abstractProductA = factory.CreateProductA();
        }
        public void Run()
        {
            _abstractProductB.Interact(_abstractProductA);
        }
    }
}

    

