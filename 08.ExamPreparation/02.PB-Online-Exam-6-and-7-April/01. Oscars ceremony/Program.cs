using System;

namespace _01._Oscars_ceremony
{
    class Program
    {
        static void Main(string[] args)
        {
            int roomRent = int.Parse(Console.ReadLine());

            double statues = roomRent - roomRent * 0.3;
            double food = statues - statues * 0.15;
            double music = food * 0.5;

            double total = roomRent + statues + food + music;
            Console.WriteLine($"{total:f2}");

        }
    }
}
