using Week7ExceptionsLINQ;
using Week7ExceptionsLINQ.Exceptions;
using Week7ExceptionsLINQ.ExtensionMethods;
using Week7ExceptionsLINQ.LINQExercices;

//ExceptionRunner.Run();

//int x = 0;
//int? y = null;
//// OR
//Nullable<int> z = null;


//string pathToFile = @"D:/Projects/GitHub/wantsome-net8-group/Week7ExceptionsLINQ/Week7ExceptionsLINQ2/temporar.txt";
//string pathToFileWrite = @"D:/Projects/GitHub/wantsome-net8-group/Week7ExceptionsLINQ/Week7ExceptionsLINQ/temporar2.txt";

//try
//{
//    string content = File.ReadAllText(pathToFile);

//    Console.WriteLine(content);

//    File.WriteAllText(pathToFileWrite, content);
//}
//catch(FileNotFoundException ex)
//{
//    Console.WriteLine("Pathul catre fisier nu este corect sau fisierul nu exista.");
//}
//catch(DirectoryNotFoundException ex)
//{
//    Console.WriteLine("Pathul contine un folder (directory) ce nu exista.");
//}

// ArgumentNullExceptio, FileNotFoundException, DirectoryNotFoundException
// File.ReadAllLines();

//string myName = "alexandru";
//Console.WriteLine(StringExtensions.MakeLastLetterUpperCase(myName));
//Console.WriteLine(myName.MakeLastLetterUpperCase());
//Console.WriteLine(myName.AppendLetter("a"));


//Console.WriteLine("racecar".IsPalindrom());
//Console.WriteLine("alex".IsPalindrom());

//Func<string, bool> isPalindrom = (input) =>
//{
//    for (int index = 0; index < input.Length - 1; index++)
//    {
//        if (input[index] != input[input.Length - 1 - index])
//        {
//            return false;
//        }
//    }

//    return true;
//};

//Console.WriteLine(isPalindrom("racecar"));

//Func<string, bool> compareTemp = input => "alex" == input;
//Console.WriteLine(compareTemp("alex"));

//var student = new
//{
//    Name = "Alex",
//    Age = 25,
//    Gender = "Male",
//    IsActive = true
//};

//Console.WriteLine(student.Name);

//List<string> names = new List<string>
//{
//    "Rebeca",
//    "Alexandru",
//    "Oana",
//    "Roxana",
//    "Ana",
//    "Bogdan",
//    "Melania",
//    "Adrian",
//    "Stefana"
//};

//List<string> orderedNames = names.Where(x => x.Contains("r") || x.Contains("R"))
//                                .OrderBy(x => x)
//                                .Select(x => x.ToLower())
//                                .ToList();
//orderedNames.Print();

//List<Car> cars = new List<Car>
//{
//    new Car("Honda Civic", 4, "green", false, 2010),
//    new Car("Dacia Duster", 5, "white", false, 2017),
//    new Car("Tesla", 4, "black", true, 2020),
//    new Car("Honda Long", 6, "purple", false, 1998),
//    new Car("Honda Short", 2, "white", false, 2015),
//};

//var resultCars = cars.Where(x => x.Year > 2000)
//                        .OrderBy(x => x.Model)
//                        .Select(x => new
//                        {
//                            Model = x.Model,
//                            Year = x.Year
//                        })
//                        .ToList();

//foreach (var carAnonymous in resultCars)
//{
//    Console.WriteLine($"Model: {carAnonymous.Model}, Year: {carAnonymous.Year}");
//}

//resultCars.Print();

//Console.WriteLine("Do you want to sort the result?");
//var input = bool.Parse(Console.ReadLine());

//List<string> names = new List<string>
//{
//    "Rebeca",
//    "Alexandru",
//    "Oana",
//    "Roxana",
//    "Ana",
//    "Bogdan",
//    "Melania",
//    "Adrian",
//    "Stefana"
//};

//var resultImmediateExecution = names.Select(x => x.ToLower())
//    .OrderBy(x => x)
//    .Where(x => x.Contains("r") || x.Contains("R"))
//    .ToList();

//var resultDefferedExecution = names.Select(x => x.ToLower());

//if (input)
//{
//    resultDefferedExecution = resultDefferedExecution.OrderBy(x => x);
//}

//resultDefferedExecution = resultDefferedExecution.Where(x => x.Contains("r") || x.Contains("R"));

//names.Add("Bobr");

//// Immediate execution
//foreach (var item in resultImmediateExecution)
//{
//    Console.WriteLine(item);
//}

//// Deffered LINQ Execution
//Console.WriteLine("\n\n\nDeferred method:");
//foreach (var item in resultDefferedExecution)
//{
//    Console.WriteLine(item);
//}

var numbers = new List<int> { 1, 2, 3, 4, 5, 6 };

// Exercise 8
Console.WriteLine(numbers.Where(x => x % 2 == 0).Sum(x => x * x));

// Exercise 9
var exercise9 = numbers.Select(x => x * x).ToList();

Console.Write(string.Join(" ", exercise9));