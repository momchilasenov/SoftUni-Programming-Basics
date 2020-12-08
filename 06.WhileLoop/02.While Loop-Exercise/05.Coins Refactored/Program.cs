using System;

namespace _05.Coins__with_Loop_
{
    class Program
    {
        static void Main(string[] args)
        {

            double change = double.Parse(Console.ReadLine());
            double changeInPennies = Math.Floor(change * 100); 
            int coinCounter = 0;

            while (changeInPennies != 0)
            {
                if (changeInPennies >= 200)
                {
                    changeInPennies -= 200;
                    coinCounter++;
                }
                else if (changeInPennies >= 100)
                {
                    changeInPennies -= 100;
                    coinCounter++;
                }
                else if (changeInPennies >= 50)
                {
                    changeInPennies -= 50;
                    coinCounter++;
                }
                else if (changeInPennies >= 20)
                {
                    changeInPennies -= 20;
                    coinCounter++;
                }
                else if (changeInPennies >= 10)
                {
                    changeInPennies -= 10;
                    coinCounter++;
                }
                else if (changeInPennies >= 5)
                {
                    changeInPennies -= 5;
                    coinCounter++;
                }
                else if (changeInPennies >= 2)
                {
                    changeInPennies -= 2;
                    coinCounter++;
                }
                else if (changeInPennies >= 1)
                {
                    changeInPennies -= 1;
                    coinCounter++;
                }
                
            }
            Console.WriteLine(coinCounter);
            
        }
    }
}
