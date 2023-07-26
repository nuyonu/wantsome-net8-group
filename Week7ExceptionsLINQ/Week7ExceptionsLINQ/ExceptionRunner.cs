using Week7ExceptionsLINQ.Exceptions;

namespace Week7ExceptionsLINQ
{
    public static class ExceptionRunner
    {
        public static void Run()
        {
            //ExampleOne();
            //ExampleTwo();
            ExerciseOne();
        }

        public static void ExerciseOne()
        {
            /*
             * Write a program that reads a number from the user and checks if it is a prime number. If the number is less than 2, throw a custom exception called InvalidNumberException.
             */
            Console.WriteLine("Introdu numarul pentru a verifica daca e prim:");
            int number = Int32.Parse(Console.ReadLine());

            try
            {
                if (IsPrime(number))
                {
                    Console.WriteLine("Numarul este prim.");
                }
                else
                {
                    Console.WriteLine("Numarul nu este prim.");
                }
            }
            catch (InvalidNumberException ex)
            {
                Console.WriteLine("Numarul introdus trebuie sa fie mai mare ca 2.");
                Console.WriteLine(ex.Message);
            }
            catch (Exception ex)
            {
                Console.WriteLine("Something went wrong. Please contact us.");
            }
        }

        public static bool IsPrime(int number)
        {
            if (number < 2)
            {
                throw new InvalidNumberException("The number should be greater than 2.");
            }

            for(int i = 2; i < number; i++)
            {
                if(number % i == 0)
                {
                    return false;
                }
            }

            return true;
        }

        public static void ExampleTwo()
        {
            while(true)
            {
                Console.WriteLine("Introdu numele angajatului:");
                string name = Console.ReadLine();

                try
                {
                    Employee alex = new Employee(name);

                    Console.WriteLine($"Angajatul cu numele {alex.Name} a fost creat.");

                    break;
                }
                catch (NameException ex)
                {
                    Console.WriteLine("Numele introdus nu este corect. Introdu din nou.");
                }
            }
        }

        public static void ExampleOne()
        {
            try
            {
                string content = ReadFromFile("temp.txt", "write");

                if (content.Contains("temp"))
                {
                    Console.WriteLine("Contine");
                }
                else
                {
                    Console.WriteLine("Nu contine");
                }
            }
            catch (ArgumentNullException ex)
            {
                Console.WriteLine("Fisierul pe care doresti sa-l citesti nu este disponibil.");
            }
            catch (InvalidOperationException ex)
            {
                Console.WriteLine("InvalidOperationException");
            }
            finally
            {
                Console.WriteLine("Finally.");
            }

            string ReadFromFile(string fileName, string operation)
            {
                if (fileName == null)
                {
                    throw new ArgumentNullException();
                }

                if (operation != "read")
                {
                    throw new InvalidOperationException();
                }

                return "temp";
            }
        }
    }
}
