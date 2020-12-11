using System;

namespace _01._Unique_PIN_Codes
{
    class Program
    {
        static void Main(string[] args)
        {
            int firstNumberLimit = int.Parse(Console.ReadLine());
            int secondNumberLimit = int.Parse(Console.ReadLine());
            int thirdNumberLimit = int.Parse(Console.ReadLine());

            for (int firstNumber = 1; firstNumber <= firstNumberLimit; firstNumber++)
            {

                for (int secondNumber = 1; secondNumber <= secondNumberLimit; secondNumber++)
                {
                    int counter = 0; //зануляваме брояча тук за да е на 0 за всяко ново число
                    for (int i = 1; i <= secondNumber; i++)
                    {
                        if (secondNumber % i == 0)
                        {
                            counter++;
                        }
                    }
                    for (int thirdNumber = 1; thirdNumber <= thirdNumberLimit; thirdNumber++)
                    {
                        if (firstNumber % 2 == 0 && thirdNumber % 2 == 0)
                        {
                            if (counter == 2)
                            {
                                Console.WriteLine($"{firstNumber} {secondNumber} {thirdNumber}");
                            }
                        }
                    }

                }
            }
        }
    }
}

