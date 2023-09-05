namespace AsyncProgrammingAndGenerics.Homework.Solution.ExerciseFive;

public static class ExerciseFiveRunner
{
    public static void Run()
    {
        string[] names = { "Alice", "Bob", "Charlie", "David" };
        List<string> fruits = new List<string> { "Apple", "Banana", "Cherry" };

        LengthComparer stringComparer = new LengthComparer();
        SizeComparer<string> collectionComparer = new SizeComparer<string>();

        Console.WriteLine("Comparing string lengths:");
        Console.WriteLine(stringComparer.Compare(names[0], names[1])); // Output: -1 (Alice < Bob)
        Console.WriteLine(stringComparer.Compare(fruits[0], fruits[2])); // Output: 0 (Apple == Cherry)

        Console.WriteLine("\nComparing collection sizes:");
        Console.WriteLine(collectionComparer.Compare(fruits, fruits)); // Output: 0 (Same size)
    }
}

public interface IComparer<T>
{
    int Compare(T x, T y);
}

public class LengthComparer : IComparer<string>
{
    public int Compare(string x, string y)
    {
        return x.Length.CompareTo(y.Length);
    }
}

public class SizeComparer<T> : IComparer<ICollection<T>>
{
    public int Compare(ICollection<T> x, ICollection<T> y)
    {
        return x.Count.CompareTo(y.Count);
    }
}