using System;

namespace _05.Journey
{
    internal class Program
    {
        static void Main(string[] args)
        {
            double budjet = double.Parse(Console.ReadLine());
            string season = Console.ReadLine();
            season = season.ToLower();
            string destination = "";
            string destinationIn = "";
            double sum = 0; 
            
            if (budjet <= 100 )
            {
                destination = "Bulgaria";
                if (season == "summer")
                {
                    sum =  (budjet * 0.3); destinationIn = "Camp";
                }
                else { sum = (budjet * 0.7); destinationIn = "Hotel"; }
            }

            if (budjet >100 && budjet <= 1000 )
            {
                destination = "Balkans";
                if (season == "summer")
                {
                    sum = (budjet * 0.4); destinationIn = "Camp";
                }
                else { sum = (budjet * 0.8); destinationIn = "Hotel"; }
            }
            if (budjet > 1000)
            {
                destination = "Europe";
                                
                    sum = (budjet * 0.9); destinationIn = "Hotel";
                
            }
            if (budjet > 0 )
            {
                Console.WriteLine($"Somewhere in {destination}");
                Console.WriteLine($"{destinationIn} - {sum:f2}");
            }
        }
        
            
    }
}
