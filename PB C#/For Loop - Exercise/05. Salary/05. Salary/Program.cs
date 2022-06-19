using System;

namespace _05._Salary
{
    internal class Program
    {
        static void Main(string[] args)
        {
            
            int tabs = int.Parse(Console.ReadLine());
            int salary = int.Parse(Console.ReadLine());
            int sum = 0;
            
            string siteName = "";
            while (salary > 0)
            {
                if (tabs == 0) { break; }
               siteName = Console.ReadLine();
                if (siteName == "Facebook") { salary = salary - 150; }
                if (siteName == "Instagram") { salary = salary - 100; }
                if (siteName == "Reddit") { salary = salary - 50; }
                
                tabs--;
                
            }
            if (salary == 0)
            {
                Console.WriteLine("You have lost your salary.");
            }
            else
            {
                Console.WriteLine(salary);
            }
        }
    }
}
