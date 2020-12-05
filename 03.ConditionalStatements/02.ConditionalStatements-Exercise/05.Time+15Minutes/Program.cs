using System;

namespace _05.Time__15Minutes
{
    class Program
    {
        static void Main(string[] args)
        {
            //РЕШЕНИЕ 1
            //отпечатваме часове и минути
            int hours = int.Parse(Console.ReadLine());
            int minutes = int.Parse(Console.ReadLine());

            //изчисляваме колко ще са минутите след 15 минути
            int minutesPlus15 = minutes + 15;

            //ако минутите след 15 минути са > 59 
            //тогава часът се увеличава с 1
            //изчисляваме минутите като от минутите+15 вадим 60 = остатък 

            if (minutesPlus15 > 60)
            {
                hours = hours + 1;
                minutesPlus15 = minutesPlus15 - 60;
            }
            // ако часовете са > 23 то часът става 0 
            if (hours > 23)
            {
                hours = 0;
            }
            // ако минутите+15 са <10 трябва да сложим 0 пред цифрата и принтираме така
            if (minutesPlus15 < 10)
            {
                Console.WriteLine($"{hours}:0{minutesPlus15}");
            }
            //принтираме стандартно
            else
            {
                Console.WriteLine($"{hours}:{minutesPlus15}");
            }

            ////РЕШЕНИЕ 2
            //// Input
            //int hours = int.Parse(Console.ReadLine());
            //int minutes = int.Parse(Console.ReadLine());
            //// Calculations
            //minutes += 15;

            //if (minutes >= 60)
            //{
            //    minutes -= 60;
            //    hours += 1;
            //}
            //if (hours >= 24)
            //{
            //    hours = 0
            //}
            ////Output
            //Console.WriteLine($"{hours}:{minutes:d2}");

        }
    }
}