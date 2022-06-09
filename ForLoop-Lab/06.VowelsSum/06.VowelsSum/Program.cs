using System;

namespace _06.VowelsSum
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string words = Console.ReadLine();
            int sum = 0;
            for (int i = 0; i < words.Length; i++)
            {
                if (words[i] == 'a')
                {
                    sum = sum + 1;
                }
                if (words[i] == 'e')
                {
                    sum = sum + 2;
                }
                if (words[i] == 'i')
                {
                    sum = sum + 3;
                }
                if (words[i] == 'o')
                {
                    sum = sum + 4;
                }
                if (words[i] == 'u')
                {
                    sum = sum + 5;
                }
            }
            Console.WriteLine(sum);
        }
    }
}
