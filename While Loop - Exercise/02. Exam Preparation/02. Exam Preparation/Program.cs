using System;

namespace _02._Exam_Preparation
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int badGrades = int.Parse(Console.ReadLine());

            int countBadGrades = 0;
            string problem;
            double sumScore = 0;
            
            int countProblems = 0;
            string lastProblem = "";
            

            while ((problem = Console.ReadLine()) != "Enough")
            {
                lastProblem = problem;
                countProblems++;

                int grade = int.Parse(Console.ReadLine());

                if (grade <= 4)
                {
                    countBadGrades++;

                    if (countBadGrades == badGrades)
                    {
                        Console.WriteLine($"You need a break, {badGrades} poor grades.");
                        return;
                    }
                }

                sumScore += grade;
            }

            double avgScore = sumScore / countProblems;

            Console.WriteLine($"Average score: {avgScore:f2}");
            Console.WriteLine($"Number of problems: {countProblems}");
            Console.WriteLine($"Last problem: {lastProblem}");
        }
    }
}
