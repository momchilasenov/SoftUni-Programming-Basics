using System;
using System.Runtime.CompilerServices;

namespace _09._Moving
{
    class Program
    {
        static void Main(string[] args)
        {

            int width = int.Parse(Console.ReadLine());
            int length = int.Parse(Console.ReadLine());
            int height = int.Parse(Console.ReadLine());

            int roomSpace = width * length * height;
            int boxesSpace = 0;
            bool noFreeSpace = false;

            string input = Console.ReadLine();

            while (input != "Done")
            {
                int boxes = int.Parse(input);
                boxesSpace += boxes;

                if (boxesSpace >= roomSpace)
                {
                    noFreeSpace = true;
                    break;
                }
                input = Console.ReadLine();

            }
            if (input == "Done")
            {
                Console.WriteLine($"{roomSpace - boxesSpace} Cubic meters left.");
            }

            if (noFreeSpace)
            {
                int diff = boxesSpace - roomSpace;
                Console.WriteLine($"No more free space! You need {diff} Cubic meters more.");
            }

        }
    }
}
