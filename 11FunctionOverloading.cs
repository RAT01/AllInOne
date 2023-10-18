//fUNCTION OVERLOADING
public class Calculator{
public int Add(int a, int b){
    return a + b;
}
public int Add(int a, int b, int c){
    return a+b+c;
}
public double Add(double a, double b){
    return a + b;
}

}
class Program{
    static void Main(){
        Calculator c = new Calculator();
        int sum = c.Add(11,13);
        int sum2 = c.Add(11,12,13);
        double sum3= c.Add(1.2,1.3);
        Console.WriteLine(sum);

        Console.WriteLine(sum2);
        Console.WriteLine(sum3);


    }
}