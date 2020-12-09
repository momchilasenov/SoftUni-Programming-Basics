using System;

namespace _03._Combinations
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            int countCombinations = 0;

            for (int i = 0; i<=n; i++)
            {
                for (int j = 0; j<=n; j++)
                {
                    for (int k = 0; k<=n; k++)
                    {
                        int value = i + j + k;
                        if (value == n)
                        {
                            countCombinations++;
                        }
                    }
                }
            }
            Console.WriteLine(countCombinations);

        }
    }
}
