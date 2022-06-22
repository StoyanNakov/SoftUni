using System;

namespace _04._Balls
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());

            int points = 0; 

            int red = 0; 
            int orange = 0; 
            int yellow = 0;
            int white = 0; 
            int black = 0; 
            int other = 0; 

            for (int i = 1; i <= n; i++)
            {
                string balls = Console.ReadLine();

                switch (balls)
                {
                    case "red":
                        red++;
                        points += 5;
                        break;
                    case "orange":
                        orange++;
                        points += 10;
                        break;
                    case "yellow":
                        yellow++;
                        points += 15;
                        break;
                    case "white":
                        white++;
                        points += 20;
                        break;
                    case "black":
                        black++;
                        points /= 2;
                        break;
                    default:
                        other++;
                        break;
                }
            }

            Console.WriteLine($"Total points: {points}");
            Console.WriteLine($"Red balls: {red}");
            Console.WriteLine($"Orange balls: {orange}");
            Console.WriteLine($"Yellow balls: {yellow}");
            Console.WriteLine($"White balls: {white}");
            Console.WriteLine($"Other colors picked: {other}");
            Console.WriteLine($"Divides from black balls: {black}");
        }
    }
}
