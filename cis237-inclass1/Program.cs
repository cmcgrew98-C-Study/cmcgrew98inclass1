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

            // Let's make an array to hold a bunch of instances of
            // the Employee class
            Employee[] employees = new Employee[10];

            // Let's add some employees to our array
            //employees[0] = new Employee("David", "Barnes", 835.00m);
            //employees[1] = new Employee("James", "Kirk", 453.0m);
            //employees[2] = new Employee("Jean-Luc", "Picard", 563.0m);
            //employees[3] = new Employee("Benjamin", "Sisko", 753.0m);
            //employees[4] = new Employee("Kathryn", "Janeway", 953.0m);
            //employees[5] = new Employee("Johnathan", "Archer", 643.0m);

            // Make a string for the path to the csv file
            string pathToCsv = "../../employees.csv";

            // Create the instance of CSVProcessor
            CSVProcessor csvProcessor = new CSVProcessor();

            try
            {
                // Call the ImportCSV method sending over the path
                // and the array to store the records in.
                csvProcessor.ImportCsv(pathToCsv, employees);
            }
            catch (Exception)
            {
                // All the work in already in CSVProcessor. Could
                // do more error messages if we wanted to.
            }

            // Use the UI class to figure out what to do
            // Get some input from the user
            int choice = ui.GetUserInput();

            // While the choice they selected is not 2, continue
            while(choice != 2)
            {
                // See if the input they send is equal to 1.
                if (choice == 1)
                {
                    // Create a string that can be concated to
                    string outputString = "";

                    // Print out the employees in the array
                    // for (int i = 0; i < employees.Length; i++)
                    foreach (Employee employee in employees)
                    {
                        // So long as NOT null, add it to the outputstring
                        if (employee != null)
                        {
                            // Concat to the output string
                            outputString += employee.ToString() +
                                Environment.NewLine;
                        }
                    }

                    // Use the UI class to print out the string
                    ui.Output(outputString);
                }

                //Re-prompt the user for input
                choice = ui.GetUserInput();
            }
        }
    }
}
