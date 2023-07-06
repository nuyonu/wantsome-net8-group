using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOP.Week4_Classwork
{
    public class Car
    {
        public Car(string model, int year, string color, int mileage) 
        {
            this.model = model;
            this.year = year;
            this.color = color;
            this.mileage = mileage;
        }

        public string model;
        public int year;
        public string color;
        public int mileage;

        public string GetModel()
        {
            return model;
        }

        public string GetModel2(string defaultModel)
        {
            var result = model == null ? defaultModel : model;

            return result;
        }

        public int GetYear()
        {
            return year;
        }

        public int GetMileage()
        {
            return mileage;
        }

        public void Drive()
        {
            mileage = mileage + 10;
        }
    }
}

/*
 * 
 * Create a class Car with one constructor and the following fields:
- model
- year
- color
- mileage

Add the following methods:
- GetModel() - returns the model of the car.
- GetYear() - returns the year the car was made.
- GetColor() - returns the color of the car.
- GetMileage() - returns the current mileage of the car.
- Drive() - increase the mileage of the car by 10 miles.
 */