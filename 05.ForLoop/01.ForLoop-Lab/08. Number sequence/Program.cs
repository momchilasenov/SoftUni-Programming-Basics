using System;

namespace _08._Number_sequence
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());

            int minNumber = int.MaxValue; //казваш че мин числото ще ти е = +2млрд....(много голямо число)
            int maxNumber = int.MinValue; // макс числото ще ти е = -2млрд (много малко число)
            // задаваш такива стойности за да си сигурен, че ще влезе в проверката 
            for (int i = 0; i < n; i++)
            {
                int inputNumber = int.Parse(Console.ReadLine());

                if (maxNumber < inputNumber) // ако влезе в този if ще получиш макс
                {
                    maxNumber = inputNumber;
                }

                if (minNumber > inputNumber) //имаш ли по-малко число пропуска да влезе в макс-а
                {
                    minNumber = inputNumber;
                }
            }
            Console.WriteLine($"Max number: {maxNumber}");
            Console.WriteLine($"Min number: {minNumber}");
        }

        
    }
}
