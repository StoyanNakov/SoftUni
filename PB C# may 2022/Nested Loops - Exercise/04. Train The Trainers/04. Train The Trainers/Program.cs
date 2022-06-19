using System;

namespace _04._Train_The_Trainers
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int peopple = int.Parse(Console.ReadLine());

            int countGrades = 0;
            double allGrades = 0;
            string presName;

            while ((presName = Console.ReadLine()) != "Finish")
            {
                double totalGrades = 0;

                for (int i = 1; i <= peopple; i++)
                {
                    double grades = double.Parse(Console.ReadLine());
                    totalGrades += grades;
                    allGrades += grades;
                    countGrades++;
                }

                Console.WriteLine($"{presName} - {totalGrades / peopple:f2}.");
            }

            Console.WriteLine($"Student's final assessment is {allGrades / countGrades:f2}.");
        }
    }
}
