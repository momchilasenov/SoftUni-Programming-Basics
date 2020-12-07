using System;

namespace _05._Game_Of_Intervals
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            double totalSum = 0;
            double numbersCount = 0;
            double invalidNumbers = 0;
            double from0To9 = 0;
            double from10To19 = 0;
            double from20To29 = 0;
            double from30To39 = 0;
            double from40To50 = 0;

            for (int i = 0; i < n; i++)
            {
                int number = int.Parse(Console.ReadLine());
                numbersCount++;

                if (number < 0 || number > 50)
                {
                    totalSum /= 2;
                    invalidNumbers++;
                }
                else if (number >= 0 && number <= 9)
                {
                    totalSum += number * 0.2;
                    from0To9++;
                }
                else if (number >= 10 && number <= 19)
                {
                    totalSum += number * 0.3;
                    from10To19++;
                }
                else if (number >= 20 && number <= 29)
                {
                    totalSum += number * 0.4;
                    from20To29++;
                }
                else if (number >= 30 && number <= 39)
                {
                    totalSum += 50;
                    from30To39++;
                }
                else if (number >= 40 && number <= 50)
                {
                    totalSum += 100;
                    from40To50++;
                }
            }
            Console.WriteLine($"{totalSum:f2}");
            Console.WriteLine($"From 0 to 9: {from0To9/numbersCount*100:f2}%");
            Console.WriteLine($"From 10 to 19: {from10To19/numbersCount*100:f2}%");
            Console.WriteLine($"From 20 to 29: {from20To29/numbersCount*100:f2}%");
            Console.WriteLine($"From 30 to 39: {from30To39/numbersCount*100:f2}%");
            Console.WriteLine($"From 40 to 50: {from40To50/numbersCount*100:f2}%");
            Console.WriteLine($"Invalid numbers: {invalidNumbers/numbersCount*100:f2}%");

        }
    }
}
