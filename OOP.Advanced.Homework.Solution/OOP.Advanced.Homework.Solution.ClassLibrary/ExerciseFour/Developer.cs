namespace OOP.Advanced.Homework.Solution.ClassLibrary.ExerciseFour;

public class Developer : Employee
{
    public Developer(string name, int age, double salary, List<string> skills, bool isJunior)
    {
        Name = name;
        Age = age;
        Salary = salary;
        Skills = skills;
        IsJunior = isJunior;
    }

    public List<string> Skills { get; set; }

    public bool IsJunior { get; set; }

    public override double CalculateBonus()
    {
        return Salary * 0.2;
    }

    public override string GetContactInfo()
    {
        return
            $"Name: {Name}, Age: {Age}, Skills: {string.Join(", ", Skills)}, Email: {EmailHelper.ConstructEmailFromName(Name)}, Phone: [COMING SOON]";
    }
}