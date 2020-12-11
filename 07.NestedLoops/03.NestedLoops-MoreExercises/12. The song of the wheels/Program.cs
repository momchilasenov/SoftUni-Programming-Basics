using System;

namespace _12._The_song_of_the_wheels
{
    class Program
    {
        static void Main(string[] args)
        {
            int controlNumber = int.Parse(Console.ReadLine());
            int counter = 0;
            bool flag = false;
            int passA = 0;
            int passB = 0;
            int passC = 0;
            int passD = 0;
            int newLine = 0;


            for (int a = 1; a <= 9; a++)
            {
                for (int b = 1; b <= 9; b++)
                {
                    for (int c = 1; c <= 9; c++)
                    {
                        for (int d = 1; d <= 9; d++)
                        {
                            if (a * b + c * d == controlNumber)
                            {
                                if (a < b && c > d)
                                {
                                    counter++;
                                    Console.Write($"{a}{b}{c}{d} ");
                                    newLine = 1;
                                    if (counter == 4)
                                    {
                                        passA = a;
                                        passB = b;
                                        passC = c;
                                        passD = d;
                                        flag = true;
                                    }
                                }
                            }
                        }
                    }
                }
            }
            if (flag)
            {
                Console.WriteLine($"{Environment.NewLine}Password: {passA}{passB}{passC}{passD}");
            }
            else if (!flag)
            {
                if (newLine == 1)
                {
                    Console.WriteLine();
                }
                Console.WriteLine("No!");
            }

        }
    }
}
