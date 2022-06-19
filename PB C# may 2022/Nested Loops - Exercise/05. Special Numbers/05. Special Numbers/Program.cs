using System;

namespace _05._Special_Numbers
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int input = int.Parse(Console.ReadLine());

            for (int first = 1; first <= 9; first++)
            {
                for (int second = 1; second <= 9; second++)
                {
                    for (int third = 1; third <= 9; third++)
                    {
                        for (int fourth = 1; fourth <= 9; fourth++)
                        {
                            if (input % first == 0 && input % second == 0 && input % third == 0 && input % fourth == 0)
                            {
                                Console.Write($"{first}{second}{third}{fourth} ");
                            }
                        }
                    }
                }
            }

        }
    }
}
