using System;

namespace _03._Histogram
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int p1 = 0;
            int p2 = 0;
            int p3 = 0;
            int p4 = 0;
            int p5 = 0;
            double numbers = int.Parse(Console.ReadLine());   
            for (int i = 0; i < numbers; i++)
            {
                double num =double.Parse(Console.ReadLine());
                if (num >= 1 && num < 200) { p1++;}
                if (num >= 200 && num <=399) { p2++; }
                if (num >= 400 && num <= 599) { p3++; }
                if (num >= 600 && num <= 799) { p4++; }
                if (num >= 800) { p5++; }

            }
            Console.WriteLine($"{((p1 / numbers) * 100):f2}%");
            Console.WriteLine($"{((p2 / numbers) * 100):f2}%");
            Console.WriteLine($"{((p3 / numbers) * 100):f2}%");
            Console.WriteLine($"{((p4 / numbers) * 100):f2}%");
            Console.WriteLine($"{((p5 / numbers) * 100):f2}%");


        }
    }
}
