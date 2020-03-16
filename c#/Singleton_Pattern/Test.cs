
using System;

namespace Singleton_Pattern
{
    // Class to Check the global behaviour of Singleton class
    public class Test
    {
        public void DisplaySingleton()
        {
            Console.WriteLine(Singleton.Instance.Data);
        }
    }
}