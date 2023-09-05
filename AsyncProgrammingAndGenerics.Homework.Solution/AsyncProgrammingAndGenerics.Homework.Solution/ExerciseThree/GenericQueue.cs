namespace AsyncProgrammingAndGenerics.Homework.Solution.ExerciseThree;

public class GenericQueue<T>
{
    private List<T> queue = new List<T>();

    public void Enqueue(T item)
    {
        queue.Add(item);
    }

    public T Dequeue()
    {
        if (queue.Count == 0)
        {
            throw new InvalidOperationException("The queue is empty.");
        }

        T item = queue[0];
        queue.RemoveAt(0);
        return item;
    }

    public T Peek()
    {
        if (queue.Count == 0)
        {
            throw new InvalidOperationException("The queue is empty.");
        }

        return queue[0];
    }

    public bool IsEmpty()
    {
        return queue.Count == 0;
    }
}