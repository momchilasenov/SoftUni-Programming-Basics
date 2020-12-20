using System;
using System.Runtime.Serialization;
using System.Security.Cryptography;

namespace _06._High_Jump
{
    class Program
    {
        static void Main(string[] args)
        {
            
            int desiredJump = int.Parse(Console.ReadLine());

            int failedJumps = 0;
            int currentGoal = desiredJump - 30;
            int jumpCounter = 0;
            int currentJump = 0; 

            while (true) 
            {
                currentJump = int.Parse(Console.ReadLine()); 
                jumpCounter++;                               

                failedJumps = 0;

                while (currentJump <= currentGoal) 
                { 
                    failedJumps++;

                    if (failedJumps == 3) 
                    {
                        Console.WriteLine($"Tihomir failed at {currentGoal}cm after {jumpCounter} jumps.");
                        return;
                    }

                    currentJump = int.Parse(Console.ReadLine()); 
                    jumpCounter++; 

                }

                if (currentJump > currentGoal) 
                {
                    if (currentGoal >= desiredJump) 
                    {
                        break; 
                    }
                    currentGoal += 5; 

                }

            }
            if (failedJumps < 3) 
            {
                Console.WriteLine($"Tihomir succeeded, he jumped over {currentGoal}cm after {jumpCounter} jumps.");
            }

        }
    }
}


