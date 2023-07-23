namespace OOP.Advanced.Homework.Solution.ClassLibrary.ExerciseTwo;

public class Book
{

    public Book(string title, string author, int pageCount)
    {
        Title = title;
        Author = author;
        PageCount = pageCount;
        CurrentPage = 1; // By default, the current page is set to the beginning (page 1)
    }

    public string Title { get; set; }

    public string Author { get; set; }

    public int PageCount { get; set; }

    public int CurrentPage { get; set; }

    public string GetTitle()
    {
        return Title;
    }

    public string GetAuthor()
    {
        return Author;
    }

    public int GetPageCount()
    {
        return PageCount;
    }

    public int GetCurrentPage()
    {
        return CurrentPage;
    }

    public void NextPage()
    {
        if (CurrentPage < PageCount)
        {
            CurrentPage++;
        }
    }

    public void PreviousPage()
    {
        if (CurrentPage > 1)
        {
            CurrentPage--;
        }
    }
}