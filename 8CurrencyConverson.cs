

Console.WriteLine("Choose currency conversion:");
Console.WriteLine("1. USD to INR\n 2. KWD to INR \n 3. EUR to INR");
Console.Write("Enter your choice (1/2/3): ");

int choice = Convert.ToInt32(Console.ReadLine());

double amount, result;

switch (choice)
{
    case 1:
        Console.Write("Enter the amount in USD: ");
        amount = Convert.ToDouble(Console.ReadLine());
        result = amount * 81.07; // Conversion rate as of the knowledge cutoff date.
        Console.WriteLine($"Converted amount: {result} INR");
        break;

    case 2:
        Console.Write("Enter the amount in KWD: ");
        amount = Convert.ToDouble(Console.ReadLine());
        result = amount * 267.104; // Conversion rate as of the knowledge cutoff date.
        Console.WriteLine($"Converted amount: {result} INR");
        break;

    case 3:
        Console.Write("Enter the amount in EUR: ");
        amount = Convert.ToDouble(Console.ReadLine());
        result = amount * 91.2389; // Conversion rate as of the knowledge cutoff date.
        Console.WriteLine($"Converted amount: {result} INR");
        break;

    default:
        Console.WriteLine("Invalid choice. Please select a valid option (1/2/3).");
        break;
}