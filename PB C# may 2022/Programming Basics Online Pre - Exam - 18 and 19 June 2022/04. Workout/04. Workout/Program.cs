using System;

namespace _04._Workout
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int days = int.Parse(Console.ReadLine());
            double kmFirstDay = double.Parse(Console.ReadLine());
            double sumKm = 0;
            double nextDayKm =kmFirstDay;
            for (int i = 1; i <= days; i++)
            {
                double percent = double.Parse(Console.ReadLine());
                nextDayKm = nextDayKm + ((nextDayKm * percent) / 100);
               // Console.WriteLine(nextDayKm);
                sumKm = sumKm + nextDayKm;
                
            }
            sumKm = sumKm + kmFirstDay;
            if (sumKm < 1000)
            {
                Console.WriteLine($"Sorry Mrs. Ivanova, you need to run {Math.Ceiling(1000 - sumKm)} more kilometers");
            }
            if (sumKm >= 1000) 
            {
                Console.WriteLine($"You've done a great job running {Math.Ceiling(sumKm - 1000)} more kilometers!");
            }
           
        }
    }
}
