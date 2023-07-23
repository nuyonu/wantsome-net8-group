namespace OOP.Advanced.Homework.Solution.ClassLibrary.ExerciseFour;

public abstract class Employee
{
    public string Name { get; set; }

    public int Age { get; set; }
    
    // We can have also Email and Phone number properties

    public double Salary { get; set; }

    public abstract double CalculateBonus();

    public virtual string GetContactInfo()
    {
        return $"Name: {Name}, Age: {Age}";
    }
}