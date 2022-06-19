using System;

namespace _08._Tennis_Ranklist
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int numbersOfTournirs = int.Parse(Console.ReadLine());
            int scorePints = int.Parse(Console.ReadLine());
            int sum = 0;
            double wins = 0;
            for (int i = 0; i < numbersOfTournirs; i++)
            {
                string etap = Console.ReadLine();
                if (etap == "W") { sum += 2000; wins++; }
                if (etap == "F") { sum += 1200; }
                if (etap == "SF") { sum += 720; }
            }

            Console.WriteLine($"Final points: {sum + scorePints}");
            Console.WriteLine($"Average points: {sum / numbersOfTournirs}");
            Console.WriteLine($"{(wins / numbersOfTournirs) * 100:f2}%");

        }
    }
}
