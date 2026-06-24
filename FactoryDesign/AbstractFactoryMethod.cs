interface GarliceBread
{
    void prepare();
}

class BasicGarliceBread : GarliceBread
{
    public void prepare()
    {
        Console.WriteLine("Preparing a basic garlice bread with butter and garlic.");
    }
}

class CheeseGarliceBread : GarliceBread
{
    public void prepare()
    {
        Console.WriteLine("Preparing a cheese garlice bread with butter, garlic, and cheese.");
    }
}

class BasicWheatGarliceBread : GarliceBread
{
    public void prepare()
    {
        Console.WriteLine("Preparing a basic wheat garlice bread with butter and garlic.");
    }
}

class CheeseWheatGarliceBread : GarliceBread
{
    public void prepare()
    {
        Console.WriteLine("Preparing a cheese wheat garlice bread with butter, garlic, and cheese.");
    }
}

interface MealFactory
{
    SimpleBurger CreateBurger(string type);
    GarliceBread CreateGarliceBread(string type);
}

class SinghMealFactory : MealFactory
{
    public SimpleBurger CreateBurger(string type)
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

    public GarliceBread CreateGarliceBread(string type)
    {
        if (type.Equals("basic", StringComparison.OrdinalIgnoreCase))
        {
            return new BasicGarliceBread();
        }
        else if (type.Equals("cheese", StringComparison.OrdinalIgnoreCase))
        {
            return new CheeseGarliceBread();
        }
        else
        {
            throw new ArgumentException("Invalid garlice bread type");
        }
    }
}

class KingMealFactory : MealFactory
{
    public SimpleBurger CreateBurger(string type)
    {
        if (type.Equals("basic", StringComparison.OrdinalIgnoreCase))
        {
            return new BasicWheatBurger();
        }
        else if (type.Equals("standard", StringComparison.OrdinalIgnoreCase))
        {
            return new StandardWheatBurger();
        }
        else if (type.Equals("premium", StringComparison.OrdinalIgnoreCase))
        {
            return new PremiumWheatBurger();
        }
        else
        {
            throw new ArgumentException("Invalid burger type");
        }
    }

    public GarliceBread CreateGarliceBread(string type)
    {
        if (type.Equals("basic", StringComparison.OrdinalIgnoreCase))
        {
            return new BasicWheatGarliceBread();
        }
        else if (type.Equals("cheese", StringComparison.OrdinalIgnoreCase))
        {
            return new CheeseWheatGarliceBread();
        }
        else
        {
            throw new ArgumentException("Invalid garlice bread type");
        }
    }
}

class AbstractFactoryMethodExample
{
    public void Initialize()
    {
        MealFactory singhMealFactory = new SinghMealFactory();
        SimpleBurger basicSinghBurger = singhMealFactory.CreateBurger("basic");
        basicSinghBurger.prepare();

        GarliceBread cheeseSinghGarliceBread = singhMealFactory.CreateGarliceBread("cheese");
        cheeseSinghGarliceBread.prepare();

        MealFactory kingMealFactory = new KingMealFactory();
        SimpleBurger premiumKingBurger = kingMealFactory.CreateBurger("premium");
        premiumKingBurger.prepare();

        GarliceBread basicKingGarliceBread = kingMealFactory.CreateGarliceBread("basic");
        basicKingGarliceBread.prepare();
    }
}
