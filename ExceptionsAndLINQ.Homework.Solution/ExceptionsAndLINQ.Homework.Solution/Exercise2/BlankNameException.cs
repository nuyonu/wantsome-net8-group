namespace ExceptionsAndLINQ.Homework.Solution.Exercise2;

public class BlankNameException : Exception
{
    public BlankNameException(string? message) : base(message)
    { }
}
