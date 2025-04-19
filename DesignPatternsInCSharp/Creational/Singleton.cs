namespace DesignPatternsInCSharp.Creational
{
    public sealed class SingleTon
    {
        private static SingleTon? _instance;
        private static readonly object _lock = new();

        private SingleTon()
        {
            Console.WriteLine("SingleTon instance created.");
        }
        public static SingleTon Instance
        {
            get
            {
                lock (_lock)
                {
                    _instance ??= new SingleTon();
                    return _instance;
                }
            }
        }

        public void DoSomething()
        {
            Console.WriteLine("Doing something inside SingleTon Instance.");
        }
    }
}