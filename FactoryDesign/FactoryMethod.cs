
class BasicWheatBurger : SimpleBurger
{
    public void prepare()
    {
        Console.WriteLine("Preparing Basic Wheat Burger");
    }
}

class StandardWheatBurger : SimpleBurger
{
    public void prepare()
    {
        Console.WriteLine("Preparing Standard Wheat Burger");
    }
}

class PremiumWheatBurger : SimpleBurger
{
    public void prepare()
    {
        Console.WriteLine("Preparing Premium Wheat Burger");
    }
}

interface BurgerFactory
{
    SimpleBurger CreateBurger(string type);
}

class SinghBurger : BurgerFactory
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
}

class KingBurger : BurgerFactory
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
}

class FactoryMethodExample
{
    public void Initialize()
    {
        BurgerFactory singhBurgerFactory = new SinghBurger();
        SimpleBurger basicSinghBurger = singhBurgerFactory.CreateBurger("basic");
        basicSinghBurger.prepare();

        BurgerFactory kingBurgerFactory = new KingBurger();
        SimpleBurger premiumKingBurger = kingBurgerFactory.CreateBurger("premium");
        premiumKingBurger.prepare();
    }
}
