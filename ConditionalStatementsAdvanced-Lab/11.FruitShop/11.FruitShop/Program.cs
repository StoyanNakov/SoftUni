using System;

namespace _11.FruitShop
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string fruct = Console.ReadLine();
            string day = Console.ReadLine();
            double quantity = double.Parse(Console.ReadLine());
            double sum = 0;
            switch (day)
            {
                case "Monday":
                case "Tuesday":
                case "Wednesday":
                case "Thursday":
                case "Friday":
                    if (fruct == "banana") { sum = quantity * 2.50; }
                    if (fruct == "apple") { sum = quantity * 1.20; }
                    if (fruct == "orange") { sum = quantity * 0.85; }
                    if (fruct == "grapefruit") { sum = quantity * 1.45; }
                    if (fruct == "kiwi") { sum = quantity * 2.70; }
                    if (fruct == "pineapple") { sum = quantity * 5.50; }
                    if (fruct == "grapes") { sum = quantity * 3.85; }
                    
                    break;

                case "Saturday":
                case "Sunday":
                    if (fruct == "banana") { sum = quantity * 2.70; }
                    if (fruct == "apple") { sum = quantity * 1.25; }
                    if (fruct == "orange") { sum = quantity * 0.90; }
                    if (fruct == "grapefruit") { sum = quantity * 1.60; }
                    if (fruct == "kiwi") { sum = quantity * 3.00; }
                    if (fruct == "pineapple") { sum = quantity * 5.60; }
                    if (fruct == "grapes") { sum = quantity * 4.20; }
                    
                    break;

                default:
                    

                    break;
            }
            if (sum > 0) { Console.WriteLine($"{sum:f2}"); }
            else { Console.WriteLine("error"); }
        }
    }
}
