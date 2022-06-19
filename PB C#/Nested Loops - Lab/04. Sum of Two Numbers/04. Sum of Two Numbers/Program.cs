using System;

namespace _04._Sum_of_Two_Numbers
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int combination = 0;
            int start = int.Parse(Console.ReadLine());
            int end = int.Parse(Console.ReadLine());
            int magicNumber = int.Parse(Console.ReadLine());
            int a = 0;
            int b = 0;
            for (int i = start; i <= end; i++) 
            {

                for (int j = start; j <= end; j++)
                {
                    combination++;
                    if (i + j == magicNumber)
                    {

                        Console.WriteLine($"Combination N:{combination} ({i} + {j} = {magicNumber})");
                        return;
                    }
                }
            }

            Console.WriteLine($"{combination} combinations - neither equals {magicNumber}");
        }
    }
}
