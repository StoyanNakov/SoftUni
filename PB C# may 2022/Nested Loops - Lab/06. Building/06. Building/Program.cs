using System;

namespace _06._Building
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int floor = int.Parse(Console.ReadLine());
            int rooms = int.Parse(Console.ReadLine());

            
                if (floor == 1)
                {

                    for (int j = 0; j < rooms; j++)
                    {
                        Console.Write($"L{floor}{j} ");
                    }
                    Console.WriteLine();
                    return;
                }
                else
                {
                    for (int j = 0; j < rooms; j++)
                    {
                        Console.Write($"L{floor}{j} ");
                    }
                    Console.WriteLine();
                    floor--;
                }

            for (int i = floor; floor >= 1; floor--)
            {
                if (floor % 2 == 0)
                {
                    for (int j = 0; j < rooms; j++)
                    {
                        Console.Write($"O{floor}{j} ");
                    }
                    Console.WriteLine();
                }
                else 
                {
                    for (int j = 0; j < rooms; j++)
                    {
                        Console.Write($"A{floor}{j} ");
                    }
                    Console.WriteLine();
                }


            }
           
        }
    }
}
