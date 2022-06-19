using System;

namespace _03.NewHouse
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string flowers = Console.ReadLine();
            double quantity = int.Parse(Console.ReadLine());
            double budjet = double.Parse(Console.ReadLine());
            double sum = 0;

            if (flowers == "Roses")
            {
                sum = quantity * 5.00;
                if (quantity > 80) { sum = sum - (sum * 0.10); }
            }
            if (flowers == "Dahlias")
            {
                sum = quantity * 3.8;
                if (quantity > 90) { sum = sum - (sum * 0.15); }
            }
            if (flowers == "Tulips")
            {
                sum = quantity * 2.80;
                if (quantity > 80) { sum = sum - (sum * 0.15); }
            }
            if (flowers == "Narcissus")
            {
                sum = quantity * 3.00;
                if (quantity < 120) { sum = sum + (sum * 0.15); }
            }
            if (flowers == "Gladiolus")
            {
                sum = quantity * 2.50;
                if (quantity < 80) { sum = sum + (sum * 0.20); }
            }
            if (sum <= budjet)
            {
                Console.WriteLine($"Hey, you have a great garden with {quantity} {flowers} and {budjet - sum:f2} leva left.");
            }
            else { Console.WriteLine($"Not enough money, you need {sum - budjet:f2} leva more."); }


        }
    }
}
