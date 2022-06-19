using System;

namespace _03._Vacation
{
    internal class Program
    {
        static void Main(string[] args)
        {
            double neededMoney = double.Parse(Console.ReadLine()); 
            double owndedMoney = double.Parse(Console.ReadLine());
            int daysCounter = 0;
            int spendingCounter = 0;
            while (owndedMoney < neededMoney && spendingCounter < 5)
            {
                string command = Console.ReadLine();
                double money = double.Parse(Console.ReadLine());
                daysCounter ++;

                if (command == "spend")
                {
                    spendingCounter++;
                    owndedMoney = owndedMoney - money;
                    if (owndedMoney < 0)
                    {
                        owndedMoney = 0;
                    }
                }
                else
                {
                    spendingCounter = 0;
                    owndedMoney+=money;
                }
            }
            if (spendingCounter == 5)
            {
                Console.WriteLine($"You can't save the money.");
                Console.WriteLine(daysCounter);
            }
            if (owndedMoney >= neededMoney)
            {
                Console.WriteLine($"You saved the money for {daysCounter} days.");
            }
        }
    }
}
