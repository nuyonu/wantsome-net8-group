namespace OOP.Advanced.Homework.Solution.ClassLibrary.ExerciseSix;

public class Circle : IShape, IColor
{

    public Circle(double radius)
    {
        Radius = radius;
        Color = "Black";
    }

    public Circle(double radius, string color)
    {
        Radius = radius;
        Color = color;
    }

    public double Radius { get; set; }

    public string Color { get; set; }

    public double CalculateArea()
    {
        return Math.PI * Radius * Radius;
    }

    public string CalculateArea(string unit)
    {
        var area = CalculateArea();
        return $"Area: {area} {unit}";
    }
}