// See https://aka.ms/new-console-template for more information
Console.WriteLine("Fibonacci seriees");
int a=0, b=1, c=0;
for (int i=1; i<20; i++){
    Console.Write(a+" ");

    a = a+b;
    b = c;
    c = a;
}
