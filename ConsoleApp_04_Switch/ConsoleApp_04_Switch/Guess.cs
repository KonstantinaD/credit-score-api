using System;

namespace ConsoleApp_04_Switch
{
    public class Guess
    {
        public static void ProcessGuess(int guessedNumber)
        {
            switch (guessedNumber)
            {
                case 1:
                case 2:
                case 3:
                    Console.WriteLine("too low");
                    break;
                case 4:
                    Console.WriteLine("correct");
                    break;

                default:
                    Console.WriteLine("too high");
                    break;
            }
        }
    }
}
