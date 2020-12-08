using System;

namespace _04._Sequence_2k_1
{
    class Program
    {
        static void Main(string[] args)
        {
            //double number = double.Parse(Console.ReadLine()); // 8
            //double row = 1;

            //while (number >= row)
            //{
            //    Console.WriteLine(row);
            //    row = row * 2 + 1;  
            //}


            int n = int.Parse(Console.ReadLine()); 
            int k = 1;

            while (n >= k)
            {
                Console.WriteLine(k);
                k = k * 2 + 1;
            }






        }
    }
}
