using System;

namespace _08.CinemaTicket
{
    internal class Program
    {
        static void Main(string[] args)
        {
                    //Monday
                    //Tuesday
                    //Wednesday
                    //Thursday
                    //Friday
                    //Saturday
                    //Sunday
        string ticket = Console.ReadLine();

            switch (ticket)
            {
                case "Monday":
                case "Tuesday":
                case "Friday":
                    Console.WriteLine("12");
                    break;

                case "Wednesday":
                case "Thursday":
                Console.WriteLine("14");
                    break;
                case "Saturday":
                case "Sunday":
                    Console.WriteLine("16");
                    break;

                default:
                    break;
            }
           
        }
    }
}
