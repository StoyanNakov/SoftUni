using System;

namespace _03._Combinations
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int input = int.Parse(Console.ReadLine());
            int count = 0;
            for (int a = 0; a <= input; a++)
            {
                for (int b = 0; b <= input; b++)
                {
                    for (int c = 0; c <= input; c++)
                    {
                        if (a + b + c == input)
                        { count++; }
                    }
                }
            }
            Console.WriteLine(count);
        }
    }
}
