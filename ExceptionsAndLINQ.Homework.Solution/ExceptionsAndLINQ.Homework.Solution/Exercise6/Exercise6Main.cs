namespace ExceptionsAndLINQ.Homework.Solution.Exercise6
{
    internal static class Exercise6Main
    {
        public static void Run()
        {
            Console.WriteLine(100.ToBinary());
            Console.WriteLine(100.ToBinaryRaw());
        }
    }

    public static class IntegerExtensions
    {
        public static string ToBinary(this int value)
        {
            return Convert.ToString(value, 2);
        }

        public static string ToBinaryRaw(this int value)
        {
            var binary = string.Empty;
            var current = value;

            while (current > 0)
            {
                binary = (current % 2) + binary;
                current /= 2;
            }
            return binary;
        }
    }
}
