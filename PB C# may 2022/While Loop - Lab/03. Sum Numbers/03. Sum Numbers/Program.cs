using System;

namespace _03._Sum_Numbers
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int maxSum = int.Parse(Console.ReadLine());
            int sum = 0;
            while (maxSum > sum) 
            {
                int input = int.Parse(Console.ReadLine());
                sum += input;
            }
            Console.WriteLine(sum);
        }
    }
}
