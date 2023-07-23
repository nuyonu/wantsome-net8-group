namespace OOP.Advanced.Homework.Solution.ClassLibrary.ExerciseThree;

public abstract class Shape
{
    public string Color { get; set; }

    public double Area { get; protected set; }

    public abstract void CalculateArea();

    public virtual double GetPerimeter()
    {
        // This is just an example. This should be also abstract because returning 0 is not ok for everyone
        return 0;
    }
}