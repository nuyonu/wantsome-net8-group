using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOP.Week4
{
    public class Car
    {
        // Ctor => brand, model, year  + by default color = white;
        // Ctor => brand, model, year, color

        public Car(string brand, string model, int year)
        {
            this.brand = brand;
            this.model = model;
            this.year = year;
            this.color = "white";
            this.nrOfSeats = 4;
        }

        public Car(string brand, string model, int year, string color)
        {
            this.brand = brand;
            this.model = model;
            this.year = year;
            this.color = color;
            this.nrOfSeats = 4;
        }

        ~Car()
        {
            Console.WriteLine("Destructor");
        }

        public string color;
        public string brand;
        public int nrOfSeats;
        public int year;
        public string model;

        public void ChangeColor(string newColor)
        {
            this.color = newColor;
        }

        public string GetModelCode()
        {
            string result = string.Empty;

            result += this.brand;
            result += this.model;
            result += this.year;

            return result;
        }

        public string GetModelCode2()
        {
            return $"{this.brand}{this.model}{this.year}";
        }
    }

    //public class Course 
    //{ 
    //}
}
