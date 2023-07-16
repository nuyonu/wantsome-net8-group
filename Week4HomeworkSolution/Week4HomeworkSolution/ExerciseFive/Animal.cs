namespace Week4HomeworkSolution.ExerciseFive
{
    public class Animal
    {
        // Fields. Can be encapsulated (make them private)
        public string name;
        public string species;
        public string breed;
        public int age;
        public string color;
        public double weight;
        public bool isSpayedOrNeutered;

        // Constructor
        // Best practice is to have maximum 7 parameters on constructor or methods
        public Animal(string name, string species, string breed, int age, string color, double weight, bool isSpayedOrNeutered)
        {
            this.name = name;
            this.species = species;
            this.breed = breed;
            this.age = age;
            this.color = color;
            this.weight = weight;
            this.isSpayedOrNeutered = isSpayedOrNeutered;
        }

        // Getters and setters for the fields
        public string GetName()
        {
            return name;
        }

        public void SetName(string name)
        {
            this.name = name;
        }

        public string GetSpecies()
        {
            return species;
        }

        public void SetSpecies(string species)
        {
            this.species = species;
        }

        public string GetBreed()
        {
            return breed;
        }

        public void SetBreed(string breed)
        {
            this.breed = breed;
        }

        public int GetAge()
        {
            return age;
        }

        public void SetAge(int age)
        {
            this.age = age;
        }

        public string GetColor()
        {
            return color;
        }

        public void SetColor(string color)
        {
            this.color = color;
        }

        public double GetWeight()
        {
            return weight;
        }

        public void SetWeight(double weight)
        {
            this.weight = weight;
        }

        public bool IsSpayedOrNeutered()
        {
            return isSpayedOrNeutered;
        }

        public void SetIsSpayedOrNeutered(bool isSpayedOrNeutered)
        {
            this.isSpayedOrNeutered = isSpayedOrNeutered;
        }
    }
}
