using System.Net.WebSockets;

namespace Interfaces
{
    class Program
    {
        static void Main(string[] args)
        {
            // interface = defines a "contract" that all the classes inheriting from should follow

            //             an interface declares "what a class should have"
            //             an inheriting class defines "how it shoud do it"

            //             benefit = security + multiple inheritance + "plug-and-play"

            Rabbit rabbit = new Rabbit();
            Hawk hawk = new Hawk();
            Fish fish = new Fish();

            rabbit.Flee();
            hawk.Hunt();
            fish.Flee();
            fish.Hunt();
        }
    }

    interface IPrey
    {
        void Flee();
    }

    interface IPredator
    {
        void Hunt();
    }

    class Rabbit : IPrey
    {
        public void Flee()
        {
            Console.WriteLine("The rabbit runs away!");
        }
    }

    class Hawk : IPredator
    {
        public void Hunt()
        {
            Console.WriteLine("The hawk is searching for food!");
        }
    }

    class Fish : IPredator, IPrey
    {
        public void Flee()
        {
            Console.WriteLine("The fish swims away!");
        }

        public void Hunt()
        {
            Console.WriteLine("The fish is searching for smaller fish!");
        }
    }
}