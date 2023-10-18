// See https://aka.ms/new-console-template for more information
using System;
public class Program
{
    public static void Main(string[] args)
    {
    
        //
        String String1 = "     string method        ";
        Console.WriteLine(String1);
        //ToUpper()
        Console.WriteLine(String1.ToUpper());
        //ToLower()
        Console.WriteLine(String1.ToLower());
        //Replace Method to Function
        Console.WriteLine(String1.Replace("method", "function"));
        //Remove whitespaces from the string at the start of string and the end of string
        Console.WriteLine(String1.Trim());
        //length of the string
        Console.WriteLine(String1.Length);
        //retrives a substring from 'String1' starting from index 14 to the end of string
        Console.WriteLine(String1.Substring(14));
    }

}