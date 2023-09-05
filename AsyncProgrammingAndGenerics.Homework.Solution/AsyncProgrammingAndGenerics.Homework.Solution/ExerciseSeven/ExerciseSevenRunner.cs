namespace AsyncProgrammingAndGenerics.Homework.Solution.ExerciseSeven;

public static class ExerciseSevenRunner
{
    public static async Task RunAsync()
    {
        string filePath = "output.txt";
        string content = "Hello, World!";

        await WriteStringToFileAsync(filePath, content);

        Console.WriteLine($"Content written to {filePath}");
    }

    public static async Task WriteStringToFileAsync(string filePath, string content)
    {
        using (var writer = new StreamWriter(filePath))
        {
            await writer.WriteAsync(content);
        }
    }
}