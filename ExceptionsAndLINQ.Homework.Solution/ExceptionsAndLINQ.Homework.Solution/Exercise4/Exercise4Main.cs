namespace ExceptionsAndLINQ.Homework.Solution.Exercise4
{
    internal static class Exercise4Main
    {
        public static void Run()
        {
            Console.WriteLine("To close the program, write STOP.");
            while(true)
            {
                Console.Write("Enter the name of a file: ");
                string fileName = Console.ReadLine();

                if (fileName == "STOP")
                {
                    break;
                }

                try
                {
                    if (File.Exists(fileName))
                    {
                        string fileContent = File.ReadAllText(fileName);

                        if (string.IsNullOrEmpty(fileContent))
                        {
                            Console.WriteLine("File is empty.");
                            Console.Write("Enter some text to write to the file: ");
                            fileContent = Console.ReadLine();
                            File.WriteAllText(fileName, fileContent);

                            Console.WriteLine("\nFile contents:");
                            Console.WriteLine(fileContent);
                        }
                        else
                        {
                            Console.WriteLine("File contents:");
                            Console.WriteLine(fileContent);
                        }
                    }
                    else
                    {
                        Console.WriteLine("File does not exist.");
                        Console.Write("Enter some text to write to the file: ");
                        string fileContent = Console.ReadLine();
                        File.WriteAllText(fileName, fileContent);

                        Console.WriteLine("\nFile contents:");
                        Console.WriteLine(fileContent);
                    }
                }
                catch (IOException e)
                {
                    Console.WriteLine("Error: An I/O error occurred while reading or writing the file. {0}", e.Message);
                }
            }
        }
    }
}
