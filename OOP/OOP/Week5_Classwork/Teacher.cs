using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOP.Week5_Classwork
{
    public class Teacher : Person
    {
        public List<Course> Courses { get; set; }

        public override void Introduce()
        {
            Console.WriteLine($"Hi, my name is {GetFullName()} and i'm a teacher.");
            Console.WriteLine("My courses:");
            foreach (Course course in Courses)
            {
                Console.WriteLine($"Id: {course.Id}, Name: {course.Name}");
            }
        }

        public override string GetFullName()
        {
            return $"{FirstName} {LastName}";
        }
    }
}

/*
 * 
 * Createa a class Teacher that inherits from Person class and implement the Introduce method with message "Hi, my name is <FULL NAME> and i'm a teacher."
Teacher should have the following properties:
- Courses - a list with courses

Now update the class Person to force the derived class to implement GetFullName() - returns a string
 */