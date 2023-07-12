using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOP.Week5
{
    public abstract class Vehicle
    {
        public string Color { get; set; }

        public int NrOfWheels { get; set; }

        public abstract void MakeSound();
    }

    public class Audi : Vehicle
    {
        public int SerialNumber { get; set; }

        public override void MakeSound()
        {
            Console.WriteLine("Audi sound");
        }
    }

    public class Tesla : Vehicle
    {
        public bool ElectricCar { get; set; }

        public override void MakeSound()
        {
            Console.WriteLine("Tesla sound");
        }
    }

    public class Dacia : Vehicle
    {
        public override void MakeSound()
        {
            Console.WriteLine("Dacia sound");
        }
    }
}
