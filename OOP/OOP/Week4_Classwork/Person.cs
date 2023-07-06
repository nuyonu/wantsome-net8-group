using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOP.Week4_Classwork
{
    public class Person
    {
        public Person(string firstName, string lastName, int age, string gender) 
        {
            this.firstName = firstName;
            this.lastName = lastName;
            this.age = age;

            if (gender != "Male" && gender != "Female")
            {
                throw new Exception("Gender is not correct.");
            }

            this.gender = gender;
        }

        public string firstName;
        public string lastName;
        public int age;
        public string gender;
    }
}

/*
 * 
 * Create a class Person with one constructor to initialize the values:
- firstName
- lastName
- age
- gender (Check if gender is Male or Female. If not, throw an Exception)

Add Introduce method with the following message: "Hi, mi name is <FULL NAME> and I am a <AGE> year old <GENDER>."
 */