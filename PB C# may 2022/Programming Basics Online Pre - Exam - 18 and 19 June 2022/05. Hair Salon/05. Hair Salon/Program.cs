using System;

namespace _05._Hair_Salon
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int targetMoney = int.Parse(Console.ReadLine());
            int sum = 0;
            string service = "";
            string details = "";
            while ((service = Console.ReadLine()) != "closed")
            {
                details = Console.ReadLine();
                if (service == "haircut")
                {
                    if (details == "mens") { sum = sum + 15; }
                    if (details == "ladies") { sum = sum + 20; }
                    if (details == "kids") { sum = sum + 10; }
                }
                if (service == "color")
                {
                    if (details == "touch up") { sum = sum + 20; }
                    if (details == "full color") { sum = sum + 30; }
                    
                }
            
                if (sum >= targetMoney) { break; }
            }
            if (sum >= targetMoney)
            {
                Console.WriteLine($"You have reached your target for the day!");
            }
            else 
            {
                Console.WriteLine($"Target not reached! You need {targetMoney - sum}lv. more.");
            }
                Console.WriteLine($"Earned money: {sum}lv.");

        }
    }
}
