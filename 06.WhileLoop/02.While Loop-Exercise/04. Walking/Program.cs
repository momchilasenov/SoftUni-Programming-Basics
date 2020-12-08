using System;

namespace _04._Walking
{
    class Program
    {
        static void Main(string[] args)
        {
            //int stepsMade = 0;
            //int stepsSum = 0;
            //int goingHomeSteps = 0;

            //// повтаряме броя стъпки всеки ден 
            //// цикълът спира когато стъпките >= 10 000
            //// цикълът се върти докато стъпките < 10 000

            //while (stepsSum < 10000) //докато общо стъпките са по-малко
            //{
            //    stepsMade = int.Parse(Console.ReadLine()); //приемай нови данни
            //    stepsSum += stepsMade;

            //    if (input == "Going home")
            //    {
            //        goingHomeSteps = int.Parse(Console.ReadLine());
            //        stepsSum += goingHomeSteps;
            //    }

            //}
            //int stepsDifference = stepsSum - 10000;

            //Console.WriteLine("Goal reached! Good job!");
            //Console.WriteLine($"{stepsDifference} steps over the goal!");

            //--------------------------------------------------------------

            //int stepsMade = 0;
            //int stepsSum = 0;
            //int goingHomeSteps = 0;

            //string input = "";

            //while (input != "Going home") //
            //{
            //    input = Console.ReadLine();

            //    if (input == "Going home")
            //    {
            //        goingHomeSteps = int.Parse(Console.ReadLine());
            //        stepsSum += goingHomeSteps;
            //        if (stepsSum >= 10000)
            //        {
            //            break;
            //        }
            //        else
            //        {
            //            Console.WriteLine($"{10000 - stepsSum} more steps to reach goal.");
            //            break;
            //        }
            //    }
            //    stepsMade = int.Parse(input); 
            //    stepsSum += stepsMade;

            //    if (stepsSum >= 10000)
            //    {
            //        break;
            //    }


            //}
            //if (stepsSum >= 10000)
            //{
            //    int stepsDifference = stepsSum - 10000;
            //    Console.WriteLine("Goal reached! Good job!");
            //    Console.WriteLine($"{stepsDifference} steps over the goal!");
            //}


            //Самостоятелно решение

            string stepsMade = Console.ReadLine(); //инпут може да ти е или going home или стъпките но като стринг и вътре в цикъла да ги преобразуваш 
            int stepsSum = 0;

            //    while (stepsMade != "Going home")
            //    {
            //        int steps = int.Parse(stepsMade);
            //        stepsSum += steps;

            //        if (stepsSum >= 10000)
            //        {
            //            break;
            //        }
            //        stepsMade = Console.ReadLine();
            //        if (stepsMade == "Going home")
            //        {
            //            stepsSum += int.Parse(Console.ReadLine());
            //        }

            //    }
            //    int difference = stepsSum - 10000;
            //    if (stepsSum >= 10000)
            //    {
            //        Console.WriteLine("Goal reached! Good job!");
            //        Console.WriteLine($"{difference} steps over the goal!");
            //    }
            //    else
            //    {
            //        Console.WriteLine($"{Math.Abs(difference)} more steps to reach goal.");
            //    }

            //ДЕСИСЛАВА ТОПУЗАКОВА РЕШЕНИЕ

            int steps = 0; //инициализирам си променлива където да съхранявам всички стъпки 

            while (steps < 10000) // докато стъпките са < 10000
            {
                string command = Console.ReadLine(); //аз трябва да получавам някаква команда
                //има два варианта за команда
                if (command == "Going home") //1.
                {
                    int stepsToHome = int.Parse(Console.ReadLine());
                    steps += stepsToHome;
                    break; 
                }
                else //2. число но под формата на стринг което трябва да преобразуваме
                {
                    int walkedSteps = int.Parse(command); //инициализираш нова променлива за съхранение на стъпките в число
                    steps += walkedSteps; //просто добавяш стъпките към общия брой 
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

