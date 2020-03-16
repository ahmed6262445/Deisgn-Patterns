using System;

namespace Singleton_Pattern
{
    class Program
    {
        static void Main(string[] args)
        {
            Singleton.Instance.Data = 1; //Sets the property Data of Singleton Class
            Console.WriteLine(Singleton.Instance.Data); //Print the value of property Data of Singleton Class
            Test obj = new Test();  //Class to check the global Singleton concept
            obj.DisplaySingleton(); //Print the value of property Data of Singleton class thourgh class Test
        }
    }
}
