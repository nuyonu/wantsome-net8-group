using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOP.Week5_Classwork
{
    public abstract class Shape
    {
        public abstract double GetArea();

        public abstract double GetPerimeter();
    }

    public class Circle : Shape
    {
        public Circle(double radius)
        {
            Radius = radius;
        }

        public double Radius { get; set; }

        public double PI { get; } = 3.14;

        public override double GetArea()
        {
            return PI * (Radius * Radius);
        }

        public override double GetPerimeter()
        {
            return 2 * PI * Radius;
        }
    }

    public class Rectangle : Shape
    {
        public Rectangle(double width, double height)
        {
            Width = width;
            Height = height;
        }

        public double Width { get; set; }

        public double Height { get; set; }

        public override double GetArea()
        {
            return Width * Height;
        }

        public override double GetPerimeter()
        {
            return 2 * Width + 2 * Height;
        }
    }
}

/*
 * Create an abstract Shape class that has the following abstract methods:
- GetArea(): returns the area of the shape.
- GetPerimeter(): returns the perimeter of the shape.

Next, create a Circle class that inherits from the Shape class and has the following private properties: radius and PI. The Circle class should override the GetArea() and GetPerimeter() methods from the Shape class and implement them using the formula for the area and perimeter of a circle.

Finally, create a Rectangle class that inherits from the Shape class and has the following private properties: width and height. The Rectangle class should override the GetArea() and GetPerimeter() methods from the Shape class and implement them using the formula for the area and perimeter of a rectangle.
 */