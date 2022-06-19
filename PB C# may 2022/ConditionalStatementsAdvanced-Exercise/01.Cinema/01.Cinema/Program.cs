using System;

namespace _01.Cinema
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string type = Console.ReadLine();
            int row = int.Parse(Console.ReadLine());
            int column = int.Parse(Console.ReadLine());
            double income = 0.0;

            if (type == "Premiere")
            {
                income = row * column * 12.00;
            }
            else if (type == "Normal")
            {
                income = row * column * 7.50;
            }
            else if (type == "Discount")
            {
                income = row * column * 5.00;
            }
            


                Console.WriteLine($"{income:f2} leva");
        }
    }
}
