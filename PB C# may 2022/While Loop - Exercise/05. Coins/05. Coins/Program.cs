using System;

namespace _05._Coins
{
    internal class Program
    {
        static void Main(string[] args)
        {
            double input = double.Parse(Console.ReadLine()) * 100;

            int inputMoney = (int)input;

            int coins = 0;

            while (inputMoney > 0)
            {
                if (inputMoney >= 200)
                {
                    inputMoney -= 200;
                }
                else if (inputMoney >= 100)
                {
                    inputMoney -= 100;
                }
                else if (inputMoney >= 50)
                {
                    inputMoney -= 50;
                }
                else if (inputMoney >= 20)
                {
                    inputMoney -= 20;
                }
                else if (inputMoney >= 10)
                {
                    inputMoney -= 10;
                }
                else if (inputMoney >= 5)
                {
                    inputMoney -= 5;
                }
                else if (inputMoney >= 2)
                {
                    inputMoney -= 2;
                }
                else
                {
                    inputMoney -= 1;
                }

                coins++;
            }

            Console.WriteLine(coins);
        }
    }
}
