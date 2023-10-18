// See https://aka.ms/new-console-template for more information
Console.WriteLine(" Test for prime numbers.");

 int count = 0; //count of 0 after modulus
//   Console.WriteLine("Enter the Number");
int input =Convert.ToInt16(Console.ReadLine());

 while (input != null){
    Console.WriteLine("Enter the Number--------");

    input =Convert.ToInt16(Console.ReadLine());
for(int i = 1; i<=input; i++){
    if (input%i==0){
       count++;
       break;
    }
}
    
    if(count==2 ){
    Console.WriteLine("{0} is a prime Number", input);
    
    }
    if(input==1 || input ==0){
        Console.WriteLine("is not a prime or composite"); 
      }
    else {
    Console.WriteLine("{0} is not a prime Number", input);
    }
 }