using System;

namespace PetShop
{
    class Program
    {
        static void Main(string[] args)
        {
            int dogs = int.Parse(Console.ReadLine());
            int others = int.Parse(Console.ReadLine());
            double result = (dogs * 2.50) + (others * 4);
            Console.WriteLine($"{result} lv.");

        }
    }
}
