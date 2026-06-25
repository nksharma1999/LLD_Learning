class Singleton
{
    private static Singleton instance;
    private static readonly object lockObject = new object();

    private Singleton() { }

    public static Singleton Instance
    {
        get
        {
            if (instance == null)
            {
                lock (lockObject)
                {
                    if (instance == null)
                    {
                        instance = new Singleton();
                    }
                }
            }
            return instance;
        }
    }
}

class SingletonExample
{
    public void Initialize()
    {
        Singleton singleton1 = Singleton.Instance;
        Singleton singleton2 = Singleton.Instance;

        if (singleton1 == singleton2)
        {
            Console.WriteLine("Both instances are the same.");
        }
        else
        {
            Console.WriteLine("Instances are different.");
        }
    }
}