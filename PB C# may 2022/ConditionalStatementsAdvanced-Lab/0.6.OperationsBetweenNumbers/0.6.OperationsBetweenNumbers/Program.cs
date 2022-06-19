using System;

namespace _0._6.OperationsBetweenNumbers
{
    internal class Program
    {
        static void Main(string[] args)
        {
            double n1 = double.Parse(Console.ReadLine());
            double n2 = double.Parse(Console.ReadLine());
            string operation = Console.ReadLine();
            int afterOperation  = 0;
            if (operation == "+")
            {
                if ((n1 + n2) % 2 == 0) { Console.WriteLine($"{n1} + {n2} = {n1 + n2} - even"); }
                else { Console.WriteLine($"{n1 + n2} - odd"); }
            }
            if (operation == "-")
            {
                if ((n1 - n2) % 2 == 0) { Console.WriteLine($"{n1} - {n2} = {n1 - n2} - even"); }
                else { Console.WriteLine($"{n1} - {n2} = {n1 - n2} - odd"); }
            }
            if (operation == "*")
            {
                if ((n1 * n2) % 2 == 0) { Console.WriteLine($"{n1} * {n2} = {n1 * n2} - even"); }
                else { Console.WriteLine($"{n1} * {n2} = {n1 * n2} - odd"); }
            }
            if (operation == "/")
            {
                if (n2 != 0)
                {
                    Console.WriteLine($"{n1} / {n2} = {(n1 / n2):f2}");
                }
                else { Console.WriteLine($"Cannot divide {n1} by zero"); }
            }
            if (operation == "%")
            {
                if (n2 != 0)
                {
                    Console.WriteLine($"{n1} % {n2} = {(n1 % n2)}");
                }
                else { Console.WriteLine($"Cannot divide {n1} by zero"); }
            }

            
        }
    }
}
