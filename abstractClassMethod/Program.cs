using System;

namespace AbstractClassesDemo
{
    // Abstract class
    public abstract class Shape
    {
        public abstract double GetArea();
    }

    // Derived class Circle
    public class Circle : Shape
    {
        public double Radius { get; set; }

        public Circle(double radius)
        {
            Radius = radius;
        }

        public override double GetArea()
        {
            return Math.PI * Radius * Radius;
        }
    }

    // Derived class Rectangle
    public class Rectangle : Shape
    {
        public double Width { get; set; }
        public double Height { get; set; }

        public Rectangle(double width, double height)
        {
            Width = width;
            Height = height;
        }

        public override double GetArea()
        {
            return Width * Height;
        }
    }

    class Program
    {
        static void Main(string[] args)
        {
            // Prompt user for circle radius and create Circle instance
            Console.Write("Enter the radius of the circle: ");
            double radius = Convert.ToDouble(Console.ReadLine());
            Circle circle = new Circle(radius);

            // Prompt user for rectangle dimensions and create Rectangle instance
            Console.Write("Enter the width of the rectangle: ");
            double width = Convert.ToDouble(Console.ReadLine());
            Console.Write("Enter the height of the rectangle: ");
            double height = Convert.ToDouble(Console.ReadLine());
            Rectangle rectangle = new Rectangle(width, height);

            // Calculate and display the areas
            Console.WriteLine($"Circle Area: {circle.GetArea()}");
            Console.WriteLine($"Rectangle Area: {rectangle.GetArea()}");
        }
    }
}
