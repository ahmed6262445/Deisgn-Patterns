using System;

namespace Facade_Pattern
{
    class Program
    {
        static void Main(string[] args)
        {
            Facade facade = new Facade();

            Console.WriteLine(facade.OrderFood());
        }
    }
}
