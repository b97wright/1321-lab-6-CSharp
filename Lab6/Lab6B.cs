/*
    Class: 1321L
    Section: Section W#1 C#
    Term: Spring 2022
    Instructor: Gayathri Yella
    Name: Brandon Wright
    Lab#: 6B
 */

using System;

namespace Lab6
{
    class Lab6A
    {
        static void Main(string[] args)
        {
            string uI;
            int randNum = 0, compGuess, count = 1;
            Random rnd = new Random();

            // user inout for random number from 1 to 1000
            Console.Write("Enter a number between 1 and 1000: ");
            uI = Console.ReadLine();
            randNum = Convert.ToInt32(uI);

            // random number generator so Computer can guess users number
            compGuess = (rnd.Next(1001) + 1);

            Console.WriteLine("My guess was " + compGuess);

            // while loop to see if the computer has the right number user entered
            while (randNum != compGuess)
            {
                compGuess = (rnd.Next(1001) + 1);
                count++;

                Console.WriteLine("My guess was " + compGuess);
            }
            

            Console.WriteLine(" ");
            Console.WriteLine("I guessed the number was " + compGuess + " and it only took me " + count + " guesses");

        }
    }
}
