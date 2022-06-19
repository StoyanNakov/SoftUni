using System;

namespace _01._Old_Books
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string searchedBookName = Console.ReadLine();
            string findedBookName = "";
            int count = 0;
            while (findedBookName != "No More Books")
            {
                
                
                findedBookName = Console.ReadLine();
                if (findedBookName == searchedBookName) 
                {
                    Console.WriteLine($"You checked {count} books and found it.");
                    return;
                    
                }
                count++;
            }
            Console.WriteLine("The book you search is not here!");
            Console.WriteLine($"You checked {count-1} books.");

        }
    }
}
