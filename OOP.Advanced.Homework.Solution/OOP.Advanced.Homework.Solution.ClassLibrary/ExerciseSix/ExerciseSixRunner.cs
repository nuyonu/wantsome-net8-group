namespace OOP.Advanced.Homework.Solution.ClassLibrary.ExerciseSix;

public static class ExerciseSixRunner
{
    public static void Run()
    {
        IShape circle = new Circle(5);
        IShape rectangle = new Rectangle(10, 5);

        Console.WriteLine(circle.CalculateArea()); // Outputs 78.5398163397448
        Console.WriteLine(rectangle.CalculateArea()); // Outputs 50

        Console.WriteLine(circle.CalculateArea("square feet")); // Outputs "Area: 78.5398163397448 square feet"
        Console.WriteLine(rectangle.CalculateArea("square meters")); // Outputs "Area: 50 square meters"

        var circleColor = (IColor) circle;
        circleColor.Color = "Red";

        var rectangleColor = (IColor) rectangle;
        rectangleColor.Color = "Blue";

        Console.WriteLine(circleColor.Color); // Outputs "Red"
        Console.WriteLine(rectangleColor.Color); // Outputs "Blue"
    }
}