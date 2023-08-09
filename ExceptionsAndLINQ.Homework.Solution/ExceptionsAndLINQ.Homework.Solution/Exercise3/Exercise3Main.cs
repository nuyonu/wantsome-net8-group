namespace ExceptionsAndLINQ.Homework.Solution.Exercise3
{
    internal static class Exercise3Main
    {
        public static void Run()
        {
            Console.Write("Enter a list of numbers (separated by spaces): ");
            string userInput = Console.ReadLine();

            if (string.IsNullOrEmpty(userInput))
            {
                Console.WriteLine("Your input is invalid.");

                return;
            }

            try
            {
                int[] numbers = userInput.Split(' ').Select(int.Parse).ToArray();

                if (numbers.Length == 0)
                {
                    throw new DivideByZeroException();
                }

                long sum = numbers.Sum();

                if (sum > int.MaxValue)
                {
                    throw new OverflowException();
                }

                double average = (double)sum / numbers.Length;

                Console.WriteLine("Sum: " + sum);
                Console.WriteLine("Average: " + average);
            }
            catch (FormatException)
            {
                Console.WriteLine("Input string was not in a correct format.");
            }
            catch (OverflowException)
            {
                Console.WriteLine("Arithmetic operation resulted in an overflow.");
            }
            catch (DivideByZeroException)
            {
                Console.WriteLine("Attempted to divide by zero.");
            }
        }
    }
}
