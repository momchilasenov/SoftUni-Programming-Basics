using System;

namespace Practice
{
    class Program
    {
        static void Main(string[] args)
        {
            //този цикъл казва - докато Product e различен от string Stop - продължавай да четеш продукти 
            //string product = Console.ReadLine(); //това е създаването на променлива
            //while (product != "Stop") // това е булевият израз
            //{
            //    product = Console.ReadLine(); //това е еквивалент на i++ във for цикъла
            //}

            //int number = 1;
            //while (number <= 10)
            //{
            //    Console.WriteLine(number);
            //    number++;
            //}

            //for (int i = 1; i <= 100; i++)
            //{
            //    Console.WriteLine(i);

            //    if (i == 25)
            //    {
            //        break;
            //    }
            //}

            //int a = 5; 
            //while (true)
            //{
            //    if (a == 10)
            //    {
            //        break;
            //    }
            //    Console.WriteLine(a);
            //    a++;
            //}


            //string input = Console.ReadLine();
            //while (input != "Stop")
            //{
            //    if (input == "Paris")
            //    {
            //        break;
            //    }
            //    input = Console.ReadLine();
            //}

            //string input = Console.ReadLine();
            //double sum = 0; 
            //while (input != "Stop")
            //{
            //    sum += double.Parse(input); //парсваш стринг-а input в double 
            //}

            //int sum = 0;
            //for (int i = 1; i <= 10; i++)
            //{
            //    int num = int.Parse(Console.ReadLine());
            //    if (num % 2 == 0)
            //    {
            //        continue;
            //    }
            //    sum += num;
            //}

            //int n = 1; //променлива, която ще използваш в цикъла

            //while (n < 5) // булев израз (true или false)
            //{
            //    Console.WriteLine(n); //при true се изпълнява този код
            //    n++; //промяна на променливата (стъпка, без нея има infinte loop
            //}
            //-----------------------------------------------------------------------------
            //Console.WriteLine("Type your age:");
            //int age = int.Parse(Console.ReadLine());

            //while (true)
            //{
            //    if (age >= 18)
            //    {
            //        Console.WriteLine("Welcome to da club!");
            //        break;
            //    }
            //    Console.WriteLine("Invalid age");
            //    age = int.Parse(Console.ReadLine());
            //}
            //-----------------------------------------------------------------------------
            //Този код работи като горния:

            //Console.WriteLine("Type your age:");
            //int age = int.Parse(Console.ReadLine());

            //while (age < 18)
            //{
            //    Console.WriteLine("Invalid age");
            //    age = int.Parse(Console.ReadLine());
            //}
            //Console.WriteLine("Welcome to da club!");
            //-----------------------------------------------------------------------------
            //string input = Console.ReadLine();

            //while (input != "baby") //"10"
            //{
            //    int numbers = int.Parse(input); //10
            //    numbers++;
            //    Console.WriteLine(numbers);

            //    input = Console.ReadLine();  
            //}
            //-----------------------------------------------------------------------------
            string input = Console.ReadLine();
            int difference = 0;

            while (input != "mama")
            {

                difference = int.Parse(input);
                difference += 2;
                Console.WriteLine(difference);
                input = Console.ReadLine();

            }
        }
    }
}
