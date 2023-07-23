namespace OOP.Advanced.Homework.Solution.ClassLibrary.ExerciseFour;

public class Manager : Employee
{
    public Manager(string name, int age, double salary, Department department)
    {
        Name = name;
        Age = age;
        Salary = salary;
        Department = department;
    }

    public Department Department { get; set; }

    public override double CalculateBonus()
    {
        return Salary * 0.1;
    }

    public override string GetContactInfo()
    {
        return $"Name: {Name}, Age: {Age}, Department: {Department}, Email: {EmailHelper.ConstructEmailFromName(Name)}, Phone: [COMING SOON]";
    }
}