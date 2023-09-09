using System;

class Program
{
    private const double BASE_RATE = 200;
    private const double RATE_PER_HOUR = 150;
    private const double RATE_PER_MILE = 2;

    static void Main()
    {
        Console.Write("Enter hours: ");
        double hours = double.Parse(Console.ReadLine());

        Console.Write("Enter miles: ");
        double miles = double.Parse(Console.ReadLine());

        double fee = BASE_RATE + RATE_PER_HOUR * hours + RATE_PER_MILE * miles;
        Console.WriteLine($"Total fee: ${fee:0.00}");
    }
}
