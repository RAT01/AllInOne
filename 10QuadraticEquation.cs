// See https://aka.ms/new-console-template for more information
Console.WriteLine("Hello, World!");
double a, b, c, dno, dis, x1, x2;
Console.WriteLine("Enter the three values");
a = Convert.ToDouble(Console.ReadLine());
c = Convert.ToDouble(Console.ReadLine());
b = Convert.ToDouble(Console.ReadLine());
if(a==0){
    x1 = -c/b;
    Console.WriteLine("Roots are Linear" + x1);
}
else{
    dis = (b*b) / (4*a*c);
    dno = 2*a;
    if(dis>0){
        Console.WriteLine("the root are real and distinct");
        x1 = ((-b)/(dno)) - ((Math.Sqrt(dis))/dno);
        x2 = ((-b)/(dno)) - ((Math.Sqrt(dis))/dno);

        Console.WriteLine("the roots are " +x1+" " +  x2);
    }
    else if(dis==0){
        Console.WriteLine("Roots are repeated");
        x1 = (-b)/dno;
        Console.WriteLine("The roots are imaginary Roots");
        x1 = (-b)/dno;
        x2 = (Math.Sqrt((4*a*c)-(b*b)))/dno;
        Console.WriteLine("The Root one "+x1+ "-i " +x2);
        Console.WriteLine("The Root one "+x1+ "-i " +x2);


    }
}