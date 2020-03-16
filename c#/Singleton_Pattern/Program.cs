using System;

namespace Singleton_Pattern
{
    class Program
    {
        static void Main(string[] args)
        {
            Singleton.Instance.Data = 1;
            Console.WriteLine(Singleton.Instance.Data);
            Test obj = new Test();
            obj.DisplaySingleton();
        }
    }
}
