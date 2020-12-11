using System;

namespace _07._Safe_Passwords_Generator
{
    class Program
    {
        static void Main(string[] args)
        {
            int a = int.Parse(Console.ReadLine());
            int b = int.Parse(Console.ReadLine());
            int maxPasswords = int.Parse(Console.ReadLine());

            int counter = 0;

            int A = 35;
            int B = 64;

            while (A <= 55)
            {
                while (B <= 96)
                {
                    for (int x = 1; x <= a; x++)
                    {
                        for (int y = 1; y <= b; y++)
                        {
                            char letterA = (char)A;
                            char letterB = (char)B;

                            Console.Write($"{letterA}{letterB}{x}{y}{letterB}{letterA}|");
                            counter++;
                            A++;
                            B++;

                            if (A > 55)
                            {
                                A = 35;
                            }
                            if (B > 96)
                            {
                                B = 64;
                            }
                            if (x == a && y == b)
                            {
                                return;
                            }
                            if (counter >= maxPasswords)
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
