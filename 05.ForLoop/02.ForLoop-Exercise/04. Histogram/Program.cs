using System;

namespace _04._Histogram
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            int lessThan200 = 0;
            int from200to399 = 0;
            int from400to599 = 0;
            int from600to799 = 0;
            int above800 = 0;

            for (int i = 1; i <= n; i++)
            {
                int inputNumber = int.Parse(Console.ReadLine());

                if (inputNumber < 200)
                {
                    lessThan200++;
                }
                else if (inputNumber >= 200 && inputNumber <= 399)
                {
                    from200to399++;
                }
                else if (inputNumber >= 400 && inputNumber <= 599)
                {
                    from400to599++;
                }
                else if (inputNumber >= 600 && inputNumber <= 799)
                {
                    from600to799++;
                }
                else
                {
                    above800++;
                }
            }
            double p1 = lessThan200 * 1.0 / n * 100;
            double p2 = from200to399 * 1.0 / n * 100;
            double p3 = from400to599 * 1.0 / n * 100;
            double p4 = from600to799 * 1.0 / n * 100;
            double p5 = above800 * 1.0 / n * 100;

            Console.WriteLine($"{p1:f2}%");
            Console.WriteLine($"{p2:f2}%");
            Console.WriteLine($"{p3:f2}%");
            Console.WriteLine($"{p4:f2}%");
            Console.WriteLine($"{p5:f2}%");

        }
    }
}
