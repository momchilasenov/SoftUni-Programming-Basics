using System;

namespace _04._Even_Powers_of_2
{
    class Program
    {
        static void Main(string[] args)
        {

            // потребителят въвежда число
            // печатаме докато четните степени са <= въведеното число
            // повтаряме 

            //1-ВО РЕШЕНИЕ
            //int n = int.Parse(Console.ReadLine());

            //for (int i = 0; i <= n; i += 2)
            //{
            //    Console.WriteLine(Math.Pow(2, i));
            //}

            //2-РО РЕШЕНИЕ
            int n = int.Parse(Console.ReadLine());

            int num = 1;
            for (int i = 0; i<=n; i += 2)
            {
                Console.WriteLine(num);
                num *= 4;
            }



        }
    }
}
