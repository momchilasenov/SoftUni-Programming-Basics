using System;

namespace _06._Tournament_of_Christmas
{
    class Program
    {
        static void Main(string[] args)
        {
            
            int tournamentDays = int.Parse(Console.ReadLine());
            double totalMoneyEarned = 0;
            int daysAsWinners = 0;
            int daysAsLosers = 0;

            for (int days = 1; days <= tournamentDays; days++) 
            {
                string command = Console.ReadLine(); 
                double moneyPerDay = 0; 
                int countWonGames = 0;
                int countLostGames = 0;

                while (command != "Finish")
                { 

                    string result = Console.ReadLine();

                    if (result == "win")
                    {
                        moneyPerDay += 20;
                        countWonGames++;
                    }
                    else if (result == "lose")
                    {
                        countLostGames++;
                    }

                    command = Console.ReadLine();
                }
                if (countWonGames > countLostGames) 
                {
                    moneyPerDay *= 1.1;
                    daysAsWinners++;
                    totalMoneyEarned += moneyPerDay;
                }
                else
                {
                    totalMoneyEarned += moneyPerDay;
                    daysAsLosers++;
                }
            }
            if (daysAsWinners > daysAsLosers)
            {
                totalMoneyEarned *= 1.2;
                Console.WriteLine($"You won the tournament! Total raised money: {totalMoneyEarned:f2}");
            }
            else
            {
                Console.WriteLine($"You lost the tournament! Total raised money: {totalMoneyEarned:f2}");
            }


        }
    }
}
