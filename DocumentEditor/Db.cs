class FileStorage(string filePath = "document.txt") : Persistence
{
    private string _filePath = filePath;

    public void Save(string text)
    {
        // Logic to save the content to a file at _filePath
        System.IO.File.WriteAllText(_filePath, text);
    }
}

class DatabaseStorage(string connectionString = "") : Persistence
{
    private string _connectionString = connectionString;

    public void Save(string text)
    {
        // Logic to save the content to a database using _connectionString
        // This is a placeholder for actual database saving logic.
        Console.WriteLine($"Saving to database: {text}");
    }
}