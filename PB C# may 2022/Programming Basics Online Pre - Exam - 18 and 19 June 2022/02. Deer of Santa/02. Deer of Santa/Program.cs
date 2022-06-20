using System;

namespace _02._Deer_of_Santa
{
    internal class Program
    {
        static void Main(string[] args)
        {
            double daysOut = double.Parse(Console.ReadLine());
            double food = double.Parse(Console.ReadLine());
            double foodForFirst = double.Parse(Console.ReadLine());
            double foodForSecond = double.Parse(Console.ReadLine());
            double foodForThird = double.Parse(Console.ReadLine());

            double needForAll = (daysOut * foodForFirst) + (daysOut * foodForSecond) + (daysOut * foodForThird);
            if (food >= needForAll)
            {
                Console.WriteLine($"{Math.Floor(food - needForAll)} kilos of food left.");
            }
            else 
            {
                Console.WriteLine($"{Math.Ceiling(needForAll - food)} more kilos of food are needed.");
            }
        }
    }
}
