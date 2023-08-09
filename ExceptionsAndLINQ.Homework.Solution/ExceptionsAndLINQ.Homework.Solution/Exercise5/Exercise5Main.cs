namespace ExceptionsAndLINQ.Homework.Solution.Exercise5
{
    internal static class Exercise5Main
    {
        public static void Run()
        {
            Console.WriteLine(DateTime.Now.ToFullDateString());
        }
    }

    public static class DateTimeExtensions
    {
        public static string ToFullDateString(this DateTime dateTime)
        {
            return dateTime.ToString("MM/dd/yyyy HH:mm:ss");
        }
    }
}
