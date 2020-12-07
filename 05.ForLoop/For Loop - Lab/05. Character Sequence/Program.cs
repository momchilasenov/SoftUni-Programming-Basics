using System;

namespace _05._Character_Sequence
{
    class Program
    {
        static void Main(string[] args)
        {
            string someText = Console.ReadLine();

            for (int i=0; i<someText.Length; i++)
            {
                Console.WriteLine(someText[i]);
            }
        }
    }
}
