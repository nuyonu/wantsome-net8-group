using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOP.Week4_Classwork
{
    public class Author
    {
        public Author(string name, string email, string country) 
        {
            this.name = name;
            this.email = email;
            this.country = country;
        }

        public string name;
        public string email;
        public string country;

        public void Print()
        {
            string result = $"Name {this.name}, Email: {email}, Country: {country}";

            Console.WriteLine(result);
        }
    }
}


/*
 * Create a class Author with one constructor to initialize the values:
- name
- email
- country

Add Print Method (to show all details)*/