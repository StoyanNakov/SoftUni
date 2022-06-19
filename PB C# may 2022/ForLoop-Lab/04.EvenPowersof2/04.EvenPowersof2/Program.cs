using System;

namespace _04.EvenPowersof2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            double number = int.Parse(Console.ReadLine());
            double number1 = 2; 
           

            for (int i = 1; i <= number; i++)
            {
                if (i % 2 == 0)
                {
                    Console.WriteLine(number1);
                    number1 = Math.Pow(number1, i);
                    
                }
            }
            
        }
    }
}
