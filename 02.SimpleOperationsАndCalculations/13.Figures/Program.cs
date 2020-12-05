using System;

namespace _01._GreetingByName
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Enter figure type: ");
            string figure = Console.ReadLine();
            double area = 0;

            if (figure == "square")
            {
                Console.Write("Enter side: ");
                double side = double.Parse(Console.ReadLine());
                area = side * side;
                Console.Write("The figure area is ");
                
            }

            else if (figure == "rectangle")
            {
                Console.Write("Enter side 1: ");
                double side1 = double.Parse(Console.ReadLine());
                Console.Write("Enter side 2: ");
                double side2 = double.Parse(Console.ReadLine());
                area = side1 * side2;
                Console.Write("The figure area is ");
                
            }

            else if (figure == "circle")
            {
                Console.Write("Enter radius: ");
                double radius = double.Parse(Console.ReadLine());
                area = radius * radius * Math.PI;
                Console.Write("The figure area is ");
            }

            else if (figure == "triangle")
            {
                Console.Write("Enter side 1: ");
                double side1 = double.Parse(Console.ReadLine());
                Console.Write("Enter height: ");
                double height = double.Parse(Console.ReadLine());
                area = (side1 * height) / 2;
            }
                Console.WriteLine($"{area:f3}");
        }
    }
}
