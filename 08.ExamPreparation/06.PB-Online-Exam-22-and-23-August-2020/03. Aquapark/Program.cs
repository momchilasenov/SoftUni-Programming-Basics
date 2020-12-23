using System;

namespace _03._Aquapark
{
    class Program
    {
        static void Main(string[] args)
        {
            string month = Console.ReadLine();
            int numberOfHoursSpent = int.Parse(Console.ReadLine());
            int peopleInGroup = int.Parse(Console.ReadLine());
            string timeOfDay = Console.ReadLine();

            double pricePerPerson = 0;

            if (timeOfDay == "day")
            {
                if (month == "march" || month == "april" || month == "may")
                {
                    pricePerPerson = 10.50;
                }
                else if (month == "june" || month == "july" || month == "august")
                {
                    pricePerPerson = 12.60;
                }
            }
            else if (timeOfDay == "night")
            {
                if (month == "march" || month == "april" || month == "may")
                {
                    pricePerPerson = 8.4;
                }
                else if (month == "june" || month == "july" || month == "august")
                {
                    pricePerPerson = 10.20;
                }
            }

            if (peopleInGroup >= 4)
            {
                pricePerPerson = pricePerPerson * 0.9;
            }
            if (numberOfHoursSpent >= 5)
            {
                pricePerPerson = pricePerPerson * 0.5;
            }

            double total = (peopleInGroup*pricePerPerson) * numberOfHoursSpent;

            Console.WriteLine($"Price per person for one hour: {pricePerPerson:f2}");
            Console.WriteLine($"Total cost of the visit: {total:f2}");

        }
    }
}
