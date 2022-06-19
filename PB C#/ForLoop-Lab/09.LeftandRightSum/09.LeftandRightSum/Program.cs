using System;

namespace _09.LeftandRightSum
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int count = int.Parse(Console.ReadLine());
            int leftNumber = 0;
            int rightNumber  = 0;
            int lSum = 0;
            int rSum = 0;
            for (int i = 0; i < count; i++)
            {
                leftNumber = int.Parse(Console.ReadLine());
                lSum = lSum + leftNumber;
            }

            for (int i = 0; i < count; i++)
            {
                rightNumber = int.Parse(Console.ReadLine());
                rSum = rSum + rightNumber;
            }


            if (rSum == lSum)
            {
                Console.WriteLine($"Yes, sum = {lSum}");
            }
            else { Console.WriteLine($"No, diff = {Math.Abs(lSum - rSum)}"); }
        }
    }
}
