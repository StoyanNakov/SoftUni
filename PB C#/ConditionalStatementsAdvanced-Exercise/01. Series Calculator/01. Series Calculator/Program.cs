using System;

namespace _01._Series_Calculator
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string serialName = Console.ReadLine();
            double seasonsNumber = double.Parse(Console.ReadLine()); 
            double episodies = double.Parse(Console.ReadLine());
            double minutes = double.Parse(Console.ReadLine());
            double sumInMinutes = 0;

            sumInMinutes = (((minutes * 20) /100) + minutes) * episodies * seasonsNumber + (seasonsNumber * 10) ;

            Console.WriteLine($"Total time needed to watch the {serialName} series is {sumInMinutes:f0} minutes.");


        }
    }
}
