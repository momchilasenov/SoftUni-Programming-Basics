using System;

namespace _04._Car_Number
{
    class Program
    {
        static void Main(string[] args)
        {
            int startInterval = int.Parse(Console.ReadLine());
            int endInterval = int.Parse(Console.ReadLine());

            for (int i = startInterval; i <= endInterval; i++)
            {
                for (int j = startInterval; j <= endInterval; j++)
                {
                    for (int k = startInterval; k <= endInterval; k++)
                    {
                        for (int l = startInterval; l <= endInterval; l++)
                        {
                            if (i % 2 == 0 && l % 2 != 0 || i % 2 != 0 && l % 2 == 0)
                            {
                                if (i > l)
                                {
                                    if ((j + k) % 2 == 0)
                                    {
                                        Console.Write($"{i}{j}{k}{l} ");
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
