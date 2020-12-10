using System;

namespace _02._Equal_Sums_Even_Odd_Position
{
    class Program
    {
        static void Main(string[] args)
        {
            int number1 = int.Parse(Console.ReadLine());
            int number2 = int.Parse(Console.ReadLine());

            for (int number = number1; number <= number2; number++)
            {
                string currentNumber = number.ToString(); 
                int oddSum = 0;
                int evenSum = 0; 

                for (int position = 0; position < currentNumber.Length; position++) 
                {
                    int currentDigit = int.Parse(currentNumber[position].ToString()); 

                    if (position % 2 == 0) 
                    {
                        evenSum += currentDigit; 
                    }
                    else
                    {
                        oddSum += currentDigit;
                    }

                }
                if (evenSum == oddSum)
                {
                    Console.Write(currentNumber + " ");
                }

            }

        }
    }
}
