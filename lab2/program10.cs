
//Write a class named ‘Shape’ having Length and Breadth properties along with default and parametrized constructor.
//The parametrized constructor should accept two inputs and initializethe properties of the class.
//Create new class rectangle from shape class and calculate area of rectangle. 
/*using System;

public class Shape
{
    // Properties
    public double Length { get; set; }
    public double Breadth { get; set; }

    // Default Constructor
    public Shape()
    {
        Length = 0;
        Breadth = 0;
    }

    // Parameterized Constructor
    public Shape(double length, double breadth)
    {
        Length = length;
        Breadth = breadth;
    }
}
public class Rectangle : Shape
{
    // Constructor that calls the base class constructor
    public Rectangle(double length, double breadth) : base(length, breadth)
    {
    }

    // Method to calculate the area of the rectangle
    public double CalculateArea()
    {
        return Length * Breadth;
    }
}
public class Program10
{
    public static void Main()
    {
        // Create an instance of Rectangle using the parameterized constructor
        Rectangle rect = new Rectangle(5.0, 3.0);

        // Calculate and display the area of the rectangle
        double area = rect.CalculateArea();
        Console.WriteLine($"The area of the rectangle is: {area}");
    }
}
*/