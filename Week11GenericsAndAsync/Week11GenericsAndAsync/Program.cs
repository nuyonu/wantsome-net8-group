using System.Runtime.Intrinsics.X86;
using Week11GenericsAndAsync.AsyncProgramming;
using Week11GenericsAndAsync.AsyncProgramming.ExerciseThree;
using Week11GenericsAndAsync.Generics;

//GenericsRunner.Run();

//new CoffeMaker().MakeCoffe();

//Console.WriteLine("\nAsync method:");

//await new CoffeMakerAsync().MakeCoffeAsync();

//- Use the created function to read a file
//var result = await FileHelper.ReadFileFromPathAsync(FilePaths.File1);

//Console.WriteLine(result);

List<Task<string>> readFromFilesTasks = new List<Task<string>>
{
    FileHelper.ReadFileFromPathAsync(FilePaths.File1),
    FileHelper.ReadFileFromPathAsync(FilePaths.File2),
    FileHelper.ReadFileFromPathAsync(FilePaths.File3),
};

//- Use the function to start reading files in parallel, but display the fastest response
//var fastestTask = await Task.WhenAny(readFromFilesTasks);
//Console.WriteLine(await fastestTask);

//- Use the function to start reading files in parallel, but display all concatenated contents
var allTasksResult = await Task.WhenAll(readFromFilesTasks);
Console.WriteLine(string.Join("", allTasksResult));