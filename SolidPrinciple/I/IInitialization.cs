class IInitialization
{
    public void Initialize()
    {
        Console.WriteLine("Initialization logic goes here for violated examples.");
        Shape square = new Square(5);
        Shape rectangle = new Rectangle(4, 6);
        Shape cube = new Cube(3);
        Console.WriteLine($"Square Area: {square.Area()}");
        Console.WriteLine($"Rectangle Area: {rectangle.Area()}");
        Console.WriteLine($"Cube Area: {cube.Area()}");
        Console.WriteLine($"Cube Volume: {cube.Volume()}");

        try
        {
            Console.WriteLine($"Square Volume: {square.Volume()}");
        }
        catch (NotImplementedException ex)
        {
            Console.WriteLine(ex.Message);
        }

        Console.WriteLine("Initialization logic goes here for compliant examples.");
        Console.WriteLine("Two-Dimensional Shapes:");
        TwoDimensionalShape squareFollowed = new Square_Followed(5);
        TwoDimensionalShape rectangleFollowed = new Rectangle_Followed(4, 6);
        ThreeDimensionalShape cubeFollowed = new Cube_Followed(3);
        Console.WriteLine($"Square Area: {squareFollowed.Area()}");
        Console.WriteLine($"Rectangle Area: {rectangleFollowed.Area()}");
        Console.WriteLine($"Cube Area: {cubeFollowed.Area()}");
        Console.WriteLine($"Cube Volume: {cubeFollowed.Volume()}");
        // The following line would cause a compile-time error, as TwoDimensionalShape does not have a Volume method.
        // Console.WriteLine($"Square Volume: {squareFollowed.Volume()}");
        Console.WriteLine("Attempting to call Volume on TwoDimensionalShape will result in a compile-time error, demonstrating adherence to the Interface Segregation Principle.");
    }
}