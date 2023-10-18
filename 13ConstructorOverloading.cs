public class Person
{
    public string Name;
    public int Age;
    //constructor with name parameter
    public Person(string name){
        Name = name;
        Age = 0;

    }
    public Person(string name , int age){
        Name = name;
        Age = age;

    }
    //Default constructor
    public Person()
    {
        Name = "UNKNOWN";
        Age = 33;
    }
        
}
class Program{
    public static void Main(){
    Person P1 = new Person("Alice");
    Console.WriteLine("First Constructor\nName: " +P1.Name +" Age: "+P1.Age);
    Person P3 = new Person("Bill",44);
    Console.WriteLine("Second Constructor \nName: "+P3.Name+ " Age: "+P3.Age);
    Person P2 = new Person();
    Console.WriteLine("Default Constructor\nName: "+P2.Name+" Age: " +P2.Age);
}
}