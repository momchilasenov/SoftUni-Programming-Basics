using System;

namespace _02._Letters_Combinations
{
    class Program
    {
        static void Main(string[] args)
        {
            char startLetter = char.Parse(Console.ReadLine());
            char endLetter = char.Parse(Console.ReadLine());
            char tabooLetter = char.Parse(Console.ReadLine());
            int count = 0;

            for (char i = startLetter; i <= endLetter; i++)
            {
                for (char j = startLetter; j <= endLetter; j++)
                {
                    for (char k = startLetter; k <= endLetter; k++)
                    {
                        if (i == tabooLetter || j == tabooLetter || k == tabooLetter)
                        {
                            continue;
                        }
                        else
                        {
                            Console.Write($"{i}{j}{k} ");
                            count++;

                        }
                    }
                }
            }
            Console.Write($"{count}");
        }
    }
}



