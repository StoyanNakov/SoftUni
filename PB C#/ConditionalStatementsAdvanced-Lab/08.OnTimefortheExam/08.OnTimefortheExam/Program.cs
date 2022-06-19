using System;

namespace _08.OnTimefortheExam
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int hourExam = int.Parse(Console.ReadLine());
            int minExam = int.Parse(Console.ReadLine());
            int hourArrival = int.Parse(Console.ReadLine());
            int minArrival = int.Parse(Console.ReadLine());
            int examTotalInMinutes = (hourExam * 60) + minExam;
            int arrivalTotalInMinutes = (hourArrival * 60) + minArrival;
            int diferens = arrivalTotalInMinutes - examTotalInMinutes ;
            
            if (diferens < -30)
            {
                Console.Write("Early");
                if (diferens >= 60)
                { Console.WriteLine($"{diferens} hours before the start"); }
                else { Console.WriteLine($"{diferens} hours before the start"); }
                                    
            }
            if (diferens >= -30 && diferens <= 0)
            {
                Console.WriteLine("On Time");
            }
            if (diferens > 0)
            {
                Console.WriteLine("Late");

            }
        }
    }
}
