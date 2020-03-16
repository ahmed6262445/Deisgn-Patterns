namespace Singleton_Pattern
{
    public class Singleton
    {
        private Singleton() { }
        private static Singleton _instance = null;

        public static Singleton Instance
        {
            get
            {
                if (_instance == null)
                    _instance = new Singleton();
                return _instance;
            }
        }

        public int Data { get; set; }
    }
}