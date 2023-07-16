namespace Week4HomeworkSolution.ExerciseOne;

public class Crop
{
    public string name;
    // This can be encapsulated
    public string currentStage;

    public Crop(string name)
    {
        this.name = name;
        this.currentStage = "Seed";
    }

    public void Water()
    {
        // This ca be done with Enum instead of hardcoded strings.
        switch (this.currentStage)
        {
            case "Seed":
                this.currentStage = "Sprout";
                break;
            
            case "Sprout":
                this.currentStage = "Plant";
                break;
            
            case "Plant":
                this.currentStage = "CanBeHarvested";
                break;
            
            case "CanBeHarvested":
                Console.WriteLine("You can't water this crop anymore.");
                throw new Exception("Stage is already to CanBeHarvested");
            
            case "Harvested":
                Console.WriteLine("You can't water this crop anymore.");
                throw new Exception("Stage is already to Harvested");
            
            default:
                throw new Exception("Something went wrong.");
        }
    }

    public void Harvest()
    {
        if (currentStage != "CanBeHarvested")
        {
            throw new Exception("You need to water this plant until can be harvested.");
        }

        this.currentStage = "Harvested";
    }

    public void PrintCurrentStage()
    {
        Console.WriteLine($"Current stage is <{this.currentStage}> for {this.name}.");
    }
}
