using System;

namespace _06._Sum_And_Product
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            int a;
            int b;
            int c;
            int d;
            bool finde = false;
            for (a = 1; a <= 9; a++)
            { 
                if (finde == true) { break; }
                for (b = 9; b >= a; b--)
                {
                    if (finde == true) { break; }
                    for (c = 0; c <=9; c++)
                    {
                        for (d = 9; d >= c; d--)
                        {
                            if (finde == true) { break; }

                            if ((a * b * c * d) / (a+b+c+d) == 3 && n % 3 == 0)
                            {
                                Console.WriteLine($"{d}{c}{b}{a}"); finde = true;
                            }
                            if ((a+b+c+d) == (a*b*c*d) && n % 10 == 5)
                            {
                                Console.WriteLine($"{a}{b}{c}{d}"); finde = true;
                            }
                        }
                    }
                }
                
            }
            if (finde == false) { Console.WriteLine("Nothing found"); }

        }
    }
}

