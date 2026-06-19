interface Shape
{
    decimal Area();
    decimal Volume();
}

class Square : Shape
{
    private decimal Side { get; set; }

    public Square(decimal side)
    {
        Side = side;
    }
    public decimal Area()
    {
        return Side * Side;
    }

    public decimal Volume()
    {
        throw new NotImplementedException("Volume is not applicable for Square.");
    }
}

class Rectangle : Shape
{
    private decimal Length { get; set; }
    private decimal Width { get; set; }

    public Rectangle(decimal length, decimal width)
    {
        Length = length;
        Width = width;
    }
    public decimal Area()
    {
        return Length * Width;
    }

    public decimal Volume()
    {
        throw new NotImplementedException("Volume is not applicable for Rectangle.");
    }
}
// The Cube class violates the Interface Segregation Principle (ISP) because it is forced to implement the Volume method, which is not applicable to all shapes. This leads to a design where some classes have methods that are not relevant to their functionality, resulting in a less cohesive and more difficult to maintain codebase.
class Cube : Shape
{
    private decimal Side { get; set; }

    public Cube(decimal side)
    {
        Side = side;
    }
    public decimal Area()
    {
        return 6 * Side * Side;
    }

    public decimal Volume()
    {
        return Side * Side * Side;
    }
}
