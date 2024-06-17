using System;

namespace InterfacesDemo
{
    // Interface
    public interface IMovable
    {
        void Move();
    }

    // Class Car implementing IMovable
    public class Car : IMovable
    {
        public void Move()
        {
            Console.WriteLine("Car is moving");
        }
    }

    // Class Bicycle implementing IMovable
    public class Bicycle : IMovable
    {
        public void Move()
        {
            Console.WriteLine("Bicycle is moving");
        }
    }

    class Program
    {
        static void Main(string[] args)
        {
            // Create instances of Car and Bicycle
            Car car = new Car();
            Bicycle bicycle = new Bicycle();

            // Prompt user for choice
            Console.WriteLine("Type 'car' or 'bicycle' to know if the vehicle is moving:");
            string vehicleChoice = Console.ReadLine().ToLower();

            // Call the Move() method based on user choice
            switch (vehicleChoice)
            {
                case "car":
                    car.Move();      // Outputs "Car is moving"
                    break;
                case "bicycle":
                    bicycle.Move();  // Outputs "Bicycle is moving"
                    break;
                default:
                    Console.WriteLine("Invalid choice. Please type 'car' or 'bicycle'.");
                    break;
            }
        }
    }
}
