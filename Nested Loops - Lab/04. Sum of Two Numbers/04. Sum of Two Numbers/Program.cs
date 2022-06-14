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
            for (int i = start; i <= end; i++) 
            {
                if (start + i == magicNumber)
                {
                    combination++;
                    Console.WriteLine(i);
                }
            }

            
        }
    }
}
