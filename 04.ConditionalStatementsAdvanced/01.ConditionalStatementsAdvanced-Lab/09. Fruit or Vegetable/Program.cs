using System;

namespace _09._Fruit_or_Vegetable
{
    class Program
    {
        static void Main(string[] args)
        {
            string product = Console.ReadLine();

            switch (product)
            {
                case "banana":
                case "apple":
                case "kiwi":
                case "cherry":
                case "lemon":
                case "grapes":
                    Console.WriteLine("fruit");
                    break;
                case "tomato":
                case "cucumber":
                case "pepper":
                case "carrot":
                    Console.WriteLine("vegetable");
                    break;
                default:
                    Console.WriteLine("unknown");
                    break;
            }

            // Solution with || logical operator
            //string thing = Console.ReadLine();
            //if (thing == "banana" || thing == "kiwi" || thing == "apple" || thing == "lemon" || thing == "grapes" || thing == "cherry")
            //{
            //    Console.WriteLine("fruit");
            //}
            //else if (thing == "tomato" || thing == "cucumber" || thing == "carror")
            //{
            //    Console.WriteLine("vegetable");
            //}
            //else
            //{
            //    Console.WriteLine("unknown");
            //}

        }
    }
}
