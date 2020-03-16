
using System;

namespace Singleton_Pattern
{
    public class Test
    {
        public void DisplaySingleton()
        {
            Console.WriteLine(Singleton.Instance.Data);
        }
    }
}