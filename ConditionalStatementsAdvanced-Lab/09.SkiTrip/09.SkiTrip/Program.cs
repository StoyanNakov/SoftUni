using System;

namespace _09.SkiTrip
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int days = int.Parse(Console.ReadLine());
            string  rooms = Console.ReadLine();
            string stars = Console.ReadLine();
            double sum = 0;


            if (rooms == "room for one person")
            {
                sum = (days - 1) * 18.00;
            }

            if (rooms == "apartment")
            {
                sum = (days - 1) * 25.00;
                if (days < 10) { sum = sum - (sum * 0.30); }
                if (days > 10 && days <= 15) { sum = sum - (sum * 0.35); }
                if (days > 15) { sum = sum - (sum * 0.50); }
            }
            if (rooms == "president apartment")
            {
                sum = (days - 1) * 35.00;
                if (days < 10) { sum = sum - (sum * 0.10); }
                if (days > 10 && days <= 15) { sum = sum - (sum * 0.15); }
                if (days > 15) { sum = sum - (sum * 0.20); }
            }
            if (stars == "positive")
            {
                sum = sum + (sum * 0.25);
            }
            else { sum = sum - (sum * 0.10); }

            Console.WriteLine($"{sum:f2}");
        }
    }
}
