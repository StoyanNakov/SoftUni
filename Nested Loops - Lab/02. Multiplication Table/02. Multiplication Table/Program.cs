using System;

namespace _02._Multiplication_Table
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int first;
            int second;
            for (first = 1; first <=10; first++)
            {
                for (second = 1; second <= 10; second++)
                
                    Console.WriteLine($"{first} * {second} = {first*second}");
            }

           
        }
    }
}
