using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOP.Week5_Classwork
{
    public abstract class Person
    {
        private string gender;

        public string FirstName { get; set; }

        public string LastName { get; set; }

        public int Age { get; set; }

        public string Gender
        {
            get { return gender; }
            set
            {
                if (value.ToLower() == "male" || value.ToLower() == "female")
                {
                    gender = value;
                }
                else
                {
                    throw new Exception("Gender is not correct.");
                }
            }
        }

        public virtual void Introduce()
        {
            Console.WriteLine($"Hi, my name is {LastName} {FirstName} and I am a {Age} year old {Gender}.");
        }

        public abstract string GetFullName();
    }
}

/*
 * Create a class Person with the following properties:
- FirstName
- LastName
- Age
- Gender (Custom property with custom check if gender is Male or Female. If not, throw an Exception). Use case-insensitive comparation. 

Add Introduce method with the following message: "Hi, my name is <FULL NAME> and I am a <AGE> year old <GENDER>.". This will be the base implementation
 */
