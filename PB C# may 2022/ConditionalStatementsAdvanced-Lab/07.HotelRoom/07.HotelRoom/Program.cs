using System;

namespace _07.HotelRoom
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string month= Console.ReadLine();
            int days = int.Parse(Console.ReadLine());
            double studio = 0;
            double apartment = 0;
            if (month == "May" || month == "October")
            {
                studio = days * 50;
                apartment = days * 65;
                if (days > 7 && days <= 14)
                {
                    studio = studio - (studio * 0.05); 
                }

                if (days > 14)
                {
                    studio = studio - (studio * 0.30); apartment = apartment - (apartment * 0.10);
                }
            }

            if (month == "June" || month == "September")
            {
                studio = days * 75.20;
                apartment = days * 68.70;
                if (days > 14)
                {
                    studio = studio - (studio * 0.20); apartment = apartment - (apartment * 0.10);
                }
            }

            if (month == "July" || month == "August")
            {
                studio = days * 76;
                apartment = days * 77;
                if (days > 14)
                {
                    apartment = apartment - (apartment * 0.10);
                }
               
            }
            Console.WriteLine($"Apartment: {apartment:f2} lv.");
            Console.WriteLine($"Studio: {studio:f2} lv.");
        }
    }
}
