using System;

namespace _08._Secret_Door_s_Lock
{
    class Program
    {
        static void Main(string[] args)
        {
            int hundredsCeiling = int.Parse(Console.ReadLine());
            int tensCeiling = int.Parse(Console.ReadLine());
            int onesCeiling = int.Parse(Console.ReadLine());

            for (int hundreds = 1; hundreds <= hundredsCeiling; hundreds++)
            {
                for (int tens = 1; tens <= tensCeiling; tens++)
                {
                    int counter = 0;
                    for (int i = 1; i <= tens; i++)
                    {
                        if (tens % i == 0)
                        {
                            counter++;
                        }
                    }
                    for (int ones = 1; ones <= onesCeiling; ones++)
                    {
                        if (hundreds % 2 == 0)
                        {
                            if (counter == 2)
                            {
                                if (ones % 2 == 0)
                                {
                                    Console.WriteLine($"{hundreds} {tens} {ones}");
                                }
                            }
                        }
                    }
                }
            }

        }
    }
}
