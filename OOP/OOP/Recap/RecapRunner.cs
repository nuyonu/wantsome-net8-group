namespace OOP.Recap
{
    public static class RecapRunner
    {
        public static void Run()
        {
            ConstructionProject project = new ConstructionProject("Office Building", DateTime.Now.AddDays(-30), DateTime.Now.AddDays(30), "ABC Construction", 500000.0f);

            project.AddTask("Excavation", 10);
            project.AddTask("Foundation", 20);
            project.AddTask("Structural Framing", 30);
            project.AddTask("Plumbing", 15);

            Console.WriteLine(project.GetProjectDuration());  // Output: 75
            Console.WriteLine(project.GetTotalCost());  // Output: 30000.0

            List<string> tasks = project.GetTasksNames();
            foreach (string task in tasks)
            {
                Console.WriteLine(task);
            }
        }
    }
}
