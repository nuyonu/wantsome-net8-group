namespace Week4HomeworkSolution.ExerciseEight
{
    public class StudentEight
    {
        // Fields
        public string name;
        public DateTime startDate;
        public DateTime? endDate; // DateTime? means Nullable<DateTime> https://learn.microsoft.com/en-us/dotnet/csharp/language-reference/builtin-types/nullable-value-types
        public College college;
        public DateTime birthDate;

        // Constructor
        public StudentEight(string name, DateTime startDate, DateTime? endDate, College college, DateTime birthDate)
        {
            this.name = name;
            this.startDate = startDate;
            this.endDate = endDate;
            this.college = college;
            this.birthDate = birthDate;
        }

        // Method for checking if the student is still enrolled
        public bool IsStillStudent()
        {
            // If end date is null, then is still a student
            if (endDate == null)
            {
                return true;
            }

            // If end date is in the future, then is still a student
            if (DateTime.Now < endDate)
            {
                return true;
            }

            // Something else => false
            return false;
        }

        // Method for getting the student's age
        public int GetAge()
        {
            DateTime today = DateTime.Today;
            int age = today.Year - birthDate.Year;

            if (birthDate > today.AddYears(-age))
            {
                age--;
            }

            return age;
        }

        // Method for printing the student's details
        public void Print()
        {
            Console.WriteLine($"Name: {name} \n Start Date: {startDate.ToString("d")} \n College: {college.name} \n Birth Date: {birthDate.ToString("d")} \n Age: {GetAge()}");
        }
    }
}