using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace cis237_inclass1
{
    class CSVProcessor
    {
        public void ImportCsv(string pathToCSVFile, Employee[] employees)
        {
            // Declare the StreamReader
            StreamReader streamReader = null;

            try
            {
                // Declare a string for the line
                string line;

                // Make an instance of the StreamReader
                streamReader = new StreamReader(pathToCSVFile);

                // Initialize a counter for number of records
                int counter = 0;

                // While we are still reading a line from the file
                while ((line = streamReader.ReadLine()) != null)
                {
                    // Process the line
                    this.ProcessLine(line, employees, counter++);
                }
            }
            catch (FileNotFoundException e)
            {
                // Output the exception and the stacktrace for the exception
                Console.WriteLine("The path to the file is invalid.");
                Console.WriteLine(e.ToString());
                Console.WriteLine();
                Console.WriteLine(e.StackTrace);
                // How to throw an exception
                throw new Exception("The path to the file is invalid.");
            }
            catch (Exception e)
            {
                // Output the exception and the stacktrace for the exception
                Console.WriteLine(e.ToString());
                Console.WriteLine();
                Console.WriteLine(e.StackTrace);
                // How to throw an existing exception
                throw e;
            }
            finally
            {
                // If the stream reader was created, make sure it
                // is closed before exiting the reader
                if (streamReader != null)
                {
                    streamReader.Close();
                }
            }
        }

        private void ProcessLine(string line, Employee[] employees, int index)
        {
            // Declare array of parts that will contain the results
            // of splitting the read in string.
            string[] parts = line.Split(',');

            // Assign each part to a variable
            string firstName = parts[0];
            string lastName = parts[1];
            decimal salary = decimal.Parse(parts[2]);

            // Add a new employee to the array
            employees[index] = new Employee(firstName, lastName, salary);
        }
    }
}
