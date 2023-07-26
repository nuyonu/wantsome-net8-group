using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Week7ExceptionsLINQ.Exceptions;

namespace Week7ExceptionsLINQ
{
    public class Employee
    {
        public Employee()
        { }

        public Employee(string name)
        {
            this.Name = name;
        }

        private string name;

        public string Name
        {
            get
            {
                return name;
            }
            set
            {
                if (value.Length < 3)
                {
                    throw new NameException("Name should have length greater than 3.");
                }

                name = value;
            }
        }

        public int Age { get; set; }

        public double Salary { get; set; }
    }
}
