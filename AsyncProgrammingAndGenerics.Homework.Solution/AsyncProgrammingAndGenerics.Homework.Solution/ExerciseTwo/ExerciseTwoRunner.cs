namespace AsyncProgrammingAndGenerics.Homework.Solution.ExerciseTwo;

public static class ExerciseTwoRunner
{
    public static void Run()
    {
        List<string> fruits = new List<string> { "Apple", "Banana", "Cherry" };
        
        Console.WriteLine("Original List:");
        foreach (var fruit in fruits)
        {
            Console.Write($"{fruit} ");
        }

        Console.WriteLine();
        
        ApplyAction(fruits, fruit => Console.WriteLine($"I like {fruit}s!"));
    }

    public static void ApplyAction<T>(List<T> inputList, Action<T> action)
    {
        foreach (var item in inputList)
        {
            action(item);
        }
    }
}