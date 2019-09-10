using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace cis237_inclass1
{
    class UserInterface
    {
        // No Variables
        // No Properties
        // No Constructors. Default should work fine

        //*******************************
        // Methods
        //*******************************
        public int GetUserInput()
        {
            // Print out a menu
            this.PrintMenu();

            // Get the input from the user
            string input = Console.ReadLine();

            // Validate the input
            // While the input is not valid re-get the input
            while (input != "1" && input != "2")
            {
                // Print Error Message
                this.PrintErrorMessage();

                // Re-print the menu
                this.PrintMenu();

                // Get the input from the console again.
                input = Console.ReadLine();
            }
            // At this point, I know the input is a valid number
            // of either a 1 or a 2.

            // Return selection
            return Int32.Parse(input);
        }

        public void Output(string outputString)
        {
            Console.WriteLine(outputString);
        }

        private void PrintMenu()
        {
            Console.WriteLine("What would you like to do?");
            Console.WriteLine("1. Print List");
            Console.WriteLine("2. Exit");
        }

        private void PrintErrorMessage()
        {
            Console.WriteLine("That is not a valid entry");
            Console.WriteLine("Please make a valid choice");
            Console.WriteLine();
        }
    }
}
