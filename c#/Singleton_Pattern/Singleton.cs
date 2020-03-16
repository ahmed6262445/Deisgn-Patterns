namespace Singleton_Pattern
{
    public class Singleton
    {
        private Singleton() { } //private constructor, so that it may not be called outside the class
        private static Singleton _instance = null; //Static single instance of Singleton

        public static Singleton Instance
        {
            get
            {
                if (_instance == null) //If no instance of Singleton Exists 
                    _instance = new Singleton(); //Initialize a new one
                return _instance; // return the instance
            }
        }

        public int Data { get; set; } //Property to check global behaviour of Singleton Class 
        // Implement all the bussiness logic here to use Singleton class
    }
}