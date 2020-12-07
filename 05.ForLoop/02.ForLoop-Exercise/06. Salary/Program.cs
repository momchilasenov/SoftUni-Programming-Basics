using System;

namespace _06._Salary
{
    class Program
    {
        static void Main(string[] args)
        {
            int openTabs = int.Parse(Console.ReadLine());
            int salary = int.Parse(Console.ReadLine());

            for (int i = 0; i <= openTabs; i++)
            {
                if (salary <= 0)
                {
                    Console.WriteLine("You have lost your salary.");
                    break;
                }
                string website = Console.ReadLine();

                if (website == "Facebook")
                {
                    salary -= 150;
                }
                else if (website == "Instagram")
                {
                    salary -= 100;
                }
                else if (website == "Reddit")
                {
                    salary -= 50;
                }
            }
            if (salary > 0)
            {
                Console.WriteLine(salary);
            }
        }
    }
}

