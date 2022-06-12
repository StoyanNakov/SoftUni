using System;

namespace _06._Max_Number
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string num = Console.ReadLine();

            int max = int.MinValue;

            while (num != "Stop")
            {
                int number = int.Parse(num);

                if (max < number)
                {
                    max = number;
                }

                num = Console.ReadLine();
            }

            Console.WriteLine(max);
        }
    }
}
