
//Write a program to demonstrate different types of property in C#.

/*using System;


public class Demo
{
    // Auto-Implemented Property
    public int AutoProperty { get; set; }

    // Read-Only Property
    public int ReadOnlyProperty { get; }

    // Write-Only Property
    private string writeOnlyBackingField;
    public string WriteOnlyProperty
    {
        set
        {
            writeOnlyBackingField = value;
        }
    }

    // Computed Property
    public int ComputedProperty
    {
        get
        {
            return AutoProperty * 2; // For demonstration, compute double of AutoProperty
        }
    }

    // Static Property
    public static int StaticProperty { get; set; }

    // Constructor to initialize ReadOnlyProperty
    public Demo(int readOnlyValue)
    {
        ReadOnlyProperty = readOnlyValue;
    }

    // Method to display property values
    public void DisplayProperties()
    {
        Console.WriteLine("AutoProperty: " + AutoProperty);
        Console.WriteLine("ReadOnlyProperty: " + ReadOnlyProperty);
        Console.WriteLine("ComputedProperty: " + ComputedProperty);
        Console.WriteLine("StaticProperty: " + StaticProperty);
    }
}

public class Program9
{
    public static void Main()
    {
        // Creating an instance of Demo class
        Demo demoInstance = new Demo(10);

        // Setting values
        demoInstance.AutoProperty = 5;
        demoInstance.WriteOnlyProperty = "This is a write-only property";

        // Setting static property
        Demo.StaticProperty = 42;

        // Displaying property values
        demoInstance.DisplayProperties();
    }
}
*/