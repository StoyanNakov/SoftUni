using System;

namespace _07._Moving
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int w = int.Parse(Console.ReadLine());
            int l = int.Parse(Console.ReadLine());
            int h = int.Parse(Console.ReadLine());

            int volume = w * l * h;
            int boxes = 0;

            while (boxes < volume)
            {
                string input = Console.ReadLine();

                if (input != "Done")
                {
                    int curentBoxes = int.Parse(input);
                    boxes += curentBoxes;
                }
                else
                {
                    break;
                }
            }

            if (boxes < volume)
            {
                Console.WriteLine($"{volume - boxes} Cubic meters left.");
            }
            else
            {
                Console.WriteLine($"No more free space! You need {boxes - volume} Cubic meters more.");
            }
        }
    }
}
