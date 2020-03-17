using System;

namespace Facade_Pattern
{
    class Program
    {
        static void Main(string[] args)
        {
            Facade facade = new Facade();

            Console.WriteLine(facade.OrderFood());
        
            ShapeMaker shapeMaker = new ShapeMaker();

            Console.WriteLine(shapeMaker.DrawSquare());
            Console.WriteLine(shapeMaker.DrawRectangle());
            Console.WriteLine(shapeMaker.DrawSquare());
        }

    
    }
}
