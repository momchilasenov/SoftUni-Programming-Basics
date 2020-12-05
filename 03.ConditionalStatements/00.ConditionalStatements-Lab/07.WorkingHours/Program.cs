    using System;

    namespace _07.Working_Hours
    {
        class Program
        {
            static void Main(string[] args)
            {
                int hour = int.Parse(Console.ReadLine());
                string day = Console.ReadLine();

            //Solving the problem with IF    
            //if ((day == "Monday" || day == "Tuesday" || day == "Wednesday" || day == "Thursday" || day == "Friday"||day == "Saturday") && (hour >= 10 && hour <= 18))
                //{
                //    Console.WriteLine("open");
                //}

                //else
                //{
                //    Console.WriteLine("closed");
                //}

            //Solving the problem with switch
                switch (day)
                {
                    case "Monday":
                    case "Tuesday":
                    case "Wednesday":
                    case "Thursday":
                    case "Friday":
                    case "Saturday":
                        if (hour >= 10 && hour <= 18)
                        {
                            Console.WriteLine("open");
                        }
                        else
                        {
                            Console.WriteLine("closed");
                        }
                        break;
                    default:
                        Console.WriteLine("closed");
                        break;

                }

            }
        }
    }
