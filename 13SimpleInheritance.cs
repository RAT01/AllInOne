using System;
// Base class (Superclass)
public class Animal
{
    public string Name { get; set; }
    public int Age { get; set; }
    public void MakeSound()
    {
        Console.WriteLine("Animal makes a sound.");
    }
}
// Derived class (Subclass)
public class Dog : Animal
{
    public void Bark()
    {
        Console.WriteLine("Dog barks!");
    }
}
class Program
{
    static void Main()
    {
        Dog myDog = new Dog();
        myDog.Name = "Buddy";
        myDog.Age = 3;

        Console.WriteLine("Dog's Name: " + myDog.Name);
        Console.WriteLine("Dog's Age: " + myDog.Age);

        myDog.MakeSound(); // Inherited method from the Animal class
        myDog.Bark();      // Method specific to the Dog class
    }
}
