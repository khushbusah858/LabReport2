//Write a C# program to create virtual method in C#

/*using System;

namespace khushi
{
    // Base class
    public class Animal
    {
        public string Name { get; set; }

        // Virtual method
        public virtual void Speak()
        {
            Console.WriteLine($"{Name} makes a sound.");
        }
    }

    // Derived class
    public class Dog : Animal
    {
        // Override the virtual method
        public override void Speak()
        {
            Console.WriteLine($"{Name} barks.");
        }
    }

    // Another derived class
    public class Cat : Animal
    {
        // Override the virtual method
        public override void Speak()
        {
            Console.WriteLine($"{Name} meows.");
        }
    }

    class Program4
    {
        static void Main(string[] args)
        {
            // Create instances of derived classes
            Animal myAnimal = new Animal { Name = "Generic Animal" };
            Animal myDog = new Dog { Name = "Rex" };
            Animal myCat = new Cat { Name = "Whiskers" };

            // Call the virtual method
            myAnimal.Speak();  // Output: Generic Animal makes a sound.
            myDog.Speak();     // Output: Rex barks.
            myCat.Speak();     // Output: Whiskers meows.

            // Demonstrate polymorphism
            Animal[] animals = { myAnimal, myDog, myCat };
            foreach (var animal in animals)
            {
                animal.Speak();  // Calls the appropriate Speak method based on the actual object type
            }
        }
    }
}*/
