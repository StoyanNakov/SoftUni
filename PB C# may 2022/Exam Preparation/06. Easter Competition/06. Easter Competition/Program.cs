using System;

namespace _06._Easter_Competition
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int numOfBread = int.Parse(Console.ReadLine());

            double maxPoints = 0; 
            string bestBaker = ""; 

            
            for (int i = 1; i <= numOfBread; i++)
            {
                string bakerName = Console.ReadLine(); 
                double totalPoints = 0;

                string input = Console.ReadLine();
                
                while (input != "Stop")
                {
                    double points = int.Parse(input);
                    totalPoints += points; 
                    input = Console.ReadLine(); 
                }

                Console.WriteLine($"{bakerName} has {totalPoints} points.");

                if (totalPoints > maxPoints)
                {
                    
                    maxPoints = totalPoints;
                    bestBaker = bakerName; 
                    Console.WriteLine($"{bakerName} is the new number 1!"); 
                }
            }

            Console.WriteLine($"{bestBaker} won competition with {maxPoints} points!");

        }
    }
}
