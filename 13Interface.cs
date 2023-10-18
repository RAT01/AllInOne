using System;

// First interface
public interface IFlyable
{
    void Fly();
}

// Second interface
public interface ISwimmable
{
    void Swim();
}

// Class implementing multiple interfaces
public class Bird : IFlyable, ISwimmable
{
    public void Fly()
    {
        Console.WriteLine("Bird is flying.");
    }

    public void Swim()
    {
        Console.WriteLine("Bird is swimming.");
    }
}

class Program
{
    static void Main()
    {
        Bird myBird = new Bird();
        myBird.Fly(); // Method from the IFlyable interface
        myBird.Swim(); // Method from the ISwimmable interface
    }
}
