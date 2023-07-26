using Week7ExceptionsLINQ;
using Week7ExceptionsLINQ.Exceptions;

//ExceptionRunner.Run();

//int x = 0;
//int? y = null;
//// OR
//Nullable<int> z = null;


string pathToFile = @"D:/Projects/GitHub/wantsome-net8-group/Week7ExceptionsLINQ/Week7ExceptionsLINQ2/temporar.txt";
string pathToFileWrite = @"D:/Projects/GitHub/wantsome-net8-group/Week7ExceptionsLINQ/Week7ExceptionsLINQ/temporar2.txt";

try
{
    string content = File.ReadAllText(pathToFile);

    Console.WriteLine(content);

    File.WriteAllText(pathToFileWrite, content);
}
catch(FileNotFoundException ex)
{
    Console.WriteLine("Pathul catre fisier nu este corect sau fisierul nu exista.");
}
catch(DirectoryNotFoundException ex)
{
    Console.WriteLine("Pathul contine un folder (directory) ce nu exista.");
}

// ArgumentNullExceptio, FileNotFoundException, DirectoryNotFoundException
// File.ReadAllLines();