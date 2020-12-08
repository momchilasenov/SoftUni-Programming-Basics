using System;

namespace _06._Cake
{
    class Program
    {
        static void Main(string[] args)
        {
	    //Algorithm
            //програмата се изпълнява докато парчетата не свършат
            // или до получаване на команда stop (стринг) 
            // хората вземат парчета с размер 1*1 
            // трябва да изчислиш обема на тортата 
            // докато не получим командата стоп - намаляваме обема на тортата 
            // и проверяваме дали е <= 0 

            int cakeLength = int.Parse(Console.ReadLine());
            int cakeWidth = int.Parse(Console.ReadLine());
            int cakeArea = cakeLength * cakeWidth;
            int cakeLeft = cakeArea;

            string input = Console.ReadLine();
            int pieces = 0;
            int totalPieces = 0;

            while (input != "STOP") //"4"
            {
                pieces = int.Parse(input); // 4
                totalPieces += pieces;
                cakeLeft -= pieces; //100 - 4

               
                if (cakeLeft <= 0)
                {
                    Console.WriteLine($"No more cake left! You need {totalPieces - cakeArea} pieces more.");
                    break;
                }
                
                input = Console.ReadLine();

            }
            if (input == "STOP")
            {
                Console.WriteLine($"{cakeArea - totalPieces} pieces are left.");
            }
        }
    }
}
