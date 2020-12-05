using System;

namespace _04.MetricConverter
{
    class Program
    {
        static void Main(string[] args)
        {
            //// A better solution to the same problem
            ////1. input data
            //double numberToConvert = double.Parse(Console.ReadLine());
            //string inputUnitOfMeasure = Console.ReadLine();
            //string outputUnitOfMeasure = Console.ReadLine();
            ////2. convert the input unit of measure to meters

            //if (inputUnitOfMeasure == "cm")
            //{
            //    numberToConvert = numberToConvert / 100;
            //}
            //else if (inputUnitOfMeasure == "mm")
            //{
            //    numberToConvert = numberToConvert / 1000;
            //}
            //else if (inputUnitOfMeasure == "m")
            //{
            //    numberToConvert = numberToConvert / 1;
            //}

            //if (outputUnitOfMeasure == "cm")
            //{
            //    numberToConvert = numberToConvert * 100;
            //}
            //else if (outputUnitOfMeasure == "mm")
            //{
            //    numberToConvert = numberToConvert * 1000;
            //}
            //else if (outputUnitOfMeasure == "m")
            //{
            //    numberToConvert = numberToConvert * 1;
            //}
            //Console.WriteLine($"{numberToConvert:f3}");


            ////The slow and boring solution to the problem
            ////1. input data
            //double numberToConvert = double.Parse(Console.ReadLine());
            //string inputUnitOfMeasure = Console.ReadLine();
            //string outputUnitOfMeasure = Console.ReadLine();
            ////2. convert M to CM and MM
            //string meters = "m";
            //string cm = "cm";
            //string mm = "mm";

            //if (inputUnitOfMeasure == meters && outputUnitOfMeasure == cm)
            //{
            //    numberToConvert *= 100;
            //}
            //else if (inputUnitOfMeasure == meters && outputUnitOfMeasure == mm)
            //{
            //    numberToConvert *= 1000;
            //}

            //else if (inputUnitOfMeasure == cm && outputUnitOfMeasure == meters)
            //{
            //    numberToConvert /= 100;
            //}
            //else if (inputUnitOfMeasure == cm && outputUnitOfMeasure == mm)
            //{
            //    numberToConvert *= 10;
            //}
            //else if (inputUnitOfMeasure == mm && outputUnitOfMeasure == meters)
            //{
            //    numberToConvert /= 1000;
            //}
            //else if (inputUnitOfMeasure == mm && outputUnitOfMeasure == cm)
            //{
            //    numberToConvert /= 10;
            //}
            //else
            //{
            //    numberToConvert = numberToConvert*1;
            //}
            //Console.WriteLine($"{numberToConvert:F3}");

        }
    }
}
