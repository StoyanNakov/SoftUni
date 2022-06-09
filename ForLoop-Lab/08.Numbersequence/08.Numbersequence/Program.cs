using System;

namespace _08.Numbersequence
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int count = int.Parse(Console.ReadLine());
            int minNum = int.MaxValue;
            int maxNum = int.MinValue;
            for (int i = 0; i < count; i++)
            {
                int number = int.Parse(Console.ReadLine());
                
                if (maxNum < number) 
                { 
                    maxNum = number; 
                }
                if (minNum > number) 
                {
                    minNum = number; 
                }

            }
            
            Console.WriteLine($"Max number: {maxNum}");
            Console.WriteLine($"Min number: {minNum}");
        }
    }
}
