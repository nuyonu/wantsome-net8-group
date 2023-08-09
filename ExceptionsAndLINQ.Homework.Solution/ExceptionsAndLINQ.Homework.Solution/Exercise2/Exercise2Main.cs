namespace ExceptionsAndLINQ.Homework.Solution.Exercise2
{
    internal static class Exercise2Main
    {
        public static void Run()
        {
            Console.WriteLine("Insert a list of names. Write STOP to close the program");

            try
            {
                var insertedNames = new List<string>();
                
                while (true)
                {
                    var insertedName = Console.ReadLine();

                    if (insertedName == "STOP")
                    {
                        break;
                    }

                    CheckIfNameIsBlank(insertedName);

                    insertedNames.Add(insertedName);
                }

                Console.WriteLine($"You entered the following names: {string.Join(", ", insertedNames)}");
            }
            catch (BlankNameException exception)
            {
                Console.WriteLine(exception.Message);
            }
        }

        private static void CheckIfNameIsBlank(string? insertedName)
        {
            if (string.IsNullOrEmpty(insertedName) || string.IsNullOrWhiteSpace(insertedName))
            {
                throw new BlankNameException("Inserted name is blank.");
            }
        }
    }
}
