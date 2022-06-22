using System;

namespace _03._Painting_Eggs
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string size = Console.ReadLine();
            string color = Console.ReadLine();
            int batches = int.Parse(Console.ReadLine());

            double price = 0;

           
            if (color == "Red")
            {
                
                if (size == "Large")
                {
                    price = 16.00;
                }
                else if (size == "Medium")
                {
                    price = 13.00;
                }
                else 
                {
                    price = 9.00;
                }
            }
            else if (color == "Green")
            {
                
                if (size == "Large")
                {
                    price = 12.00;
                }
                else if (size == "Medium")
                {
                    price = 9.00;
                }
                else 
                {
                    price = 8.00;
                }
            }
            else 
            {
                
                if (size == "Large")
                {
                    price = 9.00;
                }
                else if (size == "Medium")
                {
                    price = 7.00;
                }
                else 
                {
                    price = 5.00;
                }
            }

          
            double profit = batches * price;
            
            double expenses = profit * 35 / 100;
            
            profit -= expenses;

           
            Console.WriteLine($"{profit:F2} leva.");
        }
    }
}
