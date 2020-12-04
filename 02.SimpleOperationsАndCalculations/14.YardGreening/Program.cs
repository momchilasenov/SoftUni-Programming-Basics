using System;

namespace YardGreening
{
    class Program
    {
        static void Main(string[] args)
        {
            double meters = double.Parse(Console.ReadLine());
            double totalprice = meters * 7.61;
            double discount = totalprice * 0.18;
            double finalprice = totalprice - discount;

            Console.WriteLine($"The final price is: {finalprice} lv.");
            Console.WriteLine($"The discount is: {discount} lv.");
        }
    }
}
