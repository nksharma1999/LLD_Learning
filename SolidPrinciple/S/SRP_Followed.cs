
class ShoppingCart_Followed
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

class InvoicePrinter
{
    public void PrintInvoice(ShoppingCart_Followed cart)
    {
        Console.WriteLine("Invoice:");
        foreach (var product in cart.GetProducts())
        {
            Console.WriteLine($"{product.Name}: {product.Price:C}");
        }
        Console.WriteLine($"Total: {cart.CalculateTotal():C}");
    }
}

class DatabaseSaver
{
    public void SaveToDatabase(ShoppingCart_Followed cart)
    {
        Console.WriteLine("Saving shopping cart to database...");
        // Code to save the shopping cart to a database
    }
}   