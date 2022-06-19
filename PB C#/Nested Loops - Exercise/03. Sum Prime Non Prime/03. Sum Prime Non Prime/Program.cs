using System;

namespace _03._Sum_Prime_Non_Prime
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int sumPrime = 0;
            int sumNonPrime = 0;
            string input;

            while ((input = Console.ReadLine()) != "stop")
            {
                int currentNum = int.Parse(input);

                if (currentNum < 0)
                {
                    Console.WriteLine("Number is negative.");
                    continue;
                }
                else if (currentNum == 0)
                {
                    sumNonPrime += currentNum;
                    continue;
                }

                bool isPrime = true;

                for (int i = 2; i < currentNum; i++)
                {
                    if (currentNum % i == 0)
                    {
                        isPrime = false;
                        break;
                    }
                }

                if (isPrime)
                {
                    sumPrime += currentNum;
                }
                else
                {
                    sumNonPrime += currentNum;
                }
            }
            Console.WriteLine($"Sum of all prime numbers is: {sumPrime}");
            Console.WriteLine($"Sum of all non prime numbers is: {sumNonPrime}");
        }
    }
}
