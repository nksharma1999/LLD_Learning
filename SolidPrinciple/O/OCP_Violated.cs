
class OShoppingCart_Violated
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

class OInvoicePrinter
{
    OShoppingCart_Violated cart;
        public OInvoicePrinter(OShoppingCart_Violated cart)
        {
            this.cart = cart;
        }   

    public void PrintInvoice(OShoppingCart_Violated cart)
    {
        Console.WriteLine("Invoice:");
        foreach (var product in cart.GetProducts())
        {
            Console.WriteLine($"{product.Name}: {product.Price:C}");
        }
        Console.WriteLine($"Total: {cart.CalculateTotal():C}");
    }
}

class ODatabaseSaver
{
    OShoppingCart_Violated cart;

    public ODatabaseSaver(OShoppingCart_Violated cart)
    {
        this.cart = cart;
    }
    public void SaveToSQlDatabase()
    {
        Console.WriteLine("Saving shopping cart to SQL database...");
        // Code to save the shopping cart to a SQL database
    }
    public void SaveToMongoDB()
    {
        Console.WriteLine("Saving shopping cart to MongoDB...");
        // Code to save the shopping cart to a MongoDB database
    }
    public void SaveToFile()
    {
        Console.WriteLine("Saving shopping cart to a file...");
        // Code to save the shopping cart to a file
    }
}   