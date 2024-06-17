using System;

namespace InheritanceDemo
{
    // Base class Animal
    public class Animal
    {
        public virtual void MakeSound()
        {
            Console.WriteLine("Some generic sound");
        }
    }

    // Derived class Dog
    public class Dog : Animal
    {
        public override void MakeSound()
        {
            Console.WriteLine("Bark");
        }
    }

    // Derived class Cat
    public class Cat : Animal
    {
        public override void MakeSound()
        {
            Console.WriteLine("Meow");
        }
    }

    class Program
    {
        static void Main(string[] args)
        {
            // Create instances of Animal, Dog, and Cat
            Animal animal = new Animal();
            Dog dog = new Dog();
            Cat cat = new Cat();

            // Prompt user for choice
            Console.WriteLine("Enter 'animal', 'dog', or 'cat' to know sound:");
            string choice = Console.ReadLine().ToLower();

            // Call the MakeSound() method based on user choice
            switch (choice)
            {
                case "animal":
                    animal.MakeSound();  // Outputs "Some generic sound"
                    break;
                case "dog":
                    dog.MakeSound();     // Outputs "Bark"
                    break;
                case "cat":
                    cat.MakeSound();     // Outputs "Meow"
                    break;
                default:
                    Console.WriteLine("Invalid choice. Please enter 'animal', 'dog', or 'cat'.");
                    break;
            }
        }
    }
}
