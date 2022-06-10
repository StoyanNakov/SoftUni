using System;

namespace _02._Half_Sum_Element
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int numbers = int.Parse(Console.ReadLine());
            int sum = 0;
            int max = int.MaxValue;
            for (int i = 0; i < numbers; i++)
            {
                int num = int.Parse(Console.ReadLine());
                sum += num;
                if (num > max)
                {
                    max = num;
                }

            }
            int sumWithoutMaxNumber = sum - max;
                if (max == sumWithoutMaxNumber)
                {
                    Console.WriteLine("Yes");
                    Console.WriteLine($"Sum = {max}");
                }
                else
                {
                    Console.WriteLine("No");
                    Console.WriteLine($"Diff = {Math.Abs(max - sumWithoutMaxNumber)}");
                }




           
        }
    }
}
