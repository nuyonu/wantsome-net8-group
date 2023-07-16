namespace Week4HomeworkSolution.ExerciseSeven
{
    public class University
    {
        // Fields
        private string name;
        private List<Student> students;
        private List<Faculty> faculties;

        // Constructor
        public University(string name)
        {
            this.name = name;
            students = new List<Student>();
            faculties = new List<Faculty>();
        }

        // Method for adding a student to the university
        public void AddStudent(Student student)
        {
            students.Add(student);
        }

        // Method for adding a faculty member to the university
        public void AddFaculty(Faculty faculty)
        {
            faculties.Add(faculty);
        }

        public List<Student> GetStudents()
        {
            return students;
        }

        // Method for getting the number of students at the university
        public int GetStudentCount()
        {
            return students.Count;
        }

        // Method for getting the number of faculty members at the university
        public int GetFacultyCount()
        {
            return faculties.Count;
        }
    }
}
