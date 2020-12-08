using System;

namespace Stream_Of_Letters
{
    class Program
    {
        static void Main(string[] args)
        {
            string input = "";
            string word = "";
            string sumSecretCommand = "";
            char currentLetter = '+';
            string newWord = "";
            bool letterOrNot;


            while (input != "End")
            {
                input = Console.ReadLine();

                if (input != "End")
                {
                    currentLetter = char.Parse(input);
                    letterOrNot = char.IsLetter(currentLetter);
                    if (letterOrNot)
                    {
                        if (currentLetter == 'c' && !(sumSecretCommand.Contains("c")))
                        {
                            sumSecretCommand += char.ToString(currentLetter);

                        }
                        else if (currentLetter == 'o' && !(sumSecretCommand.Contains("o")))
                        {
                            sumSecretCommand += char.ToString(currentLetter);
                        }
                        else if (currentLetter == 'n' && !(sumSecretCommand.Contains("n")))
                        {
                            sumSecretCommand += char.ToString(currentLetter);
                        }
                        else
                        {
                            word += char.ToString(currentLetter);

                        }
                        if (sumSecretCommand.Contains("c") && sumSecretCommand.Contains("o") && sumSecretCommand.Contains("n"))
                        {
                            word += " ";
                            newWord = word;
                            sumSecretCommand = "";
                        }
                    }
                }
                else
                {
                    break;
                }
            }
            if (input == "End")
            {
                Console.WriteLine(newWord);
            }
        }

    }
}