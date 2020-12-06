using System;

namespace _06._Operations_Between_Numbers
{
    class Program
    {
        static void Main(string[] args)
        {
            int n1 = int.Parse(Console.ReadLine());
            int n2 = int.Parse(Console.ReadLine());
            char action = char.Parse(Console.ReadLine());

            double result = 0;
            string evenOrOdd = "";

            if (action == '+')
            {
                result = n1 + n2;
            }
            else if (action == '-')
            {
                result = n1 - n2;
            }
            else if (action == '*')
            {
                result = n1 * n2;
            }
            else if (action == '/')
            {
                if (n2 == 0)
                {
                    Console.WriteLine($"Cannot divide {n1} by zero");
                }
                else
                {
                    result = n1*1.0 / n2;
                    Console.WriteLine($"{n1} / {n2} = {result:f2}");
                }
            }
            else if (action == '%')
            {
                if (n2 == 0)
                {
                    Console.WriteLine($"Cannot divide {n1} by zero");
                }
                else
                {
                    result = n1 % n2;
                    Console.WriteLine($"{n1} % {n2} = {result}");
                }
            }

            if (action == '+' || action == '-' || action == '*')
            {
                if (result % 2 == 0)
                {
                    evenOrOdd = "even";
                }
                else
                {
                    evenOrOdd = "odd";
                }
                Console.WriteLine($"{n1} {action} {n2} = {result} - {evenOrOdd}");


            }
        }
    }
}
