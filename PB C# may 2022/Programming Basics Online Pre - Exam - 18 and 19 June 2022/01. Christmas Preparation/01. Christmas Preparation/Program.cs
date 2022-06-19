using System;

namespace _01._Christmas_Preparation
{
    internal class Program
    {
        static void Main(string[] args)
        {
            double paper = double.Parse(Console.ReadLine());
            double plat = double.Parse(Console.ReadLine());
            double glue = double.Parse(Console.ReadLine());  
            double discount = double.Parse(Console.ReadLine());

            double sumPaper = paper * 5.80;
            double sumPlat = plat * 7.2;
            double sumGlue = glue * 1.2;
            double total = sumPaper + sumPlat + sumGlue;
            double discountValue = (total * discount) / 100; 
            Console.WriteLine($"{total - discountValue:f3}");
            
        }
    }
}
