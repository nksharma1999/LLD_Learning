interface TwoDimensionalShape
{
    decimal Area();
}

interface ThreeDimensionalShape : TwoDimensionalShape
{
    decimal Volume();
}

class Square_Followed : TwoDimensionalShape
{
    private decimal Side { get; set; }

    public Square_Followed(decimal side)
    {
        Side = side;
    }
    public decimal Area()
    {
        return Side * Side;
    }
}

class Rectangle_Followed : TwoDimensionalShape
{
    private decimal Length { get; set; }
    private decimal Width { get; set; }

    public Rectangle_Followed(decimal length, decimal width)
    {
        Length = length;
        Width = width;
    }
    public decimal Area()
    {
        return Length * Width;
    }
}

class Cube_Followed : ThreeDimensionalShape
{
    private decimal Side { get; set; }

    public Cube_Followed(decimal side)
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