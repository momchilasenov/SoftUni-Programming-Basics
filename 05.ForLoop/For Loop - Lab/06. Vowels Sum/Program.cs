using System;

namespace _06._Vowels_Sum
{
    class Program
    {
        static void Main(string[] args)
        {

            // ПЪРВО РЕШЕНИЕ
            //string text = Console.ReadLine();
            //int valueA = 0;
            //int valueE = 0;
            //int valueI = 0;
            //int valueO = 0;
            //int valueU = 0;

            //for (int i = 0; i < text.Length; i++)
            //{
            //    if (text[i] == 'a')
            //    {
            //        valueA += 1;
            //    }
            //    else if (text[i] == 'e')
            //    {
            //        valueE += 2;
            //    }
            //    else if (text[i] == 'i')
            //    {
            //        valueI += 3;
            //    }
            //    else if (text[i] == 'o')
            //    {
            //        valueO += 4;
            //    }
            //    else if (text[i] == 'u')
            //    {
            //        valueU += 5;
            //    }
            //}
            //int sum = valueA + valueE + valueI + valueO + valueU;
            //Console.WriteLine(sum);

            //ВТОРО РЕШЕНИЕ
            //string text = Console.ReadLine();

            //int totalSum = 0;

            //for (int i = 0; i<text.Length; i++)
            //{
            //    char letter = text[i];

            //    if (letter == 'a')
            //    {
            //        totalSum += 1;
            //    }
            //    else if(letter == 'e')
            //    {
            //        totalSum += 2;
            //    }
            //    else if (letter == 'i')
            //    {
            //        totalSum += 3;
            //    }
            //    else if (letter == 'o')
            //    {
            //        totalSum += 4;
            //    }
            //    else if (letter == 'u')
            //    {
            //        totalSum += 5;
            //    }

            //}
            //Console.WriteLine(totalSum);

            //ТРЕТО РЕШЕНИЕ
            string text = Console.ReadLine();
            int totalSum = 0;

            for (int i = 0; i < text.Length; i++)
            {
                char letter = text[i];

                switch (letter)
                {
                    case 'a':
                        totalSum += 1;
                        break;
                    case 'e':
                        totalSum += 2;
                        break;
                    case 'i':
                        totalSum += 3;
                        break;
                    case 'o':
                        totalSum += 4;
                        break;
                    case 'u':
                        totalSum += 5;
                        break;
                }

            }
            Console.WriteLine(totalSum);
        }
    }
}
