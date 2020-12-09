using System;

namespace Password_Hacking
{
    class Program
    {
        static void Main(string[] args)
        {
            string password = Console.ReadLine();

            for (char i = 'a'; i <= 'z'; i++) 
            {
                for (char j = 'a'; j <= 'z'; j++)
                {
                    for (char k = 'a'; k <= 'z'; k++)
                    {
                        for (char l = 'a'; l <= 'z'; l++)
                        {
                            string combination = $"{i}{j}{k}{l}";
                            if (combination == password)
                            {
                                Console.WriteLine($"You cracked it. Password is {combination}");
                            }
                        }

                    }
                }
            }
        }
    }
}

