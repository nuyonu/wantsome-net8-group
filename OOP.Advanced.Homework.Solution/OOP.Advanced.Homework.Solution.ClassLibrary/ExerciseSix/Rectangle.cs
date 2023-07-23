namespace OOP.Advanced.Homework.Solution.ClassLibrary.ExerciseSix;

public class Rectangle : IShape, IColor
{

    public Rectangle(double width, double height)
    {
        Width = width;
        Height = height;
        Color = "Black";
    }

    public Rectangle(double width, double height, string color)
    {
        Width = width;
        Height = height;
        Color = color;
    }

    public double Width { get; set; }

    public double Height { get; set; }

    public string Color { get; set; }

    public double CalculateArea()
    {
        return Width * Height;
    }

    public string CalculateArea(string unit)
    {
        var area = CalculateArea();
        return $"Area: {area} {unit}";
    }
}