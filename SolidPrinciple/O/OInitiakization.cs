class OInitialization
{
    public void Initialization()
    {
        // Initialization code here
        Console.WriteLine("Initialization OCP violation Code Example......");
        OShoppingCart_Violated ocp = new OShoppingCart_Violated();
        ocp.AddProduct(new Product("Laptop", 999.99m));
        ocp.AddProduct(new Product("Mouse", 49.99m));
        OInvoicePrinter printer = new OInvoicePrinter(ocp);
        printer.PrintInvoice(ocp);
        ODatabaseSaver saver = new ODatabaseSaver(ocp);
        saver.SaveToSQlDatabase();
        saver.SaveToMongoDB();
        saver.SaveToFile();
        Console.WriteLine("Initialization OCP violation Code Example Ended......");
        Console.WriteLine("Initialization OCP Followed Code Example......");
        OShoppingCart_Followed ocpFollowed = new OShoppingCart_Followed();
        ocpFollowed.AddProduct(new Product("Laptop", 999.99m)); 
        ocpFollowed.AddProduct(new Product("Mouse", 49.99m));
        OInvoicePrinter_Followed printerFollowed = new OInvoicePrinter_Followed(ocpFollowed);
        printerFollowed.PrintInvoice(ocpFollowed);
        IDatabaseSaver sqlSaver = new SqlDatabaseSaver();
        sqlSaver.Save(ocpFollowed);
        IDatabaseSaver mongoSaver = new MongoDatabaseSaver();
        mongoSaver.Save(ocpFollowed);
        IDatabaseSaver fileSaver = new FileDatabaseSaver();
        fileSaver.Save(ocpFollowed);
        Console.WriteLine("Initialization OCP Followed Code Example Ended......");
    }
}