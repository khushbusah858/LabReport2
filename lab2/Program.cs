//Write a C# program to demonstrate different types of inheritance. 

/*using System;

namespace khushi
{
    // Base class
    public class Animal
    {
        public string Name { get; set; }

        public void Eat()
        {
            Console.WriteLine($"{Name} is eating.");
        }
    }

    // Single Inheritance
    public class Dog : Animal
    {
        public void Bark()
        {
            Console.WriteLine($"{Name} is barking.");
        }
    }

    // Multilevel Inheritance
    public class Labrador : Dog
    {
        public void Fetch()
        {
            Console.WriteLine($"{Name} is fetching.");
        }
    }

    // Hierarchical Inheritance
    public class Cat : Animal
    {
        public void Meow()
        {
            Console.WriteLine($"{Name} is meowing.");
        }
    }

    // Interface example for Multiple Inheritance
    public interface IFlyable
    {
        void Fly();
    }

    public class Bird : Animal, IFlyable
    {
        public void Fly()
        {
            Console.WriteLine($"{Name} is flying.");
        }
    }

    class Program
    {
        static void Main(string[] args)
        {
            // Single Inheritance
            Dog myDog = new Dog { Name = "Rex" };
            myDog.Eat();
            myDog.Bark();

            // Multilevel Inheritance
            Labrador myLab = new Labrador { Name = "Buddy" };
            myLab.Eat();
            myLab.Bark();
            myLab.Fetch();

            // Hierarchical Inheritance
            Cat myCat = new Cat { Name = "Whiskers" };
            myCat.Eat();
            myCat.Meow();

            // Interface-based Multiple Inheritance
            Bird myBird = new Bird { Name = "Tweety" };
            myBird.Eat();
            myBird.Fly();
        }
    }
}
*/