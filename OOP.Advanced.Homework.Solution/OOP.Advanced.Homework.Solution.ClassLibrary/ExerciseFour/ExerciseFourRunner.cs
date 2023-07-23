namespace OOP.Advanced.Homework.Solution.ClassLibrary.ExerciseFour;

public static class ExerciseFourRunner
{
    public static void Run()
    {
        var manager = new Manager("John Doe", 35, 50000, Department.IT);
        var developer = new Developer("Jane Smith", 28, 30000, new List<string> { "C#", "JavaScript" }, false);

        Console.WriteLine(manager.CalculateBonus()); // Outputs 5000
        Console.WriteLine(developer.CalculateBonus()); // Outputs 6000

        Console.WriteLine(manager.GetContactInfo()); // Outputs "Name: John Doe, Age: 35, Department: IT, Email: john.d
    }
}