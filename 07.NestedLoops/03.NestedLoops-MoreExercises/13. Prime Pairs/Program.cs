using System;

namespace _13._Prime_Pairs
{
    class Program
    {
        static void Main(string[] args)
        {
            int startFirstPair = int.Parse(Console.ReadLine());
            int startSecondPair = int.Parse(Console.ReadLine());
            int diffFirstPair = int.Parse(Console.ReadLine());
            int diffSecondPair = int.Parse(Console.ReadLine());

            int endFirstPair = startFirstPair + diffFirstPair;
            int endSecondPair = startSecondPair + diffSecondPair;

            int count1 = 0;
            int count2 = 0;

            for (int i = startFirstPair; i <= endFirstPair; i++)
            {
                for (int d1 = 1; d1 <= i; d1++)
                {
                    if (i % d1 == 0)
                    {
                        count1++;
                        if (count1 > 2)
                        {
                            count1 = 0;
                            break;
                        }
                    }
                }

                for (int j = startSecondPair; j <= endSecondPair; j++)
                {
                    for (int d2 = 1; d2 <= j; d2++)
                    {
                        if (j % d2 == 0)
                        {
                            count2++;
                            if (count2 > 2)
                            {
                                count2 = 0;
                                break;
                            }
                        }
                    }

                    if (count1 == 2 && count2 == 2)
                    {
                        Console.WriteLine($"{i}{j}");
                    }
                    
                }
            }
        }
    }
}
