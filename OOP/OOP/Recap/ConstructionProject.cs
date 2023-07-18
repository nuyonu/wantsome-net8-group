namespace OOP.Recap
{
    public class ConstructionProject
    {
        public ConstructionProject()
        {
            Tasks = new List<ConstructionTask>();
        }

        public ConstructionProject(string projectName, DateTime startDate, DateTime endDate, string contractor, float budget) : this()
        {
            ProjectName = projectName;
            StartDate = startDate;
            EndDate = endDate;
            Contractor = contractor;
            Budget = budget;
        }

        public string ProjectName { get; set; }

        public DateTime StartDate { get; set; }

        public DateTime EndDate { get; set; }

        public string Contractor { get; set; }

        public float Budget { get; set; }

        public List<ConstructionTask> Tasks { get; set; }

        public void AddTask(string taskName, int duration)
        {
            var task = new ConstructionTask(taskName, duration);

            Tasks.Add(task);
        }

        public int GetProjectDuration()
        {
            int totalProjectDuration = 0;

            foreach (ConstructionTask task in Tasks)
            {
                totalProjectDuration += task.Duration;
            }

            return totalProjectDuration;
        }

        public float GetTotalCost()
        {
            return (float)(400 * GetProjectDuration());
        }

        public List<string> GetTasksNames()
        {
            List<string> tasksNames = new List<string>();

            foreach (ConstructionTask task in Tasks)
            {
                tasksNames.Add(task.Name);
            }

            return tasksNames;
        }
    }

    // [ {taskName, duration}, {taskName, duration}]
}

/*
 * Create a class ConstructionProject that represents a construction project. The class should have the following properties:
- ProjectName (string): The name of the construction project.
- StartDate (string): The start date of the construction project.
- EndDate (string): The end date of the construction project.
- Contractor (string): The name of the contractor responsible for the project.
- Budget (float): The allocated budget for the construction project.
- Tasks (list of Task): The tasks that must be done in order to complete the construction.

Methods:
- AddTask(taskName: string, duration: int): Adds a new task to the project with the given task name and duration in days.
- GetProjectDuration() -> int: Returns the total duration of the construction project in days, considering the durations of all tasks.
- GetTotalCost() -> float: Returns the total cost of the construction project, which is the sum of the durations of all tasks multiplied by a predefined daily rate.
- GetTaskList() -> List[str]: Returns a list of all tasks in the construction project.
 */
