namespace OOP.Advanced.Homework.Solution.ClassLibrary.ExerciseTwo;

public static class ExerciseTwoRunner
{
    public static void Run()
    {
        var book = new Book("The Great Gatsby", "F. Scott Fitzgerald", 180);

        Console.WriteLine(book.GetTitle()); // Outputs "The Great Gatsby"
        Console.WriteLine(book.GetAuthor()); // Outputs "F. Scott Fitzgerald"
        Console.WriteLine(book.GetPageCount()); // Outputs 180
        Console.WriteLine(book.GetCurrentPage()); // Outputs 1

        book.NextPage();
        Console.WriteLine(book.GetCurrentPage()); // Outputs 2

        book.NextPage();
        book.NextPage();
        book.NextPage();
        Console.WriteLine(book.GetCurrentPage()); // Outputs 5

        book.PreviousPage();
        Console.WriteLine(book.GetCurrentPage()); // Outputs 4

        book.Title = "The Great Gatsby (Revised Edition)";
        Console.WriteLine(book.GetTitle()); // Outputs "The Great Gatsby (Revised Edition)"

        book.Author = "F. Scott Fitzgerald (Revised by Jane Doe)";
        Console.WriteLine(book.GetAuthor()); // Outputs "F. Scott Fitzgerald (Revised by Jane Doe)"
    }
}