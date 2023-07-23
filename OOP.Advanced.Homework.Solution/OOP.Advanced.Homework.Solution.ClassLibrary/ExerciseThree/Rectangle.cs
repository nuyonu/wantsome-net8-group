namespace OOP.Advanced.Homework.Solution.ClassLibrary.ExerciseThree;

public class Rectangle : Shape
{
    public Rectangle(string color, double width, double height)
    {
        Color = color;
        Width = width;
        Height = height;
    }

    public double Width { get; set; }

    public double Height { get; set; }

    public override void CalculateArea()
    {
        Area = Width * Height;
    }

    public override double GetPerimeter()
    {
        return 2 * (Width + Height);
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
                perimeter = perimeter * 1550.0031; // Convert to square inches
                break;
            
            case "feet":
                perimeter = perimeter * 10.7639104; // Convert to square feet
                break;
        }

        return $"Perimeter: {perimeter} {unit}";
    }
}