using System;

namespace _10.OddEvenSum
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int oddSum = 0;
            int evenSum = 0;
            int number = int.Parse(Console.ReadLine());
            for (int i = 1; i <= number ; i++)
            {
                int input  = int.Parse(Console.ReadLine());
                if (i % 2 == 0)
                {
                    evenSum = evenSum + input;
                }
                else
                {
                    oddSum = oddSum + input;
                }
            }

            if (oddSum == evenSum)
            {
                Console.WriteLine("Yes");
                Console.WriteLine($"Sum = {Math.Abs(evenSum)}");
            }
                else
            {
                Console.WriteLine("No");
                Console.WriteLine($"Diff = {Math.Abs(oddSum - evenSum)}");
            }
        }
    }
}
