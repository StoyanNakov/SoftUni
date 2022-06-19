using System;

namespace _05.SmallShop
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string product = Console.ReadLine();
            string town = Console.ReadLine();
            double quantity = double.Parse(Console.ReadLine());
            double sum = 0;
            if (product == "coffee")
            {
                if (town == "Sofia") { sum = quantity * 0.50; }
                else if (town == "Plovdiv") { sum = quantity * 0.40; }
                else if (town == "Varna") { sum = quantity * 0.45; }
            }
            else if (product == "water")
            {
                if (town == "Sofia") { sum = quantity * 0.80; }
                else if (town == "Plovdiv") { sum = quantity * 0.70; }
                else if (town == "Varna") { sum = quantity * 0.70; }
            }
            else if (product == "beer") 
            {
                if (town == "Sofia") { sum = quantity * 1.20; }
                else if (town == "Plovdiv") { sum = quantity * 1.15; }
                else if (town == "Varna") { sum = quantity * 1.10; }
            }
            else if (product == "sweets")
            {
                if (town == "Sofia") { sum = quantity * 1.45; }
                else if (town == "Plovdiv") { sum = quantity * 1.30; }
                else if (town == "Varna") { sum = quantity * 1.35; }
            }
            else if (product == "peanuts")
            {
                if (town == "Sofia") { sum = quantity * 1.60; }
                else if (town == "Plovdiv") { sum = quantity * 1.50; }
                else if (town == "Varna") { sum = quantity * 1.55; }
            }



            Console.WriteLine($"{sum}");
        }
    }
}
