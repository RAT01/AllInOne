// See https://aka.ms/new-console-template for more information
Console.WriteLine("iii. Test for vowels. ");
string str1 , strtolower;
Console.WriteLine("Enter the String ");
str1 = Console.ReadLine();
Console.WriteLine("Your Given String-- "+str1);
strtolower = str1.ToLower();
Console.WriteLine("Now Converted to Lower-- "+ strtolower);
Char[] strarray = strtolower.ToCharArray();

foreach (char r in strarray){
    if (r=='a'|| r == 'e' || r == 'i' ||
    
     r == 'o' || r == 'o')
    {
        Console.WriteLine(r+ " is the vowel");
    }     
}

int len = strarray.Length;
for (int i = len -1; i >= 0; i--)
{
    Console.WriteLine(strarray[i]);
}

for (int m = 0; m < len; m++)
{
    sum += strarray[m];
}