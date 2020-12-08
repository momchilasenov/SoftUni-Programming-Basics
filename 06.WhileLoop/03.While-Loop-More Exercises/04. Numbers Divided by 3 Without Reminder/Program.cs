using System;

namespace _04._Numbers_Divided_by_3_Without_Reminder
{
    class Program
    {
        static void Main(string[] args)
        {
            //for (int i = 3; i<100; i += 3)
            //{
            //    Console.WriteLine(i);
            //}

            for (int i = 1;i<=100; i++)
            {
                if (i % 3 == 0)
                {
                    Console.WriteLine(i);
                }
            }

        }
    }
}
