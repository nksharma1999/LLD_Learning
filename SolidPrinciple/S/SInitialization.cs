using System;
namespace SolidPrinciple.S
{
    public class SInitialization
    {
        public static void Initialize()
        {
            Console.WriteLine("Initialization SRP violation Code Example......");
            ShoppingCart_Violated srp = new();
            srp.AddProduct(new Product("Laptop", 999.99m));
            srp.AddProduct(new Product("Mouse", 49.99m));
            srp.PrintInvoice();
            srp.SaveToDatabase();
            Console.WriteLine("Initialization SRP violation Code Example Ended......");
            
            Console.WriteLine("Initialization SRP followed Code Example......");
            ShoppingCart_Followed srpFollowed = new();
            srpFollowed.AddProduct(new Product("Laptop", 999.99m));
            srpFollowed.AddProduct(new Product("Mouse", 49.99m));
            InvoicePrinter printer = new();
            printer.PrintInvoice(srpFollowed);
            DatabaseSaver saver = new();
            saver.SaveToDatabase(srpFollowed);
            Console.WriteLine("Initialization SRP followed Code Example Ended......");
        }
    }
}