using System;

namespace _01._Train
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int wagons = int.Parse(Console.ReadLine());
            int[] people = new int[wagons];
            int sum = 0;
            for (int j = 0; j < wagons; j++)
            {
                int consoleInWagone = int.Parse(Console.ReadLine());
                people[j] = consoleInWagone;
            }

            foreach (int i in people)
            {
                sum += i;
                Console.Write($"{i} ");
                
            }
            Console.WriteLine();
            Console.WriteLine(sum);
        }
    }
}
