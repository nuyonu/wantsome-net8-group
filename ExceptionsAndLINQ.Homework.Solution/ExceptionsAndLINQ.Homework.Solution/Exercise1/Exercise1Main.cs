namespace ExceptionsAndLINQ.Homework.Solution.Exercise1
{
    internal static class Exercise1Main
    {
        public static void Run()
        {
            Console.WriteLine("Insert a date from the future:");

            try
            {
                var insertedDate = Console.ReadLine();
                DateTimeHelper.ParseAndCheckIfDateIsInTheFuture(insertedDate);

                Console.WriteLine("Inserted date is correct.");
            }
            catch (InvalidDateException exception)
            {
                Console.WriteLine(exception.Message);
            }
        }
    }

}
