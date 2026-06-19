class DInitialization
{
    public void Initialize()
    {
        Console.WriteLine("Violating Dependency Inversion Principle:");
        UserService userService = new UserService();
        userService.storeUserToMySQL();
        userService.storeUserToMongoDB();
        Console.WriteLine("\nFollowing Dependency Inversion Principle:");
        IDatabase mySQLDatabase = new MySQLDatabase_Followed();
        IDatabase mongoDBDatabase = new MongoDBDatabase_Followed();
        UserService_Followed userService_Followed = new UserService_Followed(mySQLDatabase);
        userService_Followed.StoreUser("John Doe");
        userService_Followed = new UserService_Followed(mongoDBDatabase);
        userService_Followed.StoreUser("Jane Doe");

    }
}