namespace Week4HomeworkSolution.ExerciseSeven
{
    public class Faculty
    {
        // Fields
        private string firstName;
        private string lastName;
        private int employeeId;
        private List<string> subjectsTaught;

        // Constructor
        public Faculty(string firstName, string lastName, int employeeId, List<string> subjectsTaught)
        {
            this.firstName = firstName;
            this.lastName = lastName;
            this.employeeId = employeeId;
            this.subjectsTaught = subjectsTaught;
        }

        // Method for getting the faculty member's full name
        public string GetFullName()
        {
            return firstName + " " + lastName;
        }

        // Method for getting the subjects the faculty member teaches
        public List<string> GetSubjectsTaught()
        {
            return subjectsTaught;
        }
    }
}
