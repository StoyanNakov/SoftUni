using System;

namespace _03._Santas_Holiday
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int days = int.Parse(Console.ReadLine());
            days = days - 1;
            string room = Console.ReadLine();
            string raiting = Console.ReadLine();
            double price = 0;
            if (room == "room for one person")
            {
                price = 18.00;
            }
            if (room == "apartment")
            {
                price = 25.00;
            }
            if (room == "president apartment")
            {
                price = 35.00;
            }
            double sumForNigth = days * price;
            if (room == "apartment")
            {

                if (days < 10) { sumForNigth = sumForNigth - ((sumForNigth * 30) / 100); }
                if (days >= 10 && days <= 15) { sumForNigth = sumForNigth - ((sumForNigth * 35) / 100); }
                if (days > 15) { sumForNigth = sumForNigth - ((sumForNigth * 50) / 100); }
            }
            
            if (room == "president apartment")
            {

                if (days < 10) { sumForNigth = sumForNigth - ((sumForNigth * 10) / 100); }
                if (days >= 10 && days <= 15) { sumForNigth = sumForNigth - ((sumForNigth * 15) / 100); }
                if (days > 15) { sumForNigth = sumForNigth - ((sumForNigth * 20) / 100); }
            }
            if (raiting == "positive")
            {
                sumForNigth = sumForNigth + (sumForNigth * 0.25);
            }
            else { sumForNigth = sumForNigth - (sumForNigth * 0.10); }
            Console.WriteLine($"{sumForNigth:f2}");

        }
    }
}
