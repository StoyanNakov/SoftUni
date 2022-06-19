using System;

namespace _04._Clever_Lily
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int LiliAge = int.Parse(Console.ReadLine());
            double washerPrice = double.Parse(Console.ReadLine());
            int toyPrice = int.Parse(Console.ReadLine());
            double money = 0;
            double toysNumber = 0;
            double sum = 0;
            for (int i = 1; i <= LiliAge; i++)
            {
                if (i % 2 == 0)
                {
                    money  = ((money + (i * 5)) - 1);
                }
                else 
                {
                    toysNumber++;
                }
            }
            sum = money + (toysNumber * toyPrice);
            if (sum >= washerPrice)
            {
                Console.WriteLine($"Yes! {sum- washerPrice:f2}");
            }
            else
            {
                Console.WriteLine($"No! {Math.Abs(sum- washerPrice):f2}");
            }
            
        }
    }
}
