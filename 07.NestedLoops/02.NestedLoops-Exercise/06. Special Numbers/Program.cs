using System;

namespace _06._Special_Numbers
{
    class Program
    {
        static void Main(string[] args)
        {
            
            int n = int.Parse(Console.ReadLine());

            for (int thousands = 1; thousands <= 9; thousands++)
            {
                for (int hundreds = 1; hundreds <= 9; hundreds++)
                {
                    for (int tens = 1; tens <= 9; tens++)
                    {
                        for (int ones = 1; ones <= 9; ones++)
                        {
                            bool check1 = thousands != 0 && n % thousands == 0;
                            bool check2 = hundreds != 0 && n % hundreds == 0;
                            bool check3 = tens != 0 && n % tens == 0;
                            bool check4 = ones != 0 && n % ones == 0;

                            if (check1 && check2 && check3 && check4)
                            {
                                Console.Write($"{thousands}{hundreds}{tens}{ones} ");

                            }

                        }
                    }
                }
            }

            //int n = int.Parse(Console.ReadLine());

            //for (int number = 1111; number <= 9999; number++)
            //{
            //    int thousands = number / 1000;
            //    int hundreds = number / 100 % 10;
            //    int tens = number / 10 % 10;
            //    int ones = number % 10;

            //    //проверяваме дали N е специално 
            //    if (thousands != 0 && hundreds != 0 && tens != 0 && ones != 0 && n % thousands == 0 && n % hundreds == 0 && n % tens == 0 && n % ones == 0)
            //    {
            //        Console.Write(number + " ");
            //    }

            //    // друг тип проверка дали N е специално с булеви променливи
            //    // първо проверяваме дали числото е различно от 0 за да не се счупи програмата
            //    //bool check1 = thousands != 0 && n % thousands == 0;
            //    //bool check2 = hundreds != 0 && n % hundreds == 0;
            //    //bool check3 = tens != 0 && n % tens == 0;
            //    //bool check4 = ones != 0 && n % ones == 0;

            //    //if (check1 && check2 && check3 && check4)
            //    //{
            //    //    Console.Write(number + " ");
            //    //}
            //}

            ////вземане на всяка цифра от цялото число
            //int number = int.Parse(Console.ReadLine());
            //                                    // числото 1234:
            //int thousands = number / 1000;      // 1234 / 1000 = 1
            //int hundreds = ((number / 100)%10); // 1234 /100 = 12 -> 12 % 10 = 2
            //int tens = number / 10 % 10;        // 1234 / 10 = 123 -> 123 % 10 = 3
            //int ones = number % 10;             // 1234 % 10 = 4
            //Console.WriteLine(thousands); //1
            //Console.WriteLine(hundreds);  //2
            //Console.WriteLine(tens);      //3
            //Console.WriteLine(ones);      //4
        }
    }
}
