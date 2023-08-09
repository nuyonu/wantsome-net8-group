namespace ExceptionsAndLINQ.Homework.Solution.Exercise1;

public class InvalidDateException : Exception
{
    public InvalidDateException(string? message) : base(message)
    { }
}
