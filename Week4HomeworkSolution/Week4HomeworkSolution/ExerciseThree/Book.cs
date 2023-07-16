namespace Week4HomeworkSolution.ExerciseThree
{
    public class Book
    {
        // Fields. Can be encapsulated (make them private)
        public string title;
        public string author;
        public int year;

        // Constructor
        public Book(string title, string author, int year)
        {
            this.title = title;
            this.author = author;
            this.year = year;
        }

        // Getters and setters for the fields to set and retrieve internal values if they are private.
        public string GetAuthor()
        {
            return this.author;
        }

        public string GetTitle()
        {
            return this.title;
        }

        public int GetYear()
        {
            return this.year;
        }

        public void SetAuthor(string newAuthor)
        {
            this.author = newAuthor;
        }

        public void SetTitle(string newTitle)
        {
            this.title = newTitle;
        }

        public void SetYear(int newYear)
        {
            this.year = newYear;
        }
    }
}
