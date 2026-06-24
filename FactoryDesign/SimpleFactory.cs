interface SimpleBurger
{
    void prepare();
}

class BasicBurger : SimpleBurger
{
    public void prepare()
    {
        Console.WriteLine("Preparing a basic burger with lettuce, tomato, and patty.");
    }
}

class StandardBurger : SimpleBurger
{
    public void prepare()
    {
        Console.WriteLine("Preparing a standard burger with cheese, lettuce, tomato, and patty.");
    }
}

class PremiumBurger : SimpleBurger
{
    public void prepare()
    {
        Console.WriteLine("Preparing a premium burger with bacon, cheese, lettuce, tomato, and patty.");
    }
}

class SimpleBurgerFactory
{
    public SimpleBurger createBurger(string type)
    {
        if (type.Equals("basic", StringComparison.OrdinalIgnoreCase))
        {
            return new BasicBurger();
        }
        else if (type.Equals("standard", StringComparison.OrdinalIgnoreCase))
        {
            return new StandardBurger();
        }
        else if (type.Equals("premium", StringComparison.OrdinalIgnoreCase))
        {
            return new PremiumBurger();
        }
        else
        {
            throw new ArgumentException("Invalid burger type");
        }
    }
}

class SimpleFactoryExample
{
    public void Initialize()
    {
        SimpleBurgerFactory burgerFactory = new SimpleBurgerFactory();

        SimpleBurger basicBurger = burgerFactory.createBurger("basic");
        basicBurger.prepare();

        SimpleBurger standardBurger = burgerFactory.createBurger("standard");
        standardBurger.prepare();

        SimpleBurger premiumBurger = burgerFactory.createBurger("premium");
        premiumBurger.prepare();
    }
}
