using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace cis237_inclass1
{
    class Program
    {
        static void Main(string[] args)
        {
            // Make a new instance of the User Interface class
            UserInterface ui = new UserInterface();

            // Simply to show the default constructor works.
            Employee myEmployee = new Employee();

            // Make an actual employee with properties and output it.
            Employee myOtherEmployee = new Employee(
                "David",
                "Barnes",
                4500.87m
            );


            // Use the UI class to figure out what to do
            // Get some input from the user
            int choice = ui.GetUserInput();

            // While the choice they selected is not 2, continue
            while(choice != 2)
            {
                // See if the input they send is equal to 1.
                if (choice == 1)
                {
                    // Output are one employee.
                    ui.Output(myOtherEmployee.ToString());
                }

                //Re-prompt the user for input
                choice = ui.GetUserInput();
            }
        }
    }
}
