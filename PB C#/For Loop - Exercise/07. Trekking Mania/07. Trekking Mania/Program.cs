using System;

namespace _07._Trekking_Mania
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int numbersOfGroups = int.Parse(Console.ReadLine());
            double sum = 0;
            double musala = 0;
            double monblat = 0;
            double kilimandjaro = 0;
            double k2 = 0;
            double everest = 0;
            for (int i = 1; i <= numbersOfGroups; i++)
            {
                int peoples = int.Parse(Console.ReadLine());
                sum = sum + peoples;
                if (peoples <= 5) { musala+=peoples; }
                if (peoples > 5 && peoples <= 12) { monblat+=peoples;}
                if (peoples >= 13 && peoples <= 25) { kilimandjaro+=peoples; }
                if (peoples >= 26 && peoples <= 40) { k2+=peoples; }
                if (peoples >= 41) { everest+=peoples; }

            }
           
            Console.WriteLine($"{(musala / sum) * 100:f2}%");
            Console.WriteLine($"{(monblat / sum) * 100:f2}%");
            Console.WriteLine($"{(kilimandjaro / sum) * 100:f2}%");
            Console.WriteLine($"{(k2 / sum) * 100:f2}%");
            Console.WriteLine($"{(everest / sum) * 100:f2}%");
        }
    }
}
