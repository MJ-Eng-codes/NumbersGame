//MJ Eng [.NET24]

using System;
using System.Transactions;

namespace NumbersGame
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Välkommen! Jag tänker på ett nummer.");
            Console.WriteLine("Kan du gissa vilket? Du får fem försök.");

            //Random numer 1-20
            Random random = new Random();
            int randNum = random.Next(1, 20);

            bool guessCorrectly = false;

            for (int i = 0; i < 5; i++)
            {
                Console.WriteLine("Gissa ett tal mellan 1-20!");
                int ans = UserInput();
                if (CheckGuess(randNum,ans))
                {
                    guessCorrectly = true;
                    break;
                }

                              
            }
            if (!guessCorrectly)
            {
                Console.WriteLine("Tyvärr, du lyckades inte gissa talet på fem försök!");
                Console.WriteLine($"Rätt nummer var {randNum}.");
            }
        }
        public static int UserInput()
        {
            int input = 0;
            bool isValid = false;

            while (!isValid)
            {
                string userInput = Console.ReadLine();

                if (int.TryParse(userInput,out input) && input >= 1 && input <=20)
                {
                    isValid = true;
                }

                else
                {
                    Console.WriteLine("Fel datatyp eller utanför 1-20! Skriv in ett tal mellan 1-20!");
                }
            }
            return input;            
        }

        public static bool CheckGuess(int randNum, int ans)
        {
            if (randNum == ans)
            {
                Console.WriteLine("Wohoo! Du klarade det!");
                return true;
            }

            else if (randNum < ans)
            {
                Console.WriteLine("Tyvärr, du gissade för högt!");                
            }

            else
            {
                Console.WriteLine("Tyvärr, du gissade för lågt!");                
            }
            return false;
        }
    }
}
