using System;

namespace _04.FishingBoat
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int budjet = int.Parse(Console.ReadLine());
            string season = Console.ReadLine();
            int people = int.Parse(Console.ReadLine());
            double sum = 0;

            if (season == "Spring")
            {
                sum = 3000;
            }

            if (season == "Summer" || season == "Autumn")
            {
                sum = 4200;
            }
            
            if (season == "Winter")
            {
                sum = 2600;
            }
            if (people <= 6)
            {
                sum = sum - (sum * 0.1);
            }
            if (people >= 7 && people <= 11)
            {
                sum = sum - (sum * 0.15);
            }

            if (people >= 12)
            {
                sum = sum - (sum * 0.25);
            }
            if (people % 2 == 0 && season != "Autumn")
            {
                sum = sum - (sum * 0.05);
            }

            if (sum <= budjet)
            {
                Console.WriteLine($"Yes! You have {budjet - sum:f2} leva left.");
            }
            else { Console.Write($"Not enough money! You need {sum - budjet:f2} leva.");}
        }
    }
}
