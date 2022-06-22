using System;

namespace _05._Care_of_Puppy
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int boughtFood = int.Parse(Console.ReadLine()) * 1000;
            int eatenFood = 0;

            string input = Console.ReadLine();

            while (input != "Adopted")
            {
                eatenFood += int.Parse(input);
              
                input = Console.ReadLine();
            }

            if (boughtFood >= eatenFood)
            {
                Console.WriteLine($"Food is enough! Leftovers: {boughtFood - eatenFood} grams.");
            }
           
            else
            {
                Console.WriteLine($"Food is not enough. You need {eatenFood - boughtFood} grams more.");
            }
        }
    }
}
