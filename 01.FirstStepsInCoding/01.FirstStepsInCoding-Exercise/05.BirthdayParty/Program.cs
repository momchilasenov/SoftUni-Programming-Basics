using System;

namespace _05.BirthdayParty
{
    class Program
    {
        static void Main(string[] args)
        {
            int rent = int.Parse(Console.ReadLine());
            double cake = rent * 0.2;
            double drinks = cake - (cake*0.45);
            double animator = (1.0/3.0) * rent;
            double sum = rent + cake + drinks + animator;

            Console.WriteLine(sum);


        }
    }
}
