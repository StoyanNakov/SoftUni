using System;

namespace _12.TradeCommissions
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string town = Console.ReadLine();
            double sales = double.Parse(Console.ReadLine());
            double sum = 0;
            if (sales > 0 && sales <= 500) 
            {
                switch (town)
                {
                    case "Sofia":
                        sum = (sales * 0.05); 
                        break;
                    case "Varna":
                        sum = (sales * 0.045);
                        break;
                    case "Plovdiv":
                        sum = (sales * 0.055);
                        break;
                    default:
                        Console.WriteLine("error");
                        break;
                }
                
            }
            if (sales > 500 && sales <= 1000) 
            {
                switch (town)
                {
                    case "Sofia":
                        sum = (sales * 0.07);
                        break;
                    case "Varna":
                        sum = (sales * 0.075);
                        break;
                    case "Plovdiv":
                        sum = (sales * 0.08);
                        break;
                    default:
                        Console.WriteLine("error");
                        break;
                }
            }
            if (sales > 1000 && sales <= 10000) 
            {
                switch (town)
                {
                    case "Sofia":
                        sum = (sales * 0.08);
                        break;
                    case "Varna":
                        sum = (sales * 0.1);
                        break;
                    case "Plovdiv":
                        sum = (sales * 0.12);
                        break;
                    default:
                        Console.WriteLine("error");
                        break;
                }
            }
            if (sales > 10000 )
            {
                switch (town)
                {
                    case "Sofia":
                        sum = (sales * 0.12);
                        break;
                    case "Varna":
                        sum = (sales * 0.13);
                        break;
                    case "Plovdiv":
                        sum = (sales * 0.145);
                        break;
                    default:
                        Console.WriteLine("error");
                        break;
                }
            }
            if (sales < 0) { Console.WriteLine("error");}
            if (sum > 0) { Console.WriteLine($"{sum:f2}"); }

        }
    }
}
