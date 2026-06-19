
class MySQLDatabase //Low-level module
{
    public void SaveToMySQL()
    {
        Console.WriteLine("Saving data to MySQL database...");
    }
}

class MongoDBDatabase //Low-level module
{
    public void SaveToMongoDB()
    {
        Console.WriteLine("Saving data to MongoDB database...");
    }
}

class UserService //High-level module
{

    public void storeUserToMySQL()
    {
        MySQLDatabase mySQLDatabase = new MySQLDatabase();
        mySQLDatabase.SaveToMySQL();
    }

    public void storeUserToMongoDB()
    {
        MongoDBDatabase mongoDBDatabase = new MongoDBDatabase();
        mongoDBDatabase.SaveToMongoDB();
    }
}