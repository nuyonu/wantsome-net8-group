namespace OOP.Advanced.Homework.Solution.ClassLibrary.ExerciseThree;

public static class ExerciseThreeRunner
{
    public static void Run()
    {
        var rectangle1 = new Rectangle("Green", 6, 8);
        var rectangle2 = new Rectangle("Yellow", 10, 12);

        var circle1 = new Circle("Purple", 3);
        var circle2 = new Circle("Orange", 5);

        var shapes = new List<Shape> { rectangle1, rectangle2, circle1, circle2 };

        foreach (var shape in shapes)
        {
            shape.CalculateArea();
        }

        shapes.Sort((shape1, shape2) => shape2.Area.CompareTo(shape1.Area));

        foreach (var shape in shapes)
        {
            Console.WriteLine(shape.Color + ": " + shape.Area);
        }

        double totalPerimeter = 0;
        foreach (var shape in shapes)
        {
            totalPerimeter += shape.GetPerimeter();
        }

        Console.WriteLine("Total perimeter: " + totalPerimeter + " inches"); // Outputs "Total perimeter: 122,26548245744 inches"
    }
}