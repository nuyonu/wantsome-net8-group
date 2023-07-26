namespace Week7ExceptionsLINQ.Exceptions
{
    public class NameException : Exception
    {
        public NameException(string? message) : base(message)
        { }
    }
}
