using System;

public class Program
{
    public static void Main(string[] args)
    {
        Console.WriteLine("Temperature Conversion:");
        Console.WriteLine("1. Celsius to Fahrenheit");
        Console.WriteLine("2. Fahrenheit to Celsius");
        Console.Write("Enter your choice (1/2): ");

        int choice = Convert.ToInt32(Console.ReadLine());

        double temp, far, convertedTemp;

        switch (choice)
        {
            case 1:
                Console.Write("Enter the temperature in Celsius: ");
                temp = Convert.ToDouble(Console.ReadLine());
                convertedTemp = CelsiusToFahrenheit(temp);
                Console.WriteLine($"Converted temperature: {convertedTemp} Fahrenheit");
                break;

            case 2:
                Console.Write("Enter the temperature in Fahrenheit: ");
                far = Convert.ToDouble(Console.ReadLine());
                convertedTemp = FahrenheitToCelsius(far);
                Console.WriteLine($"Converted temperature: {convertedTemp} Celsius");
                break;

            default:
                Console.WriteLine("Invalid choice. Please select a valid option (1/2).");
                break;
        }
    }

    public static double CelsiusToFahrenheit(double celsius)
    {
        return (celsius * 9 / 5) + 32;
    }

    public static double FahrenheitToCelsius(double fahrenheit)
    {
        return (fahrenheit - 32) * 5 / 9;
    }
}
