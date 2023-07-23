namespace OOP.Advanced.Homework.Solution.ClassLibrary.ExerciseThree;

public class Circle : Shape
{
    private const double Pi = Math.PI;

    public Circle(string color, double radius)
    {
        Color = color;
        Radius = radius;
    }

    public double Radius { get; set; }

    public override void CalculateArea()
    {
        Area = Pi * Radius * Radius;
    }

    public override double GetPerimeter()
    {
        return 2 * Pi * Radius;
    }

    public string GetPerimeter(string unit)
    {
        var perimeter = GetPerimeter();

        // We will consider meters as default unit size

        switch (unit)
        {
            case "meters":
                // We don't need to change the value
                break;

            case "inches":
                perimeter *= 1550.0031; // Convert to square inches
                break;

            case "feet":
                perimeter *= 10.7639104; // Convert to square feet
                break;
        }

        return $"Circumference: {perimeter} {unit}";
    }
}