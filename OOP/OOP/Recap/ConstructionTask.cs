namespace OOP.Recap
{
    public class ConstructionTask
    {
        public ConstructionTask(string name, int duration)
        {
            Name = name;
            Duration = duration;
        }

        public string Name { get; set; }

        public int Duration { get; set; }
    }
}

/*
 * Create a class ConstructionTask that represents a contruction task. The class should have the following properties:
- Name: The name of the construction task.
- Duration: The duration of the construction task.
 */