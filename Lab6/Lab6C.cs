/*
    Class: 1321L
    Section: Section W#1 C#
    Term: Spring 2022
    Instructor: Gayathri Yella
    Name: Brandon Wright
    Lab#: 6C
 */

using System;

namespace Lab6
{
    class Lab6C
    {
        static void Main(string[] args)
        {
            string uI;
            char choice = 'Y';
            int money = 1000, temp, option;
            bool ezpz = true;

            Console.WriteLine("Welcome! ");
            Console.WriteLine("You have $" + money + " in your account.");
            Console.WriteLine(" ");

            // condition for do-while loop to loop at least once
            choice = Char.ToLower(choice);

            // do-while loop for the menu options
            do
            {
                ezpz = true;

                // standard menu for options
                Console.WriteLine("Menu");
                Console.WriteLine("0 - Make a deposit");
                Console.WriteLine("1 - Make a withdrawal");
                Console.WriteLine("2 - Display account value");
                Console.WriteLine(" ");

                Console.Write("Please make a selection: ");
                uI = Console.ReadLine();
                option = Convert.ToInt32(uI);
                do
                {
                    switch (option)
                    {
                        case 0:
                            {
                                // deposit menu option 
                                Console.Write("How much would you like to deposit? : ");
                                uI = Console.ReadLine();
                                temp = Convert.ToInt32(uI);

                                money = money + temp;

                                option = 2;

                                break;
                            }
                        case 1:
                            {
                                // withdraw menu option 
                                Console.Write("How much would you like to withdraw? : ");
                                uI = Console.ReadLine();
                                temp = Convert.ToInt32(uI);

                                money = money - temp;

                                option = 2;

                                break;
                            }
                        case 2:
                            {
                                // Display account 
                                Console.WriteLine("Your current balance is $" + money);
                                Console.Write("Would you like to return to the main menu (Y/N)? : ");
                                uI = Console.ReadLine();
                                choice = Convert.ToChar(uI);
                                choice = Char.ToLower(choice);
                                Console.WriteLine(" ");
                                ezpz = false;
                                break;
                            }
                        default:
                            {
                                // Invalid entry
                                Console.WriteLine("Invalid entry, please try again. ");
                                Console.Write("Would you like to return to the main menu (Y/N)? : ");
                                uI = Console.ReadLine();
                                choice = Convert.ToChar(uI);
                                choice = Char.ToLower(choice);
                                Console.WriteLine(" ");
                                ezpz = false;

                                break;
                            }
                    }

                } while (ezpz == true);

            } while ('n' != choice);
            Console.WriteLine(" ");
            Console.WriteLine("Thank you for banking with us! ");

        }
    }
}
