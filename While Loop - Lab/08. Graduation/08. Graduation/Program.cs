using System;

namespace _08._Graduation
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string studentName = Console.ReadLine();

            double totalScore = 0;
            int badScore = 0;
            int count = 1;

            while (count <= 12)
            {
                double score = double.Parse(Console.ReadLine());

                if (score >= 4)
                {
                    count++;
                    totalScore += score;
                }
                else
                {                    
                    badScore++;

                    if (badScore == 2)
                    {
                        Console.WriteLine($"{studentName} has been excluded at {count} grade");
                        return;
                    }
                }
            }

            double averageScore = totalScore / 12;
            Console.WriteLine($"{studentName} graduated. Average grade: {averageScore:f2}");
        }
    }
}
