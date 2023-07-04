using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOP.Week4
{
    public class Employee
    {
        //public Employee()
        //{
        //    this.firstName = "Not Defined";
        //    this.lastName = "Not Defined";
        //    this.salary = 1890;
        //}

        public Employee(string firstName, string lastName, string cnp)
        {
            this.firstName = firstName;
            this.lastName = lastName;
            this.cnp = cnp;
            this.salary = 1890;
            this.isActive = true;
        }

        public string firstName;
        public string lastName;
        public int age;
        public string cnp;
        public double salary;
        public bool isActive;
        public DateOnly startDate;

        public void IncreaseSalaryByAge()
        {
            this.salary = this.salary * this.age;
        }

        public int GetNextAge()
        {
            return this.age + 1;
        }

        public void IncreaseAge()
        {
            this.age = this.age + 1;
        }

        // IncreaseSalaryByAge => newSalary = salary * age;
        // IncreaseAge => age + 1


       // public RETURN_TYPE METHOD_NAME {}
       // Examples:
       // public void MyMethod {}
       // pbulic int MyMethodWithReturn { return 20; }
    }
}
