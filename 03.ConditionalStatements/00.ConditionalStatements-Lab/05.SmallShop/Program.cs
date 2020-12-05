using System;

namespace _05._Small_Shop
{
    class Program
    {
        static void Main(string[] args)
        {
            string product = Console.ReadLine();
            string city = Console.ReadLine();
            double quantity = double.Parse(Console.ReadLine());

            double price = 0;

            switch (product)
            {
                case "coffee":
                    if (city == "Sofia")
                    {
                        price = 0.50;
                    }
                    else if (city == "Plovdiv")
                    {
                        price = 0.40;
                    }
                    else
                    {
                        price = 0.45;
                    }

                    break;
                case "water":
                    if (city == "Sofia")
                    {
                        price = 0.80;
                    }
                    else if (city == "Plovdiv")
                    {
                        price = 0.70;
                    }
                    else
                    {
                        price = 0.70;
                    }

                    break;
                case "beer":
                    if (city == "Sofia")
                    {
                        price = 1.20;
                    }
                    else if (city == "Plovdiv")
                    {
                        price = 1.15;
                    }
                    else
                    {
                        price = 1.10;
                    }

                    break;
                case "sweets":
                    if (city == "Sofia")
                    {
                        price = 1.45;
                    }
                    else if (city == "Plovdiv")
                    {
                        price = 1.30;
                    }
                    else
                    {
                        price = 1.35;
                    }

                    break;
                case "peanuts":
                    if (city == "Sofia")
                    {
                        price = 1.60;
                    }
                    else if (city == "Plovdiv")
                    {
                        price = 1.50;
                    }
                    else
                    {
                        price = 1.55;
                    }

                    break;
            }

            double total = quantity * price;
            Console.WriteLine(total);

            //Solving the problem with IF

            //string product = Console.ReadLine();
            //string city = Console.ReadLine();
            //double quantity = double.Parse(Console.ReadLine());

            //double price = 0;

            //if (product == "coffee")
            //{
            //    if (city == "Sofia")
            //    {
            //        price = 0.50;
            //    }
            //    else if (city == "Plovdiv")
            //    {
            //        price = 0.40;
            //    }
            //    else
            //    {
            //        price = 0.45;
            //    }
            //}
            //else if (product == "water")
            //{
            //    if (city == "Sofia")
            //    {
            //        price = 0.80;
            //    }
            //    else if (city == "Plovdiv")
            //    {
            //        price = 0.70;
            //    }
            //    else
            //    {
            //        price = 0.70;
            //    }
            //}
            //else if (product == "beer")
            //{
            //    if (city == "Sofia")
            //    {
            //        price = 1.20;
            //    }
            //    else if (city == "Plovdiv")
            //    {
            //        price = 1.15;
            //    }
            //    else
            //    {
            //        price = 1.10;
            //    }
            //}
            //else if (product == "sweets")
            //{
            //    if (city == "Sofia")
            //    {
            //        price = 1.45;
            //    }
            //    else if (city == "Plovdiv")
            //    {
            //        price = 1.30;
            //    }
            //    else
            //    {
            //        price = 1.35;
            //    }
            //}
            //else if (product == "peanuts")
            //{
            //    if (city == "Sofia")
            //    {
            //        price = 1.60;
            //    }
            //    else if (city == "Plovdiv")
            //    {
            //        price = 1.50;
            //    }
            //    else
            //    {
            //        price = 1.55;
            //    }
            //}

            //double total = quantity * price;
            //Console.WriteLine(total);
        }
    }
}
