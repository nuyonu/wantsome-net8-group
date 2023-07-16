namespace Week4HomeworkSolution.ExerciseSeven
{
    public class Student
    {
        // Fields
        private string firstName;
        private string lastName;
        private int studentId;
        private double gpa;

        // Constructor
        public Student(string firstName, string lastName, int studentId, double gpa)
        {
            this.firstName = firstName;
            this.lastName = lastName;
            this.studentId = studentId;
            this.gpa = gpa;
        }

        // Method for getting the student's full name
        public string GetFullName()
        {
            return firstName + " " + lastName;
        }

        // Method for checking if the student has honors
        public bool HasHonors()
        {
            return gpa >= 3.5;
        }
    }
}
