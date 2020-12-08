using System;

namespace _01._Read_Text
{
    class Program
    {
        static void Main(string[] args)
        {
            string input = Console.ReadLine();
            while (input != "Stop")
            {
                Console.WriteLine(input);
                input = Console.ReadLine();
            }

            ////Друго решение на същия проблем
            string input = Console.ReadLine();

            while (true)
            {
                if (input == "Stop")
                {
                    break;
                }
                Console.WriteLine(input);
                input = Console.ReadLine();
            }
        }
    }
}
