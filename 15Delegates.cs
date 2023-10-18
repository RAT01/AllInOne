using System;
delegate void MyDelegate(int a, int b);
public class Calculate{
    public static void add(int a, int b){
        Console.WriteLine("Addition is " +(a + b));
    }
    public static void sub(int a, int b){
        Console.WriteLine("Subtraction  is " +(a - b));

    }
}
class Program{
    public static void Main(){
        MyDelegate MDele = new MyDelegate(Calculate.add);
        MDele (7,8);
        MyDelegate MDele1= new MyDelegate(Calculate.sub);
        MDele1(8,6);
    }
}