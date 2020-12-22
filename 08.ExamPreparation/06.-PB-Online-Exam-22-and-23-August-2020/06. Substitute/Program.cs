using System;

namespace _06._Substitute
{
    class Program
    {
        static void Main(string[] args)
        {
            int firstNumberPlayer1 = int.Parse(Console.ReadLine());
            int secondNumberPlayer1 = int.Parse(Console.ReadLine());
            int firstNumberPlayer2 = int.Parse(Console.ReadLine());
            int secondNumberPlayer2 = int.Parse(Console.ReadLine());

            int substitutionCounter = 0;

            for (int k = firstNumberPlayer1; k <= 8; k++)
            {
                for (int l = 9; l >= secondNumberPlayer1; l--)
                {
                    for (int m = firstNumberPlayer2; m <= 8; m++)
                    {
                        for (int n = 9; n >= secondNumberPlayer2; n--)
                        {
                            if (k % 2 == 0 && m % 2 == 0)
                            {
                                if (l % 2 != 0 && n % 2 != 0)
                                {
                                    if (k == m && l == n)
                                    {
                                        Console.WriteLine("Cannot change the same player.");
                                    }
                                    else
                                    {
                                        Console.WriteLine($"{k}{l} - {m}{n}");

                                        substitutionCounter++;
                                        if (substitutionCounter == 6)
                                        {
                                            return;
                                        }
                                    }
                                }
                            }
                        }
                    }
                }
            }
        }
    }
}
