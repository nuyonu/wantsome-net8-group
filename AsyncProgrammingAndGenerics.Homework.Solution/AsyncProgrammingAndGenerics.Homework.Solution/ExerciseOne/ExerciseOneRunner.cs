namespace AsyncProgrammingAndGenerics.Homework.Solution.ExerciseOne;

public static class ExerciseOneRunner
{
    public static void Run()
    {
        List<int> numbers = new List<int> { 1, 2, 3, 4, 5 };
        List<int> reversedNumbers = ReverseList(numbers);
        
        Console.WriteLine("Original List:");
        foreach (var number in numbers)
        {
            Console.Write($"{number} ");
        }
        
        Console.WriteLine("\nReversed List:");
        foreach (var number in reversedNumbers)
        {
            Console.Write($"{number} ");
        }
    }

    public static List<T> ReverseList<T>(List<T> inputList)
    {
        var result = new List<T>();
        
        for(var index = inputList.Count - 1; index >= 0; index--)
        {
            result.Add(inputList[index]);
        }

        return result;
    }
}