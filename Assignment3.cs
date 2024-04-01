using System;

class Program
{
    static void Main(string[] args)
    {
        Console.Write("Enter seconds: ");
        int seconds = Convert.ToInt32(Console.ReadLine());

        double minutes = seconds / 60.0;
        Console.WriteLine($"{seconds} seconds is equal to {minutes} minutes.");

        double hours = minutes / 60.0;
        Console.WriteLine($"{minutes} minutes is equal to {hours} hours.");

        double days = hours / 24.0;
        Console.WriteLine($"{hours} hours is equal to {days} days.");

        double months = days / 30.0;
        Console.WriteLine($"{days} days is equal to {months} months.");
    }
}