namespace Week4HomeworkSolution.ExerciseEight
{
    public class Professor
    {
        // Fields
        public string name;
        public string faculty;
        public string specialization;
        public List<StudentEight> studentsWhoGiveTheirDegree;

        public Professor(string name, string faculty, string specialization)
        {
            this.name = name;
            this.faculty = faculty;
            this.specialization = specialization;
            this.studentsWhoGiveTheirDegree = new List<StudentEight>();
        }

        // Constructor with name, faculty, specialization, and studentsWhoGiveTheirDegree
        public Professor(string name, string faculty, string specialization, List<StudentEight> studentsWhoGiveTheirDegree)
        {
            this.name = name;
            this.faculty = faculty;
            this.specialization = specialization;
            this.studentsWhoGiveTheirDegree = studentsWhoGiveTheirDegree;
        }
    }
}