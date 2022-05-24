using System;

namespace _07.WorkingHours
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int hour = int.Parse(Console.ReadLine());
            string day = Console.ReadLine();

            if (day != "Sunday" && (hour >= 10 && hour <= 18))
            { Console.WriteLine("open"); }
            else { Console.WriteLine("closed"); }

        }
    }
}
