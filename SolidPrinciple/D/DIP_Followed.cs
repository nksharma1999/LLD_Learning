interface IDatabase
{
    void SaveData(string data);
}
//Low-level modules
class MySQLDatabase_Followed : IDatabase
{
    public void SaveData(string data)
    {
        Console.WriteLine($"Saving '{data}' to MySQL database...");
    }
}
//Low-level modules
class MongoDBDatabase_Followed : IDatabase
{
    public void SaveData(string data)
    {
        Console.WriteLine($"Saving '{data}' to MongoDB database...");
    }
}

class UserService_Followed //High-level module (Now loosely coupled to the database through the IDatabase interface)
{
    private IDatabase database; 

    public UserService_Followed(IDatabase database)
    {
        this.database = database;
    }

    public void StoreUser(string userData)
    {
        database.SaveData(userData);
    }
}