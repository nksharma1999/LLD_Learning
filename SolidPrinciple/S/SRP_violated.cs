using System;

// This class also violates the Single Responsibility Principle (SRP) because it has multiple responsibilities:
// 1. It manages the list of products in the shopping cart (AddProduct and GetProducts methods).
// 2. It calculates the total price of the products in the cart (CalculateTotal method).
// 3. It prints the invoice (PrintInvoice method).
class ShoppingCart_Violated
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

    // This method is responsible for calculating the total price of the products in the cart, which is a separate responsibility from managing the products.
    public decimal CalculateTotal()
    {
        decimal total = 0;
        foreach (var product in products)
        {
            total += product.Price;
        }
        return total;
    }

    // This method is responsible for printing the invoice, which is another separate responsibility from managing the products and calculating the total.
    public void PrintInvoice()
    {
        Console.WriteLine("Invoice:");
        foreach (var product in products)
        {
            Console.WriteLine($"{product.Name}: {product.Price:C}");
        }
        Console.WriteLine($"Total: {CalculateTotal():C}");
    }

    public void SaveToDatabase()
    {
        Console.WriteLine("Saving shopping cart to database...");
        // Code to save the shopping cart to a database
    }
}