using System;

namespace _05._Challenge_the_Wedding
{
    class Program
    {
        static void Main(string[] args)
        {
            int maleClients = int.Parse(Console.ReadLine());
            int femaleClients = int.Parse(Console.ReadLine());
            int tables = int.Parse(Console.ReadLine());

            int meetingsCount = 0; 

            for (int i=1; i<=maleClients; i++)
            {
                for (int l=1; l<=femaleClients; l++)
                {
                    meetingsCount++;
                    if (meetingsCount > tables)
                    {
                        return;
                    }
                    Console.Write($"({i} <-> {l}) ");
                }
            }
        }
    }
}
