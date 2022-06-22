using System;

namespace _02._Skeleton
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int min = int.Parse(Console.ReadLine());
            int sec = int.Parse(Console.ReadLine());
            double length = double.Parse(Console.ReadLine()); 
            int speed = int.Parse(Console.ReadLine()); 

           
            int control = min * 60 + sec;

           
            double reducedТime = length / 120 * 2.5;
           
            double time = speed * (length / 100) - reducedТime;

            
            if (time <= control)
            {
                Console.WriteLine("Marin Bangiev won an Olympic quota!");
                Console.WriteLine($"His time is {time:f3}.");
            }
            else
            {
                Console.WriteLine($"No, Marin failed! He was {time - control:f3} second slower.");
            }


        }
    }
}
