
class OShoppingCart_Followed
{
    List<Product> products = new List<Product>();
    public void AddProduct(Product product)
    {
        products.Add(product);
    }

    public List<Product> GetProducts()
    {
        return products;
    }

     public decimal CalculateTotal()
    {
        decimal total = 0;
        foreach (var product in products)
        {
            total += product.Price;
        }
        return total;
    }
}

class OInvoicePrinter_Followed
{
    OShoppingCart_Followed cart;
        public OInvoicePrinter_Followed(OShoppingCart_Followed cart)
        {
            this.cart = cart;
        }   

    public void PrintInvoice(OShoppingCart_Followed cart)
    {
        Console.WriteLine("Invoice:");
        foreach (var product in cart.GetProducts())
        {
            Console.WriteLine($"{product.Name}: {product.Price:C}");
        }
        Console.WriteLine($"Total: {cart.CalculateTotal():C}");
    }
}

interface IDatabaseSaver
{
    void Save(OShoppingCart_Followed cart);
} 

class SqlDatabaseSaver : IDatabaseSaver
{
    public void Save(OShoppingCart_Followed cart)
    {
        Console.WriteLine("Saving shopping cart to SQL database...");
        // Code to save the shopping cart to a SQL database
    }
}

class MongoDatabaseSaver : IDatabaseSaver
{
    public void Save(OShoppingCart_Followed cart)
    {
        Console.WriteLine("Saving shopping cart to MongoDB...");
        // Code to save the shopping cart to a MongoDB database
    }
}   

class FileDatabaseSaver : IDatabaseSaver
{
    public void Save(OShoppingCart_Followed cart)
    {
        Console.WriteLine("Saving shopping cart to a file...");
        // Code to save the shopping cart to a file
    }
}
