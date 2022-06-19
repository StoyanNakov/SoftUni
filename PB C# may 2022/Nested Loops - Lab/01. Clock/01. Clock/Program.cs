using System;

namespace _01._Clock
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int min = 0;
            for (int hour= 0; hour <= 23; min++) 
            {
               Console.WriteLine($"{hour}:{min}");
                
                if (min == 59) { hour++;min = -1; }
            }
        }
    }
}
