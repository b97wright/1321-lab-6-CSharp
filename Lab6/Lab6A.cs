using System;

namespace Lab6
{
    class Lab6A
    {
        static void Main(string[] args)
        {
            string uI;
            int Max = 0, userNum;

            Console.WriteLine("Please enter 10 numbers and this program will display the largest.");
            Console.WriteLine(" ");

            for (int i = 1; i < 11; i++)
            {
                Console.Write("Please enter number " + i + ": ");
                uI = Console.ReadLine();
                userNum = Convert.ToInt32(uI);

                if (userNum > Max)
                    Max = userNum;
            }

            Console.WriteLine(" ");
            Console.Write("The largest number was " + Max);

        }
    }
}
