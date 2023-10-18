using System;
// Base class (Superclass)
public class Animal
{
    public void MakeSound()
    {
        Console.WriteLine("Animal makes a sound.");
    }
}
// First derived class (Subclass)
public class Dog : Animal
{
    public void Bark()
    {
        Console.WriteLine("Dog barks!");
    }
}
// Second derived class (Subclass)
public class Cat : Animal
{
    public void Meow()
    {
        Console.WriteLine("Cat meows!");
    }
}
class Program
{
    static void Main()
    {
        Dog myDog = new Dog();
        myDog.MakeSound(); // Inherited method from the Animal class
        myDog.Bark();      // Method specific to the Dog class

        Cat myCat = new Cat();
        myCat.MakeSound(); // Inherited method from the Animal class
        myCat.Meow();      // Method specific to the Cat class
    }
}
