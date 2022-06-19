using System;

namespace _07.SumNumbers
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int count = int.Parse(Console.ReadLine());
            int sum = 0;
            for (int i = 0; i < count; i++)
            {
                int number  = int.Parse(Console.ReadLine());
                sum = sum + number;
            }
                Console.WriteLine(sum);
        }
    }
}
