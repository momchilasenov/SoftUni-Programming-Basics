using System;

namespace _04._Walking
{
    class Program
    {
        static void Main(string[] args)
        {

            int steps = 0; 

            while (steps < 10000) 
            {
                string command = Console.ReadLine(); 
               
                if (command == "Going home") 
                {
                    int stepsToHome = int.Parse(Console.ReadLine());
                    steps += stepsToHome;
                    break; 
                }
                else 
                {
                    int walkedSteps = int.Parse(command); 
                    steps += walkedSteps; 
                }
            }
            if (steps >= 10000)
            {
                Console.WriteLine("Goal reached! Good job");
            }
            else
            {
                Console.WriteLine($"{10000-steps} more steps to reach goal.");
            }

        }

    }

}

