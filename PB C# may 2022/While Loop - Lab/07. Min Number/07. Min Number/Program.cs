using System;

namespace _07._Min_Number
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string num = Console.ReadLine();

            int min = int.MaxValue;

            while (num != "Stop")
            {
                int number = int.Parse(num);

                if (number < min)
                {
                    min = number;
                }

                num = Console.ReadLine();
            }

            Console.WriteLine(min);
        }
    }
}
