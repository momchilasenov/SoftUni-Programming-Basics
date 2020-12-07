using System;

namespace _03._Numbers_1_to_N_with_Step_3
{
    class Program
    {
        static void Main(string[] args)
        {
            //Принтира числата от 1 до Н през 3
            int n = int.Parse(Console.ReadLine());
            for (int i = 1; i <= n; i += 3)
            {
                Console.WriteLine(i);
            }

            //Принтира числата от Н до 1 през 3
            int n = int.Parse(Console.ReadLine());
            for (int i = n; i >= 1; i -= 3)
            {
                Console.WriteLine(i);
            }

        }
    }
}
