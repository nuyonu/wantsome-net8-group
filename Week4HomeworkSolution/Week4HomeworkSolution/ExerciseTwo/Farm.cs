namespace Week4HomeworkSolution.ExerciseTwo;

public class Farm
{
    public Farm(string name, int area)
    {
        this.name = name;
        this.area = area;
        this.animalCount = 0;
    }
    
    public string name;
    public int area;
    public int animalCount;

    public void AddAnimals(int count)
    {
        animalCount += count;
    }

    public double CalculateDensity()
    {
        return (double)animalCount / (double)area;
    }
}