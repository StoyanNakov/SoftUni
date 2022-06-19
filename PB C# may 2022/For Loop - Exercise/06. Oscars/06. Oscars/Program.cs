using System;

namespace _06._Oscars
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string actorName = Console.ReadLine();
            double startScore = double.Parse(Console.ReadLine());
            int number = int.Parse(Console.ReadLine());
            double SumInputScore = startScore;
            int i = 0;
            while  (SumInputScore <= 1250.5)
            {
                if (i == number) { break; }
                double  nameOfActorsScore = Console.ReadLine().Length;
                double scoreFromActors = double.Parse(Console.ReadLine());
                SumInputScore = SumInputScore + (nameOfActorsScore * scoreFromActors) / 2;
                //Console.WriteLine(SumInputScore);
                //Console.WriteLine((nameOfActorsScore * scoreFromActors) / 2);
                i++;
            }
            
            if (SumInputScore <= 1250.5)
            {
                Console.WriteLine($"Sorry, {actorName} you need {1250.5 - SumInputScore:f1} more!");
            }
            else 
            {
                Console.WriteLine($"Congratulations, {actorName} got a nominee for leading role with {SumInputScore:f1}!");
            }
        }
    }
}
