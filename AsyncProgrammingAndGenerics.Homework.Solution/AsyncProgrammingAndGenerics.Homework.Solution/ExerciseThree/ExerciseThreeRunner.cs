namespace AsyncProgrammingAndGenerics.Homework.Solution.ExerciseThree;

public static class ExerciseThreeRunner
{
    public static void Run()
    {
        GenericQueue<string> queue = new GenericQueue<string>();
        
        queue.Enqueue("First");
        queue.Enqueue("Second");
        queue.Enqueue("Third");
        
        Console.WriteLine($"Peek: {queue.Peek()}");
        Console.WriteLine($"Dequeue: {queue.Dequeue()}");
        Console.WriteLine($"Peek: {queue.Peek()}");
    }
}