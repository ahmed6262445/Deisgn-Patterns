using System;

namespace Factory_Pattern
{
    interface Shape
    {
        public void Draw();
    }

    public class Circle:Shape
    {
        public void Draw()
        {
            Console.WriteLine("Inside Circle::Draw Method\n");
        }
    }


    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");
        }
    }
}
