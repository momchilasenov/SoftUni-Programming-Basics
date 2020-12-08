using System;
using System.Transactions;

namespace _02._Report_System
{
    class Program
    {
        static void Main(string[] args)
        {
            
            int sumFromSales = int.Parse(Console.ReadLine());

            int moneyCollected = 0;
            int transactionCounter = 0;
            int moneyFromTransaction = 0;
            int paidWithCash = 0;
            int paidWithCC = 0;
            int peopleWithCash = 0;
            int peopleWithCC = 0;

            while (sumFromSales > moneyCollected)
            {
                string input = Console.ReadLine();
                transactionCounter++;

                if (input == "End")
                {
                    if (moneyCollected < sumFromSales)
                    {
                        Console.WriteLine("Failed to collect required money for charity.");
                        break;
                    }
                    else
                    {
                        break;
                    }

                }
                else
                {
                    if (transactionCounter % 2 != 0) // 1/3/5
                    {
                        moneyFromTransaction = int.Parse(input); //150
                        if (moneyFromTransaction > 100)
                        {
                            Console.WriteLine("Error in transaction!");
                            continue;
                        }
                        else
                        {
                            Console.WriteLine("Product sold!");
                            peopleWithCash++;
                            paidWithCash += moneyFromTransaction;
                        }

                    }
                    else if (transactionCounter % 2 == 0) // 2/4/6
                    {
                        moneyFromTransaction = int.Parse(input);
                        if (moneyFromTransaction < 10)
                        {
                            Console.WriteLine("Error in transaction!");
                            continue;
                        }
                        else
                        {
                            Console.WriteLine("Product sold!");
                            peopleWithCC++;
                            paidWithCC += moneyFromTransaction;
                        }
                    }
                    moneyCollected = paidWithCash + paidWithCC;

                }

            }
            if (moneyCollected >= sumFromSales)
            {
                Console.WriteLine($"Average CS: {paidWithCash * 1.0 / peopleWithCash:f2}");
                Console.WriteLine($"Average CC: {paidWithCC * 1.0 / peopleWithCC:f2}");
            }

        }
    }
}
