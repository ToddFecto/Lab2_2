using System;

namespace Lab2_2
{
    class Program
    {
        static bool calcNumbers()
        {
            while (true)
            {
                Console.Write("\n\nContinue? (y/n): ");                        //Prompts for user input to continue or not
                string moreNumbers = Console.ReadLine();
                moreNumbers = moreNumbers.ToLower();                           //Converts input case to only lower case

                if (moreNumbers == "y" || moreNumbers == "yes")                //Checks the condition to continue or quit
                {
                    return true;
                }
                else if (moreNumbers == "n" || moreNumbers == "no")
                {
                    return false;
                }
                else
                {
                    Console.Write("Please enter only y or n!");                //Prompts user to only enter a y (yes ) or n (no) if another character is entered
                }
            }
        }
        static void Main(string[] args)
        {
                Console.WriteLine("Learn your squares and cubes!\n");          //Application title

            do
            {
                int i;
                int n = 0;
                string userIn;
                int squared = 0;
                int cubed = 0;

                do
                {
                    Console.Write("\nEnter an integer: ");                     //Requests and Accepts user input
                    userIn = Console.ReadLine();
                }
                while (int.TryParse(userIn, out n) == false);

                Console.WriteLine("\n\nNumber\t\tSquared\t\tCubed");
                Console.WriteLine("=======\t\t=======\t\t=======");

                for (i = 1; i <= n; i++)
                {
                    squared = i * i;
                    cubed = i * i * i;

                    Console.WriteLine($"{i}\t\t{squared}\t\t{cubed}");
                }
            }
            while (calcNumbers());                                             //Do - While loop continues if calcNumbers is true
        }
    }
}
